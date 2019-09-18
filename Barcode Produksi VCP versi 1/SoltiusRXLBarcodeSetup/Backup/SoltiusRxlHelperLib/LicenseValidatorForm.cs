using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace Soltius.RetailExcel.Helper {

    internal partial class LicenseValidatorForm : Form {

        #region Methods

        #region Event Handlers

        private void LicenseValidatorForm_Load(object sender, EventArgs e) {
            try {
                StartUp();
            } catch {
                throw;
            }
        }

        private void SearchLicenseFileButton_Click(object sender, EventArgs e) {
            try {
                BrowseLicenseFile();
            } catch {
                throw;
            }
        }

        private void ApplyLicenseButton_Click(object sender, EventArgs e) {
            try {
                if (!IsValidated()) {
                    return;
                }
                this.Close();
            } catch {
                throw;
            }
        }

        #endregion

        #region Not Overridables

        private void StartUp() {
            try {
                SetLayout();
                InitFields();
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

        private void InitFields() {
            try {
                try {
                    LicenseFileTextBox.Text = string.Format(@"{0}\{1}.Config.License", Path.GetDirectoryName(_FileName), Path.GetFileNameWithoutExtension(_FileName));
                } catch {
                    LicenseFileTextBox.Text = string.Empty;
                }
            } catch {
                throw;
            }
        }

        private bool IsValidated() {
            try {
                if (LicenseFileTextBox.Text.Length == 0) {
                    MessageBox.Show(this, "Please enter the License File.", _ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LicenseFileTextBox.Focus();
                    BrowseLicenseFile();
                    return false;
                }
                if (!File.Exists(LicenseFileTextBox.Text)) {
                    MessageBox.Show(this, "Can not find the License File.", _ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LicenseFileTextBox.Focus();
                    BrowseLicenseFile();
                    return false;
                }
                if (CompanyNameTextBox.Text.Length == 0) {
                    MessageBox.Show(this, "Please enter Company Name.", _ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CompanyNameTextBox.Focus();
                    return false;
                }
                if (UserNameTextBox.Text.Length == 0) {
                    MessageBox.Show(this, "Please enter User Name.", _ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserNameTextBox.Focus();
                    return false;
                }
                if (EmailTextBox.Text.Length == 0 || 
                    !Regex.IsMatch(EmailTextBox.Text, @"^(([^<>()[\]\\.,;:\s@\""]+"
                   + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                   + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                   + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                   + @"[a-zA-Z]{2,}))$")) {

                    MessageBox.Show(this, "Please enter a valid Email Address.", _ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EmailTextBox.Focus();
                    return false;
                }
                return true;
            } catch {
                throw;
            }
        }

        private void BrowseLicenseFile() {
            try {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = string.Format("{0} License Configuration", _ApplicationName);
                fileDialog.InitialDirectory = Application.StartupPath;
                fileDialog.FileName = string.Format("{0}.Config.License", _ApplicationName);
                fileDialog.DefaultExt = "Config.License";
                fileDialog.Filter = "Soltius Blaster License (*.Config.License)|*.Config.License";
                fileDialog.SupportMultiDottedExtensions = true;
                DialogResult result = fileDialog.ShowDialog(this);
                if (result == DialogResult.OK) {
                    LicenseFileTextBox.Text = fileDialog.FileName;
                }
            } catch {
                throw;
            }
        }

        public string GetValue() {
            try {
                return string.Format("ApplicationType={0};CompanyName={1};UserName={2};Email={3}", _ApplicationType, CompanyNameTextBox.Text, UserNameTextBox.Text, EmailTextBox.Text);
            } catch {
                throw;
            }
        }

        public string GetLicenseFile() {
            try {
                return LicenseFileTextBox.Text;
            } catch {
                throw;
            }
        }

        #endregion

        #region Constructors

        public LicenseValidatorForm() {
            try {
                InitializeComponent();
            } catch {
                throw;
            }
        }

        public LicenseValidatorForm(string applicationType, string applicationName, string fileName)
            : this() {

            try {
                if (string.IsNullOrEmpty(applicationType)) {
                    throw new ApplicationException("ApplicationType can not be empty.");
                }
                this._ApplicationType = applicationType;
                if (string.IsNullOrEmpty(applicationName)) {
                    throw new ApplicationException("ApplicationName can not be empty.");
                }
                this._ApplicationName = applicationName;
                if (string.IsNullOrEmpty(fileName)) {
                    throw new ApplicationException("FileName can not be empty.");
                }
                this._FileName = fileName;
            } catch {
                throw;
            }
        }

        #endregion

        #endregion

        #region Fields

        private string _ApplicationType = string.Empty;

        private string _ApplicationName = string.Empty;

        private string _FileName = string.Empty;

        #endregion

    }

}
