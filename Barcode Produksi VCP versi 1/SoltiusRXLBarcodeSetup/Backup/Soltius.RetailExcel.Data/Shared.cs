using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Runtime.CompilerServices;

using Soltius;
using Soltius.RetailExcel;
using Soltius.RetailExcel.Data;
using Soltius.RetailExcel.Data.Properties;
using Soltius.RetailExcel.Helper;

namespace Soltius.RetailExcel.Data {

    public delegate void UpdateErrorHandler(ErrorHandlerArgs args);

    public class ErrorHandlerArgs {

        #region Methods

        public ErrorHandlerArgs(string tableName, DataRow changedRow, DataViewRowState recordStates, Exception exception) {
            try {
                this._TableName = tableName;
                this._ChangedRow = changedRow;
                this._Exception = exception;
                this._RecordStates = recordStates;
            } catch {
                throw;
            }
        }

        #endregion

        #region Properties

        public string TableName {
            get {
                try {
                    return _TableName;
                } catch {
                    throw;
                }
            }
        }

        public DataRow ChangedRow {
            get {
                try {
                    return _ChangedRow;
                } catch {
                    throw;
                }
            }
        }

        public DataViewRowState RecordStates {
            get {
                try {
                    return _RecordStates;
                } catch {
                    throw;
                }
            }
        }

        public Exception Exception {
            get {
                try {
                    return _Exception;
                } catch {
                    throw;
                }
            }
        }

        public ErrorHandlingAction Action {
            get {
                try {
                    return _Action;
                } catch {
                    throw;
                }
            }
            set {
                try {
                    this._Action = value;
                } catch {
                    throw;
                }
            }
        }

        #endregion

        #region Fields

        private string _TableName = string.Empty;

        private DataRow _ChangedRow = null;

        private DataViewRowState _RecordStates;

        private Exception _Exception = null;

        private ErrorHandlingAction _Action;

        #endregion

    }

    public enum ErrorHandlingAction {
        ThrowError,
        RepeatExecution
    }

    [DebuggerNonUserCode()]
    [Serializable]
    public static class RxlTableName {

        #region Methods

        #region Not Overridables

        public static bool Contains(string item) {
            try {
                return _Arrays.Contains(item);
            } catch {
                throw;
            }
        }

        #endregion

        #region Constructors

        [MethodImpl(MethodImplOptions.Synchronized)]
        static RxlTableName() {
            try {
                Type thisType = MethodInfo.GetCurrentMethod().DeclaringType;
                _Arrays = new List<string>();
                foreach (FieldInfo fieldInfo in thisType.GetFields(BindingFlags.Public | BindingFlags.Static)) {
                    string item = fieldInfo.Name;
                    fieldInfo.SetValue(null, item);
                    _Arrays.Add(item);
                    ++_Count;
                }
            } catch {
                throw;
            }
        }

        #endregion

        #endregion

        #region Properties

        public static int Count {
            get {
                try {
                    return _Count;
                } catch {
                    throw;
                }
            }
        }

        public static string[] Arrays {
            get {
                try {
                    return _Arrays.ToArray();
                } catch {
                    throw;
                }
            }
        }

        #endregion

        #region Fields

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static int _Count;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static List<string> _Arrays;

        public static readonly string Organization;
        public static readonly string DeliveryNoteHeader;
        public static readonly string DeliveryNoteDetail;
        public static readonly string DeliveryValidationHeader;
        public static readonly string DeliveryValidationDetail;
        public static readonly string TransferOutHeader;
        public static readonly string TransferOutDetail;
        public static readonly string GeneralDescription;
        public static readonly string Division;
        public static readonly string Vendor;
        public static readonly string Customer;
        public static readonly string Item;
        public static readonly string ItemBarcode;
        public static readonly string PurchaseOrderHeader;
        public static readonly string PurchaseOrderDetail;
        public static readonly string SalesOrderHeader;
        public static readonly string SalesOrderDetail;
        public static readonly string GRNHeader;
        public static readonly string GRNDetail;
        #endregion

    }

    [DebuggerNonUserCode()]
    [Serializable]
    public static class RxlTableType {

        public static readonly int DiscrepancyReason = 1;

    }

}
