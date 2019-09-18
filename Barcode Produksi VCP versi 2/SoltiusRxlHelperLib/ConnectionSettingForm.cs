using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Soltius.RetailExcel.Helper {

    internal partial class ConnectionSettingForm : Form {

        #region Methods

        #region Event Handlers

        private void ConnectionSettingForm_Load(object sender, EventArgs e) {
            try {

            } catch {
                throw;
            }
        }

        private void TestConnectionButton_Click(object sender, EventArgs e) {
            try {
                TestConnection();
            } catch {
                throw;
            }
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e) {
            try {
                SaveSettings();
            } catch {
                throw;
            }
        }

        private void CleaTextsButton_Click(object sender, EventArgs e) {
            try {
                ClearTexts();
            } catch {
                throw;
            }
        }

        #endregion

        #region Not Overridables

        private void StartUp() {
            try {
                SetLayout();
            } catch {
                throw;
            }
        }

        private void SetLayout() {
            try {
                if (this.Owner != null && !this.Owner.IsDisposed) {
                    this.CenterToParent();
                } else {
                    this.CenterToScreen();
                }
            } catch {
                throw;
            }
        }

        private bool TestConnection() {
            try {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = ServerTextBox.Text;
                builder.InitialCatalog = DatabaseTextBox.Text;
                builder.UserID = UserIDTextBox.Text;
                builder.Password = PasswordTextBox.Text;
                builder.AsynchronousProcessing = true;
                builder.ConnectTimeout = 30;
                builder.ApplicationName = DefaultApplicationInfo.FullApplicationName;
                using (SqlConnection connection = new SqlConnection(builder.ToString())) {
                    connection.Open();
                    MessageBox.Show(this, "Test connection succeded.", DefaultApplicationInfo.FullApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            } catch (Exception ex) {
                try {
                    ExceptionManager.ShowException(DefaultApplicationInfo.FullApplicationName, this.Owner, ex);
                } catch { }
                return false;
            }
        }

        private void SaveSettings() {
            try {
                RegistryKey regKey = null;
                try {
                    regKey = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("CWH");
                } catch { }
                if (regKey == null) {
                    regKey = Registry.LocalMachine.OpenSubKey("Software");
                    regKey = regKey.CreateSubKey("CWH");
                }
                using (regKey) {
                    regKey.SetValue("DATASOURCE", ServerTextBox.Text, RegistryValueKind.String);
                    regKey.SetValue("DATABASE", ServerTextBox.Text, RegistryValueKind.String);
                    regKey.SetValue("USER ID", ServerTextBox.Text, RegistryValueKind.String);
                    regKey.SetValue("PASSWORD", ServerTextBox.Text, RegistryValueKind.String);
                    regKey.SetValue("Level", ServerTextBox.Text, RegistryValueKind.String);
                    regKey.SetValue("Organization", ServerTextBox.Text, RegistryValueKind.String);
                }
                MessageBox.Show(this, "Connection Settins has been succesfully saved.", DefaultApplicationInfo.FullApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } catch {
                throw;
            }
        }

        private void ClearTexts() {
            try {
                ServerTextBox.Text = string.Empty;
                DatabaseTextBox.Text = string.Empty;
                UserIDTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                LevelNumberTextBox.Text = string.Empty;
                OrganizationTextBox.Text = string.Empty;
            } catch {
                throw;
            }
        }

        #endregion

        #region Contructors

        public ConnectionSettingForm() {
            try {
                InitializeComponent();
            } catch {
                throw;
            }
        }

        #endregion

        #endregion

    }

}
