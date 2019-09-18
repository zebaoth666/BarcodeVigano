using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Soltius.RetailExcel.Helper {

    /// <summary>
    /// Provides encapsulator of Rxl Configure application.
    /// Use Soltius.RetailExcel.Helper.RxlConfiguration instead.
    /// </summary>
    [Obsolete("Use Soltius.RetailExcel.Helper.RxlConfiguration instead.", true)]
    public static class RxlConnectionString {

        /// <summary>
        /// Gets Retail Excel Base connection string.
        /// Use Soltius.RetailExcel.Helper.RxlConfiguration.GetCurrent().GetConnectionString(string) instead.
        /// </summary>
        /// <param name="applicationName"></param>
        /// <returns></returns>
        [Obsolete("Use Soltius.RetailExcel.Helper.RxlConfiguration.GetCurrent().GetConnectionString() instead.", true)]
        public static string GetRxlBase(string applicationName) {
            try {
                using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("CWH")) {
                    if (regKey == null) {
                        throw new ApplicationException("There's an error occurred when trying to get Retail Excel connection string. Please check the Rxl Configure and make sure the connection string has been properly set.");
                    }
                    // regKey.GetValue("DATABASE")
                    string dataSource = Convert.ToString("192.168.0.3");
                    string initialCatalog = Convert.ToString("MilanoHeadOffice");
                    string userId = Convert.ToString("sa");
                    string password = Convert.ToString("110485");
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = dataSource;
                    builder.InitialCatalog = initialCatalog;
                    builder.UserID = userId;
                    builder.Password = password;
                    builder.AsynchronousProcessing = true;
                    builder.ConnectTimeout = 30;
                    builder.ApplicationName = string.IsNullOrEmpty(applicationName) ? DefaultApplicationInfo.FullApplicationName : applicationName;
                    return builder.ToString();
                }
            } catch {
                throw;
            }
        }

    }

}
