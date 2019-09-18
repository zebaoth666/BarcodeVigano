using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Soltius.RetailExcel.Helper.Properties;

namespace Soltius.RetailExcel.Helper {

    public static class LoginManager {

        #region Methods

        public static DialogResult ShowDialog(LoginType loginType, Form owner, string applicationName) {
            try {
                if (owner == null || owner.IsDisposed) {
                    throw new ArgumentException("owner can not be null or disposed.");
                }
                if (_LoginForm != null && !_LoginForm.IsDisposed) {
                    try {
                        _LoginForm.Dispose();
                    } catch { }
                }
                _LoginForm = new LoginForm(loginType, applicationName);
                owner.AddOwnedForm(_LoginForm);
                _LoginForm.LoginSucceeded += _LoginForm_LoginSucceeded;
                DialogResult result = _LoginForm.ShowDialog(owner);
                _LoginForm.LoginSucceeded -= _LoginForm_LoginSucceeded;
                return result;
            } catch {
                throw;
            }
        }

        public static bool TryLogin(string applicationName, string organizationCode, string userName, string password) {
            try {
                using (DataTable employeeTable = new DataTable("Employee")) {
                    using (SqlConnection connection = new SqlConnection(RxlConfiguration.GetCurrent().GetConnectionString(applicationName))) {
                        using (SqlCommand command = new SqlCommand(Resources.GetEmployeeByLoginCommandText, connection)) {
                            command.CommandTimeout = 0;
                            command.Parameters.AddWithValue("@OrganizationCode", organizationCode);
                            command.Parameters.AddWithValue("@UserName", userName);
                            command.Parameters.AddWithValue("@Password", Convert.ToBase64String(Encoding.ASCII.GetBytes(password)));
                            connection.Open();
                            using (SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.KeyInfo | CommandBehavior.CloseConnection)) {
                                employeeTable.Load(dataReader);
                            }
                        }
                    }
                    DataRow row = employeeTable.Rows[0];
                    _LoginInfo = new LoginInfoArgs(
                            row.Field<int>("LevelNumber"), row.Field<string>("OrganizationCode"),
                            row.Field<string>("OrganizationName"), row.Field<string>("EmployeeCode"),
                            row.Field<string>("EmployeeName"), row.Field<string>("LoginName")
                        );
                    return true;
                }
            } catch {
                return false;
            }
        }

        private static void _LoginForm_LoginSucceeded(object sender, LoginInfoArgs e) {
            try {
                _LoginInfo = e;
            } catch {
                throw;
            }
        }

        #endregion

        #region Properties

        public static LoginInfoArgs LoginInfo {
            get {
                try {
                    return _LoginInfo;
                } catch {
                    throw;
                }
            }
        }

        #endregion

        #region Fields

        private static LoginInfoArgs _LoginInfo = LoginInfoArgs.Empty;

        private static LoginForm _LoginForm;

        #endregion

    }

    public class LoginInfoArgs : EventArgs {

        #region Methods

        private LoginInfoArgs() {
            try {

            } catch {
                throw;
            }
        }

        public LoginInfoArgs(int levelNumber, string organizationCode, string organizationName, string employeeCode, string employeeName, string loginName) {
            try {
                this._LevelNumber = levelNumber;
                this._OrganizationCode = organizationCode;
                this._OrganizationName = organizationName;
                this._EmployeeCode = employeeCode;
                this._EmployeeName = employeeName;
                this._LoginName = loginName;
            } catch {
                throw;
            }
        }

        #endregion

        #region Properties

        public new static LoginInfoArgs Empty {
            get {
                return new LoginInfoArgs();
            }
        }

        public int LevelNumber {
            get {
                try {
                    return this._LevelNumber;
                } catch {
                    throw;
                }
            }
        }

        public string OrganizationCode {
            get {
                try {
                    return this._OrganizationCode;
                } catch {
                    throw;
                }
            }
        }

        public string OrganizationName {
            get {
                try {
                    return this._OrganizationName;
                } catch {
                    throw;
                }
            }
        }

        public string EmployeeCode {
            get {
                try {
                    return this._EmployeeCode;
                } catch {
                    throw;
                }
            }
        }

        public string EmployeeName {
            get {
                try {
                    return this._EmployeeName;
                } catch {
                    throw;
                }
            }
        }

        public string LoginName {
            get {
                try {
                    return this._LoginName;
                } catch {
                    throw;
                }
            }
        }

        #endregion

        #region Fields

        private int _LevelNumber = -1;

        private string _OrganizationCode = string.Empty;

        private string _OrganizationName = string.Empty;

        private string _EmployeeCode = string.Empty;

        private string _EmployeeName = string.Empty;

        private string _LoginName = string.Empty;

        #endregion

    }

    /// <summary>
    /// Type of Login
    /// </summary>
    public enum LoginType {
        /// <summary>
        /// Users allowed to select from which Organization they will login.
        /// </summary>
        SelectableLogin,
        /// <summary>
        /// Users only allowed login from Organization that already selected in Rxl Configure.
        /// </summary>
        LockedLogin,
        /// <summary>
        /// Only Administrator allowed to login.
        /// </summary>
        AdminLogin
    }

}
