using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Management;
using Microsoft.Win32;

using Soltius.Security;

namespace Soltius.RetailExcel.Helper {

    public static class LicenceValidator {

        public static bool Validate(IWin32Window owner, string applicationType, string applicationName, string fileName) {
            try {
                if (!File.Exists(fileName)) {
                    MessageBox.Show(owner, string.Format("File not found."), string.IsNullOrEmpty(applicationName) ? applicationName : DefaultApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                AssemblyName inspectedAssemblyName = AssemblyName.GetAssemblyName(fileName);
                if (inspectedAssemblyName == null) {
                    return false;
                }
                if (inspectedAssemblyName.GetPublicKey().Length == 0) {
                    return false;
                }
                string publicKeyToken = Regex.Matches(Assembly.GetExecutingAssembly().FullName, @"PublicKeyToken=(?<tokenValue>(\w|\d)+)", RegexOptions.IgnoreCase).Cast<Match>().First().Value;
                if (!inspectedAssemblyName.FullName.Contains(publicKeyToken)) {
                    MessageBox.Show(owner, string.Format("License Error: Different PublicKeyToken."), string.IsNullOrEmpty(applicationName) ? applicationName : DefaultApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                string licenseFile = string.Empty;
                string userInfo = string.Empty;
                string userInfoFile = Path.ChangeExtension(fileName, "Config.User");
                bool createNewUserInfo = !File.Exists(userInfoFile);
                if (createNewUserInfo) {
                    using (LicenseValidatorForm form = new LicenseValidatorForm(applicationType, applicationName, fileName)) {
                        try {
                            form.ShowDialog(owner);
                            userInfo = form.GetValue();
                            licenseFile = form.GetLicenseFile();
                        } catch {
                            throw;
                        }
                    }
                } else {
                    using (StreamReader reader = new StreamReader(userInfoFile)) {
                        userInfo = reader.ReadToEnd();
                        if (string.IsNullOrEmpty(userInfo)) {
                            MessageBox.Show(owner, string.Format("Failed to validate the license."), string.IsNullOrEmpty(applicationName) ? applicationName : DefaultApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        try {
                            userInfo = StringCrypter.Decrypt(userInfo);
                        } catch {
                            throw;
                        }
                    }
                }
                if (licenseFile.Length == 0) {
                    licenseFile = Path.ChangeExtension(fileName, "Config.License");
                }
                if (!File.Exists(licenseFile)) {
                    MessageBox.Show(owner, string.Format("Lincense file not found."), string.IsNullOrEmpty(applicationName) ? applicationName : DefaultApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                string license = string.Empty;
                using (StreamReader reader = new StreamReader(licenseFile)) {
                    license = reader.ReadToEnd();
                    if (string.IsNullOrEmpty(license)) {
                        MessageBox.Show(owner, string.Format("Fail to validate the license."), string.IsNullOrEmpty(applicationName) ? applicationName : DefaultApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    try {
                        license = StringCrypter.Decrypt(license);
                    } catch {
                        throw;
                    }
                }
                try {
                    ValidateInternal(userInfo, license);
                } catch {
                    throw;
                }
                if (createNewUserInfo) {
                    using (StreamWriter writer = new StreamWriter(userInfoFile)) {
                        userInfo = StringCrypter.Encrypt(userInfo);
                        writer.Write(userInfo);
                        writer.Flush();
                    }
                }
                return true;
            } catch {
                return false;
            }
        }

        private static bool ValidateInternal(string userInfo, string licenseValue) {
            try {
                RegistryKey regKey = null;
                ManagementObjectSearcher searcher = null;
                ManagementBaseObject obj = null;
                try {
                    string machineGuid = string.Empty;
                    regKey = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Cryptography");
                    machineGuid = Convert.ToString(regKey.GetValue("MachineGuid"));
                    searcher = new ManagementObjectSearcher("SELECT * FROM Win32_UserAccount");
                    obj = searcher.Get().Cast<ManagementBaseObject>().First();
                    string administratorSID = Convert.ToString(obj["SID"]);
                    searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                    obj = searcher.Get().Cast<ManagementBaseObject>().First();
                    string OSSerialNumber = Convert.ToString(obj["SerialNumber"]);
                    string OSRegisteredUser = Convert.ToString(obj["RegisteredUser"]);
                    string OSVersion = Convert.ToString(obj["Version"]);
                    string OSInstalDate = Convert.ToString(obj["InstallDate"]);
                    searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                    obj = searcher.Get().Cast<ManagementBaseObject>().First();
                    string boardManufacturer = Convert.ToString(obj["Manufacturer"]);
                    string boardProduct = Convert.ToString(obj["Product"]);
                    string value = string.Format("{0};AdministratorSID={1};MachineGuid={2};OSSerialNumber={3};OSRegisteredUser={4};OSVersion={5};OSInstallDate={6};BoardManufacturer={7};BoardProduct={8}",
                        userInfo,
                        administratorSID, machineGuid, OSSerialNumber, OSRegisteredUser, OSVersion, OSInstalDate, boardManufacturer, boardProduct);
                    if (licenseValue == value) {
                        return true;
                    }
                } catch {
                    throw;
                } finally {
                    if (regKey != null) {
                        try {
                            regKey.Close();
                        } catch { }
                    }
                    if (searcher != null) {
                        try {
                            searcher.Dispose();
                        } catch { }
                    }
                    if (obj != null) {
                        try {
                            obj.Dispose();
                        } catch { }
                    }
                }
                return false;
            } catch {
                throw;
            }
        }

    }

}
