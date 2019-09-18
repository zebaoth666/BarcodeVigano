using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Soltius.RetailExcel.Helper;

namespace Soltius.RetailExcel.Helper {

    public static class ExceptionManager {

        #region Methods

        public static Exception GetInnerException(Exception exception) {
            try {
                while (exception.InnerException != null) {
                    exception = exception.InnerException;
                }
                return exception;
            } catch {
                throw;
            }
        }

        public static string GetErrorMessage(Exception exception) {
            try {
                GetInnerException(exception);
                SqlException sqlException = exception as SqlException;
                if (sqlException != null) {
                    return string.Format("Exception:\r\n   Msg {0}, Level {1}, State {2}, Procedure {3}, Line {4}\r\n   {5}\r\n\r\nStack Trace:\r\n{6}", sqlException.Number, sqlException.Class, sqlException.State, sqlException.Procedure, sqlException.LineNumber, sqlException.Message, sqlException.StackTrace);
                } else {
                    return string.Format("Error:\r\n   {0}\r\n\r\n Stack Trace:\r\n   {1}", exception.Message, exception.StackTrace);
                }
            } catch {
                throw;
            }
        }

        public static void ShowException(string applicationName, Form owner, Exception exception) {
            try {
                if (owner == null || owner.IsDisposed) {
                    MessageBox.Show(null, GetErrorMessage(exception), string.IsNullOrEmpty(applicationName) ? DefaultApplicationInfo.FullApplicationName : applicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    if (owner.InvokeRequired) {
                        owner.Invoke(new ShowExceptionHandler<Exception>(ShowException), applicationName, owner, exception);
                    } else {
                        MessageBox.Show(owner, GetErrorMessage(exception), string.IsNullOrEmpty(applicationName) ? DefaultApplicationInfo.FullApplicationName : applicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch {
                throw;
            }
        }

        public static void ShowException(string applicationName, Form owner, string errorMessage) {
            try {
                if (owner == null || owner.IsDisposed) {
                    MessageBox.Show(null, errorMessage, string.IsNullOrEmpty(applicationName) ? DefaultApplicationInfo.FullApplicationName : applicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    if (owner.InvokeRequired) {
                        owner.Invoke(new ShowExceptionHandler<string>(ShowException), applicationName, owner, errorMessage);
                    } else {
                        MessageBox.Show(owner, errorMessage, string.IsNullOrEmpty(applicationName) ? DefaultApplicationInfo.FullApplicationName : applicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch {
                throw;
            }
        }

        #endregion

        #region Nested Types

        private delegate void ShowExceptionHandler<T>(string applicationName, Form owner, T exception);

        #endregion

    }

}
