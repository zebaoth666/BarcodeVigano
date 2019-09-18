using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

using Soltius.RetailExcel.Helper;
using Soltius.RetailExcel.Helper.Properties;

namespace Soltius.RetailExcel.Helper {

    internal partial class LoginForm : Form {

        #region Methods

        #region Event Handlers

        private void LoginForm_Load(object sender, EventArgs e) {
            try {
                StartUp();
            } catch {
                throw;
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e) {
            try {
                InitLoginType();
            } catch {
                throw;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            try {
                Login();
            } catch {
                throw;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            try {
                Close(false);
            } catch {
                throw;
            }
        }

        private void UserNameTextBox_KeyUp(object sender, KeyEventArgs e) {
            try {
                if (e.KeyCode != Keys.Enter) {
                    return;
                }
                if (UserNameTextBox.Text.Length > 0 && PasswordTextBox.Text.Length == 0) {
                    PasswordTextBox.Focus();
                } else if (UserNameTextBox.Text.Length == 0) {
                    return;
                } else {
                    Login();
                }
            } catch {
                throw;
            }
        }

        private void PasswordTextBox_KeyUp(object sender, KeyEventArgs e) {
            try {
                if (e.KeyCode != Keys.Enter) {
                    return;
                }
                if (PasswordTextBox.Text.Length > 0 && UserNameTextBox.Text.Length == 0) {
                    UserNameTextBox.Focus();
                } else if (PasswordTextBox.Text.Length == 0) {
                    return;
                } else {
                    Login();
                }
            } catch {
                throw;
            }
        }

        private void RefreshOrganizationButton_Click(object sender, EventArgs e) {
            try {
                BeginRefreshOrganization();
            } catch {
                throw;
            }
        }

        #endregion

        #region Not Overridables

        private void StartUp() {
            try {
                SetupPosition();

            } catch {
                throw;
            }
        }

        private void SetupPosition() {
            try {
                bool hasOwnerForm = (this.Owner != null && !this.Owner.IsDisposed);
                if (hasOwnerForm) {
                    this.CenterToParent();
                } else {
                    this.CenterToScreen();
                }
            } catch {
                throw;
            }
        }

        private void InitLoginType() {
            try {
                if (_LoginType != LoginType.SelectableLogin) {
                    OrganizationComboBox.Enabled = false;
                    RefreshOrganizationButton.Enabled = false;
                }
                if (_LoginType == LoginType.LockedLogin) {
                    RefreshOrganization();
                    AfterRefreshOrganization(false);
                }
            } catch {
                throw;
            }
        }

        private void BeginRefreshOrganization() {
            try {
                if (_LoginType == LoginType.AdminLogin) {
                    return;
                }
                MainPanel.Enabled = false;
                MethodInvoker invoker = RefreshOrganization;
                invoker.BeginInvoke(EndRefreshOrganization, invoker);
            } catch {
                throw;
            }
        }

        private void RefreshOrganization() {
            try {
                using (DataTable table = new DataTable("Organization")) {
                    using (SqlConnection connection = new SqlConnection(RxlConfiguration.GetCurrent().GetConnectionString(null))) {
                        using (SqlCommand command = new SqlCommand(Resources.GetOrganizationCommandText, connection)) {
                            command.CommandTimeout = 0;
                            connection.Open();
                            using (SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.KeyInfo)) {
                                table.Load(dataReader);
                            }
                        }
                    }
                    _OrganizationDataSource.Clear();
                    foreach (DataRow row in table.Rows) {
                        _OrganizationDataSource.Add(new KeyValuePair<string, string>(row.Field<string>("OrganizationCode"), row.Field<string>("OrganizationName")));
                    }
                }
            } catch {
                throw;
            }
        }

        private void EndRefreshOrganization(IAsyncResult result) {
            try {
                MethodInvoker invoker = result.AsyncState as MethodInvoker;
                if (invoker == null) {
                    return;
                }
                invoker.EndInvoke(result);
            } catch {
                throw;
            } finally {
                try {
                    if (this.InvokeRequired) {
                        this.Invoke(new SingleParamInvoker<bool>(AfterRefreshOrganization), true);
                    } else {
                        AfterRefreshOrganization(true);
                    }
                } catch {
                    throw;
                }
            }
        }

        private void AfterRefreshOrganization(bool showDropDown) {
            try {
                MainPanel.Enabled = true;
                OrganizationComboBox.DataSource = new BindingSource(_OrganizationDataSource, null);
                OrganizationComboBox.ValueMember = "Key";
                OrganizationComboBox.DisplayMember = "Value";
                OrganizationComboBox.SelectedValue = RxlConfiguration.GetCurrent().OrganizationCode;
                OrganizationComboBox.Focus();
                OrganizationComboBox.DroppedDown = showDropDown;
            } catch {
                throw;
            }
        }

        private bool IsValidated() {
            try {
                if ((_LoginType != LoginType.AdminLogin) && (OrganizationComboBox.SelectedIndex == -1)) {
                    MessageBox.Show(this, "Please select the Organization.", _ApplicationName.Length > 0 ? _ApplicationName : DefaultApplicationInfo.FullApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    OrganizationComboBox.Focus();
                    OrganizationComboBox.DroppedDown = true;
                    return false;
                }
                if (UserNameTextBox.Text.Length == 0) {
                    MessageBox.Show(this, "Please enter the user name.", _ApplicationName.Length > 0 ? _ApplicationName : DefaultApplicationInfo.FullApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserNameTextBox.Focus();
                    return false;
                }
                if (PasswordTextBox.Text.Length == 0) {
                    MessageBox.Show(this, "Please enter the password.", _ApplicationName.Length > 0 ? _ApplicationName : DefaultApplicationInfo.FullApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PasswordTextBox.Focus();
                    return false;
                }
                return true;
            } catch {
                throw;
            }
        }

        private void Login() {
            try {
                if (!IsValidated()) {
                    return;
                }
                int result = 0;
                using (SqlConnection connection = new SqlConnection(RxlConfiguration.GetCurrent().GetConnectionString(_ApplicationName))) {
                    string commandText = string.Empty;
                    switch (_LoginType) {
                        case LoginType.SelectableLogin:
                        case LoginType.LockedLogin:
                            commandText = Resources.GetEmployeeByLoginCommandText;
                            break;
                        case LoginType.AdminLogin:
                            commandText = Resources.AdminLoginCommandText;
                            break;
                        default:
                            break;
                    }
                    using (SqlCommand command = new SqlCommand(commandText, connection)) {
                        command.CommandTimeout = 0;
                        if ((_LoginType == LoginType.SelectableLogin) || (_LoginType == LoginType.LockedLogin)) {
                            command.Parameters.AddWithValue("@OrganizationCode", Convert.ToString(OrganizationComboBox.SelectedValue));
                        }
                        command.Parameters.AddRange(
                                new SqlParameter[] {
                                    new SqlParameter("@UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, UserNameTextBox.Text),
                                    new SqlParameter("@Password", SqlDbType.NVarChar, 0, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, Convert.ToBase64String(Encoding.ASCII.GetBytes(PasswordTextBox.Text))),
                                }
                            );
                        connection.Open();
                        try {
                            if (_LoginType == LoginType.AdminLogin) {
                                result = (int)command.ExecuteScalar();
                            } else {
                                using (DataTable table = new DataTable("Employee")) {
                                    using (SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.KeyInfo | CommandBehavior.SingleRow)) {
                                        table.Load(dataReader);
                                    }
                                    result = table.Rows.Count;
                                    foreach (DataRow row in table.Rows) {
                                        _LoginInfoArgs = new LoginInfoArgs(row.Field<int>("LevelNumber"), row.Field<string>("OrganizationCode"), row.Field<string>("OrganizationName"), row.Field<string>("EmployeeCode"), row.Field<string>("EmployeeName"), row.Field<string>("LoginName"));
                                    }
                                }
                            }
                        } catch { }
                    }
                }
                if (result <= 0) {
                    string errorMessage = string.Empty;
                    if (_LoginType == LoginType.AdminLogin) {
                        errorMessage = "You are not authorized to use this tool, only Administrator allowed to use this tool.";
                    } else {
                        errorMessage = "Wrong User Name or Password.";
                    }
                    MessageBox.Show(this, errorMessage, _ApplicationName.Length > 0 ? _ApplicationName : DefaultApplicationInfo.FullApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginButton.Focus();
                    return;
                }
                if (_LoginType == LoginType.AdminLogin) {
                    OnLoginSucceeded(LoginInfoArgs.Empty);
                } else {
                    OnLoginSucceeded(_LoginInfoArgs);
                }
                Close(true);
            } catch {
                throw;
            }
        }

        private void Close(bool selected) {
            try {
                if (this.Modal) {
                    if (selected) {
                        this.DialogResult = DialogResult.OK;
                    } else {
                        this.DialogResult = DialogResult.Cancel;
                    }
                    //return;
                }
                if (this.Owner != null && !this.Owner.IsDisposed) {
                    try {
                        this.Owner.RemoveOwnedForm(this);
                    } catch { }
                }
                try {
                    this.Dispose();
                } catch { }
            } catch {
                //throw;
            }
        }

        protected void OnLoginSucceeded(LoginInfoArgs e) {
            try {
                if (LoginSucceeded != null) {
                    LoginSucceeded(this, e);
                }
            } catch {
                throw;
            }
        }

        #endregion

        #region Constructors

        public LoginForm() {
            InitializeComponent();
        }

        public LoginForm(LoginType loginType, string applicationName)
            : this() {

            try {
                this._LoginType = loginType;
                if (applicationName == null) {
                    return;
                }
                this._ApplicationName = applicationName;
            } catch {
                throw;
            }
        }

        #endregion

        #endregion

        #region Fields

        private LoginType _LoginType;

        private string _ApplicationName = string.Empty;

        private List<KeyValuePair<string, string>> _OrganizationDataSource = new List<KeyValuePair<string, string>>();

        private LoginInfoArgs _LoginInfoArgs;

        #endregion

        #region Events

        public event EventHandler<LoginInfoArgs> LoginSucceeded;

        #endregion

    }

}
