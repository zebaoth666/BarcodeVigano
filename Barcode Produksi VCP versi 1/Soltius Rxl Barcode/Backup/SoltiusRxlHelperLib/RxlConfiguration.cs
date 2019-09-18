using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Soltius.RetailExcel.Helper {

    /// <summary>
    /// Provides encapsulator of Rxl Configure application.
    /// </summary>
    public class RxlConfiguration {

        #region Methods

        #region Not Overridables

        /// <summary>
        /// Gets current configuration.
        /// </summary>
        /// <returns></returns>
        public static RxlConfiguration GetCurrent() {
            try {
                using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("CWH")) {
                    if (regKey == null) {
                        //throw new ApplicationException("There's an error occurred when trying to get Retail Excel connection string. Please check the Rxl Configure and make sure the connection string has been properly set.");
                        using (ConnectionSettingForm form = new ConnectionSettingForm()) {
                            form.ShowDialog();
                        }
                    }
                    string dataSource = Convert.ToString(regKey.GetValue("DATASOURCE"));
                    string initialCatalog = Convert.ToString(regKey.GetValue("DATABASE"));
                    string userId = Convert.ToString(regKey.GetValue("USER ID"));
                    string password = Convert.ToString(regKey.GetValue("PASSWORD"));
                    int levelNumber = int.Parse(Convert.ToString(regKey.GetValue("Level")));
                    string organizationCode = Convert.ToString(regKey.GetValue("Organization"));
                    return new RxlConfiguration(dataSource, initialCatalog, userId, password, levelNumber, organizationCode);
                }
            } catch {
                throw;
            }
        }

        /// <summary>
        /// Gets connection string.
        /// </summary>
        /// <param name="applicationName"></param>
        /// <returns></returns>
        public string GetConnectionString(string applicationName) {
            try {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = this._DataSource;
                builder.InitialCatalog = this._InitialCatalog;
                builder.UserID = this._UserID;
                builder.Password = this._Password;
                builder.AsynchronousProcessing = true;
                builder.ConnectTimeout = 30;
                builder.ApplicationName = string.IsNullOrEmpty(applicationName) ? DefaultApplicationInfo.FullApplicationName : applicationName;
                return builder.ToString();
            } catch {
                throw;
            }
        }

        #endregion

        #region Constructors

        private RxlConfiguration() {
            try {
                _DataSource = string.Empty;
                _InitialCatalog = string.Empty;
                _UserID = string.Empty;
                _Password = string.Empty;
                _LevelNumber = 0;
                _OrganizationCode = "001";
            } catch {
                throw;
            }
        }

        private RxlConfiguration(
            string _DataSource, string _InitialCatalog,
            string _UserID, string _Password,
            int _LevelNumber, string _OrganizationCode)
            : this() {

            try {
                this._DataSource = _DataSource;
                this._InitialCatalog = _InitialCatalog;
                this._UserID = _UserID;
                this._Password = _Password;
                this._LevelNumber = _LevelNumber;
                this._OrganizationCode = _OrganizationCode;
            } catch {
                throw;
            }
        }

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of SQL Server instance to connect to.
        /// </summary>
        public string DataSource {
            get {
                return this._DataSource;
            }
        }

        /// <summary>
        /// Gets the name of the database associated with the connection.
        /// </summary>
        public string InitialCatalog {
            get {
                return this._InitialCatalog;
            }
        }

        /// <summary>
        /// Gets the UserID to be used when connecting to SQL Server.
        /// </summary>
        public string UserID {
            get {
                return this._UserID;
            }
        }

        /// <summary>
        /// Gets the Password for the SQL Server account.
        /// </summary>
        public string Password {
            get {
                return this._Password;
            }
        }

        /// <summary>
        /// Retail Excel Level Number of organization.
        /// </summary>
        public int LevelNumber {
            get {
                return this._LevelNumber;
            }
        }

        /// <summary>
        /// Retail Excel Organization Code.
        /// </summary>
        public string OrganizationCode {
            get {
                return this._OrganizationCode;
            }
        }

        #endregion

        #region Fields

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _DataSource;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _InitialCatalog;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _UserID;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _Password;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int _LevelNumber;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _OrganizationCode;

        #endregion

    }

}
