using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Data.Linq.SqlClient;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;
using C1.Win.C1BarCode;

using Soltius.RetailExcel.Data;
using Soltius.RetailExcel.Helper;
using Soltius.RetailExcel.Utils.PrintBarcode.Properties;

namespace Soltius.RetailExcel.Utils.PrintBarcode {

    internal partial class MainForm : Form {
        
        #region Methods
        
        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e) {
            try {
                StartUp();
            } catch {
                throw;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            try {
                TryLogin();
            } catch (Exception ex) {
                ExceptionManager.ShowException(ApplicationInfo.ShortApplicationName, this, ex);
                SafeExit();
                //throw;
            }
        }

        private void StatusTimer_Tick(object sender, EventArgs e) {
            try {
                CurrentDateTimeStatusLabel.Text = (_CurrentDateTime = _CurrentDateTime.AddSeconds(1.0D)).ToString("dd-MMM-yyyy HH:mm:ss tt");
            } catch {
                CurrentDateTimeStatusLabel.Text = string.Empty;
                //throw;
            }
        }

        private void DocumentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                ChangeDocumentType();
            } catch {
                throw;
            }
        }

        private void RefreshDocumentButton_Click(object sender, EventArgs e) {
            try {
                RefreshDocument();
            } catch {
                throw;
            }
        }

        private void DocumentKeyComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                ChangeDocumentInfo();
            } catch {
                throw;
            }
        }

        private void AddDetailItemsButton_Click(object sender, EventArgs e) {
            try {
                //AddDetailItems();
               AddDetailShoesItems();

            } catch {
                throw;
            }
        }

        private void ImportItemsToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                using (OpenFileDialog fileDialog = new OpenFileDialog()) {
                    fileDialog.Title = string.Format("{0} Import from Microsoft Office Excel", ApplicationInfo.ShortApplicationName);
                    fileDialog.DefaultExt = "xls";
                    fileDialog.Filter = "Microsoft Office Excel files (*.xls)|*.xls";
                    fileDialog.SupportMultiDottedExtensions = true;
                    DialogResult result = fileDialog.ShowDialog(this);
                    if (result == DialogResult.OK) {
                        ImportFromExcel(fileDialog.FileName);
                    }
                }
            } catch {
                throw;
            }
        }

        private void ExportItemsToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                using (SaveFileDialog fileDialog = new SaveFileDialog()) {
                    fileDialog.Title = string.Format("{0} Export to Microsoft Office Excel", ApplicationInfo.ShortApplicationName);
                    fileDialog.DefaultExt = "xls";
                    fileDialog.Filter = "Microsoft Office Excel files (*.xls)|*.xls";
                    fileDialog.SupportMultiDottedExtensions = true;
                    DialogResult result = fileDialog.ShowDialog(this);
                    if (result == DialogResult.OK) {
                        ExportToExcel(fileDialog.FileName);
                    }
                }
            } catch {
                throw;
            }
        }

        private void CheckAllItemsToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                foreach (DataGridViewRow row in ItemDetailDataGridView.Rows) {
                    row.Cells[IsPrintedDgvColumn.Index].Value = true;
                    decimal printCount = 0.0M;
                    try {
                        printCount = Convert.ToDecimal(row.Cells[IsPrintedDgvColumn.Index].Value);
                    } catch { }
                    if (printCount == 0.0M) {
                        row.Cells[IsPrintedDgvColumn.Index].Value = 1.0M;
                    }
                }
            } catch {
                throw;
            }
        }

        private void ClearAllItemChecksToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                foreach (DataGridViewRow row in ItemDetailDataGridView.Rows) {
                    row.Cells[IsPrintedDgvColumn.Index].Value = false;
                }
            } catch {
                throw;
            }
        }

        private void FindNextToolStripButton_Click(object sender, EventArgs e) {
            try {
                FindNextItem();
            } catch {
                throw;
            }
        }

        private void AddNewItemToolStripButton_Click(object sender, EventArgs e) {
            try {
                AddNewItem();
            } catch {
                throw;
            }
        }

        private void NewItemToolStripTextBox_KeyDown(object sender, KeyEventArgs e) {
            try {
                if (e.KeyCode != Keys.Enter) {
                    return;
                }
                e.Handled = true;
                ToolStripTextBox obj = sender as ToolStripTextBox;
                if (obj == null) {
                    return;
                }
                obj.KeyDown -= NewItemToolStripTextBox_KeyDown;
                AddNewItem();
            } catch {
                throw;
            }
        }

        private void NewItemToolStripTextBox_KeyUp(object sender, KeyEventArgs e) {
            try {
                if (e.KeyCode != Keys.Enter) {
                    return;
                }
                e.Handled = true;
                ToolStripTextBox obj = sender as ToolStripTextBox;
                if (obj == null) {
                    return;
                }
                obj.KeyDown -= NewItemToolStripTextBox_KeyDown;
                obj.KeyDown += NewItemToolStripTextBox_KeyDown;
            } catch {
                throw;
            }
        }

        private void NewPrintCountToolStripTextBox_Validating(object sender, CancelEventArgs e) {
            try {
                if (NewPrintCountToolStripTextBox.Text.Length == 0) {
                    return;
                }
                int value = 1;
                bool isNumber = int.TryParse(NewPrintCountToolStripTextBox.Text, out value);
                if (!isNumber) {
                    NewPrintCountToolStripTextBox.Text = "1";
                }
                if (value <= 0) {
                    NewPrintCountToolStripTextBox.Text = "1";
                    return;
                }
                e.Cancel = !isNumber;
            } catch {
                throw;
            }
        }

        private void RemoveAllItemsToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                RemoveAllItems();
            } catch {
                throw;
            }
        }

        private void RemoveSelectedItemsToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                RemoveSelectedItems();
            } catch {
                throw;
            }
        }

        private void ResetAllItemsButton_Click(object sender, EventArgs e) {
            try {
                ItemDetailDataGridView.CancelEdit();
                _ItemDetailBindingSource.CancelEdit();
                _RxlDataSet.ItemBarcodeWithQuantity.RejectChanges();
            } catch {
                //throw;
            }
        }

        private void ItemDetailDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e) {
            try {
                ChangeBarcodeView(e.RowIndex);
            } catch {
                throw;
            }
        }

        private void ItemDetailDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            try {
                if (e.ColumnIndex == PrintCountDgvColumn.Index) {
                    ItemDetailDataGridView[e.ColumnIndex, e.RowIndex].Value = 1.0M;
                    e.Cancel = false;
                }
            } catch {
                throw;
            }
        }

        private void ItemDetailDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            try {
                if (e.ColumnIndex == PrintCountDgvColumn.Index) {
                    decimal value = 1.0M;
                    try {
                        value = Convert.ToDecimal(ItemDetailDataGridView[e.ColumnIndex, e.RowIndex].Value);
                    } catch {
                        value = 0.0M;
                    }
                    if (value <= 0.0M) {
                        ItemDetailDataGridView[e.ColumnIndex, e.RowIndex].Value = 1.0M;
                    }
                }
            } catch {
                throw;
            }
        }

        private void BarcodeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                ChangeBarcodeView();
            } catch {
                throw;
            }
        }

        private void ChangeBarcodeTextFontStyleButton_Click(object sender, EventArgs e) {
            try
            {
                DialogResult result = BarcodeTextFontDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    if (sender == ChangeTopTextFontStyleButton)
                    {
                        ChangeBarcodeTextFont(sender == ChangeTopTextFontStyleButton, false, false);
                    }
                    else if (sender == ChangePrcTextFontStyleButton)
                    {
                        ChangeBarcodeTextFont(false, sender == ChangePrcTextFontStyleButton, false);
                    }
                    else if (sender == ChanteBottomTextFontStyleButton)
                    {
                        ChangeBarcodeTextFont(false, false, sender == ChanteBottomTextFontStyleButton);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void BarcodeTopTextTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                if (ItemDetailDataGridView.CurrentRow == null) {
                    return;
                }
                SetBarcodeText(ItemDetailDataGridView.CurrentRow);
            } catch {
                throw;
            }
        }

        private void BarcodeBottomTextTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                if (ItemDetailDataGridView.CurrentRow == null) {
                    return;
                }
                SetBarcodeText(ItemDetailDataGridView.CurrentRow);
            } catch {
                throw;
            }
        }

        private void ShowTopTextCheckBox_CheckedChanged(object sender, EventArgs e) {
            try {
                ChangeBarcodeTextFont(true,false,false);
            } catch {
                throw;
            }
        }

        private void ShowBottomTextCheckBox_CheckedChanged(object sender, EventArgs e) {
            try {
                ChangeBarcodeTextFont(false,true,false);
            } catch {
                throw;
            }
        }

        private void ResetDefaultPrintSettingButton_Click(object sender, EventArgs e) {
            try {
                SetDefaultPrintSetting(true);
            } catch {
                throw;
            }
        }

        private void LoadPrintSettingButton_Click(object sender, EventArgs e) {
            try {
                using (OpenFileDialog fileDialog = new OpenFileDialog()) {
                    fileDialog.Title = string.Format("{0} Configuration", ApplicationInfo.ShortApplicationName);
                    fileDialog.InitialDirectory = Application.StartupPath;
                    fileDialog.FileName = _ConfigFileName;
                    fileDialog.DefaultExt = "xml";
                    fileDialog.Filter = "XML files (*.xml)|*.xml";
                    fileDialog.SupportMultiDottedExtensions = true;
                    DialogResult result = fileDialog.ShowDialog(this);
                    if (result == DialogResult.OK) {
                        _ConfigFileName = fileDialog.FileName;
                        LoadConfigFile(true);
                    }
                }
            } catch {
                throw;
            }
        }

        private void SaveAsPrintSettingButton_Click(object sender, EventArgs e) {
            try {
                using (SaveFileDialog fileDialog = new SaveFileDialog()) {
                    fileDialog.Title = string.Format("{0} Configuration", ApplicationInfo.ShortApplicationName);
                    fileDialog.FileName = _ConfigFileName;
                    fileDialog.InitialDirectory = Application.StartupPath;
                    fileDialog.DefaultExt = "xml";
                    fileDialog.Filter = "XML files (*.xml)|*.xml";
                    fileDialog.SupportMultiDottedExtensions = true;
                    DialogResult result = fileDialog.ShowDialog(this);
                    if (result == DialogResult.OK) {
                        _ConfigFileName = fileDialog.FileName;
                        SaveConfigFile();
                    }
                }
            } catch {
                throw;
            }
        }

        private void AddNewLabelSettingsButton_Click(object sender, EventArgs e) {
            try {
                AddNewLabelSettings();
            } catch {
                throw;
            }
        }

        private void DeleteCurrentLabelSettingsButton_Click(object sender, EventArgs e) {
            try {
                DeleteCurrentLabelSettings();
            } catch {
                throw;
            }
        }

        private void SaveNewLabelSettingsButton_Click(object sender, EventArgs e) {
            try {
                SaveNewLabelSettings(true);
            } catch {
                throw;
            }
        }

        private void PrintLabelTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                SafeSetMaximumLabelStartIndex();
                _ChangedByLabelType = true;
            } catch {
                throw;
            }
        }

        private void PrintLabelWidthNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PrintLabelHeightNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PrintLabelColumnSpaceNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PrintLabelRowSpaceNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PaperWidthNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PaperHeightNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PageTopMarginNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PageLeftMarginNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PageBottomMarginNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PageRightMarginNumericUpDown_ValueChanged(object sender, EventArgs e) {
            try {
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void PageOrientationComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                if (_ChangedByLabelType) {
                    _ChangedByLabelType = false;
                    _LastPageOrientation = Convert.ToString(PageOrientationComboBox.SelectedValue);
                    return;
                }
                if (_LastPageOrientation == Convert.ToString(PageOrientationComboBox.SelectedValue)) {
                    return;
                } else {
                    _LastPageOrientation = Convert.ToString(PageOrientationComboBox.SelectedValue);
                }
                UnSubcribeNumericUpDownValueChangedEvents();
                decimal temp = 0.0M;
                if (Convert.ToString(PageOrientationComboBox.SelectedValue) == PageOrientationType.Landscape) {
                    temp = PaperWidthNumericUpDown.Value;
                    PaperWidthNumericUpDown.Value = PaperHeightNumericUpDown.Value;
                    PaperHeightNumericUpDown.Value = temp;
                    temp = PageTopMarginNumericUpDown.Value;
                    PageTopMarginNumericUpDown.Value = PageLeftMarginNumericUpDown.Value;
                    PageLeftMarginNumericUpDown.Value = temp;
                    temp = PageBottomMarginNumericUpDown.Value;
                    PageBottomMarginNumericUpDown.Value = PageRightMarginNumericUpDown.Value;
                    PageRightMarginNumericUpDown.Value = temp;
                } else {
                    temp = PaperHeightNumericUpDown.Value;
                    PaperHeightNumericUpDown.Value = PaperWidthNumericUpDown.Value;
                    PaperWidthNumericUpDown.Value = temp;
                    temp = PageLeftMarginNumericUpDown.Value;
                    PageLeftMarginNumericUpDown.Value = PageTopMarginNumericUpDown.Value;
                    PageTopMarginNumericUpDown.Value = temp;
                    temp = PageRightMarginNumericUpDown.Value;
                    PageRightMarginNumericUpDown.Value = PageBottomMarginNumericUpDown.Value;
                    PageBottomMarginNumericUpDown.Value = temp;
                }
                SetMaximumLabelStartIndex();
                SubcribeNumericUpDownValueChangedEvents();
            } catch {
                throw;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e) {
            try {
                PrintLabels();
            } catch (Exception ex) {
                ExceptionManager.ShowException(ApplicationInfo.ShortApplicationName, this, ex);
                //throw;
            }
        }

        private void _PrintDocument_BeginPrint(object sender, PrintEventArgs e) {
            try {
                _FirstPagePrinted = false;
                _IsPreview = (e.PrintAction == PrintAction.PrintToPreview);

                var q = from t in  DsShoesBarcode.ItemDetail.AsEnumerable()
                        where ((t.Quantity > 0) && (t.IsPrinted))
                        select t;

                _PrintHelper = new PrintHelper();
                _PrintHelper.SetPrintObject((int)PrintStartRowNumericUpDown.Value, (int)PrintStartColumnNumericUpDown.Value, q);

                if (_PrintHelper.ItemCount == 0 || PrintStartRowNumericUpDown.Maximum <= 0 || PrintStartColumnNumericUpDown.Maximum <= 0) {
                    MessageBox.Show(this, "There were nothing to print.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _PrintHelper.SetPageSettings((Convert.ToString(PageOrientationComboBox.SelectedValue) == PageOrientationType.Landscape),
                        PageLeftMarginNumericUpDown.Value, PageRightMarginNumericUpDown.Value, PageTopMarginNumericUpDown.Value, PageBottomMarginNumericUpDown.Value,
                        PaperWidthNumericUpDown.Value, PaperHeightNumericUpDown.Value,
                        LabelWidthNumericUpDown.Value, LabelHeightNumericUpDown.Value, LabelColumnSpaceNumericUpDown.Value, LabelRowSpaceNumericUpDown.Value,
                        LabelLeftMarginNumericUpDown.Value, LabelRightMarginNumericUpDown.Value, LabelTopMarginNumericUpDown.Value, LabelBottomMarginNumericUpDown.Value,
                        BarcodeWidthScaleNumericUpDown.Value, BarcodeHeightScaleNumericUpDown.Value,
                        ShowTopTextCheckBox.Checked, ShowBottomTextCheckBox.Checked, ShowPrcPrnTextCheckBox.Checked
                    );
            } catch {
                throw;
            }
        }

        private void _PrintDocument_QueryPageSettings(object sender, QueryPageSettingsEventArgs e) {
            try {
                PageSettings settings = e.PageSettings;
                settings.Landscape = _PrintHelper.IsLandscape;
                if (!_PrintHelper.IsLandscape) {
                    settings.Margins = new Margins(_PrintHelper.PageLeftMargin, _PrintHelper.PageRightMargin, _PrintHelper.PageTopMargin, _PrintHelper.PageBottomMargin);
                    settings.PaperSize = new PaperSize(PaperSourceKind.Custom.ToString(), _PrintHelper.PaperWidth, _PrintHelper.PaperHeight);
                } else {
                    settings.Margins = new Margins(_PrintHelper.PageTopMargin, _PrintHelper.PageBottomMargin, _PrintHelper.PageLeftMargin, _PrintHelper.PageRightMargin);
                    settings.PaperSize = new PaperSize(PaperSourceKind.Custom.ToString(), _PrintHelper.PaperHeight, _PrintHelper.PaperWidth);
                }
            } catch {
                throw;
            }
        }
//=====================================================================================================================//
//............................................edit by bagus pramana.....................................................//
//=====================================================================================================================//
 
        private void _PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;

                float paperWidth = (float)(e.PageBounds.Width);
                float paperHeight = (float)(e.PageBounds.Height);

                float pageTopMargin = (float)(e.MarginBounds.Top+1);
                float pageLeftMargin = (float)(e.MarginBounds.Left);
                float pageBottomMargin = (float)(e.MarginBounds.Bottom);
                float pageRightMargin = (float)(e.MarginBounds.Right);

                float labelWidth = (float)(_PrintHelper.LabelWidth);
                float labelHeight = (float)(_PrintHelper.LabelHeight);
                float labelColumnSpace = (float)(_PrintHelper.LabelColumnSpace);
                float labelRowSpace = (float)(_PrintHelper.LabelRowSpace);

                float currentX = pageLeftMargin;
                float currentY = pageTopMargin;

                float labelLeftMargin = labelWidth * (_PrintHelper.LabelLeftMargin / 100F);
                float labelRightMargin = labelWidth * (_PrintHelper.LabelRightMargin / 100F);
                float labelTopMargin = labelHeight * (_PrintHelper.LabelTopMargin / 100F);
                float labelBottomMargin = labelHeight * (_PrintHelper.LabelBottomMargin / 100F);

                float barcodeWidthScale = _PrintHelper.BarcodeWidthScale;
                float barcodeHeightScale = _PrintHelper.BarcodeHeightScale;

                int rowCount = _PrintHelper.GetRowCountPerPage(false);
                int columnCount = _PrintHelper.GetColumnCountPerPage(false);
                StringFormat textFormatCenter = new StringFormat(StringFormatFlags.LineLimit);
                textFormatCenter.Alignment = StringAlignment.Center;
                textFormatCenter.Trimming = StringTrimming.EllipsisPath;


                StringFormat textFormatLeft = new StringFormat(StringFormatFlags.LineLimit);
                textFormatLeft.Alignment = StringAlignment.Near;
                textFormatLeft.Trimming = StringTrimming.EllipsisPath;

                StringFormat textFormatRight = new StringFormat(StringFormatFlags.LineLimit);
                textFormatRight.Alignment = StringAlignment.Far;
                textFormatRight.Trimming = StringTrimming.EllipsisPath;
     
                Font topTextFont = BarcodeColourTextPreviewLabel.Tag as Font;
                //Font bottomTextFont;
                Font BarCodePreviewFont = BarCodePreview.Font;
                Font prcPrnTextFont = BarcodeAsTextPreviewLabel.Tag as Font;

                Font styleTextFont;
                Font colourTextFont;
                Font sizeTextFont;
                Font asTextFont;
                Font brandTextFont;
                Font dateTextFont;
                Font madeTextFont;


                if (PrcFontStyleLabel.Text == "Arial, 8.25pt, Regular")
                {
                    asTextFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    brandTextFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dateTextFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    madeTextFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    asTextFont = BarcodeAsTextPreviewLabel.Tag as Font;
                    brandTextFont = BarcodeAsTextPreviewLabel.Tag as Font;
                    dateTextFont = BarcodeAsTextPreviewLabel.Tag as Font;
                    madeTextFont = BarcodeAsTextPreviewLabel.Tag as Font;
                }

                if (TopTextFontStyleLabel.Text == "Arial, 8.25pt, Regular")
                {
                    styleTextFont = new System.Drawing.Font("Arial", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    colourTextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
                else
                {
                    styleTextFont = BarcodeColourTextPreviewLabel.Tag as Font;
                    colourTextFont = BarcodeColourTextPreviewLabel.Tag as Font;
                }
                if (BottomTextFontStyleLabel.Text == "Arial, 8.25pt")
                {
                    sizeTextFont = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    sizeTextFont = BarcodeStyleTextPreviewLabel.Tag as Font;
                }
                 
                //Font prcPrnTextFont = BarcodePrcPrnTextPreviewLabel.Tag as Font;

                string topTextType = Convert.ToString(TopTextTypeComboBox.SelectedValue);
                string bottomTextType = Convert.ToString(BottomTextTypeComboBox.SelectedValue);
                //new
                string prcPrnTextType = Convert.ToString(PrcPrnTextTypeComboBox.SelectedValue);

                int currentRowIndex = 1;
                if (!_FirstPagePrinted && _PrintHelper.LabelStartRow > 1)
                {
                    currentRowIndex = _PrintHelper.LabelStartRow;
                    currentY += (labelHeight * (float)(currentRowIndex - 1)) + (labelRowSpace * (float)(currentRowIndex - 1));
                }

                //RxlDataSet.ItemBarcodeWithQuantityRow row =;
   
                dsShoesBarcodePrinting.ItemDetailRow row =  _PrintHelper.GetCurrentItem();
                
                int quantityPrinted = _PrintHelper.LastQuantityPrinted;
                while (currentRowIndex <= rowCount)
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("id-ID");
                      
                    int currentColumnIndex = 1;
                    if (!_FirstPagePrinted && _PrintHelper.LabelStartColumn > 1)
                    {
                        currentColumnIndex = _PrintHelper.LabelStartColumn;
                        currentX += (labelWidth * (float)(currentColumnIndex - 1)) + (labelColumnSpace * (float)(currentColumnIndex - 1));
                    }
                    while (_PrintHelper.HasMoreItems() && currentColumnIndex <= columnCount)
                    {
                        RectangleF labelRectangle = new RectangleF(currentX, currentY, labelWidth, labelHeight);
                        string topText = string.Empty;
                        string bottomText = string.Empty;
                        string strPrcPrn = string.Empty;
                       

                        //new code to chang strPrc text font ...

                   

                        string styleText =  "Style";
                        string styleText_dot = ":" + Convert.ToString(row.Style);
                        string colourText = Convert.ToString(row.Color); ;
                        //string colourText_dot = Convert.ToString(row.Color);                 
                        string yearText = (Convert.ToString(row.ProdCode)).Substring(3,1);
                        //string sizeText_dot = ":" + Convert.ToString(row.Size);
                        //     trimmed = original.Substring(midCharIndex-1,3);
                        string sizeText_dot = Convert.ToString(row.Size);


                        string itemCodeText = Convert.ToString(row.ItemCode);
                        string brandText =  " " + Convert.ToString(row.Brand);                      
                        string dateText = Convert.ToString(row.ProdCode);
                        string asText;
                        //string Made = Convert.ToString(row.MadeFrom);
                        
                        //string asStr = row.SizeRange.Trim().Substring(1, 1);
                        //double asNum;
                        //bool isasNum = double.TryParse(asStr, out asNum);
                        if (row.ItemType.ToString() == "1")
                        {
                            asText = " AS :" + Convert.ToString(row.SizeRange);
                        }
                        else
                        {
                            asText = string.Empty;
                        }   

                     
                        SizeF styleTextSize = g.MeasureString(styleText, styleTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();
                        SizeF colourTextSize = g.MeasureString(colourText, colourTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();
                        //SizeF sizeTextSize = g.MeasureString(sizeText, sizeTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();
                        SizeF yearTextSize = g.MeasureString(yearText, sizeTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();
                        SizeF sizeTextSize = g.MeasureString(sizeText_dot, sizeTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();

                        SizeF styleTextSize_dot = g.MeasureString(styleText_dot, styleTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();
                        //SizeF colourTextSize_dot = g.MeasureString(colourText_dot, colourTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();
                        //SizeF sizeTextSize_dot = g.MeasureString(sizeText_dot, sizeTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();

                        float label_left_size = 0 ;
                        if (styleTextSize.Width > colourTextSize.Width)
                        {
                            if (styleTextSize.Width > sizeTextSize.Width)
                            {
                                //label_left_size = styleTextSize.Width;
                                label_left_size = sizeTextSize.Width;
                            }
                            else
                            {
                                label_left_size = sizeTextSize.Width;
                                //label_left_size = styleTextSize.Width;
                            }
                        }
                        else if (colourTextSize.Width > sizeTextSize.Width)
                        {
                            //label_left_size = colourTextSize.Width;
                            label_left_size = sizeTextSize.Width;
                        }
                        else
                        {
                            label_left_size = sizeTextSize.Width;
                            //label_left_size = colourTextSize.Width;
                        }


                        RectangleF styleTextRectangle = new RectangleF(new PointF(currentX + labelLeftMargin, currentY + labelTopMargin), new SizeF(label_left_size + 25, styleTextSize.Height));
                        RectangleF colourTextRectangle = new RectangleF(new PointF(currentX + labelLeftMargin, (styleTextRectangle.Height + labelRectangle.Top + labelTopMargin)), new SizeF(labelWidth - labelRightMargin, colourTextSize.Height));
                        //RectangleF colourTextRectangle_dot = new RectangleF(new PointF(currentX + labelLeftMargin + colourTextRectangle.Width, (styleTextRectangle.Height + colourTextRectangle.Height + labelRectangle.Top)), new SizeF((labelWidth - labelRightMargin) - label_left_size, colourTextSize.Height));
                        //RectangleF colourTextRectangle_dot = new RectangleF(new PointF(currentX + labelLeftMargin + 3, (styleTextRectangle.Height + colourTextRectangle.Height + labelRectangle.Top)), new SizeF(labelWidth - labelRightMargin, colourTextSize.Height));

                        //RectangleF sizeTextRectangle = new RectangleF(new PointF(currentX + labelLeftMargin, (styleTextRectangle.Height + colourTextRectangle.Height + labelRectangle.Top + labelTopMargin)), new SizeF(label_left_size + 1, sizeTextSize.Height));
                        RectangleF yearTextRectangle = new RectangleF(new PointF(currentX + labelLeftMargin + styleTextRectangle.Width+ 13, (styleTextRectangle.Height + colourTextRectangle.Height + labelRectangle.Top + labelTopMargin)), new SizeF(label_left_size + 1, sizeTextSize.Height));
                        RectangleF sizeTextRectangle_dot = new RectangleF(new PointF(currentX + labelLeftMargin, (styleTextRectangle.Height + colourTextRectangle.Height + labelRectangle.Top + labelTopMargin)), new SizeF(label_left_size + 1, sizeTextSize.Height));

                        RectangleF styleTextRectangle_dot = new RectangleF(new PointF(currentX + labelLeftMargin + styleTextRectangle.Width, currentY + labelTopMargin), new SizeF((labelWidth - labelRightMargin) - label_left_size, styleTextSize.Height));

                        //RectangleF sizeTextRectangle_dot = new RectangleF(new PointF(currentX + labelLeftMargin + sizeTextRectangle.Width, (styleTextRectangle.Height + colourTextRectangle.Height + labelRectangle.Top + labelTopMargin)), new SizeF((labelWidth - labelRightMargin) - label_left_size, sizeTextSize.Height));

                      
                        SizeF brandTextSize = g.MeasureString(brandText, brandTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();
                        RectangleF brandTextRectangle = new RectangleF(new PointF(currentX + labelLeftMargin, (styleTextRectangle.Height + colourTextRectangle.Height + sizeTextRectangle_dot.Height + labelRectangle.Top + labelTopMargin-5)), new SizeF(labelWidth - labelRightMargin, brandTextSize.Height));
                                               
                       
                        SizeF asTextSize = g.MeasureString(asText, asTextFont, (int)(labelWidth * 100F), textFormatLeft).ToSize();
                        RectangleF asTextRectangle = new RectangleF(new PointF(currentX + labelLeftMargin, (styleTextRectangle.Height + colourTextRectangle.Height + sizeTextRectangle_dot.Height + brandTextRectangle.Height + labelRectangle.Top + labelTopMargin - 8)), new SizeF(labelWidth - labelRightMargin, asTextSize.Height));

                        
                        SizeF dateTextSize = g.MeasureString(dateText, dateTextFont, (int)(labelWidth * 100F), textFormatRight).ToSize();
                        RectangleF dateTextRectangle = new RectangleF(new PointF(currentX + labelLeftMargin + 7, (styleTextRectangle.Height + colourTextRectangle.Height + sizeTextRectangle_dot.Height + brandTextRectangle.Height + labelRectangle.Top + labelTopMargin-8)), new SizeF(((labelWidth - labelRightMargin) / 2), dateTextSize.Height));

                        
                        SizeF itemCodeTexttSize = g.MeasureString(itemCodeText, madeTextFont, (int)(labelWidth * 100F), textFormatCenter).ToSize();
                      //  SizeF madeFromTextSize = g.MeasureString(Made, madeTextFont, (int)(labelWidth * 100F), textFormatCenter).ToSize();
                        RectangleF barcodeRectangle = new RectangleF(new PointF(((currentX - 10 + dateTextRectangle.Width) + (dateTextSize.Width / 2)), styleTextRectangle.Bottom + colourTextRectangle.Bottom - 43), new SizeF(((labelWidth / 2) - labelRightMargin - (brandTextSize.Width / 2)), (sizeTextSize.Height + brandTextSize.Height)));
                        RectangleF itemCodeTextRectangle = new RectangleF(new PointF(((currentX - 10 + dateTextRectangle.Width) + (dateTextSize.Width / 2)), barcodeRectangle.Y + barcodeRectangle.Height - 5), new SizeF(((labelWidth / 2) - labelRightMargin - (brandTextSize.Width / 2)), dateTextSize.Height));
                        RectangleF madeTextRectangle = new RectangleF(new PointF(((currentX - 10 + dateTextRectangle.Width) + (dateTextSize.Width / 2)), itemCodeTextRectangle.Y + itemCodeTextRectangle.Height - 2), new SizeF(((labelWidth / 2) - labelRightMargin - (brandTextSize.Width / 2)), dateTextSize.Height));

                        float minusWidth = barcodeRectangle.Width - (barcodeRectangle.Width * (barcodeWidthScale / 100F));
                        barcodeRectangle.Width -= minusWidth;
                        barcodeRectangle.Location = new PointF(barcodeRectangle.Left + (minusWidth / 2F), barcodeRectangle.Y);
                        float minusHeight = barcodeRectangle.Height - (barcodeRectangle.Height * (barcodeHeightScale / 100F));
                        barcodeRectangle.Height -= minusHeight;
                        barcodeRectangle.Location = new PointF(barcodeRectangle.X, barcodeRectangle.Top + (minusHeight / 2F));
                        g.FillRectangles(Brushes.Transparent, new RectangleF[] { labelRectangle, styleTextRectangle, barcodeRectangle, sizeTextRectangle_dot, colourTextRectangle, asTextRectangle, madeTextRectangle });
                       
                        g.DrawString(styleText, styleTextFont, Brushes.Black, styleTextRectangle, textFormatLeft);
                        g.DrawString(colourText, colourTextFont, Brushes.Black, colourTextRectangle, textFormatLeft);
                        g.DrawString(brandText, brandTextFont, Brushes.Black, brandTextRectangle, textFormatLeft);
                        g.DrawString(dateText, dateTextFont, Brushes.Black, dateTextRectangle, textFormatRight);
                        //g.DrawString(sizeText, sizeTextFont, Brushes.Black, sizeTextRectangle, textFormatLeft);
                        g.DrawString(yearText, sizeTextFont, Brushes.Black, yearTextRectangle, textFormatLeft);
                        g.DrawString(asText, asTextFont, Brushes.Black, asTextRectangle, textFormatLeft);
                        g.DrawString(itemCodeText, asTextFont, Brushes.Black, itemCodeTextRectangle, textFormatCenter);
                    //    g.DrawString(Made, asTextFont, Brushes.Black, madeTextRectangle, textFormatCenter);

                        g.DrawString(styleText_dot, styleTextFont, Brushes.Black, styleTextRectangle_dot, textFormatLeft);
                        //g.DrawString(colourText_dot, colourTextFont, Brushes.Black, colourTextRectangle_dot, textFormatLeft);
                        g.DrawString(sizeText_dot, sizeTextFont, Brushes.Black, sizeTextRectangle_dot, textFormatLeft);
                      
                      
                        BarCodePreview.Text = row.Barcode;

                        g.DrawImage(BarCodePreview.Image, barcodeRectangle);
                        currentX += labelWidth + labelColumnSpace;
                        currentColumnIndex++;
                        quantityPrinted++;
                        if (quantityPrinted >= row.Quantity)
                        {
                            quantityPrinted = 0;
                            _PrintHelper.MoveNextItem();
                            row = _PrintHelper.GetCurrentItem();
                        }
                    }
                    currentY += labelHeight + labelRowSpace;
                    currentX = pageLeftMargin;
                    currentRowIndex++;
                    if (!_FirstPagePrinted)
                    {
                        _FirstPagePrinted = true;
                    }
                }
                _PrintHelper.LastQuantityPrinted = quantityPrinted;
                e.HasMorePages = _PrintHelper.HasMoreItems();
            }
            catch
            {
                throw;
            }
        }




        private bool CheckTopWidth(string strTopText, float fLabelWidth, Font FontText, StringFormat StringFormatText) {
            bool bRetVal = false;
            Graphics g = BarcodeColourTextPreviewLabel.CreateGraphics();
            SizeF SizeFText = g.MeasureString(strTopText, FontText, (int)(fLabelWidth * 100F), StringFormatText).ToSize();
            if (SizeFText.Width >= fLabelWidth)
                bRetVal = true;
            return bRetVal;
        }

        private string CalculateSpace4BottomText(string strBottomText, float fLabelWidth, Font FontText, StringFormat StringFormatText, string strPrcPrnText) {
            string strText = strBottomText;
            string strSpace = " ";
            string strTmp = string.Empty;
            Graphics g = BarcodeAsTextPreviewLabel.CreateGraphics();


            strTmp = strText + strSpace + strPrcPrnText;
            SizeF SizeFText = g.MeasureString(strTmp, FontText, (int)(fLabelWidth * 100F), StringFormatText).ToSize();

            while (SizeFText.Width < fLabelWidth)
            {
                strSpace += " ";
                strTmp = strText + strSpace + strPrcPrnText;
                SizeFText = g.MeasureString(strTmp, FontText, (int)(fLabelWidth * 100F), StringFormatText).ToSize();
            }
            if (SizeFText.Width >= fLabelWidth)
                strSpace = strSpace.Remove(0, 1);

            return strText + strSpace + strPrcPrnText;
        }

        private void _PrintDocument_EndPrint(object sender, PrintEventArgs e) {
            try {
                _PrintHelper.Reset();
            } catch {
                throw;
            }
        }

        #endregion

        #region Not Overridables

        private void StartUp() {
            try {
                InitField();
                PrepareLayout();
                SetDataBindings(false);
            } catch {
                throw;
            }
        }

        private void TryLogin() {
            try {
                DialogResult result = LoginManager.ShowDialog(LoginType.LockedLogin, this, ApplicationInfo.ShortApplicationName);
                if (result == DialogResult.Cancel) {
                    try {
                        this.Dispose();
                    } catch { }
                }
                OrganizationStatusLabel.Text = string.Format("{0} - {1}", LoginManager.LoginInfo.EmployeeName, LoginManager.LoginInfo.OrganizationName);
                this.BeginInvoke(new MethodInvoker(GetServerDateTime));
            } catch {
                throw;
            }
        }

        private void GetServerDateTime() {
            try {
                try {
                    using (SqlConnection connection = new SqlConnection(RxlConfiguration.GetCurrent().GetConnectionString(ApplicationInfo.ShortApplicationName))) {
                        using (SqlCommand command = new SqlCommand(Resources.GetServerDateTimeCommandText, connection)) {
                            command.CommandTimeout = 0;
                            connection.Open();
                            _CurrentDateTime = ((DateTime)command.ExecuteScalar()).AddSeconds(1.0D);
                        }
                    }
                } catch {
                    _CurrentDateTime = DateTime.Now;
                }
                StatusTimer.Enabled = true;
            } catch {
                throw;
            }
        }

        private void InitField() {
            try {
                _RxlDataSet = RxlDataAccess.Instance.GetDataSet();
                _RxlBarcodeConfiguration = new RxlBarcodeConfiguration();
                LoadConfigFile(false);
            } catch {
                throw;
            }
        }

        private void PrepareLayout() {
            try {
                int maxTab = PrintSettingTabControl.TabCount;
                int i = 1;
                while (i < maxTab) {
                    PrintSettingTabControl.SelectTab(i);
                    i++;
                }
                i = maxTab - 2;
                while (i >= 0) {
                    PrintSettingTabControl.SelectTab(i);
                    i--;
                }
                maxTab = LabelSettingsTabControl.TabCount;
                i = 1;
                while (i < maxTab) {
                    LabelSettingsTabControl.SelectTab(i);
                    i++;
                }
                i = maxTab - 2;
                while (i >= 0) {
                    LabelSettingsTabControl.SelectTab(i);
                    i--;
                }
                maxTab = BarcodeSettingsTabControl.TabCount;
                i = 1;
                while (i < maxTab) {
                    BarcodeSettingsTabControl.SelectTab(i);
                    i++;
                }
                i = maxTab - 2;
                while (i >= 0) {
                    BarcodeSettingsTabControl.SelectTab(i);
                    i--;
                }
            } catch {
                throw;
            }
        }

        private void LoadConfigFile(bool isReload) {
            try {
                if (!isReload) {
                    _ConfigFileName = string.Format("{0}.Config.xml", Assembly.GetExecutingAssembly().GetName().Name);
                }
                if (File.Exists(_ConfigFileName)) {
                    try {
                        RxlBarcodeConfiguration temp = new RxlBarcodeConfiguration();
                        temp.ReadXmlSchema(_ConfigFileName);
                        if (_RxlBarcodeConfiguration.GetXmlSchema() == temp.GetXmlSchema()) {
                            _RxlBarcodeConfiguration.Clear();
                            _RxlBarcodeConfiguration.ReadXml(_ConfigFileName);
                        } else {
                            SetDefaultPrintSetting(isReload);
                        }
                    } catch {
                        _RxlBarcodeConfiguration = new RxlBarcodeConfiguration();
                        SetDefaultPrintSetting(isReload);
                    }
                } else {
                    SetDefaultPrintSetting(isReload);
                }
                if (_RxlBarcodeConfiguration.PrintSetting.Rows.Count == 0) {
                    SetDefaultPrintSetting(isReload);
                }
                if (!isReload) {
                    ValidateConfiguration();
                    SaveConfigFile();
                }
                if (isReload) {
                    SetDataBindings(isReload);
                }
            } catch {
                throw;
            }
        }

        private void SaveConfigFile() {
            try {
                _RxlBarcodeConfiguration.AcceptChanges();
                if (_ConfigFileName.Length == 0) {
                    _ConfigFileName = string.Format("{0}.Config.xml", Assembly.GetExecutingAssembly().GetName().Name);
                }
                _RxlBarcodeConfiguration.WriteXml(_ConfigFileName, XmlWriteMode.WriteSchema);
            } catch {
                throw;
            }
        }

        private void SetDefaultPrintSetting(bool validate) {
            try {
                SetDefaultPrintLabel();
                _RxlBarcodeConfiguration.PrintSetting.Clear();
                RxlBarcodeConfiguration.PrintSettingRow row = _RxlBarcodeConfiguration.PrintSetting.AddPrintSettingRow(
                        "Default", OutputPrintDocument.PrinterSettings.PrinterName,
                        1, 1, CodeTypeEnum.Code128.ToString(),
                        true, "Arial, 8.25pt", ItemColumnType.ItemName.ToString(),
                        true, "Arial, 8.25pt", ItemColumnType.Barcode.ToString(),
                        100M, 100M, 1,
                        true, "Arial, 8.25pt", ItemColumnType.SellPrice.ToString()
                    );
                row.LabelID = GetDefaultPrintLabelTypeID();
                if (validate) {
                    ValidateConfiguration();
                    SetDataBindings(validate);
                }
            } catch {
                throw;
            }
        }

        private void SetDefaultPrintLabel() {
            try {
                RxlBarcodeConfiguration.PrintLabelDataTable table = _RxlBarcodeConfiguration.PrintLabel;
                table.Clear();
                try {
                    foreach (DataColumn column in table.Columns) {
                        Type columnType = column.GetType();
                        FieldInfo autoIncrementCurrentField = columnType.GetField("autoIncrementCurrent", BindingFlags.NonPublic | BindingFlags.Instance);
                        autoIncrementCurrentField.SetValue(column, column.AutoIncrementSeed);
                    }
                } catch { }
                table.AddPrintLabelRow(
                     "Shoes Barcode Printer",
                     2.60M, 1.20M, 0.0M, 0.0M,
                     1.0M, 0.50M, 0.0M, 0.50M,
                     0.0M, 0.0M, 0.06M, 0.0M,
                     PageOrientationType.Portrait, 2.87M, 1.31M
                 );
                table.AddPrintLabelRow(
                  "Shoes Laser Printer",
                  2.60M, 1.20M, 0.27M, 0.11M,
                  1.0M, 0.50M, 1.0M, 0.50M,
                  0.0M, 0.00M, 0.0M, 0.0M,
                  PageOrientationType.Portrait, 8.61M, 11.70M
              );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 99",
                        1.37M, 0.28M, 0.25M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.16M, 0.00M, 0.24M, 0.16M,
                        PageOrientationType.Portrait, 6.5M, 8.47M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 100",
                        3.78M, 1.34M, 0.32M, 0.24M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.32M, 0.00M, 0.20M, 0.20M,
                        PageOrientationType.Landscape, 8.47M, 6.5M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 101",
                        3.78M, 1.77M, 0.32M, 0.32M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.39M, 0.00M, 0.16M, 0.16M,
                        PageOrientationType.Landscape, 8.47M, 6.5M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 103",
                        2.56M, 1.06M, 0.16M, 0.43M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.51M, 0.00M, 0.08M, 0.08M,
                        PageOrientationType.Landscape, 8.47M, 6.5M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 104",
                        3.03M, 1.02M, 0.00M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.8M, 0.00M, 0.28M, 0.28M,
                        PageOrientationType.Portrait, 6.5M, 8.47M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 105",
                        1.46M, 1.02M, 0.16M, 0.00M, 0.16M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.00M, 0.14M, 0.14M,
                        PageOrientationType.Portrait, 8.47M, 6.5M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 106",
                        0.98M, 1.06M, 0.16M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.16M, 0.00M, 0.12M, 0.12M,
                        PageOrientationType.Portrait, 8.47M, 6.89M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 107",
                        1.97M, 0.81M, 0.12M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.04M, 0.00M, 0.24M, 0.24M,
                        PageOrientationType.Portrait, 6.5M, 8.47M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 108",
                        1.46M, 0.79M, 0.16M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.18M, 0.00M, 0.12M, 0.06M,
                        PageOrientationType.Portrait, 8.47M, 6.5M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 110",
                        0.91M, 0.59M, 0.00M, 0.12M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.16M, 0.00M, 0.32M, 0.08M,
                        PageOrientationType.Portrait, 8.86M, 6.89M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 112",
                        0.87M, 0.40M, 0.00M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.20M, 0.00M, 0.16M, 0.08M,
                        PageOrientationType.Portrait, 8.47M, 6.89M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 113",
                        0.55M, 0.43M, 0.00M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.24M, 0.00M, 0.16M, 0.08M,
                        PageOrientationType.Portrait, 8.5M, 6.65M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 120",
                        4.65M, 3.07M, 0.00M, 0.94M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.51M, 0.00M, 0.98M, 0.98M,
                        PageOrientationType.Portrait, 6.5M, 8.47M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 121",
                        2.93M, 1.32M, 0.16M, 0.28M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.28M, 0.50M, 0.30M, 0.20M,
                        PageOrientationType.Portrait, 6.92M, 8.77M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 122",
                        3.33M, 0.67M, 0.65M, 0.12M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.20M, 0.00M, 0.43M, 0.32M,
                        PageOrientationType.Portrait, 8.47M, 6.5M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 123",
                        1.18M, 0.51M, 0.12M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.22M, 0.00M, 0.20M, 0.16M,
                        PageOrientationType.Portrait, 8.27M, 6.5M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 127",
                        2.60M, 1.22M, 0.47M, 0.35M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.35M, 0.00M, 0.35M, 0.28M,
                        PageOrientationType.Portrait, 6.5M, 8.47M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. 129",
                        2.28M, 0.75M, 0.39M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.30M, 0.00M, 0.20M, 0.20M,
                        PageOrientationType.Portrait, 8.47M, 6.5M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. L.02",
                        2.76M, 1.42M, 0.00M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.16M, 0.00M, 0.00M, 0.00M,
                        PageOrientationType.Portrait, 8.27M, 11.69M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. L.03",
                        2.76M, 1.17M, 0.00M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.00M, 0.00M, 0.00M, 0.00M,
                        PageOrientationType.Portrait, 8.27M, 11.69M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. L.04",
                        3.90M, 1.50M, 0.16M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.63M, 0.00M, 0.16M, 0.16M,
                        PageOrientationType.Portrait, 8.27M, 11.69M
                    );
                table.AddPrintLabelRow(
                        "Tom & Jerry No. L.05",
                        4.13M, 1.46M, 0.00M, 0.00M,
                        0.0M, 0.0M, 5.0M, 10.0M,
                        0.00M, 0.00M, 0.00M, 0.00M,
                        PageOrientationType.Portrait, 8.27M, 11.69M
                    );
            } catch {
                throw;
            }
        }

        private int GetDefaultPrintLabelTypeID() {
            try {
                RxlBarcodeConfiguration.PrintLabelRow row = null;
                try {
                    row = _RxlBarcodeConfiguration.PrintLabel.Single(t => t.LabelDescription == "Shoes Barcode Printer");
                } catch { }
                if (row != null) {
                    return row.LabelID;
                } else {
                    return 1;
                }
            } catch {
                //throw;
                return 1;
            }
        }

        private void ValidateConfiguration() {
            try {
                RxlBarcodeConfiguration.PrintSettingRow row = null;
                try {
                    row = _RxlBarcodeConfiguration.PrintSetting[0];
                } catch { }
                SingleParamInvoker<bool> setFontStyle = delegate(bool changeTop) {
                    string[] fontStyle = Regex.Split(Convert.ToString(row[string.Format("{0}TextFontStyle", changeTop ? "Top" : "Bottom")]), @",\s*");
                    string fontName = "Arial";
                    try {
                        fontName = fontStyle[0] != null && fontStyle.Length > 0 ? fontStyle[0] : "Arial";
                    } catch { }
                    float fontSize = 8.25F;
                    try {
                        fontSize = Convert.ToSingle(Regex.Replace(fontStyle[1], "pt", string.Empty, RegexOptions.IgnoreCase));
                    } catch { }
                    try {
                        BarcodeTextFontDialog.Font = new Font(fontName, fontSize);
                    } catch {
                        BarcodeTextFontDialog.Font = new Font("Arial", 8.25F);
                    }
                    row[string.Format("{0}TextFontStyle", changeTop ? "Top" : "Bottom")] = string.Format("{0}, {1}pt", fontName, fontSize);
                    ChangeBarcodeTextFont(changeTop,false, false);
                };
                setFontStyle(true);
                setFontStyle(false);
            } catch {
                throw;
            }
        }

        private void SetDataBindings(bool isReload) {
            try {
                if (!isReload) {
                    DocumentTypeComboBox.SelectedIndexChanged -= DocumentTypeComboBox_SelectedIndexChanged;
                    DocumentTypeComboBox.DataSource = new BindingSource(_DocumentTypeSource, null);
                    DocumentTypeComboBox.ValueMember = "Key";
                    DocumentTypeComboBox.DisplayMember = "Value";
                    DocumentTypeComboBox.SelectedValue = DocumentType.GRN;
                    DocumentTypeComboBox.SelectedIndexChanged += DocumentTypeComboBox_SelectedIndexChanged;

                    FindItemColumnTypeToolStripComboBox.ComboBox.DataSource = new BindingSource(_ItemColumnTypeSource, null);
                    FindItemColumnTypeToolStripComboBox.ComboBox.ValueMember = "Key";
                    FindItemColumnTypeToolStripComboBox.ComboBox.DisplayMember = "Value";
                    try {
                        FindItemColumnTypeToolStripComboBox.SelectedIndex = -1;
                    } catch { }
                }

                _PrintLabelBindingSource = new BindingSource(_RxlBarcodeConfiguration, "PrintLabel");
                _PrintSettingBindingSource = new BindingSource(_RxlBarcodeConfiguration, "PrintSetting");

                RxlBarcodeConfiguration.PrintSettingRow printSettingRow = null;
                try {
                    printSettingRow = (_PrintSettingBindingSource.Current as DataRowView).Row as RxlBarcodeConfiguration.PrintSettingRow;
                } catch {
                    return;
                }

                BarcodeTypeComboBox.DataBindings.Clear();
                BarcodeTypeComboBox.DataSource = new BindingSource(_BarcodeTypeSource, null);
                BarcodeTypeComboBox.ValueMember = "Key";
                BarcodeTypeComboBox.DisplayMember = "Value";
                BarcodeTypeComboBox.DataBindings.Add("SelectedValue", _PrintSettingBindingSource, "BarcodeType", true, DataSourceUpdateMode.OnPropertyChanged);
                BarcodeTypeComboBox.SelectedValue = 2;

                try {
                    PrinterComboBox.DataBindings.Clear();
                    List<KeyValuePair<string, string>> installedPrintersDataSource = new List<KeyValuePair<string, string>>();
                    foreach (string printer in PrinterSettings.InstalledPrinters) {
                        installedPrintersDataSource.Add(new KeyValuePair<string, string>(printer, printer));
                    }
                    PrinterComboBox.DataSource = new BindingSource(installedPrintersDataSource, null);
                    PrinterComboBox.ValueMember = "Key";
                    PrinterComboBox.DisplayMember = "Value";
                    PrinterComboBox.DataBindings.Add("SelectedValue", _PrintSettingBindingSource, "PrinterName", true, DataSourceUpdateMode.OnPropertyChanged);
                    if (!isReload || PrinterComboBox.SelectedIndex == -1) {
                        PrinterComboBox.Text = OutputPrintDocument.PrinterSettings.PrinterName;
                    }
                } catch { }

                BarcodeWidthScaleNumericUpDown.DataBindings.Clear();
                BarcodeWidthScaleNumericUpDown.DataBindings.Add("Value", _PrintSettingBindingSource, "BarcodeWidthScale", true, DataSourceUpdateMode.OnPropertyChanged);
                BarcodeWidthScaleNumericUpDown.Value = printSettingRow.BarcodeWidthScale;

                BarcodeHeightScaleNumericUpDown.DataBindings.Clear();
                BarcodeHeightScaleNumericUpDown.DataBindings.Add("Value", _PrintSettingBindingSource, "BarcodeHeightScale", true, DataSourceUpdateMode.OnPropertyChanged);
                BarcodeHeightScaleNumericUpDown.Value = printSettingRow.BarcodeHeightScale;

                TopTextFontStyleLabel.DataBindings.Clear();
                TopTextFontStyleLabel.DataBindings.Add("Text", _PrintSettingBindingSource, "TopTextFontStyle", true, DataSourceUpdateMode.OnPropertyChanged);
                TopTextFontStyleLabel.Text = printSettingRow.TopTextFontStyle;

                BottomTextFontStyleLabel.DataBindings.Clear();
                BottomTextFontStyleLabel.DataBindings.Add("Text", _PrintSettingBindingSource, "BottomTextFontStyle", true, DataSourceUpdateMode.OnPropertyChanged);
                BottomTextFontStyleLabel.Text = printSettingRow.BottomTextFontStyle;

                ShowTopTextCheckBox.DataBindings.Clear();
                ShowTopTextCheckBox.DataBindings.Add("Checked", _PrintSettingBindingSource, "ShowTopText", true, DataSourceUpdateMode.OnPropertyChanged);
                ShowTopTextCheckBox.Checked = printSettingRow.ShowTopText;

                ShowBottomTextCheckBox.DataBindings.Clear();
                ShowBottomTextCheckBox.DataBindings.Add("Checked", _PrintSettingBindingSource, "ShowBottomText", true, DataSourceUpdateMode.OnPropertyChanged);
                ShowBottomTextCheckBox.Checked = printSettingRow.ShowBottomText;

                //new
                ShowPrcPrnTextCheckBox.DataBindings.Clear();
                ShowPrcPrnTextCheckBox.DataBindings.Add("Checked", _PrintSettingBindingSource, "ShowPrcPrnText", true, DataSourceUpdateMode.OnPropertyChanged);
                ShowPrcPrnTextCheckBox.Checked = printSettingRow.ShowPrcPrnText;
                //new
                
                TopTextTypeComboBox.DataBindings.Clear();
                TopTextTypeComboBox.DataSource = new BindingSource(_ItemColumnTypeSource, null);
                TopTextTypeComboBox.ValueMember = "Key";
                TopTextTypeComboBox.DisplayMember = "Value";
                TopTextTypeComboBox.DataBindings.Add("SelectedValue", _PrintSettingBindingSource, "TopTextType", true, DataSourceUpdateMode.OnPropertyChanged);
                try {
                    TopTextTypeComboBox.SelectedValue = printSettingRow.TopTextType;
                } catch { }

                BottomTextTypeComboBox.DataBindings.Clear();
                BottomTextTypeComboBox.DataSource = new BindingSource(_ItemColumnTypeSource, null);
                BottomTextTypeComboBox.ValueMember = "Key";
                BottomTextTypeComboBox.DisplayMember = "Value";
                BottomTextTypeComboBox.DataBindings.Add("SelectedValue", _PrintSettingBindingSource, "BottomTextType", true, DataSourceUpdateMode.OnPropertyChanged);
                try {
                    BottomTextTypeComboBox.SelectedValue = printSettingRow.BottomTextType;
                } catch { }

                //new
                PrcPrnTextTypeComboBox.DataBindings.Clear();
                PrcPrnTextTypeComboBox.DataSource = new BindingSource(_PrcPrnItemColumnTypeSource, null);
                PrcPrnTextTypeComboBox.ValueMember = "Key";
                PrcPrnTextTypeComboBox.DisplayMember = "Value";
                PrcPrnTextTypeComboBox.DataBindings.Add("SelectedValue", _PrintSettingBindingSource, "PrcPrnTextType", true, DataSourceUpdateMode.OnPropertyChanged);
                try {
                    PrcPrnTextTypeComboBox.SelectedValue = printSettingRow.PrcPrnTextType;
                } catch { }
                //new

                try {
                    PrintLabelTypeComboBox.SelectedIndexChanged -= PrintLabelTypeComboBox_SelectedIndexChanged;
                } catch { }

                PrintLabelTypeComboBox.DataBindings.Clear();
                PrintLabelTypeComboBox.DataSource = _PrintLabelBindingSource;
                PrintLabelTypeComboBox.ValueMember = "LabelID";
                PrintLabelTypeComboBox.DisplayMember = "LabelDescription";
                PrintLabelTypeComboBox.DataBindings.Add("SelectedValue", _PrintSettingBindingSource, "LabelID", true, DataSourceUpdateMode.OnPropertyChanged);
                PrintLabelTypeComboBox.SelectedValue = printSettingRow.LabelID;

                RxlBarcodeConfiguration.PrintLabelRow printLabelRow = printSettingRow.PrintLabelRow;
                if (printLabelRow == null) {
                    PrintLabelTypeComboBox.SelectedValue = GetDefaultPrintLabelTypeID();
                    printLabelRow = printSettingRow.PrintLabelRow;
                }

                try {
                    PrintLabelTypeComboBox.SelectedIndexChanged += PrintLabelTypeComboBox_SelectedIndexChanged;
                } catch { }

                PrintLabelTypeTextBox.DataBindings.Clear();
                PrintLabelTypeTextBox.DataBindings.Add("Text", _PrintLabelBindingSource, "LabelDescription", true, DataSourceUpdateMode.OnPropertyChanged);

                UnSubcribeNumericUpDownValueChangedEvents();

                LabelWidthNumericUpDown.DataBindings.Clear();
                LabelWidthNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "LabelWidth", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    LabelWidthNumericUpDown.Value = printLabelRow.LabelWidth;
                }

                LabelHeightNumericUpDown.DataBindings.Clear();
                LabelHeightNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "LabelHeight", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    LabelHeightNumericUpDown.Value = printLabelRow.LabelHeight;
                }

                LabelColumnSpaceNumericUpDown.DataBindings.Clear();
                LabelColumnSpaceNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "LabelColumnSpace", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    LabelColumnSpaceNumericUpDown.Value = printLabelRow.LabelColumnSpace;
                }

                LabelRowSpaceNumericUpDown.DataBindings.Clear();
                LabelRowSpaceNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "LabelRowSpace", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    LabelRowSpaceNumericUpDown.Value = printLabelRow.LabelRowSpace;
                }

                LabelTopMarginNumericUpDown.DataBindings.Clear();
                LabelTopMarginNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "LabelTopMargin", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    LabelTopMarginNumericUpDown.Value = printLabelRow.LabelTopMargin;
                }

                LabelBottomMarginNumericUpDown.DataBindings.Clear();
                LabelBottomMarginNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "LabelBottomMargin", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    LabelBottomMarginNumericUpDown.Value = printLabelRow.LabelBottomMargin;
                }

                LabelLeftMarginNumericUpDown.DataBindings.Clear();
                LabelLeftMarginNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "LabelLeftMargin", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    LabelLeftMarginNumericUpDown.Value = printLabelRow.LabelLeftMargin;
                }

                LabelRightMarginNumericUpDown.DataBindings.Clear();
                LabelRightMarginNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "LabelRightMargin", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    LabelRightMarginNumericUpDown.Value = printLabelRow.LabelRightMargin;
                }

                PageTopMarginNumericUpDown.DataBindings.Clear();
                PageTopMarginNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "PageTopMargin", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    PageTopMarginNumericUpDown.Value = printLabelRow.PageTopMargin;
                }

                PageBottomMarginNumericUpDown.DataBindings.Clear();
                PageBottomMarginNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "PageBottomMargin", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    PageBottomMarginNumericUpDown.Value = printLabelRow.PageBottomMargin;
                }

                PageLeftMarginNumericUpDown.DataBindings.Clear();
                PageLeftMarginNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "PageLeftMargin", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    PageLeftMarginNumericUpDown.Value = printLabelRow.PageLeftMargin;
                }

                PageRightMarginNumericUpDown.DataBindings.Clear();
                PageRightMarginNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "PageRightMargin", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    PageRightMarginNumericUpDown.Value = printLabelRow.PageRightMargin;
                }

                PageOrientationComboBox.DataBindings.Clear();
                PageOrientationComboBox.DataSource = new BindingSource(_PageOrientationTypeSource, null);
                PageOrientationComboBox.ValueMember = "Key";
                PageOrientationComboBox.DisplayMember = "Value";
                PageOrientationComboBox.DataBindings.Add("SelectedValue", _PrintLabelBindingSource, "PageOrientation", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    PageOrientationComboBox.SelectedValue = printLabelRow.PageOrientation;
                }
                try {
                    _LastPageOrientation = Convert.ToString(PageOrientationComboBox.SelectedValue);
                } catch { }

                PaperWidthNumericUpDown.DataBindings.Clear();
                PaperWidthNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "PaperWidth", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    PaperWidthNumericUpDown.Value = printLabelRow.PaperWidth;
                }

                PaperHeightNumericUpDown.DataBindings.Clear();
                PaperHeightNumericUpDown.DataBindings.Add("Value", _PrintLabelBindingSource, "PaperHeight", true, DataSourceUpdateMode.OnPropertyChanged);
                if (printLabelRow != null) {
                    PaperHeightNumericUpDown.Value = printLabelRow.PaperHeight;
                }

                SubcribeNumericUpDownValueChangedEvents();
                SetMaximumLabelStartIndex();
            } catch {
                throw;
            }
        }

        private void ChangeDocumentType() {
            try {
                try {
                    DocumentKeyComboBox.SelectedIndexChanged -= DocumentKeyComboBox_SelectedIndexChanged;
                } catch { }
                DocumentKeyComboBox.SelectedIndex = -1;
                DocumentInfoTextBox.Text = string.Empty;
                DocumentKeyComboBox.DataSource = null;
                _IsFreeInput = Convert.ToString(DocumentTypeComboBox.SelectedValue) == DocumentType.None;
                ChangeDetail();
            } catch {
                throw;
            }
        }

        private void ChangeDetail() {
            try {
                if (_IsFreeInput) {
                    _ItemDetailBindingSource = null;
                    _RxlDataSet.ItemBarcodeWithQuantity.Clear();
                    _ItemDetailBindingSource = new BindingSource(_RxlDataSet, "ItemBarcodeWithQuantity");
                    ItemDetailDataGridView.AutoGenerateColumns = false;
                    ItemDetailDataGridView.DataSource = _ItemDetailBindingSource;
                    ItemDetailBindingNavigator.BindingSource = _ItemDetailBindingSource;
                } else {
                    _ItemDetailBindingSource = null;
                    ItemDetailDataGridView.DataSource = null;
                    ItemDetailBindingNavigator.BindingSource = null;
                    _RxlDataSet.ItemBarcodeWithQuantity.Clear();
                }
                DocumentKeyComboBox.Enabled = !_IsFreeInput;
                RefreshDocumentButton.Enabled = !_IsFreeInput;
                AddDetailItemsButton.Enabled = !_IsFreeInput;
                DetailGroupBox.Enabled = _IsFreeInput;
                AddNewItemToolStrip.Enabled = _IsFreeInput;
                ImportItemsToolStripMenuItem.Enabled = _IsFreeInput;
                ItemRemovingToolStripDropDownButton.Enabled = _IsFreeInput;
                ClearBarcodePreview();
            } catch {
                throw;
            }
        }

        private void RefreshDocument() {
            try {
                FillDocumentKey(Convert.ToString(DocumentTypeComboBox.SelectedValue));
            } catch {
                throw;
            }
        }

        private void FillDocumentKey(string documentType) {
            try {
                string document_key= string.Empty;
                string document_column = string.Empty;
                if (_IsFreeInput) {
                    return;
                }
                string tableName = string.Empty;
                string valueMember = string.Empty;
                string displayMember = string.Empty;
               if (documentType == DocumentType.ItemMaster) {
                    //RxlDataAccess.Instance.FillTable<RxlDataSet.DivisionDataTable>(ApplicationInfo.ShortApplicationName, true);
                    //tableName = RxlTableName.Division;
                   document_key = "ITM";
                   document_column = "DIVISION";
                }
                else if (documentType == DocumentType.PurchaseOrder) {
                    //RxlDataAccess.Instance.FillTable<RxlDataSet.PurchaseOrderHeaderDataTable>(ApplicationInfo.ShortApplicationName, true);
                    //tableName = RxlTableName.PurchaseOrderHeader;
                    document_key= "PO";
                    document_column = "DOCUMENTNO";
                }
               else if (documentType == DocumentType.InitialStock)
               {
                   //RxlDataAccess.Instance.FillTable<RxlDataSet.PurchaseOrderHeaderDataTable>(ApplicationInfo.ShortApplicationName, true);
                   //tableName = RxlTableName.PurchaseOrderHeader;
                   document_key = "ISD";
                   document_column = "DOCUMENTNO";
               }
                else if (documentType == DocumentType.GRN) {
                    //RxlDataAccess.Instance.FillTable<RxlDataSet.GRNHeaderDataTable>(ApplicationInfo.ShortApplicationName, true);
                    //tableName = RxlTableName.GRNHeader;
                    document_key = "GRN";
                    document_column = "DOCUMENTNO";
                } else {
                    throw new ApplicationException("Unknown Document Type");
                }

               dsDocumentKey = new DataSet();
               sqlSelect = "EXEC SOL_SHOES_BARCODE_DOCUMENT_KEY '" + document_column + "','" + document_key + "','" + RxlConfiguration.GetCurrent().OrganizationCode.ToString() + "'";
               queryConnection.Open();
               dataAdapter = new SqlDataAdapter(sqlSelect.ToString(), queryConnection);
               dataAdapter.Fill(dsDocumentKey, "DocumentKey");
               queryConnection.Close();


                DocumentKeyComboBox.SelectedIndexChanged -= DocumentKeyComboBox_SelectedIndexChanged;
                DocumentKeyComboBox.DataSource = dsDocumentKey.Tables["DocumentKey"].DefaultView;
                DocumentKeyComboBox.ValueMember = "DocumentKey";
                DocumentKeyComboBox.DisplayMember = "DocumentKey";
                DocumentKeyComboBox.SelectedIndex = -1;
                DocumentKeyComboBox.DroppedDown = true;
                DocumentKeyComboBox.SelectedIndexChanged += DocumentKeyComboBox_SelectedIndexChanged;
            } catch {
                throw;
            }
        }

        private void ChangeDocumentInfo() {
            try {
                if (_IsFreeInput) {
                    return;
                }
                string documentKey = string.Empty;
                try {
                    documentKey = Convert.ToString(DocumentKeyComboBox.SelectedValue);
                } catch { }
                string documentType = Convert.ToString(DocumentTypeComboBox.SelectedValue);
               if (documentType == DocumentType.ItemMaster) {
                    DocumentInfoTextBox.Text = string.Empty;
                }
                //new
                else if (documentType == DocumentType.PurchaseOrder)
                {
                    RxlDataSet.PurchaseOrderHeaderRow row = null;
                    try
                    {
                        row = _RxlDataSet.PurchaseOrderHeader.SingleOrDefault(t => t.PONumber == documentKey);
                    }
                    catch { }
                    if (row == null)
                    {
                        return;
                    }
                    try
                    {
                        //DocumentInfoTextBox.Text = string.Format("Document Date : {0}\r\nSender Organization Name : {1}\r\nReceiver Organization Name : {2}", row.SenderDocumentDate.ToString("dd-MMM-yyyy"), row.SenderOrganizationName, row.ReceiverOrganizationName);
                    }
                    catch { }
                }
               
                else if (documentType == DocumentType.GRN)
                {
                    RxlDataSet.GRNHeaderRow row = null;
                    try
                    {
                        row = _RxlDataSet.GRNHeader.SingleOrDefault(t => t.DocumentNumber == documentKey);
                    }
                    catch { }
                    if (row == null)
                    {
                        return;
                    }
                    try
                    {
                        //DocumentInfoTextBox.Text = string.Format("Document Date : {0}\r\nSender Organization Name : {1}\r\nReceiver Organization Name : {2}", row.SenderDocumentDate.ToString("dd-MMM-yyyy"), row.SenderOrganizationName, row.ReceiverOrganizationName);
                    }
                    catch { }
                    //new
                }
               else if (documentType == DocumentType.InitialStock)
               {
                   RxlDataSet.GRNHeaderRow row = null;
                   try
                   {
                       row = _RxlDataSet.GRNHeader.SingleOrDefault(t => t.DocumentNumber == documentKey);
                   }
                   catch { }
                   if (row == null)
                   {
                       return;
                   }
                   try
                   {
                       //DocumentInfoTextBox.Text = string.Format("Document Date : {0}\r\nSender Organization Name : {1}\r\nReceiver Organization Name : {2}", row.SenderDocumentDate.ToString("dd-MMM-yyyy"), row.SenderOrganizationName, row.ReceiverOrganizationName);
                   }
                   catch { }
                   //new
               }
                else
                {
                    throw new ApplicationException("Unknown Document Type");
                }
                ChangeDetail();
            } catch {
                throw;
            }
        }

        private void AddDetailItems() {
            try {
                if (_IsFreeInput) {
                    return;
                }
                if (DocumentTypeComboBox.SelectedIndex == -1) {
                    MessageBox.Show(this, "Please select the Document Type.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DocumentTypeComboBox.Focus();
                    DocumentTypeComboBox.DroppedDown = true;
                    return;
                }
                if (DocumentKeyComboBox.SelectedIndex == -1) {
                    MessageBox.Show(this, "Please select the Document Key.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DocumentKeyComboBox.Focus();
                    DocumentKeyComboBox.DroppedDown = true;
                    return;
                }
                string[] documentKeys = null;
                string documentKey = string.Empty;
                try {
                    documentKey = Convert.ToString(DocumentKeyComboBox.SelectedValue);
                } catch { }
                string documentType = Convert.ToString(DocumentTypeComboBox.SelectedValue);
                int commandTypeIndex = -1;
               if (documentType == DocumentType.ItemMaster) {
                    commandTypeIndex = 2;
                    documentKeys = new string[2];
                    documentKeys[0] = LoginManager.LoginInfo.OrganizationCode;
                    documentKeys[1] = documentKey;
                //new
                } else if (documentType == DocumentType.PurchaseOrder) {
                    commandTypeIndex = 3;
                }
               
                else if (documentType == DocumentType.GRN) {
                    commandTypeIndex = 5;
                }
                //new 
                else
                {
                    throw new ApplicationException("Unknown Document Type");
                }
                if (commandTypeIndex == 2)
                    RxlDataAccess.Instance.FillTable<RxlDataSet.ItemBarcodeWithQuantityDataTable>(true, commandTypeIndex, documentKeys);
                else
                    RxlDataAccess.Instance.FillTable<RxlDataSet.ItemBarcodeWithQuantityDataTable>(true, commandTypeIndex, documentKey);
                ItemDetailDataGridView.AutoGenerateColumns = false;
                _ItemDetailBindingSource = new BindingSource(_RxlDataSet, "ItemBarcodeWithQuantity");
                ItemDetailDataGridView.DataSource = _ItemDetailBindingSource;
                ItemDetailBindingNavigator.BindingSource = _ItemDetailBindingSource;
                DetailGroupBox.Enabled = true;
            } catch {
                throw;
            }
        }

        private void AddDetailShoesItems()
        {
            try
            {
                if (_IsFreeInput)
                {
                    return;
                }
                if (DocumentTypeComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(this, "Please select the Document Type.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DocumentTypeComboBox.Focus();
                    DocumentTypeComboBox.DroppedDown = true;
                    return;
                }
                if (DocumentKeyComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(this, "Please select the Document Key.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DocumentKeyComboBox.Focus();
                    DocumentKeyComboBox.DroppedDown = true;
                    return;
                }
                //string[] documentKeys = null;
                string documentKey = string.Empty;
                try
                {
                    documentKey = Convert.ToString(DocumentKeyComboBox.SelectedValue);
                }
                catch { }
                string documentType = Convert.ToString(DocumentTypeComboBox.SelectedValue);            
                if (documentType == DocumentType.ItemMaster)
                {
                    item_shoes_detail(DocumentKeyComboBox.Text, "O", "ITM");
                }
                else if (documentType == DocumentType.PurchaseOrder)
                {
                    item_shoes_detail("O", documentKey, "PO");
                }
                else if (documentType == DocumentType.GRN)
                {
                    item_shoes_detail("O", documentKey, "GRN");
                }
                else if (documentType == DocumentType.InitialStock)
                {
                    item_shoes_detail("O", documentKey, "ISD");
                }
                //new 
                else
                {
                    throw new ApplicationException("Unknown Document Type");
                }
              }
            catch
            {
                throw;
            }
        }

        private void ChangeBarcodeView() {
            try {
                DataGridViewRow row = ItemDetailDataGridView.CurrentRow;
                if (row == null) {
                    ClearBarcodePreview();
                    return;
                }
                SetBarcodeText(row);
            } catch {
                throw;
            }
        }

        private void ChangeBarcodeView(int rowIndex) {
            try {
                DataGridViewRow row = null;
                try {
                    row = ItemDetailDataGridView.Rows[rowIndex];
                } catch { }
                if (row == null) {
                    ClearBarcodePreview();
                    return;
                }
                SetBarcodeText(row);
            } catch {
                throw;
            }
        }

        private void ClearBarcodePreview() {
            try {
                BarcodeColourTextPreviewLabel.Text = string.Empty;
                BarcodeStyleTextPreviewLabel.Text = string.Empty;
                BarCodePreview.Text = string.Empty;
                BarcodeAsTextPreviewLabel.Text = string.Empty;
                BarcodeBrandTextPreviewLabel.Text = string.Empty;
                BarcodeColourTextPreviewLabel.Text = string.Empty;
                BarcodeDateTextPreviewLabel.Text = string.Empty;
                BarcodeSizeTextPreviewLabel.Text = string.Empty;
                BarcodeAsTextPreviewLabel.Text = string.Empty;
                BarcodeMadeFromPreviewLabel.Text = string.Empty;
            } catch {
                throw;
            }
        }

        private void SetBarcodeText(DataGridViewRow row) {            
            try {                
                if (BarcodeTypeComboBox.SelectedIndex == -1) {
                    BarcodeTypeComboBox.SelectedIndex = 2; 
                }
                try {
                    BarCodePreview.CodeType = (CodeTypeEnum)Enum.Parse(typeof(CodeTypeEnum), BarcodeTypeComboBox.Text, true);
                } catch {
                    BarcodeTypeComboBox.SelectedIndex = 2;
                    BarCodePreview.CodeType = (CodeTypeEnum)2;
                }
                string itemCode = string.Empty;
                try {
                    itemCode = Convert.ToString(row.Cells[ItemCodeDgvColumn.Index].Value);
                }
                catch { }
                string itemName = string.Empty;
                try {
                    itemName = Convert.ToString(row.Cells[ItemNameDgvColumn.Index].Value);
                } catch { }
                string barcode = string.Empty;
                try {
                    barcode = Convert.ToString(row.Cells[ItemBarcodeDgvColumn.Index].Value);
                } catch { }
                string price = string.Empty;
                try {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("id-ID");
                    price = Convert.ToDecimal(row.Cells[SellPriceDgvColumn.Index].Value).ToString("C", ci);
                }
                catch { }
                string printDate = string.Empty;
                try {
                    printDate = System.DateTime.Now.ToShortDateString();
                }
                catch { }
                BarcodeStyleTextPreviewLabel.Text = "Style : " + DsShoesBarcode.ItemDetail.Rows[int.Parse(row.Index.ToString())]["Style"].ToString();
                BarcodeSizeTextPreviewLabel.Text = "Size : " + DsShoesBarcode.ItemDetail.Rows[int.Parse(row.Index.ToString())]["Size"].ToString();
                BarcodeColourTextPreviewLabel.Text = "Colour : " + DsShoesBarcode.ItemDetail.Rows[int.Parse(row.Index.ToString())]["Color"].ToString();
                BarcodeAsTextPreviewLabel.Text = "Size : " + DsShoesBarcode.ItemDetail.Rows[int.Parse(row.Index.ToString())]["SizeRange"].ToString();
                BarCodePreview.Text = "Size : " + DsShoesBarcode.ItemDetail.Rows[int.Parse(row.Index.ToString())]["ItemCode"].ToString();
                BarcodeDateTextPreviewLabel.Text = DsShoesBarcode.ItemDetail.Rows[int.Parse(row.Index.ToString())]["ProdCode"].ToString();
                BarcodeBrandTextPreviewLabel.Text = DsShoesBarcode.ItemDetail.Rows[int.Parse(row.Index.ToString())]["Brand"].ToString();
                BarcodeMadeFromPreviewLabel.Text = DsShoesBarcode.ItemDetail.Rows[int.Parse(row.Index.ToString())]["MadeFrom"].ToString();
            } catch {
                throw;
            }
        }

        private void ChangeBarcodeTextFont(bool changeTop, bool changePcrBottom, bool changeBottom)
        {
            try {
                string value = string.Format("{0}, {1}pt, {2}", BarcodeTextFontDialog.Font.Name, BarcodeTextFontDialog.Font.Size, BarcodeTextFontDialog.Font.Style.ToString());
                if (changeTop) {
                    TopTextFontStyleLabel.Text = value;
                    BarcodeColourTextPreviewLabel.Tag = BarcodeTextFontDialog.Font.Clone();
                    BarcodeColourTextPreviewLabel.Font = new Font(BarcodeTextFontDialog.Font.Name, 8.25F);                    
                    BarcodeColourTextPreviewLabel.Visible = ShowTopTextCheckBox.Checked;
                }
                else if (changePcrBottom)
                {
                    PrcFontStyleLabel.Text = value;
                    BarcodeAsTextPreviewLabel.Tag = BarcodeTextFontDialog.Font.Clone();
                    BarcodeAsTextPreviewLabel.Font = new Font(BarcodeTextFontDialog.Font.Name, 8.25F);

                    if (!ShowBottomTextCheckBox.Checked)
                    {

                        if (!ShowPrcPrnTextCheckBox.Checked)
                            BarcodeStyleTextPreviewLabel.Visible = ShowBottomTextCheckBox.Checked;
                        else
                        {
                            BarcodeStyleTextPreviewLabel.Text = string.Empty;
                            //168, 66
                            //113, 14
                            BarcodeAsTextPreviewLabel.Location = BarcodeStyleTextPreviewLabel.Location;
                            BarcodeAsTextPreviewLabel.Size = BarcodeStyleTextPreviewLabel.Size;
                            BarcodeAsTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;
                        }
                    }
                    else
                    {
                        SetBarcodeText(ItemDetailDataGridView.CurrentRow);
                        if (!ShowPrcPrnTextCheckBox.Checked)
                            BarcodeStyleTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;
                        else
                        {
                            //168, 66
                            //113, 14
                            BarcodeAsTextPreviewLabel.Location = new Point(168, 66);
                            BarcodeAsTextPreviewLabel.Size = new Size(113, 14);
                            BarcodeAsTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;
                        }
                        BarcodeStyleTextPreviewLabel.Visible = ShowBottomTextCheckBox.Checked;
                        if (ItemColumnType.ItemName == BottomTextTypeComboBox.SelectedValue.ToString())
                            ShowPrcPrnTextCheckBox.Checked = false;
                    }
                }
                else if(changeBottom)
                {
                    BottomTextFontStyleLabel.Text = value;
                    BarcodeStyleTextPreviewLabel.Tag = BarcodeTextFontDialog.Font.Clone();
                    BarcodeStyleTextPreviewLabel.Font = new Font(BarcodeTextFontDialog.Font.Name, 8.25F);

                    if (!ShowBottomTextCheckBox.Checked)
                    {
                        if (!ShowPrcPrnTextCheckBox.Checked)
                            BarcodeStyleTextPreviewLabel.Visible = ShowBottomTextCheckBox.Checked;
                        else
                        {
                            BarcodeStyleTextPreviewLabel.Text = string.Empty;
                            //168, 66
                            //113, 14
                            BarcodeAsTextPreviewLabel.Location = BarcodeStyleTextPreviewLabel.Location;
                            BarcodeAsTextPreviewLabel.Size = BarcodeStyleTextPreviewLabel.Size;
                            BarcodeAsTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;
                        }
                    }
                    else
                    {
                        SetBarcodeText(ItemDetailDataGridView.CurrentRow);
                        if (!ShowPrcPrnTextCheckBox.Checked)
                            BarcodeStyleTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;
                        else
                        {
                            //168, 66
                            //113, 14
                            BarcodeAsTextPreviewLabel.Location = new Point(168, 66);
                            BarcodeAsTextPreviewLabel.Size = new Size(113, 14);
                            BarcodeAsTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;
                        }
                        BarcodeStyleTextPreviewLabel.Visible = ShowBottomTextCheckBox.Checked;
                        if (ItemColumnType.ItemName == BottomTextTypeComboBox.SelectedValue.ToString())
                            ShowPrcPrnTextCheckBox.Checked = false;
                    }
                }
            } catch {
                throw;
            }
        }
               private void SetMaximumLabelStartIndex() {
            try {
                int rowCountPerPage = 0;
                int columnCountPerPage = 0;
                bool isLandscape = Convert.ToString(PageOrientationComboBox.SelectedValue) == PageOrientationType.Landscape;
                try {
                    rowCountPerPage = GetLabelRowCount();
                } catch { }
                try {
                    columnCountPerPage = GetLabelColumnCount();
                } catch { }
                if (rowCountPerPage <= 0) {
                    PrintStartRowNumericUpDown.Minimum = 0;
                    PrintStartRowNumericUpDown.Maximum = 0;
                    PrintStartRowNumericUpDown.Value = 0;
                } else {
                    PrintStartRowNumericUpDown.Minimum = 1;
                    PrintStartRowNumericUpDown.Maximum = (decimal)rowCountPerPage;
                    PrintStartRowNumericUpDown.Value = 1;
                }
                if (columnCountPerPage <= 0) {
                    PrintStartColumnNumericUpDown.Minimum = 0;
                    PrintStartColumnNumericUpDown.Maximum = 0;
                    PrintStartColumnNumericUpDown.Value = 0;
                } else {
                    PrintStartColumnNumericUpDown.Minimum = 1;
                    PrintStartColumnNumericUpDown.Maximum = (decimal)columnCountPerPage;
                    PrintStartColumnNumericUpDown.Value = 1;
                }
            } catch {
                throw;
            }
        }

        private int GetLabelRowCount() {
            try {
                int result = 0;
                decimal max = (PaperHeightNumericUpDown.Value - PageBottomMarginNumericUpDown.Value) + PageTopMarginNumericUpDown.Value;
                decimal current = LabelHeightNumericUpDown.Value;
                if ((current < max) && (current > 0 && max > 0)) {
                    result++;
                    do {
                        if ((current += LabelRowSpaceNumericUpDown.Value) < max) {
                            if ((current += LabelHeightNumericUpDown.Value) < max) {
                                result++;
                            }
                        }
                    } while (current < max);
                }
                return result;
            } catch {
                throw;
            }
        }

        private int GetLabelColumnCount() {
            try {
                int result = 0;
                decimal max = (PaperWidthNumericUpDown.Value - PageRightMarginNumericUpDown.Value) + PageLeftMarginNumericUpDown.Value;
                decimal current = LabelWidthNumericUpDown.Value;
                if ((current < max) && (current > 0 && max > 0)) {
                    result++;
                    do {
                        if ((current += LabelColumnSpaceNumericUpDown.Value) < max) {
                            if ((current += LabelWidthNumericUpDown.Value) < max) {
                                result++;
                            }
                        }
                    } while (current < max);
                }
                return result;
            } catch {
                throw;
            }
        }

        private void SafeSetMaximumLabelStartIndex() {
            try {
                UnSubcribeNumericUpDownValueChangedEvents();
                SetMaximumLabelStartIndex();
                SubcribeNumericUpDownValueChangedEvents();
            } catch {
                throw;
            }
        }

        private void SubcribeNumericUpDownValueChangedEvents() {
            try {
                LabelWidthNumericUpDown.ValueChanged += PrintLabelWidthNumericUpDown_ValueChanged;
                LabelHeightNumericUpDown.ValueChanged += PrintLabelHeightNumericUpDown_ValueChanged;
                LabelColumnSpaceNumericUpDown.ValueChanged += PrintLabelColumnSpaceNumericUpDown_ValueChanged;
                LabelRowSpaceNumericUpDown.ValueChanged += PrintLabelRowSpaceNumericUpDown_ValueChanged;
                PaperWidthNumericUpDown.ValueChanged += PaperWidthNumericUpDown_ValueChanged;
                PaperHeightNumericUpDown.ValueChanged += PaperHeightNumericUpDown_ValueChanged;
                PageTopMarginNumericUpDown.ValueChanged += PageTopMarginNumericUpDown_ValueChanged;
                PageLeftMarginNumericUpDown.ValueChanged += PageLeftMarginNumericUpDown_ValueChanged;
                PageBottomMarginNumericUpDown.ValueChanged += PageBottomMarginNumericUpDown_ValueChanged;
                PageRightMarginNumericUpDown.ValueChanged += PageRightMarginNumericUpDown_ValueChanged;
                PageOrientationComboBox.SelectedIndexChanged += PageOrientationComboBox_SelectedIndexChanged;
            } catch {
                //throw;
            }
        }

        private void UnSubcribeNumericUpDownValueChangedEvents() {
            try {
                LabelWidthNumericUpDown.ValueChanged -= PrintLabelWidthNumericUpDown_ValueChanged;
                LabelHeightNumericUpDown.ValueChanged -= PrintLabelHeightNumericUpDown_ValueChanged;
                LabelColumnSpaceNumericUpDown.ValueChanged -= PrintLabelColumnSpaceNumericUpDown_ValueChanged;
                LabelRowSpaceNumericUpDown.ValueChanged -= PrintLabelRowSpaceNumericUpDown_ValueChanged;
                PaperWidthNumericUpDown.ValueChanged -= PaperWidthNumericUpDown_ValueChanged;
                PaperHeightNumericUpDown.ValueChanged -= PaperHeightNumericUpDown_ValueChanged;
                PageTopMarginNumericUpDown.ValueChanged -= PageTopMarginNumericUpDown_ValueChanged;
                PageLeftMarginNumericUpDown.ValueChanged -= PageLeftMarginNumericUpDown_ValueChanged;
                PageBottomMarginNumericUpDown.ValueChanged -= PageBottomMarginNumericUpDown_ValueChanged;
                PageRightMarginNumericUpDown.ValueChanged -= PageRightMarginNumericUpDown_ValueChanged;
                PageOrientationComboBox.SelectedIndexChanged -= PageOrientationComboBox_SelectedIndexChanged;
            } catch {
                //throw;
            }
        }

        private void AddNewLabelSettings() {
            try {
                PrintSettingTabControl.SelectedTab = LabelPrintSettingsTabPage;
                ChangeLabelInputVisible(true);
                _PrintLabelBindingSource.AddNew();
            } catch {
                throw;
            }
        }

        private void DeleteCurrentLabelSettings() {
            try {
                if (_PrintLabelBindingSource.Count == 0) {
                    return;
                }
                PrintSettingTabControl.SelectedTab = LabelPrintSettingsTabPage;
                DialogResult confirm = MessageBox.Show(this, string.Format("Are you sure to delete the current '{0}' Label type?", PrintLabelTypeTextBox.Visible ? PrintLabelTypeTextBox.Text : PrintLabelTypeComboBox.Text), ApplicationInfo.ShortApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes) {
                    try {
                        _PrintLabelBindingSource.RemoveCurrent();
                    } catch { }
                }
                SaveNewLabelSettings(false);
            } catch {
                throw;
            }
        }

        private bool ValidateNewLabelSettings() {
            try {
                if (PrintLabelTypeTextBox.Text.Length == 0) {
                    MessageBox.Show(this, "Please enter Label Type.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                var q = from t in _RxlBarcodeConfiguration.PrintLabel.AsEnumerable()
                        where (t.LabelDescription == PrintLabelTypeTextBox.Text)
                        select t;
                foreach (var i in q) {
                    return false;
                }
                return true;
            } catch {
                throw;
            }
        }

        private void SaveNewLabelSettings(bool validate) {
            try {
                if (validate && !ValidateNewLabelSettings()) {
                    PrintLabelTypeTextBox.Focus();
                    return;
                }
                _PrintLabelBindingSource.EndEdit();
                ChangeLabelInputVisible(false);
            } catch {
                throw;
            }
        }

        private void ChangeLabelInputVisible(bool newRecord) {
            try {
                AddNewLabelSettingsButton.Enabled = !newRecord;
                PrintLabelTypeTextBox.Visible = newRecord;
                PrintLabelTypeComboBox.Visible = !newRecord;
                SaveNewLabelSettingsButton.Visible = newRecord;
                SaveAsPrintSettingButton.Enabled = !newRecord;
                LoadPrintSettingButton.Enabled = !newRecord;
                ResetDefaultPrintSettingButton.Enabled = !newRecord;
                if (newRecord) {
                    PrintLabelTypeTextBox.BringToFront();
                    PrintLabelTypeTextBox.Focus();
                } else {
                    PrintLabelTypeComboBox.BringToFront();
                    PrintLabelTypeComboBox.Focus();
                }
            } catch {
                throw;
            }
        }

        private void AddNewItem() {
            try {
                if (!_IsFreeInput) {
                    return;
                }
                if (NewItemCodeToolStripTextBox.Text.Length == 0) {
                    MessageBox.Show(this, string.Format("Please enter the new Item Code", PrintLabelTypeTextBox.Visible ? PrintLabelTypeTextBox.Text : PrintLabelTypeComboBox.Text), ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NewItemCodeToolStripTextBox.Focus();
                    return;
                }
                if (NewItemNameToolStripTextBox.Text.Length == 0) {
                    MessageBox.Show(this, string.Format("Please enter the new Item Name", PrintLabelTypeTextBox.Visible ? PrintLabelTypeTextBox.Text : PrintLabelTypeComboBox.Text), ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NewItemNameToolStripTextBox.Focus();
                    return;
                }
                if (NewBarcodeToolStripTextBox.Text.Length == 0) {
                    MessageBox.Show(this, string.Format("Please enter the new Barcode", PrintLabelTypeTextBox.Visible ? PrintLabelTypeTextBox.Text : PrintLabelTypeComboBox.Text), ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NewBarcodeToolStripTextBox.Focus();
                    return;
                }
                int printCount = 1;
                try {
                    printCount = Convert.ToInt32(NewPrintCountToolStripTextBox.Text);
                } catch { }
                if (printCount <= 0) {
                    printCount = 1;
                }
                DataRowView newRowView = _ItemDetailBindingSource.AddNew() as DataRowView;
                newRowView.Row.ItemArray =
                    new object[] {
                            null,
                            NewItemCodeToolStripTextBox.Text,
                            NewItemNameToolStripTextBox.Text,
                            NewBarcodeToolStripTextBox.Text,
                            (decimal)printCount
                        };
                NewItemCodeToolStripTextBox.Text = string.Empty;
                NewItemNameToolStripTextBox.Text = string.Empty;
                NewBarcodeToolStripTextBox.Text = string.Empty;
                NewPrintCountToolStripTextBox.Text = string.Empty;
                NewItemCodeToolStripTextBox.Focus();
                AcceptChangesItemDetail();
            } catch {
                throw;
            }
        }

        private void RemoveSelectedItems() {
            try {
                if (!_IsFreeInput) {
                    return;
                }
                if (_ItemDetailBindingSource == null) {
                    return;
                }
                if (_ItemDetailBindingSource.Count == 0) {
                    return;
                }
                DataGridViewSelectedRowCollection selectedRows = ItemDetailDataGridView.SelectedRows;
                if (selectedRows == null) {
                    return;
                }
                int selectedRowsCount = selectedRows.Count;
                if (selectedRowsCount == 0) {
                    foreach (DataGridViewCell cell in ItemDetailDataGridView.SelectedCells) {
                        if (cell.OwningRow.Selected) {
                            continue;
                        }
                        cell.OwningRow.Selected = true;
                    }
                    selectedRows = ItemDetailDataGridView.SelectedRows;
                }
                DialogResult confirm = MessageBox.Show(this, string.Format("Are you sure to clear the current selected item(s)?", PrintLabelTypeTextBox.Visible ? PrintLabelTypeTextBox.Text : PrintLabelTypeComboBox.Text), ApplicationInfo.ShortApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) {
                    return;
                }
                foreach (DataGridViewRow row in selectedRows) {
                    ItemDetailDataGridView.Rows.Remove(row);
                }
                AcceptChangesItemDetail();
            } catch {
                throw;
            }
        }

        private void RemoveAllItems() {
            try {
                if (!_IsFreeInput) {
                    return;
                }
                if (_ItemDetailBindingSource == null || _ItemDetailBindingSource.Count == 0) {
                    return;
                }
                DialogResult confirm = MessageBox.Show(this, string.Format("Are you sure to clear all items?", PrintLabelTypeTextBox.Visible ? PrintLabelTypeTextBox.Text : PrintLabelTypeComboBox.Text), ApplicationInfo.ShortApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) {
                    return;
                }
                _RxlDataSet.ItemBarcodeWithQuantity.Clear();
                AcceptChangesItemDetail();
            } catch {
                throw;
            }
        }

        private void AcceptChangesItemDetail() {
            try {
                ItemDetailDataGridView.EndEdit();
                _ItemDetailBindingSource.EndEdit();
                _RxlDataSet.ItemBarcodeWithQuantity.AcceptChanges();
                if (_RxlDataSet.ItemBarcodeWithQuantity.Count == 0) {
                    ClearBarcodePreview();
                }
                _MustRepeatFind = true;
            } catch {
                throw;
            }
        }

        private void ImportFromExcel(string fileName) {
            try {
                bool merge = false;
                if (_ItemDetailBindingSource.Count > 0) {
                    DialogResult confirm = MessageBox.Show(this, "Do you want to merge it with the current item(s) or replace it with the new one?", ApplicationInfo.ShortApplicationName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Cancel) {
                        return;
                    }
                    merge = (confirm == DialogResult.Yes);
                }
                try {
                    ImportExcelUsingOleDb(fileName, merge);
                } catch (OleDbException ex) {
                    if (ex.ErrorCode == -2147467259 && ex.Message == "External table is not in the expected format.") {
                        ImportExcelUsingXml(fileName, merge);
                    } else {
                        throw;
                    }
                } catch {
                    throw;
                }
                _MustRepeatFind = true;
            } catch (Exception ex) {
                string errorMessage = string.Format("Error:\r\n   {0}{1}\r\n\r\n Stack Trace:\r\n   {2}", "There were errors occurred when trying to import the file.\r\n   ", ex.Message, ex.StackTrace);
                ExceptionManager.ShowException(ApplicationInfo.ShortApplicationName, this, errorMessage);
            }
        }

        private void ImportExcelUsingOleDb(string fileName, bool merge) {
            try {
                using (OleDbConnection connection = new OleDbConnection(string.Format("Provider={0};Data Source={1};Extended Properties={2}", "Microsoft.Jet.OLEDB.4.0", fileName, "\"Excel 8.0;HDR=Yes;IMEX=1\""))) {
                    connection.Open();
                    string workSheetName = string.Empty;
                    using (DataTable worksheets = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null)) {
                        try {
                            workSheetName = Convert.ToString(worksheets.Rows[0]["TABLE_NAME"]);
                        } catch { }
                        if (workSheetName == string.Empty) {
                            throw new ArgumentException("No worksheet is founded.");
                        }
                    }
                    using (DataTable headers = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, null)) {
                        try {
                            var q = from t in headers.AsEnumerable()
                                    where (
                                        (
                                            t.Field<string>("COLUMN_NAME") == "ItemCode" ||
                                            t.Field<string>("COLUMN_NAME") == "ItemName" ||
                                            t.Field<string>("COLUMN_NAME") == "Barcode" ||
                                            t.Field<string>("COLUMN_NAME") == "Quantity"
                                        ) &&
                                        (t.Field<string>("TABLE_NAME") == workSheetName)
                                    )
                                    select new { ColumnName = t.Field<string>("COLUMN_NAME") };
                            if (q == null || q.ElementAtOrDefault(0) == null) {
                                throw new ArgumentException("The column header in the excel file is not conformed with the schema");
                            }
                        } catch {
                            throw;
                        }
                    }
                    using (DataTable tempTable = new DataTable()) {
                        tempTable.Columns.AddRange(
                                new DataColumn[] {
                                        new DataColumn("ItemCode",typeof(string)),
                                        new DataColumn("ItemName",typeof(string)),
                                        new DataColumn("Barcode",typeof(string)),
                                        new DataColumn("Quantity",typeof(decimal)),
                                    }
                            );
                        using (OleDbCommand command = new OleDbCommand(
                            string.Format("SELECT ItemCode, ItemName, Barcode, Quantity FROM [{0}] WHERE (ItemCode IS NOT NULL AND ItemCode <> '') AND (ItemName IS NOT NULL AND ItemName <> '') AND (Barcode IS NOT NULL AND Barcode <> '')", workSheetName),
                            connection)) {

                            command.CommandTimeout = 0;
                            using (OleDbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.KeyInfo)) {
                                tempTable.Load(reader);
                            }
                        }
                        if (tempTable.Rows.Count == 0) {
                            throw new ApplicationException("The file contains no record at all or the mandatory field is null or empty.");
                        }
                        if (!merge) {
                            _RxlDataSet.ItemBarcodeWithQuantity.Clear();
                        }
                        using (DataTableReader reader = tempTable.CreateDataReader()) {
                            _RxlDataSet.ItemBarcodeWithQuantity.Load(reader);
                        }
                        _RxlDataSet.ItemBarcodeWithQuantity.AcceptChanges();
                    }
                }
            } catch {
                throw;
            }
        }

        private void ImportExcelUsingXml(string fileName, bool merge) {
            try {
                using (DataTable tempTable = new DataTable()) {
                    tempTable.Columns.AddRange(
                            new DataColumn[] {
                                new DataColumn("ItemCode",typeof(string)),
                                new DataColumn("ItemName",typeof(string)),
                                new DataColumn("Barcode",typeof(string)),
                                new DataColumn("Quantity",typeof(decimal)),
                                }
                        );
                    bool headerValidated = false;
                    Dictionary<string, int> headerListKey = new Dictionary<string, int>();
                    Dictionary<int, string> headerListValue = new Dictionary<int, string>();
                    XDocument excelFile = XDocument.Load(fileName);
                    foreach (var table in excelFile.Descendants("{urn:schemas-microsoft-com:office:spreadsheet}Table")) {
                        foreach (var row in table.Descendants("{urn:schemas-microsoft-com:office:spreadsheet}Row")) {
                            int currentIndex = 0;
                            string itemCode = string.Empty;
                            string itemName = string.Empty;
                            string barcode = string.Empty;
                            int quantity = 1;
                            foreach (var cell in row.Descendants("{urn:schemas-microsoft-com:office:spreadsheet}Cell")) {
                                foreach (var data in cell.Descendants("{urn:schemas-microsoft-com:office:spreadsheet}Data")) {
                                    string value = data.Value;
                                    if (value == string.Empty) {
                                        throw new ArgumentException("Value can not be null or empty");
                                    }
                                    if (!headerValidated) {
                                        if (value == "ItemCode" || value == "ItemName" || value == "Barcode" || value == "Quantity") {
                                            if (headerListKey.Keys.Contains(value)) {
                                                throw new ArgumentException(string.Format("There was already column '{0}' in the file!", value));
                                            }
                                            headerListKey.Add(value, currentIndex);
                                            headerListValue.Add(currentIndex, value);
                                        }
                                    } else {
                                        string currentColumn = headerListValue[currentIndex];
                                        if (currentColumn == "ItemCode") {
                                            itemCode = value;
                                        } else if (currentColumn == "ItemName") {
                                            itemName = value;
                                        } else if (currentColumn == "Barcode") {
                                            barcode = value;
                                        } else if (currentColumn == "Quantity") {
                                            try {
                                                quantity = Convert.ToInt32(value);
                                            } catch { }
                                            if (quantity <= 0) {
                                                quantity = 1;
                                            }
                                        } else {
                                            throw new ArgumentException(string.Format("Invalid column.", value));
                                        }
                                    }
                                    break;
                                }
                                currentIndex++;
                            }
                            if (!headerValidated) {
                                if (headerListKey.Count != 4) {
                                    throw new ArgumentException("The column header in the excel file is not conformed with the schema");
                                }
                                headerValidated = true;
                                continue;
                            }
                            tempTable.Rows.Add(
                                    new object[] {
                                        itemCode,
                                        itemName,
                                        barcode,
                                        (decimal)quantity,
                                    }
                                );
                        }
                        break;
                    }
                    if (!merge) {
                        _RxlDataSet.ItemBarcodeWithQuantity.Clear();
                    }
                    using (DataTableReader reader = tempTable.CreateDataReader()) {
                        _RxlDataSet.ItemBarcodeWithQuantity.Load(reader);
                    }
                    _RxlDataSet.ItemBarcodeWithQuantity.AcceptChanges();
                }
            } catch {
                throw;
            }
        }

        private void ExportToExcel(string fileName) {
            try {
                if (_ItemDetailBindingSource == null || _ItemDetailBindingSource.Count == 0) {
                    MessageBox.Show(this, string.Format("There were nothing to export.", PrintLabelTypeTextBox.Visible ? PrintLabelTypeTextBox.Text : PrintLabelTypeComboBox.Text), ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (DataSet ds = new DataSet("SoltiusRxlBarcode")) {
                    using (DataTable table = ds.Tables.Add("ItemBarcode")) {
                        table.Columns.AddRange(
                                new DataColumn[] {
                                new DataColumn("ItemCode",typeof(string)),
                                new DataColumn("ItemName",typeof(string)),
                                new DataColumn("Barcode",typeof(string)),
                                new DataColumn("Quantity",typeof(string)),
                                }
                            );
                        using (DataTableReader reader = _RxlDataSet.ItemBarcodeWithQuantity.CreateDataReader()) {
                            int itemCodeOrdinal = reader.GetOrdinal("ItemCode");
                            int itemNameOrdinal = reader.GetOrdinal("ItemName");
                            int barcodeOrdinal = reader.GetOrdinal("Barcode");
                            int QuantityOrdinal = reader.GetOrdinal("Quantity");
                            while (reader.Read()) {
                                table.Rows.Add(
                                        new object[] {
                                            reader[itemCodeOrdinal],
                                            reader[itemNameOrdinal],
                                            reader[barcodeOrdinal],
                                            Convert.ToString(((int)(decimal)reader[QuantityOrdinal])),
                                        }
                                    );
                            }
                            table.AcceptChanges();
                        }
                        ExcelHelper.Export(ds, fileName);
                    }
                }
            } catch (Exception ex) {
                string errorMessage = string.Format("Error:\r\n   {0}{1}\r\n\r\n Stack Trace:\r\n   {2}", "There were errors occurred when trying to import the file.\r\n   ", ex.Message, ex.StackTrace);
                ExceptionManager.ShowException(ApplicationInfo.ShortApplicationName, this, errorMessage);
            }
        }

        private void FindNextItem() {
            try {
                if (_ItemDetailBindingSource == null || _ItemDetailBindingSource.Count == 0) {
                    MessageBox.Show(this, "There were nothing to find.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (FindItemColumnTypeToolStripComboBox.SelectedIndex == -1) {
                    MessageBox.Show(this, "Please select Column Type to find.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FindItemColumnTypeToolStripComboBox.DroppedDown = true;
                    FindItemColumnTypeToolStripComboBox.Focus();
                    return;
                }
                if (FindItemTextToolStripTextBox.Text.Length == 0) {
                    MessageBox.Show(this, "Please enter text to find.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FindItemTextToolStripTextBox.Focus();
                    return;
                }

                int currentIndex = _ItemDetailBindingSource.Position;
                int listCount = _ItemDetailBindingSource.Count;
                string itemColumnType = Convert.ToString(FindItemColumnTypeToolStripComboBox.ComboBox.SelectedValue);
                string findText = FindItemTextToolStripTextBox.Text;

                bool newFind = _MustRepeatFind ||
                               (currentIndex != _LastFoundIndex) ||
                               (listCount != _LastItemCount) ||
                               (itemColumnType != _LastFindItemColumnType) ||
                               (findText != _LastFindItemText);

                if (newFind) {
                    _CachedFoundItemList = null;
                    _FindItemIndexer = 0;
                    _MustRepeatFind = false;
                }

                _LastItemCount = listCount;
                _LastFindItemColumnType = itemColumnType;
                _LastFindItemText = findText;

                if (_CachedFoundItemList == null) {
                    var list = ((_ItemDetailBindingSource.List as DataView).OfType<DataRowView>().AsEnumerable()).
                   Select((t, i) => new CachedItemList(i, (t.Row as dsShoesBarcodePrinting.ItemDetailRow)));

                    var searchList = list.Skip(currentIndex + 1);
                    searchList = searchList.Concat(list.Take(listCount - searchList.Count()));

                    _CachedFoundItemList = searchList.
                                           Where(t => t.Row.Field<string>(itemColumnType).Like(findText, StringHelper.CompareMethod.Text));

                    if (_CachedFoundItemList == null) {
                        MessageBox.Show(this, string.Format("The following specified text was not found:\r\n\r\n{0}", findText), ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _LastItemCount = -1;
                        _LastFindItemColumnType = string.Empty;
                        _LastFindItemText = string.Empty;
                        _LastFoundIndex = -1;
                        return;
                    }
                }

                CachedItemList currentItem = null;
                try {
                    currentItem = _CachedFoundItemList.ElementAtOrDefault(_FindItemIndexer);
                } catch { }
                if (currentItem == null) {
                    MessageBox.Show(this, "Find reached the starting point of the search.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _CachedFoundItemList = null;
                    _FindItemIndexer = 0;
                    _LastItemCount = -1;
                    _LastFindItemColumnType = string.Empty;
                    _LastFindItemText = string.Empty;
                    _LastFoundIndex = -1;
                    return;
                }
                _FindItemIndexer++;
                _LastFoundIndex = currentItem.Index;
                _ItemDetailBindingSource.Position = _LastFoundIndex;
                ItemDetailDataGridView.CurrentRow.Selected = true;
            } catch (Exception ex) {
                ExceptionManager.ShowException(ApplicationInfo.ShortApplicationName, this, ex);
                //throw;
            }
        }

        private void PrintLabels() {
            try {
                if (PrinterComboBox.SelectedIndex == -1) {
                    MessageBox.Show(this, "Please select the printer.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_ItemDetailBindingSource.Count == 0) {
                    MessageBox.Show(this, "There were nothing to print.", ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (PrintDocument _PrintDocument = new PrintDocument()) {
                    _PrintDocument.PrinterSettings.PrinterName = Convert.ToString(PrinterComboBox.SelectedValue);
                    _PrintDocument.BeginPrint += _PrintDocument_BeginPrint;
                    _PrintDocument.QueryPageSettings += _PrintDocument_QueryPageSettings;
                    _PrintDocument.PrintPage += _PrintDocument_PrintPage;
                    _PrintDocument.EndPrint += _PrintDocument_EndPrint;
                    using (PrintPreviewDialog dialog = new PrintPreviewDialog()) {
                        dialog.Document = _PrintDocument;
                        dialog.ShowDialog(this);
                    }
                }
                _ItemDetailBindingSource.MoveFirst();
            } catch {
                throw;
            }
        }

        private void SafeExit() {
            try {
                this.Dispose();
            } catch {
                //throw;
            }
        }

        #endregion

        #region Constructors

        public MainForm() {
            try {
                if (!LicenceValidator.Validate(this, ApplicationInfo.AbbreviatedApplicationName, ApplicationInfo.ShortApplicationName, Application.ExecutablePath)) {
                    MessageBox.Show(this, string.Format("Fail to validate the license."), ApplicationInfo.ShortApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SafeExit();
                }
                InitializeComponent();
            } catch {
                throw;
            }
        }

        #endregion

        #endregion

        #region Fields

        private KeyValuePair<string, string>[] _DocumentTypeSource = new KeyValuePair<string, string>[]{
            //new KeyValuePair<string, string>(DocumentType.None, "Free Input"),
            //new KeyValuePair<string, string>(DocumentType.DeliveryNote, "Delivery Note"),
            new KeyValuePair<string, string>(DocumentType.InitialStock, "Initial Stock"),
            new KeyValuePair<string, string>(DocumentType.ItemMaster, "Item Master"),
            new KeyValuePair<string, string>(DocumentType.PurchaseOrder, "Purchase Order"),
            //new KeyValuePair<string, string>(DocumentType.SalesOrder, "Sales Order"),
            new KeyValuePair<string, string>(DocumentType.GRN, "GRN"),
        };

        private KeyValuePair<string, string>[] _BarcodeTypeSource = new KeyValuePair<string, string>[]{
          
            new KeyValuePair<string, string>(CodeTypeEnum.Code39.ToString(), CodeTypeEnum.Code39.ToString()),
            new KeyValuePair<string, string>(CodeTypeEnum.Code93.ToString(), CodeTypeEnum.Code93.ToString()),  
              new KeyValuePair<string, string>(CodeTypeEnum.Code128.ToString(), CodeTypeEnum.Code128.ToString()),
            new KeyValuePair<string, string>(CodeTypeEnum.CodeI2of5.ToString(), CodeTypeEnum.CodeI2of5.ToString()),
            new KeyValuePair<string, string>(CodeTypeEnum.Codabar.ToString(), CodeTypeEnum.Codabar.ToString()),
            new KeyValuePair<string, string>(CodeTypeEnum.PostNet.ToString(), CodeTypeEnum.PostNet.ToString()),
            new KeyValuePair<string, string>(CodeTypeEnum.Ean13.ToString(), CodeTypeEnum.Ean13.ToString()),
            new KeyValuePair<string, string>(CodeTypeEnum.Ean8.ToString(), CodeTypeEnum.Ean8.ToString()),
            new KeyValuePair<string, string>(CodeTypeEnum.UpcA.ToString(), CodeTypeEnum.UpcA.ToString()),
            new KeyValuePair<string, string>(CodeTypeEnum.UpcE.ToString(), CodeTypeEnum.UpcE.ToString()),
        };

        private KeyValuePair<string, string>[] _PageOrientationTypeSource = new KeyValuePair<string, string>[]{
            new KeyValuePair<string, string>(PageOrientationType.Portrait, PageOrientationType.Portrait),
            new KeyValuePair<string, string>(PageOrientationType.Landscape, PageOrientationType.Landscape),
        };

        private KeyValuePair<string, string>[] _ItemColumnTypeSource = new KeyValuePair<string, string>[]{
            new KeyValuePair<string, string>(ItemColumnType.ItemCode, "Item Code"),
            new KeyValuePair<string, string>(ItemColumnType.ItemName, "Item Name"),
            new KeyValuePair<string, string>(ItemColumnType.Barcode, "Barcode"),            
        };
        //new
        private KeyValuePair<string, string>[] _PrcPrnItemColumnTypeSource = new KeyValuePair<string, string>[]{
            new KeyValuePair<string, string>(ItemColumnType.SellPrice, "Sell Price"),
            new KeyValuePair<string, string>(ItemColumnType.PrintDate, "Print Date"),
        };
        //new
        private RxlDataSet _RxlDataSet = null;
        private dsShoesBarcodePrinting DsShoesBarcode = null;

        private SqlConnection queryConnection = new SqlConnection(RxlConfiguration.GetCurrent().GetConnectionString(null));
        private SqlDataAdapter dataAdapter;
        private string sqlSelect = string.Empty;

        private RxlBarcodeConfiguration _RxlBarcodeConfiguration = null;

        private BindingSource _ItemDetailBindingSource = null;

        private BindingSource _PrintLabelBindingSource = null;

        private BindingSource _PrintSettingBindingSource = null;

        private string _ConfigFileName = string.Empty;

        private PrintHelper _PrintHelper = null;

        private bool _ChangedByLabelType = false;

        private bool _FirstPagePrinted = false;

        private bool _IsPreview = false;

        private DateTime _CurrentDateTime = DateTime.Now;

        private string _LastPageOrientation = string.Empty;

        private bool _IsFreeInput = false;

        private int _LastFoundIndex = 0;

        private int _LastItemCount = 0;

        private string _LastFindItemColumnType = string.Empty;

        private string _LastFindItemText = string.Empty;

        private IEnumerable<CachedItemList> _CachedFoundItemList = null;
        private DataSet dsDocumentKey = null;

        private int _FindItemIndexer = 0;

        private bool _MustRepeatFind = false;

        #endregion

        #region Nested Types

        private class PrintHelper {

            #region Methods

            #region Not Overridables

            public void Reset() {
                try {
                    _IsLandscape = false;
                    _PageLeftMargin = 0;
                    _PageRightMargin = 0;
                    _PageTopMargin = 0;
                    _PageBottomMargin = 0;

                    _PaperWidth = 0;
                    _PaperHeight = 0;

                    _LabelWidth = 0;
                    _LabelHeight = 0;
                    _LabelColumnSpace = 0;
                    _LabelRowSpace = 0;

                    _LabelLeftMargin = 0;
                    _LabelRightMargin = 0;
                    _LabelTopMargin = 0;
                    _LabelBottomMargin = 0;

                    _BarcodeWidthScale = 0;
                    _BarcodeHeightScale = 0;

                    _RowCountPerPage = -1;
                    _ColumnCountPerPage = -1;

                    _LabelStartRow = 0;
                    _LabelStartColumn = 0;

                    _CurrentItemIndex = 0;
                    _ItemCount = 0;
                    _Items = null;
                    _LastQuantityPrinted = 0;

                    _ShowTopText = true;
                    _ShowBottomText = true;

                    //new
                    _ShowPrcPrnText = true;
                } catch {
                    throw;
                }
            }

            public int GetRowCountPerPage(bool recalculate) {
                try {
                    if (!recalculate && _RowCountPerPage >= 0) {
                        return _RowCountPerPage;
                    }
                    _RowCountPerPage = 0;
                    try {
                        _RowCountPerPage = GetRowCountInternal();
                    } catch { }
                    return _RowCountPerPage;
                } catch {
                    throw;
                }
            }

            public int GetColumnCountPerPage(bool recalculate) {
                try {
                    if (!recalculate && _ColumnCountPerPage >= 0) {
                        return _ColumnCountPerPage;
                    }
                    _ColumnCountPerPage = 0;
                    try {
                        _ColumnCountPerPage = GetColumnCountInternal();
                    } catch { }
                    return _ColumnCountPerPage;
                } catch {
                    throw;
                }
            }

            private int GetRowCountInternal() {
                try {
                    int result = 0;
                    int max = (_PaperHeight - _PageBottomMargin) + _PageTopMargin;
                    int current = _LabelHeight;
                    if (current < max) {
                        result++;
                    }
                    do {
                        if ((current += _LabelRowSpace) < max) {
                            if ((current += _LabelHeight) < max) {
                                result++;
                            }
                        }
                    } while (current < max);
                    return result;
                } catch {
                    throw;
                }
            }

            private int GetColumnCountInternal() {
                try {
                    int result = 0;
                    int max = (_PaperWidth - _PageRightMargin) + _PageLeftMargin; ;
                    int current = _LabelWidth;
                    if (current < max) {
                        result++;
                    }
                    do {
                        if ((current += _LabelColumnSpace) < max) {
                            if ((current += _LabelWidth) < max) {
                                result++;
                            }
                        }
                    } while (current < max);
                    return result;
                } catch {
                    throw;
                }
            }

            public void SetProperties(
                bool isLandscape, decimal pageLeftMargin, decimal pageRightMargin, decimal pageTopMargin, decimal pageBottomMargin,
                decimal paperWidth, decimal paperHeight,
                decimal labelWidth, decimal labelHeight, decimal labelColumnSpace, decimal labelRowSpace,
                decimal labelLeftMargin, decimal labelRightMargin, decimal labelTopMargin, decimal labelBottomMargin,
                int labelStartRow, int labelStartColumn,
                EnumerableRowCollection<dsShoesBarcodePrinting.ItemDetailRow> items,
                decimal barcodeWidthScale, decimal barcodeHeightScale,
                bool showTopText, bool showBottomText, bool showPrcPrnText
                ) {

                try {
                    SetPageSettings(isLandscape, pageLeftMargin, pageRightMargin, pageTopMargin, pageBottomMargin,
                            paperWidth, paperHeight,
                            labelWidth, labelHeight, labelColumnSpace, labelRowSpace,
                            labelLeftMargin, labelRightMargin, labelTopMargin, labelBottomMargin,
                            barcodeWidthScale, barcodeHeightScale,
                            showTopText, showBottomText, showPrcPrnText
                        );

                    SetPrintObject(labelStartRow, labelStartColumn, items);
                } catch {
                    throw;
                }
            }

            public void SetPrintObject(int labelStartRow, int labelStartColumn,
                EnumerableRowCollection<dsShoesBarcodePrinting.ItemDetailRow> items)
            {

                try {
                    this._LabelStartRow = labelStartRow;
                    this._LabelStartColumn = labelStartColumn;
                    this._Items = items;
                    try {
                        _ItemCount = items.Count();
                    } catch { }
                } catch {
                    throw;
                }
            }

            public void SetPageSettings(
                bool isLandscape, decimal pageLeftMargin, decimal pageRightMargin, decimal pageTopMargin, decimal pageBottomMargin,
                decimal paperWidth, decimal paperHeight,
                decimal labelWidth, decimal labelHeight, decimal labelColumnSpace, decimal labelRowSpace,
                decimal labelLeftMargin, decimal labelRightMargin, decimal labelTopMargin, decimal labelBottomMargin,
                decimal barcodeWidthScale, decimal barcodeHeightScale,
                bool showTopText, bool showBottomText, bool showPrcPrnText
                ) {

                try {
                    this._IsLandscape = isLandscape;
                    this._PageTopMargin = (int)(pageTopMargin * 100);
                    this._PageLeftMargin = (int)(pageLeftMargin * 100);
                    this._PageBottomMargin = (int)(pageBottomMargin * 100);
                    this._PageRightMargin = (int)(pageRightMargin * 100);

                    this._PaperWidth = (int)(paperWidth * 100);
                    this._PaperHeight = (int)(paperHeight * 100);

                    this._LabelWidth = (int)(labelWidth * 100);
                    this._LabelHeight = (int)(labelHeight * 100);
                    this._LabelColumnSpace = (int)(labelColumnSpace * 100);
                    this._LabelRowSpace = (int)(labelRowSpace * 100);

                    this._LabelTopMargin = (int)(labelTopMargin);
                    this._LabelLeftMargin = (int)(labelLeftMargin);
                    this._LabelBottomMargin = (int)(labelBottomMargin);
                    this._LabelRightMargin = (int)(labelRightMargin);

                    this._BarcodeWidthScale = (int)(barcodeWidthScale);
                    this._BarcodeHeightScale = (int)(barcodeHeightScale);

                    this._ShowTopText = showTopText;
                    this._ShowBottomText = showBottomText;

                    //new
                    this._ShowPrcPrnText = showPrcPrnText;
                } catch {
                    throw;
                }
            }

            public bool HasMoreItems() {
                try {
                    return (_CurrentItemIndex < _ItemCount);
                } catch {
                    throw;
                }
            }

            public bool MoveNextItem() {
                try {
                    if (HasMoreItems()) {
                        _CurrentItemIndex++;
                        return true;
                    }
                    return false;
                } catch {
                    throw;
                }
            }

            public dsShoesBarcodePrinting.ItemDetailRow GetCurrentItem()
            {
                try {
                    if (HasMoreItems()) {
                        try {
                            return _Items.ElementAt(_CurrentItemIndex);
                        } catch { }
                    }
                    return null;
                } catch {
                    throw;
                }
            }

            #endregion

            #region Constructors

            public PrintHelper() {
                try {

                } catch {
                    throw;
                }
            }

            public PrintHelper(
                bool isLandscape, decimal pageLeftMargin, decimal pageRightMargin, decimal pageTopMargin, decimal pageBottomMargin,
                decimal paperWidth, decimal paperHeight,
                decimal labelWidth, decimal labelHeight, decimal labelColumnSpace, decimal labelRowSpace,
                decimal labelLeftMargin, decimal labelRightMargin, decimal labelTopMargin, decimal labelBottomMargin,
                decimal barcodeWidthScale, decimal barcodeHeightScale,
                bool showTopText, bool showBottomText, bool showPrcPrnText
                ) {

                try {
                    SetPageSettings(isLandscape, pageLeftMargin, pageRightMargin, pageTopMargin, pageBottomMargin,
                            paperWidth, paperHeight,
                            labelWidth, labelHeight, labelColumnSpace, labelRowSpace,
                            labelLeftMargin, labelRightMargin, labelTopMargin, labelBottomMargin,
                            barcodeWidthScale, barcodeHeightScale,
                            showTopText, showBottomText, showPrcPrnText
                        );
                } catch {
                    throw;
                }
            }

            #endregion

            #endregion

            #region Properties

            public bool IsLandscape {
                get {
                    try {
                        return this._IsLandscape;
                    } catch {
                        throw;
                    }
                }
            }

            public int PageLeftMargin {
                get {
                    try {
                        return this._PageLeftMargin;
                    } catch {
                        throw;
                    }
                }
            }

            public int PageRightMargin {
                get {
                    try {
                        return this._PageRightMargin;
                    } catch {
                        throw;
                    }
                }
            }

            public int PageTopMargin {
                get {
                    try {
                        return this._PageTopMargin;
                    } catch {
                        throw;
                    }
                }
            }

            public int PageBottomMargin {
                get {
                    try {
                        return this._PageBottomMargin;
                    } catch {
                        throw;
                    }
                }
            }

            public int PaperWidth {
                get {
                    try {
                        return this._PaperWidth;
                    } catch {
                        throw;
                    }
                }
            }

            public int PaperHeight {
                get {
                    try {
                        return this._PaperHeight;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelWidth {
                get {
                    try {
                        return this._LabelWidth;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelHeight {
                get {
                    try {
                        return this._LabelHeight;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelColumnSpace {
                get {
                    try {
                        return this._LabelColumnSpace;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelRowSpace {
                get {
                    try {
                        return this._LabelRowSpace;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelLeftMargin {
                get {
                    try {
                        return this._LabelLeftMargin;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelRightMargin {
                get {
                    try {
                        return this._LabelRightMargin;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelTopMargin {
                get {
                    try {
                        return this._LabelTopMargin;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelBottomMargin {
                get {
                    try {
                        return this._LabelBottomMargin;
                    } catch {
                        throw;
                    }
                }
            }

            public int BarcodeWidthScale {
                get {
                    try {
                        return this._BarcodeWidthScale;
                    } catch {
                        throw;
                    }
                }
            }

            public int BarcodeHeightScale {
                get {
                    try {
                        return this._BarcodeHeightScale;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelStartRow {
                get {
                    try {
                        return this._LabelStartRow;
                    } catch {
                        throw;
                    }
                }
            }

            public int LabelStartColumn {
                get {
                    try {
                        return this._LabelStartColumn;
                    } catch {
                        throw;
                    }
                }
            }

            public int ItemCount {
                get {
                    try {
                        return _ItemCount;
                    } catch {
                        throw;
                    }
                }
            }

            public int LastQuantityPrinted {
                get {
                    try {
                        return _LastQuantityPrinted;
                    } catch {
                        throw;
                    }
                }
                set {
                    try {
                        _LastQuantityPrinted = value;
                    } catch {
                        throw;
                    }
                }
            }

            public bool ShowTopText {
                get {
                    try {
                        return this._ShowTopText;
                    } catch {
                        throw;
                    }
                }
            }

            public bool ShowBottomText {
                get {
                    try {
                        return this._ShowBottomText;
                    } catch {
                        throw;
                    }
                }
            }

            //new
            public bool ShowPrcPrnText {
                get {
                    try {
                        return this._ShowPrcPrnText;
                    }
                    catch {
                        throw;
                    }
                }
            }
            //new 

            #endregion

            #region Fields

            private int _PageLeftMargin = 0;
            private int _PageRightMargin = 0;
            private int _PageTopMargin = 0;
            private int _PageBottomMargin = 0;

            private bool _IsLandscape;

            private int _PaperWidth = 0;
            private int _PaperHeight = 0;

            private int _LabelWidth = 0;
            private int _LabelHeight = 0;
            private int _LabelColumnSpace = 0;
            private int _LabelRowSpace = 0;

            private int _LabelLeftMargin = 0;
            private int _LabelRightMargin = 0;
            private int _LabelTopMargin = 0;
            private int _LabelBottomMargin = 0;

            private int _BarcodeWidthScale = 0;
            private int _BarcodeHeightScale = 0;

            private int _RowCountPerPage = -1;
            private int _ColumnCountPerPage = -1;

            private int _LabelStartRow = 0;
            private int _LabelStartColumn = 0;

            public int _CurrentItemIndex = 0;
            private int _ItemCount = 0;
            private int _LastQuantityPrinted;

            private EnumerableRowCollection<dsShoesBarcodePrinting.ItemDetailRow> _Items = null;

            private bool _ShowTopText = true;
            private bool _ShowBottomText = true;

            //new
            private bool _ShowPrcPrnText = true;

            #endregion

        }

        private static class DocumentType {

            public static readonly string None = "None";
            //public static readonly string DeliveryNote = "DeliveryNote";
            public static readonly string InitialStock = "Initial Stock";
            public static readonly string ItemMaster = "ItemMaster";
            //new
            public static readonly string PurchaseOrder = "PurchaseOrder";
            //public static readonly string SalesOrder = "SalesOrder";
            public static readonly string GRN = "GRN";
            //new
        }

        private static class PageOrientationType {

            public static readonly string Portrait = "Portrait";
            public static readonly string Landscape = "Landscape";

        }

        private static class ItemColumnType {

            public static readonly string ItemCode = "ItemCode";
            public static readonly string ItemName = "ItemName";
            public static readonly string Barcode = "Barcode";
            public static readonly string SellPrice = "SellPrice";
            public static readonly string PrintDate = "PrintDate";

        }

        private class CachedItemList {

            public CachedItemList(int Index, dsShoesBarcodePrinting.ItemDetailRow Row)
            {
                this.Index = Index;
                this.Row = Row;
            }

            public int Index;

            public dsShoesBarcodePrinting.ItemDetailRow Row;

        }

        #endregion

        private void ShowPrcPrnTextCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ChangeBarcodePrcPrnTextFont();
            }
            catch
            {
                throw;
            }
        }

        private void ChangeBarcodePrcPrnTextFont()
        {
            BarcodeAsTextPreviewLabel.Tag = BarcodeTextFontDialog.Font.Clone();
            BarcodeAsTextPreviewLabel.Font = new Font(BarcodeTextFontDialog.Font.Name, 8.25F);
            BarcodeAsTextPreviewLabel.Visible = ShowPrcPrnTextCheckBox.Checked;
            if (!ShowPrcPrnTextCheckBox.Checked)
            {
                if (ShowBottomTextCheckBox.Checked)
                    BarcodeStyleTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;
            }
            else
            {
                BarcodeStyleTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;
                if (!BarcodeStyleTextPreviewLabel.Visible)
                {

                    BottomTextTypeComboBox.SelectedValue = ItemColumnType.Barcode;
                    BarcodeAsTextPreviewLabel.Location = BarcodeAsTextPreviewLabel.Location;
                    BarcodeAsTextPreviewLabel.Size = BarcodeAsTextPreviewLabel.Size;
                    BarcodeAsTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;

                }
                else
                {
                    //168, 66
                    //113, 14
                    if (ItemColumnType.ItemName == BottomTextTypeComboBox.SelectedValue.ToString())
                        BottomTextTypeComboBox.SelectedValue = ItemColumnType.Barcode;
                    BarcodeAsTextPreviewLabel.Location = BarcodeAsTextPreviewLabel.Location;
                    BarcodeAsTextPreviewLabel.Size = BarcodeAsTextPreviewLabel.Size;
                    BarcodeAsTextPreviewLabel.TextAlign = ContentAlignment.MiddleLeft;
                }
            }
        }
        private void PrcPrnTextTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (ItemDetailDataGridView.CurrentRow == null) {
                    return;
                }
                SetBarcodeText(ItemDetailDataGridView.CurrentRow);
            }
            catch {
                throw;
            }
        }

        private void SearchTypeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FindItemTextToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void DocumentKeyComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        public void item_shoes_detail(string divison, string docNo, string table)
        {
            DsShoesBarcode = new dsShoesBarcodePrinting();
            sqlSelect = "EXEC [SOL_SHOES_BARCODE_PRINTING] '" + divison + "','" + docNo + "','" + table + "'";
            queryConnection.Open();
            dataAdapter = new SqlDataAdapter(sqlSelect.ToString(), queryConnection);
            dataAdapter.Fill(DsShoesBarcode, "ItemDetail");
            queryConnection.Close();

            ItemDetailDataGridView.AutoGenerateColumns = false;
            _ItemDetailBindingSource = new BindingSource(DsShoesBarcode, "ItemDetail");
            ItemDetailDataGridView.DataSource = _ItemDetailBindingSource;
            ItemDetailBindingNavigator.BindingSource = _ItemDetailBindingSource;
            DetailGroupBox.Enabled = true;
        }
        private void ChangePrcTextFontStyleButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = BarcodeTextFontDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    if (sender == ChangeTopTextFontStyleButton)
                    {
                        ChangeBarcodeTextFont(sender == ChangeTopTextFontStyleButton, false, false);
                    }
                    else if (sender == ChangePrcTextFontStyleButton)
                    {
                        ChangeBarcodeTextFont(false, sender == ChangePrcTextFontStyleButton, false);
                    }
                    else if (sender == ChanteBottomTextFontStyleButton)
                    {
                        ChangeBarcodeTextFont(false, false, sender == ChanteBottomTextFontStyleButton);
                    }
                }
            }
            catch
            {
                throw;
            }
        }
  
    }
}
