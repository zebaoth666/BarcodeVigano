

namespace Soltius.RetailExcel.Utils.PrintBarcode {
    
    public partial class RxlBarcodeConfiguration {

        public partial class PrintSettingDataTable : global::System.Data.TypedTableBase<PrintSettingRow> {

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public PrintSettingRow AddPrintSettingRow(string SettingCode, string PrinterName, 
                int PrintStartRow, int PrintStartColumn, string BarcodeType, 
                bool ShowTopText, string TopTextFontStyle, string TopTextType,
                bool ShowBottomText, string BottomTextFontStyle, string BottomTextType,
                decimal BarcodeWidthScale, decimal BarcodeHeightScale, int LabelID,
                bool ShowPrcPrnText, string PrcPrnTextFontStyle, string PrcPrnTextType) {

                PrintSettingRow rowPrintSettingRow = ((PrintSettingRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                    SettingCode,
                    PrinterName,
                    PrintStartRow,
                    PrintStartColumn,
                    BarcodeType,
                    ShowTopText,
                    TopTextFontStyle,
                    TopTextType,
                    ShowBottomText,
                    BottomTextFontStyle,
                    BottomTextType,
                    BarcodeWidthScale,
                    BarcodeHeightScale,
                    LabelID,
                    ShowPrcPrnText,
                    PrcPrnTextFontStyle,
                    PrcPrnTextType,
                };
                rowPrintSettingRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowPrintSettingRow);
                return rowPrintSettingRow;
            }

        }

    }
}
