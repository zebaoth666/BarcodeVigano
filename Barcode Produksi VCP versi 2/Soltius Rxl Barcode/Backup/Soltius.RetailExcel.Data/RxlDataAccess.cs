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
using System.Security.AccessControl;
using System.Security.Principal;

using Soltius;
using Soltius.RetailExcel;
using Soltius.RetailExcel.Data;
using Soltius.RetailExcel.Data.Properties;
using Soltius.RetailExcel.Helper;

namespace Soltius.RetailExcel.Data {

    public class RxlDataAccess {

        #region Methods

        #region Not Overridables

        private void InitFields() {
            try {
                _RxlDataSet = new RxlDataSet();
                _SingleLock = new Dictionary<string, EventWaitHandle>();
                foreach (DataTable table in _RxlDataSet.Tables) {
                    bool createdNew = false;
                    string handleName = string.Format("{0}{1}Lock", DefaultApplicationInfo.AbbreviatedApplicationName, table.TableName);
                    EventWaitHandle waitHandle = null;
                    try {
                        waitHandle = EventWaitHandle.OpenExisting(handleName, EventWaitHandleRights.FullControl);
                    } catch { }
                    if (waitHandle == null) {
                        EventWaitHandleSecurity waitHandleSecurity = new EventWaitHandleSecurity();
                        waitHandleSecurity.SetAccessRule(new EventWaitHandleAccessRule(@"BUILTIN\Administrators", EventWaitHandleRights.FullControl, AccessControlType.Allow));
                        waitHandle = new EventWaitHandle(true, EventResetMode.AutoReset, handleName, out createdNew, waitHandleSecurity);
                    }
                    _SingleLock.Add(table.TableName, waitHandle);
                }
            } catch {
                throw;
            }
        }

        public RxlDataSet GetDataSet() {
            try {
                return _RxlDataSet;
            } catch {
                throw;
            }
        }

        public int FillTable<TDataTable>(bool refresh, params IConvertible[] paramValues)
            where TDataTable : DataTable, new() {

            try {
                return FillTable<TDataTable>(null, refresh, 0, paramValues);
            } catch {
                throw;
            }
        }

        public int FillTable<TDataTable>(bool refresh, int commandTextIndex, params IConvertible[] paramValues)
            where TDataTable : DataTable, new() {

            try {
                return FillTable<TDataTable>(null, refresh, commandTextIndex, paramValues);
            } catch {
                throw;
            }
        }

        public int FillTable<TDataTable>(string applicationName, bool refresh, params IConvertible[] paramValues)
            where TDataTable : DataTable, new() {

            try {
                return FillTable<TDataTable>(applicationName, refresh, 0, paramValues);
            } catch {
                throw;
            }
        }

        public int FillTable<TDataTable>(string applicationName, bool refresh, int commandTextIndex, params IConvertible[] paramValues)
            where TDataTable : DataTable, new() {

            try {
                string tableName = typeof(TDataTable).Name.Replace("DataTable", string.Empty);
                _SingleLock[tableName].WaitOne();
                try {
                    TDataTable realTable = _RxlDataSet.Tables[tableName] as TDataTable;
                    if (realTable == null) {
                        return 0;
                    }
                    if (!refresh && realTable.Rows.Count > 0) {
                        return realTable.Rows.Count;
                    }
                    using (TDataTable testTable = new TDataTable()) {
                        using (DataTable loaderTable = new DataTable()) {
                            using (SqlConnection connection = new SqlConnection(RxlConfiguration.GetCurrent().GetConnectionString(applicationName))) {
                                string commandText = GetCommandText(tableName, commandTextIndex);
                                if (commandText.Length == 0) {
                                    throw new ApplicationException(string.Format("Command text for table '{0}' has not yot been set in the design time.", tableName));
                                }
                                using (SqlCommand command = new SqlCommand(commandText, connection)) {
                                    if (paramValues != null && paramValues.Length > 0) {
                                        var paramNames = Regex.Matches(commandText, @"(?<paramName>(=|<>|!=|>|>=|<|<=|LIKE)\s*@\w+)", RegexOptions.IgnoreCase)
                                                        .Cast<Match>().Select(t => new { ParamName = Regex.Replace(t.Value, @"(?<operator>(=|<>|!=|>|>=|<|<=|LIKE))", string.Empty, RegexOptions.IgnoreCase).Trim() }).Distinct()
                                                        .Select((t, i) => new { Index = i, ParamName = t.ParamName });
                                        if ((paramNames == null) || (paramNames.Count() == 0) || (paramNames.Count() != paramValues.Length)) {
                                            throw new ArgumentException("paramValues count did not match with paramNames count in command text.");
                                        }
                                        var q = from a in paramNames
                                                join b in paramValues.Select((t, i) => new { Index = i, ParamValue = t })
                                                on a.Index equals b.Index
                                                select new { ParamName = a.ParamName, ParamValue = b.ParamValue };
                                        foreach (var i in q) {
                                            command.Parameters.AddWithValue(i.ParamName, i.ParamValue);
                                        }
                                    }
                                    command.CommandTimeout = 0;
                                    connection.Open();
                                    using (SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.KeyInfo)) {
                                        loaderTable.Load(dataReader, LoadOption.OverwriteChanges);
                                    }
                                }
                            }
                            testTable.Merge(loaderTable, false, MissingSchemaAction.Ignore);
                        }
                        realTable.Clear();
                        realTable.Merge(testTable, false, MissingSchemaAction.Ignore);
                    }
                    return realTable.Rows.Count;
                } catch {
                    throw;
                } finally {
                    _SingleLock[tableName].Set();
                }
            } catch {
                throw;
            }
        }

        public TDataTable GetTable<TDataTable>(bool refresh, params IConvertible[] paramValues)
            where TDataTable : DataTable, new() {

            try {
                return GetTable<TDataTable>(null, refresh, 0, paramValues);
            } catch {
                throw;
            }
        }

        public TDataTable GetTable<TDataTable>(bool refresh, int commandTextIndex, params IConvertible[] paramValues)
            where TDataTable : DataTable, new() {

            try {
                return GetTable<TDataTable>(null, refresh, commandTextIndex, paramValues);
            } catch {
                throw;
            }
        }

        public TDataTable GetTable<TDataTable>(string applicationName, bool refresh, params IConvertible[] paramValues)
            where TDataTable : DataTable, new() {

            try {
                return GetTable<TDataTable>(applicationName, refresh, 0, paramValues);
            } catch {
                throw;
            }
        }

        public TDataTable GetTable<TDataTable>(string applicationName, bool refresh, int commandTextIndex, params IConvertible[] paramValues)
            where TDataTable : DataTable, new() {

            try {
                string tableName = typeof(TDataTable).Name.Replace("DataTable", string.Empty);
                FillTable<TDataTable>(applicationName, refresh, paramValues);
                return _RxlDataSet.Tables[tableName] as TDataTable;
            } catch {
                throw;
            }
        }

        public void Update<TDataTable>()
            where TDataTable : DataTable, new() {

            try {
                Update<TDataTable>(null, null);
            } catch {
                throw;
            }
        }

        public void Update<TDataTable>(UpdateErrorHandler errorHandler)
            where TDataTable : DataTable, new() {

            try {
                Update<TDataTable>(null, errorHandler);
            } catch {
                throw;
            }
        }

        public void Update<TDataTable>(string applicationName, UpdateErrorHandler errorHandler)
            where TDataTable : DataTable, new() {
            try {
                string tableName = typeof(TDataTable).Name.Replace("DataTable", string.Empty);
                _SingleLock[tableName].WaitOne();
                try {
                    TDataTable sourceTable = _RxlDataSet.Tables[tableName] as TDataTable;
                    if (sourceTable == null) {
                        return;
                    }
                    string selectCommandText = string.Format("SELECT * FROM {0}", tableName);
                    if (selectCommandText.Length == 0) {
                        throw new ApplicationException(string.Format("Command text for table '{0}' has not yot been set in the design time.", tableName));
                    }
                    try {
                        CreateTable(applicationName, tableName);
                        using (SqlConnection connection = new SqlConnection(RxlConfiguration.GetCurrent().GetConnectionString(applicationName))) {
                            using (SqlCommand selectCommand = new SqlCommand(selectCommandText, connection)) {
                                selectCommand.CommandTimeout = 0;
                                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand)) {
                                    using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter)) {
                                        dataAdapter.InsertCommand = commandBuilder.GetInsertCommand(true).Clone();
                                        dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand(true).Clone();
                                        dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand(true).Clone();
                                    }
                                    connection.Open();
                                    UpdateInternal(dataAdapter, DataViewRowState.Deleted, sourceTable, errorHandler);
                                    UpdateInternal(dataAdapter, DataViewRowState.Added, sourceTable, errorHandler);
                                    UpdateInternal(dataAdapter, DataViewRowState.ModifiedCurrent, sourceTable, errorHandler);
                                }
                            }
                        }
                        sourceTable.AcceptChanges();
                    } catch {
                        sourceTable.RejectChanges();
                        throw;
                    }
                } catch {
                    throw;
                } finally {
                    _SingleLock[tableName].Set();
                }
            } catch {
                throw;
            }
        }

        private void UpdateInternal(SqlDataAdapter dataAdapter, DataViewRowState recordStates, DataTable sourceTable, UpdateErrorHandler errorHandler) {
            try {
                while (true) {
                    DataRow[] changedRows = sourceTable.Select(null, null, recordStates);
                    ErrorHandlerArgs args = null;
                    try {
                        SqlRowUpdatedEventHandler rowUpdated = delegate(object sender, SqlRowUpdatedEventArgs e) {
                            args = new ErrorHandlerArgs(sourceTable.TableName, e.Row, recordStates, e.Errors);
                        };
                        dataAdapter.RowUpdated += rowUpdated;
                        dataAdapter.Update(changedRows);
                        break;
                    } catch {
                        if (errorHandler == null) {
                            throw;
                        }
                        errorHandler(args);
                        if (args.Action == ErrorHandlingAction.ThrowError) {
                            throw;
                        }
                    }
                }
            } catch {
                throw;
            }
        }

        private void CreateTable(string applicationName, string tableName) {
            try {
                string commandText = string.Empty;
                if (tableName == RxlTableName.DeliveryValidationHeader) {
                    commandText = Resources.CreateDeliveryValidationHeaderTableCommandText;
                }
                if (tableName == RxlTableName.DeliveryValidationDetail) {
                    commandText = Resources.CreateDeliveryValidationDetailTableCommandText;
                }
                if (tableName == RxlTableName.GeneralDescription) {
                    commandText = Resources.CreateGeneralDescriptionTableCommandText;
                }
                _SingleLock[tableName].WaitOne();
                using (SqlConnection connection = new SqlConnection(RxlConfiguration.GetCurrent().GetConnectionString(applicationName))) {
                    using (SqlCommand command = new SqlCommand(commandText, connection)) {
                        command.CommandTimeout = 0;
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            } catch {
                throw;
            } finally {
                _SingleLock[tableName].Set();
            }
        }

        private string GetCommandText(string tableName, int commandTextIndex) {
            try {
                if (string.IsNullOrEmpty(tableName)) {
                    throw new ArgumentException(string.Format("{0} can not be null or empty", "tableName"));
                }
                if (tableName == _RxlDataSet.Organization.TableName) {
                    switch (commandTextIndex) {
                        case 0:
                            return Resources.GetOrganizationCommandText;
                        case 1:
                            return Resources.GetOrganizationByOrganizationCodeCommandText;
                        default:
                            break;
                    }
                }
                if (tableName == _RxlDataSet.DeliveryNoteHeader.TableName) {
                    switch (commandTextIndex) {
                        case 0:
                            return Resources.GetDeliveryNoteHeaderCommandText;
                        case 1:
                            return Resources.GetDeliveryNoteHeaderByOrganizationCodeCommandText;
                        default:
                            break;
                    }
                }
                //new
                if (tableName == _RxlDataSet.PurchaseOrderHeader.TableName) {
                    switch (commandTextIndex) {
                        case 0:
                            return Resources.GetPurchaseOrderHeaderCommandText;
                        default:
                            break;
                    }
                }
                if (tableName == _RxlDataSet.SalesOrderHeader.TableName)
                {
                    switch (commandTextIndex)
                    {
                        case 0:
                            return Resources.GetSalesOrderHeaderCommandText;
                        default:
                            break;
                    }
                }
                if (tableName == _RxlDataSet.GRNHeader.TableName)
                {
                    switch (commandTextIndex)
                    {
                        case 0:
                            return Resources.GetGRNHeaderCommandText;
                        default:
                            break;
                    }
                }
                //new 
                if (tableName == _RxlDataSet.DeliveryNoteDetail.TableName) {
                    return Resources.GetDeliveryNoteDetailByDocumentNumberCommandText;
                }
                if (tableName == _RxlDataSet.Customer.TableName) {
                    return Resources.GetCustomerCommandText;
                }
                if (tableName == _RxlDataSet.Item.TableName) {
                    switch (commandTextIndex) {
                        case 0:
                            return Resources.GetItemCommandText;
                        case 1:
                            return Resources.GetItemByDeliveryNoteCommandText;
                        case 2:
                            return Resources.GetItemByDivisionCodeCommandText;
                        default:
                            break;
                    }
                }
                if (tableName == _RxlDataSet.GeneralDescription.TableName) {
                    return Resources.GetDescriptionCommandText;
                }
                if (tableName == _RxlDataSet.DeliveryValidationHeader.TableName) {
                    switch (commandTextIndex) {
                        case 0:
                            return Resources.GetDeliveryValidationHeaderCommandText;
                        case 1:
                            return Resources.GetDeliveryValidationHeaderByOrganizationCodeCommandText;
                        case 2:
                            return Resources.GetDeliveryValidationHeaderByDocumentNumberCommandText;
                        default:
                            break;
                    }
                }
                if (tableName == _RxlDataSet.DeliveryValidationDetail.TableName) {
                    switch (commandTextIndex) {
                        case 0:
                            return Resources.GetDeliveryValidationDetailCommandText;
                        case 1:
                            return Resources.GetDeliveryValidationDetailByDocumentNumberCommandText;
                        default:
                            break;
                    }
                }
                if (tableName == _RxlDataSet.TransferOutHeader.TableName) {
                    return Resources.GetTransferOutHeaderCommandText;
                }
                if (tableName == _RxlDataSet.TransferOutDetail.TableName) {
                    return Resources.GetTransferOutDetailByDocumentNumberCommandText;
                }
                if (tableName == _RxlDataSet.Division.TableName) {
                    return Resources.GetDivisionCommandText;
                }
                if (tableName == _RxlDataSet.ItemBarcodeWithQuantity.TableName) {
                    switch (commandTextIndex) {
                        case 0:
                            return Resources.GetItemBarcodeByDeliveryNoteCommandText;
                        case 1:
                            return Resources.GetItemBarcodeByTransferOutCommandText;
                        case 2:
                            return Resources.GetItemBarcodeByDivisionCommandText;
                        //new
                        case 3:
                            return Resources.GetItemBarcodeByPurchaseOrderCommandText;
                        case 4:
                            return Resources.GetItemBarcodeBySalesOrderCommandText;
                        case 5:
                            return Resources.GetItemBarcodeByGRNCommandText;
                        //new
                        default:
                            break;
                    }
                }
                return string.Empty;
            } catch {
                throw;
            }
        }

        #endregion

        #region Constructors

        private RxlDataAccess() {
            try {
                InitFields();
            } catch {
                throw;
            }
        }

        ~RxlDataAccess() {
            try {
                foreach (KeyValuePair<string, EventWaitHandle> item in _SingleLock) {
                    item.Value.Close();
                }
            } catch { }
            try {
                _RxlDataSet.Dispose();
            } catch { }
        }

        #endregion

        #endregion

        #region Properties

        public static RxlDataAccess Instance {
            get {
                try {
                    if (_RxlDataAccess == null) {
                        _RxlDataAccess = new RxlDataAccess();
                    }
                    return _RxlDataAccess;
                } catch {
                    throw;
                }
            }
        }

        #endregion

        #region Fields

        private static RxlDataAccess _RxlDataAccess;

        private RxlDataSet _RxlDataSet;

        private Dictionary<string, EventWaitHandle> _SingleLock;

        #endregion

    }

}
