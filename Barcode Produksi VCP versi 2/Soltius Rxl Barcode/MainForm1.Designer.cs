namespace Soltius.RetailExcel.Utils.PrintBarcode
{
    partial class MainForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.OutputPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.BarcodeTextFontDialog = new System.Windows.Forms.FontDialog();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.cmbWarna = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cmbMerk = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtSPKYear = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSPKMid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtSPKNum = new System.Windows.Forms.TextBox();
            this.btnCetak = new System.Windows.Forms.Button();
            this.cbRePrint = new System.Windows.Forms.CheckBox();
            this.btnTutup = new System.Windows.Forms.Button();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.BarCodePreview = new C1.Win.C1BarCode.C1BarCode();
            this.DetailGroupBox = new System.Windows.Forms.GroupBox();
            this.DetailTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemDetailPanel = new System.Windows.Forms.Panel();
            this.ItemDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemCodeDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBarcodeDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintCountDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPrintedDgvColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SellPriceDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDetailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.ItemDetailBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.ItemDetailBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.ItemDetailBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.ItemDetailBindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemDetailBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.ItemDetailBindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemDetailBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.ItemDetailBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.ItemDetailBindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemSavingToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExportItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCheckingToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.CheckAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAllItemChecksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemRemovingToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.RemoveAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveSelectedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetAllItemsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.FindItemPanel = new System.Windows.Forms.Panel();
            this.AddNewItemToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewItemCodeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.NewItemNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.NewBarcodeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.NewPrintCountToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.AddNewItemToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FindItemToolStrip = new System.Windows.Forms.ToolStrip();
            this.FindItemColumnTypeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.FindItemColumnTypeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.FindItemTextToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.FindItemTextToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.FindNextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrintSettingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BarcodePreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.BarcodePreviewPanel = new System.Windows.Forms.Panel();
            this.BarcodeMadeFromPreviewLabel = new System.Windows.Forms.Label();
            this.BarcodeDateTextPreviewLabel = new System.Windows.Forms.Label();
            this.BarcodeBrandTextPreviewLabel = new System.Windows.Forms.Label();
            this.BarcodeSizeTextPreviewLabel = new System.Windows.Forms.Label();
            this.c1BarCode1 = new C1.Win.C1BarCode.C1BarCode();
            this.BarcodeColourTextPreviewLabel = new System.Windows.Forms.Label();
            this.BarcodeStyleTextPreviewLabel = new System.Windows.Forms.Label();
            this.BarcodeAsTextPreviewLabel = new System.Windows.Forms.Label();
            this.BarcodeTypeLabel = new System.Windows.Forms.Label();
            this.PrintSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.DetailPrintSettingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PrinterPanel = new System.Windows.Forms.Panel();
            this.PrintStartColumnNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrintStartRowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrintStartColumnLabel = new System.Windows.Forms.Label();
            this.PrintStartRowLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PrinterLabel = new System.Windows.Forms.Label();
            this.PrintStartFromLabel = new System.Windows.Forms.Label();
            this.DetailPrintSettingPanel = new System.Windows.Forms.Panel();
            this.PrintSettingTabControl = new System.Windows.Forms.TabControl();
            this.LabelPrintSettingsTabPage = new System.Windows.Forms.TabPage();
            this.SaveNewLabelSettingsButton = new System.Windows.Forms.Button();
            this.LabelSettingsTabControl = new System.Windows.Forms.TabControl();
            this.LabelSizeTabPage = new System.Windows.Forms.TabPage();
            this.UnitTypeInfoLabel1 = new System.Windows.Forms.Label();
            this.LabelWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelRowSpaceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelColumnSpaceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelHeightLabel = new System.Windows.Forms.Label();
            this.LabelRowSpaceLabel = new System.Windows.Forms.Label();
            this.LabelColumnSpaceLabel = new System.Windows.Forms.Label();
            this.LabelWidthLabel = new System.Windows.Forms.Label();
            this.LabelMarginsTabPage = new System.Windows.Forms.TabPage();
            this.UnitTypeInfoLabel2 = new System.Windows.Forms.Label();
            this.LabelBottomMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelTopMarginLabel = new System.Windows.Forms.Label();
            this.LabelRightMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelTopMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelRightMarginLabel = new System.Windows.Forms.Label();
            this.LabelLeftMarginLabel = new System.Windows.Forms.Label();
            this.LabelLeftMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelBottomMarginLabel = new System.Windows.Forms.Label();
            this.PrintLabelTypeLabel = new System.Windows.Forms.Label();
            this.PrintLabelTypeTextBox = new System.Windows.Forms.TextBox();
            this.PagePrintSettingsTabPage = new System.Windows.Forms.TabPage();
            this.PaperSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.PaperHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PaperWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PaperHeightLabel = new System.Windows.Forms.Label();
            this.PaperWidthLabel = new System.Windows.Forms.Label();
            this.PageMarginsGroupBox = new System.Windows.Forms.GroupBox();
            this.UnitTypeInfoLabel3 = new System.Windows.Forms.Label();
            this.PageOrientationComboBox = new System.Windows.Forms.ComboBox();
            this.PageBottomMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PageOrientationLabel = new System.Windows.Forms.Label();
            this.PageTopMarginLabel = new System.Windows.Forms.Label();
            this.PageRightMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PageTopMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PageRightMarginLabel = new System.Windows.Forms.Label();
            this.PageLeftMarginLabel = new System.Windows.Forms.Label();
            this.PageLeftMarginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PageBottomMarginLabel = new System.Windows.Forms.Label();
            this.BarcodePrintSettingsTabPage = new System.Windows.Forms.TabPage();
            this.BarcodeSettingsTabControl = new System.Windows.Forms.TabControl();
            this.BarcodeTextTabPage = new System.Windows.Forms.TabPage();
            this.PrcFontStyleLabel = new System.Windows.Forms.Label();
            this.ChangePrcTextFontStyleButton = new System.Windows.Forms.Button();
            this.ShowBottomTextCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowPrcPrnTextCheckBox = new System.Windows.Forms.CheckBox();
            this.PrcPrnTextTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PrcPrnTextTypeLabel = new System.Windows.Forms.Label();
            this.TopTextFontStyleLabel = new System.Windows.Forms.Label();
            this.BottomTextTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BottomTextTypeLabel = new System.Windows.Forms.Label();
            this.TopTextTypeLabel = new System.Windows.Forms.Label();
            this.TopTextTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ShowTopTextCheckBox = new System.Windows.Forms.CheckBox();
            this.ChanteBottomTextFontStyleButton = new System.Windows.Forms.Button();
            this.ChangeTopTextFontStyleButton = new System.Windows.Forms.Button();
            this.BottomTextFontStyleLabel = new System.Windows.Forms.Label();
            this.BarcodeSizeTabPage = new System.Windows.Forms.TabPage();
            this.BarcodeHeightScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BarcodeHeightScaleLabel = new System.Windows.Forms.Label();
            this.BarcodeUnitInfoLabel = new System.Windows.Forms.Label();
            this.BarcodeWidthInfoLabel = new System.Windows.Forms.Label();
            this.BarcodeHeightInfoLabel = new System.Windows.Forms.Label();
            this.BarcodeWidthScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BarcodeWidthScaleLabel = new System.Windows.Forms.Label();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.DeleteCurrentLabelSettingsButton = new System.Windows.Forms.Button();
            this.AddNewLabelSettingsButton = new System.Windows.Forms.Button();
            this.ResetDefaultPrintSettingButton = new System.Windows.Forms.Button();
            this.LoadPrintSettingButton = new System.Windows.Forms.Button();
            this.SaveAsPrintSettingButton = new System.Windows.Forms.Button();
            this.BarcodeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PrintLabelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PrinterComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.RefreshDocumentButton = new System.Windows.Forms.Button();
            this.AddDetailItemsButton = new System.Windows.Forms.Button();
            this.DocumentInfoTextBox = new System.Windows.Forms.TextBox();
            this.DocumentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DocumentKeyComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentDateTimeStatusLabel = new System.Windows.Forms.Label();
            this.OrganizationStatusLabel = new System.Windows.Forms.Label();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.DetailGroupBox.SuspendLayout();
            this.DetailTableLayoutPanel.SuspendLayout();
            this.ItemDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDetailBindingNavigator)).BeginInit();
            this.ItemDetailBindingNavigator.SuspendLayout();
            this.FindItemPanel.SuspendLayout();
            this.AddNewItemToolStrip.SuspendLayout();
            this.FindItemToolStrip.SuspendLayout();
            this.PrintSettingTableLayoutPanel.SuspendLayout();
            this.BarcodePreviewGroupBox.SuspendLayout();
            this.BarcodePreviewPanel.SuspendLayout();
            this.PrintSettingGroupBox.SuspendLayout();
            this.DetailPrintSettingTableLayoutPanel.SuspendLayout();
            this.PrinterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintStartColumnNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintStartRowNumericUpDown)).BeginInit();
            this.DetailPrintSettingPanel.SuspendLayout();
            this.PrintSettingTabControl.SuspendLayout();
            this.LabelPrintSettingsTabPage.SuspendLayout();
            this.LabelSettingsTabControl.SuspendLayout();
            this.LabelSizeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelRowSpaceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelColumnSpaceNumericUpDown)).BeginInit();
            this.LabelMarginsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelBottomMarginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelRightMarginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelTopMarginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelLeftMarginNumericUpDown)).BeginInit();
            this.PagePrintSettingsTabPage.SuspendLayout();
            this.PaperSizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaperHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperWidthNumericUpDown)).BeginInit();
            this.PageMarginsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageBottomMarginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageRightMarginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageTopMarginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageLeftMarginNumericUpDown)).BeginInit();
            this.BarcodePrintSettingsTabPage.SuspendLayout();
            this.BarcodeSettingsTabControl.SuspendLayout();
            this.BarcodeTextTabPage.SuspendLayout();
            this.BarcodeSizeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeHeightScaleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeWidthScaleNumericUpDown)).BeginInit();
            this.ConfigPanel.SuspendLayout();
            this.SearchTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputPrintDocument
            // 
            this.OutputPrintDocument.DocumentName = "";
            // 
            // BarcodeTextFontDialog
            // 
            this.BarcodeTextFontDialog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTextFontDialog.FontMustExist = true;
            // 
            // StatusTimer
            // 
            this.StatusTimer.Interval = 1000;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.AllowMerge = false;
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 598);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1354, 22);
            this.MainStatusStrip.TabIndex = 3;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.cmbSize);
            this.Panel3.Controls.Add(this.Label8);
            this.Panel3.Controls.Add(this.cmbWarna);
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Controls.Add(this.cmbStyle);
            this.Panel3.Controls.Add(this.Label7);
            this.Panel3.Controls.Add(this.cmbMerk);
            this.Panel3.Controls.Add(this.txtQty);
            this.Panel3.Controls.Add(this.Label6);
            this.Panel3.Controls.Add(this.Label5);
            this.Panel3.Controls.Add(this.Label4);
            this.Panel3.Enabled = false;
            this.Panel3.Location = new System.Drawing.Point(12, 107);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(336, 124);
            this.Panel3.TabIndex = 2;
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownHeight = 75;
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.IntegralHeight = false;
            this.cmbSize.Location = new System.Drawing.Point(57, 93);
            this.cmbSize.MaxDropDownItems = 5;
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(136, 21);
            this.cmbSize.TabIndex = 3;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(199, 96);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(23, 13);
            this.Label8.TabIndex = 196;
            this.Label8.Text = "Qty";
            // 
            // cmbWarna
            // 
            this.cmbWarna.DropDownHeight = 75;
            this.cmbWarna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarna.IntegralHeight = false;
            this.cmbWarna.Location = new System.Drawing.Point(57, 67);
            this.cmbWarna.MaxDropDownItems = 5;
            this.cmbWarna.Name = "cmbWarna";
            this.cmbWarna.Size = new System.Drawing.Size(256, 21);
            this.cmbWarna.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(289, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(24, 13);
            this.Label3.TabIndex = 185;
            this.Label3.Text = "psg";
            // 
            // cmbStyle
            // 
            this.cmbStyle.DropDownHeight = 75;
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.IntegralHeight = false;
            this.cmbStyle.Location = new System.Drawing.Point(57, 41);
            this.cmbStyle.MaxDropDownItems = 5;
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(256, 21);
            this.cmbStyle.TabIndex = 1;
            this.cmbStyle.SelectedValueChanged += new System.EventHandler(this.cmbStyle_EditValueChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(11, 96);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(42, 13);
            this.Label7.TabIndex = 194;
            this.Label7.Text = "Ukuran";
            // 
            // cmbMerk
            // 
            this.cmbMerk.DropDownHeight = 75;
            this.cmbMerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMerk.IntegralHeight = false;
            this.cmbMerk.Location = new System.Drawing.Point(57, 15);
            this.cmbMerk.MaxDropDownItems = 5;
            this.cmbMerk.Name = "cmbMerk";
            this.cmbMerk.Size = new System.Drawing.Size(256, 21);
            this.cmbMerk.TabIndex = 0;
            this.cmbMerk.SelectedValueChanged += new System.EventHandler(this.cmbMerk_EditValueChanged);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(228, 93);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 20);
            this.txtQty.TabIndex = 4;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(11, 70);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(39, 13);
            this.Label6.TabIndex = 192;
            this.Label6.Text = "Warna";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(11, 44);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(36, 13);
            this.Label5.TabIndex = 190;
            this.Label5.Text = "Artikel";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(11, 18);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(31, 13);
            this.Label4.TabIndex = 188;
            this.Label4.Text = "Merk";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.txtSPKYear);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.txtSPKMid);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.txtSPKNum);
            this.Panel2.Location = new System.Drawing.Point(12, 12);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(336, 63);
            this.Panel2.TabIndex = 0;
            // 
            // txtSPKYear
            // 
            this.txtSPKYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPKYear.Location = new System.Drawing.Point(14, 11);
            this.txtSPKYear.MaxLength = 2;
            this.txtSPKYear.Name = "txtSPKYear";
            this.txtSPKYear.Size = new System.Drawing.Size(55, 38);
            this.txtSPKYear.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(72, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(22, 31);
            this.Label1.TabIndex = 178;
            this.Label1.Text = ".";
            // 
            // txtSPKMid
            // 
            this.txtSPKMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPKMid.Location = new System.Drawing.Point(93, 10);
            this.txtSPKMid.MaxLength = 4;
            this.txtSPKMid.Name = "txtSPKMid";
            this.txtSPKMid.Size = new System.Drawing.Size(100, 38);
            this.txtSPKMid.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(196, 14);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(22, 31);
            this.Label2.TabIndex = 180;
            this.Label2.Text = ".";
            // 
            // txtSPKNum
            // 
            this.txtSPKNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPKNum.Location = new System.Drawing.Point(218, 10);
            this.txtSPKNum.MaxLength = 4;
            this.txtSPKNum.Name = "txtSPKNum";
            this.txtSPKNum.Size = new System.Drawing.Size(100, 38);
            this.txtSPKNum.TabIndex = 2;
            // 
            // btnCetak
            // 
            this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Location = new System.Drawing.Point(12, 237);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(336, 67);
            this.btnCetak.TabIndex = 3;
            this.btnCetak.Text = "CETAK";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // cbRePrint
            // 
            this.cbRePrint.AutoSize = true;
            this.cbRePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRePrint.Location = new System.Drawing.Point(12, 83);
            this.cbRePrint.Name = "cbRePrint";
            this.cbRePrint.Size = new System.Drawing.Size(85, 17);
            this.cbRePrint.TabIndex = 1;
            this.cbRePrint.Text = "Cetak Ulang";
            this.cbRePrint.UseVisualStyleBackColor = true;
            this.cbRePrint.CheckedChanged += new System.EventHandler(this.cbRePrint_CheckedChanged);
            // 
            // btnTutup
            // 
            this.btnTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(12, 310);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(336, 67);
            this.btnTutup.TabIndex = 4;
            this.btnTutup.Text = "TUTUP";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(354, 12);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(766, 321);
            this.dgResult.TabIndex = 5;
            // 
            // BarCodePreview
            // 
            this.BarCodePreview.BarHeight = 52;
            this.BarCodePreview.Location = new System.Drawing.Point(984, 339);
            this.BarCodePreview.Name = "BarCodePreview";
            this.BarCodePreview.Size = new System.Drawing.Size(136, 38);
            this.BarCodePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BarCodePreview.TabIndex = 6;
            this.BarCodePreview.TabStop = false;
            // 
            // DetailGroupBox
            // 
            this.DetailGroupBox.Controls.Add(this.DetailTableLayoutPanel);
            this.DetailGroupBox.Location = new System.Drawing.Point(432, 219);
            this.DetailGroupBox.Name = "DetailGroupBox";
            this.DetailGroupBox.Size = new System.Drawing.Size(910, 392);
            this.DetailGroupBox.TabIndex = 7;
            this.DetailGroupBox.TabStop = false;
            this.DetailGroupBox.Text = "Selected Barcode Number";
            // 
            // DetailTableLayoutPanel
            // 
            this.DetailTableLayoutPanel.ColumnCount = 2;
            this.DetailTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.67567F));
            this.DetailTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.32433F));
            this.DetailTableLayoutPanel.Controls.Add(this.ItemDetailPanel, 0, 0);
            this.DetailTableLayoutPanel.Controls.Add(this.PrintSettingTableLayoutPanel, 1, 0);
            this.DetailTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.DetailTableLayoutPanel.Name = "DetailTableLayoutPanel";
            this.DetailTableLayoutPanel.RowCount = 1;
            this.DetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.DetailTableLayoutPanel.Size = new System.Drawing.Size(904, 373);
            this.DetailTableLayoutPanel.TabIndex = 0;
            // 
            // ItemDetailPanel
            // 
            this.ItemDetailPanel.Controls.Add(this.ItemDetailDataGridView);
            this.ItemDetailPanel.Controls.Add(this.ItemDetailBindingNavigator);
            this.ItemDetailPanel.Controls.Add(this.FindItemPanel);
            this.ItemDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDetailPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemDetailPanel.Name = "ItemDetailPanel";
            this.ItemDetailPanel.Size = new System.Drawing.Size(587, 367);
            this.ItemDetailPanel.TabIndex = 2;
            // 
            // ItemDetailDataGridView
            // 
            this.ItemDetailDataGridView.AllowUserToAddRows = false;
            this.ItemDetailDataGridView.AllowUserToDeleteRows = false;
            this.ItemDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDetailDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCodeDgvColumn,
            this.ItemNameDgvColumn,
            this.ItemBarcodeDgvColumn,
            this.PrintCountDgvColumn,
            this.IsPrintedDgvColumn,
            this.SellPriceDgvColumn});
            this.ItemDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDetailDataGridView.Location = new System.Drawing.Point(0, 52);
            this.ItemDetailDataGridView.Name = "ItemDetailDataGridView";
            this.ItemDetailDataGridView.RowHeadersVisible = false;
            this.ItemDetailDataGridView.Size = new System.Drawing.Size(587, 290);
            this.ItemDetailDataGridView.TabIndex = 0;
            // 
            // ItemCodeDgvColumn
            // 
            this.ItemCodeDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemCodeDgvColumn.DataPropertyName = "ItemCode";
            this.ItemCodeDgvColumn.FillWeight = 20F;
            this.ItemCodeDgvColumn.HeaderText = "Item Code";
            this.ItemCodeDgvColumn.Name = "ItemCodeDgvColumn";
            this.ItemCodeDgvColumn.ReadOnly = true;
            this.ItemCodeDgvColumn.Width = 105;
            // 
            // ItemNameDgvColumn
            // 
            this.ItemNameDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemNameDgvColumn.DataPropertyName = "ItemName";
            this.ItemNameDgvColumn.FillWeight = 40F;
            this.ItemNameDgvColumn.HeaderText = "Item Name";
            this.ItemNameDgvColumn.Name = "ItemNameDgvColumn";
            this.ItemNameDgvColumn.ReadOnly = true;
            this.ItemNameDgvColumn.Width = 245;
            // 
            // ItemBarcodeDgvColumn
            // 
            this.ItemBarcodeDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemBarcodeDgvColumn.DataPropertyName = "Barcode";
            this.ItemBarcodeDgvColumn.FillWeight = 20F;
            this.ItemBarcodeDgvColumn.HeaderText = "Barcode";
            this.ItemBarcodeDgvColumn.Name = "ItemBarcodeDgvColumn";
            this.ItemBarcodeDgvColumn.ReadOnly = true;
            this.ItemBarcodeDgvColumn.Width = 105;
            // 
            // PrintCountDgvColumn
            // 
            this.PrintCountDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrintCountDgvColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.PrintCountDgvColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrintCountDgvColumn.FillWeight = 10F;
            this.PrintCountDgvColumn.HeaderText = "Count";
            this.PrintCountDgvColumn.Name = "PrintCountDgvColumn";
            this.PrintCountDgvColumn.Width = 88;
            // 
            // IsPrintedDgvColumn
            // 
            this.IsPrintedDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsPrintedDgvColumn.DataPropertyName = "IsPrinted";
            this.IsPrintedDgvColumn.FillWeight = 5F;
            this.IsPrintedDgvColumn.HeaderText = "Print";
            this.IsPrintedDgvColumn.Name = "IsPrintedDgvColumn";
            this.IsPrintedDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsPrintedDgvColumn.Width = 44;
            // 
            // SellPriceDgvColumn
            // 
            this.SellPriceDgvColumn.DataPropertyName = "SellPrice";
            this.SellPriceDgvColumn.HeaderText = "Sell Price";
            this.SellPriceDgvColumn.Name = "SellPriceDgvColumn";
            this.SellPriceDgvColumn.Visible = false;
            // 
            // ItemDetailBindingNavigator
            // 
            this.ItemDetailBindingNavigator.AddNewItem = null;
            this.ItemDetailBindingNavigator.CountItem = this.ItemDetailBindingNavigatorCountItem;
            this.ItemDetailBindingNavigator.DeleteItem = null;
            this.ItemDetailBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemDetailBindingNavigator.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDetailBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ItemDetailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemDetailBindingNavigatorMoveFirstItem,
            this.ItemDetailBindingNavigatorMovePreviousItem,
            this.ItemDetailBindingNavigatorSeparator1,
            this.ItemDetailBindingNavigatorPositionItem,
            this.ItemDetailBindingNavigatorCountItem,
            this.ItemDetailBindingNavigatorSeparator2,
            this.ItemDetailBindingNavigatorMoveNextItem,
            this.ItemDetailBindingNavigatorMoveLastItem,
            this.ItemDetailBindingNavigatorSeparator3,
            this.ItemSavingToolStripDropDownButton,
            this.ItemCheckingToolStripDropDownButton,
            this.ItemRemovingToolStripDropDownButton,
            this.ResetAllItemsToolStripButton,
            this.toolStripButton1});
            this.ItemDetailBindingNavigator.Location = new System.Drawing.Point(0, 342);
            this.ItemDetailBindingNavigator.MoveFirstItem = this.ItemDetailBindingNavigatorMovePreviousItem;
            this.ItemDetailBindingNavigator.MoveLastItem = this.ItemDetailBindingNavigatorMoveLastItem;
            this.ItemDetailBindingNavigator.MoveNextItem = this.ItemDetailBindingNavigatorMoveNextItem;
            this.ItemDetailBindingNavigator.MovePreviousItem = this.ItemDetailBindingNavigatorMovePreviousItem;
            this.ItemDetailBindingNavigator.Name = "ItemDetailBindingNavigator";
            this.ItemDetailBindingNavigator.PositionItem = this.ItemDetailBindingNavigatorPositionItem;
            this.ItemDetailBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ItemDetailBindingNavigator.Size = new System.Drawing.Size(587, 25);
            this.ItemDetailBindingNavigator.TabIndex = 1;
            // 
            // ItemDetailBindingNavigatorCountItem
            // 
            this.ItemDetailBindingNavigatorCountItem.Name = "ItemDetailBindingNavigatorCountItem";
            this.ItemDetailBindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.ItemDetailBindingNavigatorCountItem.Text = "of {0}";
            this.ItemDetailBindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // ItemDetailBindingNavigatorMoveFirstItem
            // 
            this.ItemDetailBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItemDetailBindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("ItemDetailBindingNavigatorMoveFirstItem.Image")));
            this.ItemDetailBindingNavigatorMoveFirstItem.Name = "ItemDetailBindingNavigatorMoveFirstItem";
            this.ItemDetailBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.ItemDetailBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.ItemDetailBindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // ItemDetailBindingNavigatorMovePreviousItem
            // 
            this.ItemDetailBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItemDetailBindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("ItemDetailBindingNavigatorMovePreviousItem.Image")));
            this.ItemDetailBindingNavigatorMovePreviousItem.Name = "ItemDetailBindingNavigatorMovePreviousItem";
            this.ItemDetailBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.ItemDetailBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.ItemDetailBindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // ItemDetailBindingNavigatorSeparator1
            // 
            this.ItemDetailBindingNavigatorSeparator1.Name = "ItemDetailBindingNavigatorSeparator1";
            this.ItemDetailBindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ItemDetailBindingNavigatorPositionItem
            // 
            this.ItemDetailBindingNavigatorPositionItem.AccessibleName = "Position";
            this.ItemDetailBindingNavigatorPositionItem.AutoSize = false;
            this.ItemDetailBindingNavigatorPositionItem.Name = "ItemDetailBindingNavigatorPositionItem";
            this.ItemDetailBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.ItemDetailBindingNavigatorPositionItem.Text = "0";
            this.ItemDetailBindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // ItemDetailBindingNavigatorSeparator2
            // 
            this.ItemDetailBindingNavigatorSeparator2.Name = "ItemDetailBindingNavigatorSeparator2";
            this.ItemDetailBindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ItemDetailBindingNavigatorMoveNextItem
            // 
            this.ItemDetailBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItemDetailBindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("ItemDetailBindingNavigatorMoveNextItem.Image")));
            this.ItemDetailBindingNavigatorMoveNextItem.Name = "ItemDetailBindingNavigatorMoveNextItem";
            this.ItemDetailBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.ItemDetailBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.ItemDetailBindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // ItemDetailBindingNavigatorMoveLastItem
            // 
            this.ItemDetailBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItemDetailBindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("ItemDetailBindingNavigatorMoveLastItem.Image")));
            this.ItemDetailBindingNavigatorMoveLastItem.Name = "ItemDetailBindingNavigatorMoveLastItem";
            this.ItemDetailBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.ItemDetailBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.ItemDetailBindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // ItemDetailBindingNavigatorSeparator3
            // 
            this.ItemDetailBindingNavigatorSeparator3.Name = "ItemDetailBindingNavigatorSeparator3";
            this.ItemDetailBindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ItemSavingToolStripDropDownButton
            // 
            this.ItemSavingToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItemSavingToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportItemsToolStripMenuItem,
            this.ImportItemsToolStripMenuItem});
            this.ItemSavingToolStripDropDownButton.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.Excel;
            this.ItemSavingToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItemSavingToolStripDropDownButton.Name = "ItemSavingToolStripDropDownButton";
            this.ItemSavingToolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.ItemSavingToolStripDropDownButton.Text = "Import / Export";
            // 
            // ExportItemsToolStripMenuItem
            // 
            this.ExportItemsToolStripMenuItem.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.Save;
            this.ExportItemsToolStripMenuItem.Name = "ExportItemsToolStripMenuItem";
            this.ExportItemsToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ExportItemsToolStripMenuItem.Text = "Export";
            // 
            // ImportItemsToolStripMenuItem
            // 
            this.ImportItemsToolStripMenuItem.Enabled = false;
            this.ImportItemsToolStripMenuItem.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.FolderOpen;
            this.ImportItemsToolStripMenuItem.Name = "ImportItemsToolStripMenuItem";
            this.ImportItemsToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ImportItemsToolStripMenuItem.Text = "Import";
            // 
            // ItemCheckingToolStripDropDownButton
            // 
            this.ItemCheckingToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItemCheckingToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckAllItemsToolStripMenuItem,
            this.ClearAllItemChecksToolStripMenuItem});
            this.ItemCheckingToolStripDropDownButton.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.CheckMark;
            this.ItemCheckingToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItemCheckingToolStripDropDownButton.Name = "ItemCheckingToolStripDropDownButton";
            this.ItemCheckingToolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.ItemCheckingToolStripDropDownButton.Text = "Check Mark";
            // 
            // CheckAllItemsToolStripMenuItem
            // 
            this.CheckAllItemsToolStripMenuItem.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.CheckMark;
            this.CheckAllItemsToolStripMenuItem.Name = "CheckAllItemsToolStripMenuItem";
            this.CheckAllItemsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.CheckAllItemsToolStripMenuItem.Text = "Check All";
            // 
            // ClearAllItemChecksToolStripMenuItem
            // 
            this.ClearAllItemChecksToolStripMenuItem.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.Undo;
            this.ClearAllItemChecksToolStripMenuItem.Name = "ClearAllItemChecksToolStripMenuItem";
            this.ClearAllItemChecksToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ClearAllItemChecksToolStripMenuItem.Text = "Clear All Check";
            // 
            // ItemRemovingToolStripDropDownButton
            // 
            this.ItemRemovingToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItemRemovingToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveAllItemsToolStripMenuItem,
            this.RemoveSelectedItemsToolStripMenuItem});
            this.ItemRemovingToolStripDropDownButton.Enabled = false;
            this.ItemRemovingToolStripDropDownButton.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.DeleteItem;
            this.ItemRemovingToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItemRemovingToolStripDropDownButton.Name = "ItemRemovingToolStripDropDownButton";
            this.ItemRemovingToolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.ItemRemovingToolStripDropDownButton.Text = "Remove Item";
            // 
            // RemoveAllItemsToolStripMenuItem
            // 
            this.RemoveAllItemsToolStripMenuItem.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.DeleteAll;
            this.RemoveAllItemsToolStripMenuItem.Name = "RemoveAllItemsToolStripMenuItem";
            this.RemoveAllItemsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.RemoveAllItemsToolStripMenuItem.Text = "Remove All Items";
            // 
            // RemoveSelectedItemsToolStripMenuItem
            // 
            this.RemoveSelectedItemsToolStripMenuItem.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.DeleteItem;
            this.RemoveSelectedItemsToolStripMenuItem.Name = "RemoveSelectedItemsToolStripMenuItem";
            this.RemoveSelectedItemsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.RemoveSelectedItemsToolStripMenuItem.Text = "Remove Selected Item(s)";
            // 
            // ResetAllItemsToolStripButton
            // 
            this.ResetAllItemsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResetAllItemsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetAllItemsToolStripButton.Name = "ResetAllItemsToolStripButton";
            this.ResetAllItemsToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.ResetAllItemsToolStripButton.Text = "Default";
            this.ResetAllItemsToolStripButton.ToolTipText = "Reset to default";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // FindItemPanel
            // 
            this.FindItemPanel.Controls.Add(this.AddNewItemToolStrip);
            this.FindItemPanel.Controls.Add(this.FindItemToolStrip);
            this.FindItemPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FindItemPanel.Location = new System.Drawing.Point(0, 0);
            this.FindItemPanel.Name = "FindItemPanel";
            this.FindItemPanel.Size = new System.Drawing.Size(587, 52);
            this.FindItemPanel.TabIndex = 2;
            // 
            // AddNewItemToolStrip
            // 
            this.AddNewItemToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.AddNewItemToolStrip.Enabled = false;
            this.AddNewItemToolStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewItemToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.AddNewItemToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItemCodeToolStripTextBox,
            this.NewItemNameToolStripTextBox,
            this.NewBarcodeToolStripTextBox,
            this.NewPrintCountToolStripTextBox,
            this.AddNewItemToolStripButton});
            this.AddNewItemToolStrip.Location = new System.Drawing.Point(0, 25);
            this.AddNewItemToolStrip.Name = "AddNewItemToolStrip";
            this.AddNewItemToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.AddNewItemToolStrip.Size = new System.Drawing.Size(587, 25);
            this.AddNewItemToolStrip.TabIndex = 12;
            // 
            // NewItemCodeToolStripTextBox
            // 
            this.NewItemCodeToolStripTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewItemCodeToolStripTextBox.Name = "NewItemCodeToolStripTextBox";
            this.NewItemCodeToolStripTextBox.Size = new System.Drawing.Size(105, 25);
            // 
            // NewItemNameToolStripTextBox
            // 
            this.NewItemNameToolStripTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewItemNameToolStripTextBox.Name = "NewItemNameToolStripTextBox";
            this.NewItemNameToolStripTextBox.Size = new System.Drawing.Size(243, 25);
            // 
            // NewBarcodeToolStripTextBox
            // 
            this.NewBarcodeToolStripTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBarcodeToolStripTextBox.Name = "NewBarcodeToolStripTextBox";
            this.NewBarcodeToolStripTextBox.Size = new System.Drawing.Size(103, 25);
            // 
            // NewPrintCountToolStripTextBox
            // 
            this.NewPrintCountToolStripTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPrintCountToolStripTextBox.Name = "NewPrintCountToolStripTextBox";
            this.NewPrintCountToolStripTextBox.Size = new System.Drawing.Size(86, 25);
            this.NewPrintCountToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddNewItemToolStripButton
            // 
            this.AddNewItemToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNewItemToolStripButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewItemToolStripButton.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.AddNewItem;
            this.AddNewItemToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNewItemToolStripButton.Name = "AddNewItemToolStripButton";
            this.AddNewItemToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AddNewItemToolStripButton.Text = "Add New Item";
            // 
            // FindItemToolStrip
            // 
            this.FindItemToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.FindItemToolStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindItemToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.FindItemToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindItemColumnTypeToolStripLabel,
            this.FindItemColumnTypeToolStripComboBox,
            this.FindItemTextToolStripLabel,
            this.FindItemTextToolStripTextBox,
            this.FindNextToolStripButton});
            this.FindItemToolStrip.Location = new System.Drawing.Point(0, 0);
            this.FindItemToolStrip.Name = "FindItemToolStrip";
            this.FindItemToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.FindItemToolStrip.Size = new System.Drawing.Size(587, 25);
            this.FindItemToolStrip.TabIndex = 11;
            // 
            // FindItemColumnTypeToolStripLabel
            // 
            this.FindItemColumnTypeToolStripLabel.Name = "FindItemColumnTypeToolStripLabel";
            this.FindItemColumnTypeToolStripLabel.Size = new System.Drawing.Size(27, 22);
            this.FindItemColumnTypeToolStripLabel.Text = "Find";
            // 
            // FindItemColumnTypeToolStripComboBox
            // 
            this.FindItemColumnTypeToolStripComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FindItemColumnTypeToolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FindItemColumnTypeToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FindItemColumnTypeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FindItemColumnTypeToolStripComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindItemColumnTypeToolStripComboBox.Name = "FindItemColumnTypeToolStripComboBox";
            this.FindItemColumnTypeToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // FindItemTextToolStripLabel
            // 
            this.FindItemTextToolStripLabel.Name = "FindItemTextToolStripLabel";
            this.FindItemTextToolStripLabel.Size = new System.Drawing.Size(33, 22);
            this.FindItemTextToolStripLabel.Text = "Equal";
            // 
            // FindItemTextToolStripTextBox
            // 
            this.FindItemTextToolStripTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindItemTextToolStripTextBox.Name = "FindItemTextToolStripTextBox";
            this.FindItemTextToolStripTextBox.Size = new System.Drawing.Size(150, 25);
            this.FindItemTextToolStripTextBox.ToolTipText = "Use * for Find Like (default is Find Equal without using *)\r\nEx: asd* -> find tex" +
    "t that starts with asd\r\n      *sdf  -> find text that ends with sdf\r\n      *sd* " +
    "-> find text that contains sd";
            // 
            // FindNextToolStripButton
            // 
            this.FindNextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FindNextToolStripButton.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.Find;
            this.FindNextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindNextToolStripButton.Name = "FindNextToolStripButton";
            this.FindNextToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FindNextToolStripButton.Text = "Find Next";
            // 
            // PrintSettingTableLayoutPanel
            // 
            this.PrintSettingTableLayoutPanel.ColumnCount = 1;
            this.PrintSettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PrintSettingTableLayoutPanel.Controls.Add(this.BarcodePreviewGroupBox, 0, 0);
            this.PrintSettingTableLayoutPanel.Controls.Add(this.PrintSettingGroupBox, 0, 1);
            this.PrintSettingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintSettingTableLayoutPanel.Location = new System.Drawing.Point(596, 3);
            this.PrintSettingTableLayoutPanel.Name = "PrintSettingTableLayoutPanel";
            this.PrintSettingTableLayoutPanel.RowCount = 2;
            this.PrintSettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.98093F));
            this.PrintSettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.01907F));
            this.PrintSettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrintSettingTableLayoutPanel.Size = new System.Drawing.Size(305, 367);
            this.PrintSettingTableLayoutPanel.TabIndex = 0;
            // 
            // BarcodePreviewGroupBox
            // 
            this.BarcodePreviewGroupBox.Controls.Add(this.BarcodePreviewPanel);
            this.BarcodePreviewGroupBox.Controls.Add(this.BarcodeTypeLabel);
            this.BarcodePreviewGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BarcodePreviewGroupBox.Name = "BarcodePreviewGroupBox";
            this.BarcodePreviewGroupBox.Size = new System.Drawing.Size(123, 63);
            this.BarcodePreviewGroupBox.TabIndex = 0;
            this.BarcodePreviewGroupBox.TabStop = false;
            this.BarcodePreviewGroupBox.Text = "Barcode Preview";
            // 
            // BarcodePreviewPanel
            // 
            this.BarcodePreviewPanel.BackColor = System.Drawing.Color.White;
            this.BarcodePreviewPanel.Controls.Add(this.BarcodeMadeFromPreviewLabel);
            this.BarcodePreviewPanel.Controls.Add(this.BarcodeDateTextPreviewLabel);
            this.BarcodePreviewPanel.Controls.Add(this.BarcodeBrandTextPreviewLabel);
            this.BarcodePreviewPanel.Controls.Add(this.BarcodeSizeTextPreviewLabel);
            this.BarcodePreviewPanel.Controls.Add(this.c1BarCode1);
            this.BarcodePreviewPanel.Controls.Add(this.BarcodeColourTextPreviewLabel);
            this.BarcodePreviewPanel.Controls.Add(this.BarcodeStyleTextPreviewLabel);
            this.BarcodePreviewPanel.Controls.Add(this.BarcodeAsTextPreviewLabel);
            this.BarcodePreviewPanel.Location = new System.Drawing.Point(9, 45);
            this.BarcodePreviewPanel.Name = "BarcodePreviewPanel";
            this.BarcodePreviewPanel.Size = new System.Drawing.Size(281, 80);
            this.BarcodePreviewPanel.TabIndex = 5;
            // 
            // BarcodeMadeFromPreviewLabel
            // 
            this.BarcodeMadeFromPreviewLabel.Location = new System.Drawing.Point(172, 67);
            this.BarcodeMadeFromPreviewLabel.Name = "BarcodeMadeFromPreviewLabel";
            this.BarcodeMadeFromPreviewLabel.Size = new System.Drawing.Size(0, 13);
            this.BarcodeMadeFromPreviewLabel.TabIndex = 7;
            // 
            // BarcodeDateTextPreviewLabel
            // 
            this.BarcodeDateTextPreviewLabel.BackColor = System.Drawing.Color.Transparent;
            this.BarcodeDateTextPreviewLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeDateTextPreviewLabel.Location = new System.Drawing.Point(108, 66);
            this.BarcodeDateTextPreviewLabel.Name = "BarcodeDateTextPreviewLabel";
            this.BarcodeDateTextPreviewLabel.Size = new System.Drawing.Size(64, 14);
            this.BarcodeDateTextPreviewLabel.TabIndex = 6;
            this.BarcodeDateTextPreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BarcodeBrandTextPreviewLabel
            // 
            this.BarcodeBrandTextPreviewLabel.AutoSize = true;
            this.BarcodeBrandTextPreviewLabel.BackColor = System.Drawing.Color.Transparent;
            this.BarcodeBrandTextPreviewLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarcodeBrandTextPreviewLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeBrandTextPreviewLabel.Location = new System.Drawing.Point(0, 54);
            this.BarcodeBrandTextPreviewLabel.Name = "BarcodeBrandTextPreviewLabel";
            this.BarcodeBrandTextPreviewLabel.Size = new System.Drawing.Size(0, 13);
            this.BarcodeBrandTextPreviewLabel.TabIndex = 5;
            // 
            // BarcodeSizeTextPreviewLabel
            // 
            this.BarcodeSizeTextPreviewLabel.AutoSize = true;
            this.BarcodeSizeTextPreviewLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarcodeSizeTextPreviewLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeSizeTextPreviewLabel.Location = new System.Drawing.Point(0, 26);
            this.BarcodeSizeTextPreviewLabel.Name = "BarcodeSizeTextPreviewLabel";
            this.BarcodeSizeTextPreviewLabel.Size = new System.Drawing.Size(0, 13);
            this.BarcodeSizeTextPreviewLabel.TabIndex = 4;
            this.BarcodeSizeTextPreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c1BarCode1
            // 
            this.c1BarCode1.BarHeight = 52;
            this.c1BarCode1.Location = new System.Drawing.Point(145, 28);
            this.c1BarCode1.Name = "c1BarCode1";
            this.c1BarCode1.Size = new System.Drawing.Size(136, 38);
            this.c1BarCode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c1BarCode1.TabIndex = 1;
            this.c1BarCode1.TabStop = false;
            // 
            // BarcodeColourTextPreviewLabel
            // 
            this.BarcodeColourTextPreviewLabel.AutoSize = true;
            this.BarcodeColourTextPreviewLabel.BackColor = System.Drawing.Color.White;
            this.BarcodeColourTextPreviewLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarcodeColourTextPreviewLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeColourTextPreviewLabel.Location = new System.Drawing.Point(0, 13);
            this.BarcodeColourTextPreviewLabel.Name = "BarcodeColourTextPreviewLabel";
            this.BarcodeColourTextPreviewLabel.Size = new System.Drawing.Size(0, 13);
            this.BarcodeColourTextPreviewLabel.TabIndex = 0;
            this.BarcodeColourTextPreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarcodeStyleTextPreviewLabel
            // 
            this.BarcodeStyleTextPreviewLabel.AutoSize = true;
            this.BarcodeStyleTextPreviewLabel.BackColor = System.Drawing.Color.White;
            this.BarcodeStyleTextPreviewLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarcodeStyleTextPreviewLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeStyleTextPreviewLabel.Location = new System.Drawing.Point(0, 0);
            this.BarcodeStyleTextPreviewLabel.Name = "BarcodeStyleTextPreviewLabel";
            this.BarcodeStyleTextPreviewLabel.Size = new System.Drawing.Size(0, 13);
            this.BarcodeStyleTextPreviewLabel.TabIndex = 2;
            this.BarcodeStyleTextPreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarcodeAsTextPreviewLabel
            // 
            this.BarcodeAsTextPreviewLabel.AutoSize = true;
            this.BarcodeAsTextPreviewLabel.BackColor = System.Drawing.Color.White;
            this.BarcodeAsTextPreviewLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarcodeAsTextPreviewLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeAsTextPreviewLabel.Location = new System.Drawing.Point(0, 67);
            this.BarcodeAsTextPreviewLabel.Name = "BarcodeAsTextPreviewLabel";
            this.BarcodeAsTextPreviewLabel.Size = new System.Drawing.Size(0, 13);
            this.BarcodeAsTextPreviewLabel.TabIndex = 3;
            this.BarcodeAsTextPreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarcodeTypeLabel
            // 
            this.BarcodeTypeLabel.AutoSize = true;
            this.BarcodeTypeLabel.Location = new System.Drawing.Point(6, 23);
            this.BarcodeTypeLabel.Name = "BarcodeTypeLabel";
            this.BarcodeTypeLabel.Size = new System.Drawing.Size(74, 13);
            this.BarcodeTypeLabel.TabIndex = 0;
            this.BarcodeTypeLabel.Text = "Barcode Type";
            // 
            // PrintSettingGroupBox
            // 
            this.PrintSettingGroupBox.Controls.Add(this.DetailPrintSettingTableLayoutPanel);
            this.PrintSettingGroupBox.Location = new System.Drawing.Point(3, 80);
            this.PrintSettingGroupBox.Name = "PrintSettingGroupBox";
            this.PrintSettingGroupBox.Size = new System.Drawing.Size(298, 254);
            this.PrintSettingGroupBox.TabIndex = 0;
            this.PrintSettingGroupBox.TabStop = false;
            this.PrintSettingGroupBox.Text = "Print Setting";
            // 
            // DetailPrintSettingTableLayoutPanel
            // 
            this.DetailPrintSettingTableLayoutPanel.ColumnCount = 1;
            this.DetailPrintSettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DetailPrintSettingTableLayoutPanel.Controls.Add(this.PrinterPanel, 0, 1);
            this.DetailPrintSettingTableLayoutPanel.Controls.Add(this.DetailPrintSettingPanel, 0, 0);
            this.DetailPrintSettingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailPrintSettingTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.DetailPrintSettingTableLayoutPanel.Name = "DetailPrintSettingTableLayoutPanel";
            this.DetailPrintSettingTableLayoutPanel.RowCount = 2;
            this.DetailPrintSettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.20261F));
            this.DetailPrintSettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.79739F));
            this.DetailPrintSettingTableLayoutPanel.Size = new System.Drawing.Size(292, 235);
            this.DetailPrintSettingTableLayoutPanel.TabIndex = 0;
            // 
            // PrinterPanel
            // 
            this.PrinterPanel.Controls.Add(this.PrintStartColumnNumericUpDown);
            this.PrinterPanel.Controls.Add(this.PrintStartRowNumericUpDown);
            this.PrinterPanel.Controls.Add(this.PrintStartColumnLabel);
            this.PrinterPanel.Controls.Add(this.PrintStartRowLabel);
            this.PrinterPanel.Controls.Add(this.PrintButton);
            this.PrinterPanel.Controls.Add(this.PrinterLabel);
            this.PrinterPanel.Controls.Add(this.PrintStartFromLabel);
            this.PrinterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrinterPanel.Location = new System.Drawing.Point(3, 175);
            this.PrinterPanel.Name = "PrinterPanel";
            this.PrinterPanel.Size = new System.Drawing.Size(286, 57);
            this.PrinterPanel.TabIndex = 0;
            // 
            // PrintStartColumnNumericUpDown
            // 
            this.PrintStartColumnNumericUpDown.Location = new System.Drawing.Point(150, 52);
            this.PrintStartColumnNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrintStartColumnNumericUpDown.Name = "PrintStartColumnNumericUpDown";
            this.PrintStartColumnNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.PrintStartColumnNumericUpDown.TabIndex = 4;
            this.PrintStartColumnNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrintStartColumnNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PrintStartRowNumericUpDown
            // 
            this.PrintStartRowNumericUpDown.Location = new System.Drawing.Point(94, 52);
            this.PrintStartRowNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrintStartRowNumericUpDown.Name = "PrintStartRowNumericUpDown";
            this.PrintStartRowNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.PrintStartRowNumericUpDown.TabIndex = 3;
            this.PrintStartRowNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrintStartRowNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PrintStartColumnLabel
            // 
            this.PrintStartColumnLabel.AutoSize = true;
            this.PrintStartColumnLabel.Location = new System.Drawing.Point(154, 36);
            this.PrintStartColumnLabel.Name = "PrintStartColumnLabel";
            this.PrintStartColumnLabel.Size = new System.Drawing.Size(42, 13);
            this.PrintStartColumnLabel.TabIndex = 7;
            this.PrintStartColumnLabel.Text = "Column";
            // 
            // PrintStartRowLabel
            // 
            this.PrintStartRowLabel.AutoSize = true;
            this.PrintStartRowLabel.Location = new System.Drawing.Point(105, 36);
            this.PrintStartRowLabel.Name = "PrintStartRowLabel";
            this.PrintStartRowLabel.Size = new System.Drawing.Size(29, 13);
            this.PrintStartRowLabel.TabIndex = 6;
            this.PrintStartRowLabel.Text = "Row";
            // 
            // PrintButton
            // 
            this.PrintButton.Image = global::Soltius.RetailExcel.Utils.PrintBarcode.Properties.Resources.Printer;
            this.PrintButton.Location = new System.Drawing.Point(206, 51);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(78, 24);
            this.PrintButton.TabIndex = 5;
            this.PrintButton.Text = "Print";
            this.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // PrinterLabel
            // 
            this.PrinterLabel.AutoSize = true;
            this.PrinterLabel.Location = new System.Drawing.Point(5, 11);
            this.PrinterLabel.Name = "PrinterLabel";
            this.PrinterLabel.Size = new System.Drawing.Size(37, 13);
            this.PrinterLabel.TabIndex = 0;
            this.PrinterLabel.Text = "Printer";
            // 
            // PrintStartFromLabel
            // 
            this.PrintStartFromLabel.AutoSize = true;
            this.PrintStartFromLabel.Location = new System.Drawing.Point(5, 55);
            this.PrintStartFromLabel.Name = "PrintStartFromLabel";
            this.PrintStartFromLabel.Size = new System.Drawing.Size(79, 13);
            this.PrintStartFromLabel.TabIndex = 2;
            this.PrintStartFromLabel.Text = "Print Start From";
            // 
            // DetailPrintSettingPanel
            // 
            this.DetailPrintSettingPanel.Controls.Add(this.PrintSettingTabControl);
            this.DetailPrintSettingPanel.Controls.Add(this.ConfigPanel);
            this.DetailPrintSettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailPrintSettingPanel.Location = new System.Drawing.Point(3, 3);
            this.DetailPrintSettingPanel.Name = "DetailPrintSettingPanel";
            this.DetailPrintSettingPanel.Size = new System.Drawing.Size(286, 166);
            this.DetailPrintSettingPanel.TabIndex = 1;
            // 
            // PrintSettingTabControl
            // 
            this.PrintSettingTabControl.Controls.Add(this.LabelPrintSettingsTabPage);
            this.PrintSettingTabControl.Controls.Add(this.PagePrintSettingsTabPage);
            this.PrintSettingTabControl.Controls.Add(this.BarcodePrintSettingsTabPage);
            this.PrintSettingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintSettingTabControl.Location = new System.Drawing.Point(0, 0);
            this.PrintSettingTabControl.Name = "PrintSettingTabControl";
            this.PrintSettingTabControl.SelectedIndex = 0;
            this.PrintSettingTabControl.Size = new System.Drawing.Size(286, 134);
            this.PrintSettingTabControl.TabIndex = 0;
            // 
            // LabelPrintSettingsTabPage
            // 
            this.LabelPrintSettingsTabPage.Controls.Add(this.SaveNewLabelSettingsButton);
            this.LabelPrintSettingsTabPage.Controls.Add(this.LabelSettingsTabControl);
            this.LabelPrintSettingsTabPage.Controls.Add(this.PrintLabelTypeLabel);
            this.LabelPrintSettingsTabPage.Controls.Add(this.PrintLabelTypeTextBox);
            this.LabelPrintSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.LabelPrintSettingsTabPage.Name = "LabelPrintSettingsTabPage";
            this.LabelPrintSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LabelPrintSettingsTabPage.Size = new System.Drawing.Size(278, 108);
            this.LabelPrintSettingsTabPage.TabIndex = 0;
            this.LabelPrintSettingsTabPage.Text = "Label";
            this.LabelPrintSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveNewLabelSettingsButton
            // 
            this.SaveNewLabelSettingsButton.Location = new System.Drawing.Point(199, 10);
            this.SaveNewLabelSettingsButton.Name = "SaveNewLabelSettingsButton";
            this.SaveNewLabelSettingsButton.Size = new System.Drawing.Size(51, 23);
            this.SaveNewLabelSettingsButton.TabIndex = 3;
            this.SaveNewLabelSettingsButton.Text = "Save";
            this.SaveNewLabelSettingsButton.UseVisualStyleBackColor = true;
            this.SaveNewLabelSettingsButton.Visible = false;
            // 
            // LabelSettingsTabControl
            // 
            this.LabelSettingsTabControl.Controls.Add(this.LabelSizeTabPage);
            this.LabelSettingsTabControl.Controls.Add(this.LabelMarginsTabPage);
            this.LabelSettingsTabControl.Location = new System.Drawing.Point(4, 38);
            this.LabelSettingsTabControl.Name = "LabelSettingsTabControl";
            this.LabelSettingsTabControl.SelectedIndex = 0;
            this.LabelSettingsTabControl.Size = new System.Drawing.Size(273, 136);
            this.LabelSettingsTabControl.TabIndex = 2;
            // 
            // LabelSizeTabPage
            // 
            this.LabelSizeTabPage.Controls.Add(this.UnitTypeInfoLabel1);
            this.LabelSizeTabPage.Controls.Add(this.LabelWidthNumericUpDown);
            this.LabelSizeTabPage.Controls.Add(this.LabelRowSpaceNumericUpDown);
            this.LabelSizeTabPage.Controls.Add(this.LabelHeightNumericUpDown);
            this.LabelSizeTabPage.Controls.Add(this.LabelColumnSpaceNumericUpDown);
            this.LabelSizeTabPage.Controls.Add(this.LabelHeightLabel);
            this.LabelSizeTabPage.Controls.Add(this.LabelRowSpaceLabel);
            this.LabelSizeTabPage.Controls.Add(this.LabelColumnSpaceLabel);
            this.LabelSizeTabPage.Controls.Add(this.LabelWidthLabel);
            this.LabelSizeTabPage.Location = new System.Drawing.Point(4, 22);
            this.LabelSizeTabPage.Name = "LabelSizeTabPage";
            this.LabelSizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LabelSizeTabPage.Size = new System.Drawing.Size(265, 110);
            this.LabelSizeTabPage.TabIndex = 0;
            this.LabelSizeTabPage.Text = "Size";
            this.LabelSizeTabPage.UseVisualStyleBackColor = true;
            // 
            // UnitTypeInfoLabel1
            // 
            this.UnitTypeInfoLabel1.AutoSize = true;
            this.UnitTypeInfoLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnitTypeInfoLabel1.Location = new System.Drawing.Point(190, 94);
            this.UnitTypeInfoLabel1.Name = "UnitTypeInfoLabel1";
            this.UnitTypeInfoLabel1.Size = new System.Drawing.Size(68, 13);
            this.UnitTypeInfoLabel1.TabIndex = 8;
            this.UnitTypeInfoLabel1.Text = "* Unit in Inch";
            // 
            // LabelWidthNumericUpDown
            // 
            this.LabelWidthNumericUpDown.DecimalPlaces = 2;
            this.LabelWidthNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LabelWidthNumericUpDown.Location = new System.Drawing.Point(59, 11);
            this.LabelWidthNumericUpDown.Name = "LabelWidthNumericUpDown";
            this.LabelWidthNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.LabelWidthNumericUpDown.TabIndex = 1;
            this.LabelWidthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelRowSpaceNumericUpDown
            // 
            this.LabelRowSpaceNumericUpDown.DecimalPlaces = 2;
            this.LabelRowSpaceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LabelRowSpaceNumericUpDown.Location = new System.Drawing.Point(136, 68);
            this.LabelRowSpaceNumericUpDown.Name = "LabelRowSpaceNumericUpDown";
            this.LabelRowSpaceNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.LabelRowSpaceNumericUpDown.TabIndex = 7;
            this.LabelRowSpaceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelHeightNumericUpDown
            // 
            this.LabelHeightNumericUpDown.DecimalPlaces = 2;
            this.LabelHeightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LabelHeightNumericUpDown.Location = new System.Drawing.Point(180, 11);
            this.LabelHeightNumericUpDown.Name = "LabelHeightNumericUpDown";
            this.LabelHeightNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.LabelHeightNumericUpDown.TabIndex = 3;
            this.LabelHeightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LabelHeightNumericUpDown.ThousandsSeparator = true;
            // 
            // LabelColumnSpaceNumericUpDown
            // 
            this.LabelColumnSpaceNumericUpDown.DecimalPlaces = 2;
            this.LabelColumnSpaceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LabelColumnSpaceNumericUpDown.Location = new System.Drawing.Point(136, 41);
            this.LabelColumnSpaceNumericUpDown.Name = "LabelColumnSpaceNumericUpDown";
            this.LabelColumnSpaceNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.LabelColumnSpaceNumericUpDown.TabIndex = 5;
            this.LabelColumnSpaceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelHeightLabel
            // 
            this.LabelHeightLabel.AutoSize = true;
            this.LabelHeightLabel.Location = new System.Drawing.Point(133, 13);
            this.LabelHeightLabel.Name = "LabelHeightLabel";
            this.LabelHeightLabel.Size = new System.Drawing.Size(38, 13);
            this.LabelHeightLabel.TabIndex = 2;
            this.LabelHeightLabel.Text = "Height";
            // 
            // LabelRowSpaceLabel
            // 
            this.LabelRowSpaceLabel.AutoSize = true;
            this.LabelRowSpaceLabel.Location = new System.Drawing.Point(12, 70);
            this.LabelRowSpaceLabel.Name = "LabelRowSpaceLabel";
            this.LabelRowSpaceLabel.Size = new System.Drawing.Size(107, 13);
            this.LabelRowSpaceLabel.TabIndex = 6;
            this.LabelRowSpaceLabel.Text = "Space between Row";
            // 
            // LabelColumnSpaceLabel
            // 
            this.LabelColumnSpaceLabel.AutoSize = true;
            this.LabelColumnSpaceLabel.Location = new System.Drawing.Point(12, 43);
            this.LabelColumnSpaceLabel.Name = "LabelColumnSpaceLabel";
            this.LabelColumnSpaceLabel.Size = new System.Drawing.Size(120, 13);
            this.LabelColumnSpaceLabel.TabIndex = 4;
            this.LabelColumnSpaceLabel.Text = "Space between Column";
            // 
            // LabelWidthLabel
            // 
            this.LabelWidthLabel.AutoSize = true;
            this.LabelWidthLabel.Location = new System.Drawing.Point(12, 13);
            this.LabelWidthLabel.Name = "LabelWidthLabel";
            this.LabelWidthLabel.Size = new System.Drawing.Size(35, 13);
            this.LabelWidthLabel.TabIndex = 0;
            this.LabelWidthLabel.Text = "Width";
            // 
            // LabelMarginsTabPage
            // 
            this.LabelMarginsTabPage.Controls.Add(this.UnitTypeInfoLabel2);
            this.LabelMarginsTabPage.Controls.Add(this.LabelBottomMarginNumericUpDown);
            this.LabelMarginsTabPage.Controls.Add(this.LabelTopMarginLabel);
            this.LabelMarginsTabPage.Controls.Add(this.LabelRightMarginNumericUpDown);
            this.LabelMarginsTabPage.Controls.Add(this.LabelTopMarginNumericUpDown);
            this.LabelMarginsTabPage.Controls.Add(this.LabelRightMarginLabel);
            this.LabelMarginsTabPage.Controls.Add(this.LabelLeftMarginLabel);
            this.LabelMarginsTabPage.Controls.Add(this.LabelLeftMarginNumericUpDown);
            this.LabelMarginsTabPage.Controls.Add(this.LabelBottomMarginLabel);
            this.LabelMarginsTabPage.Location = new System.Drawing.Point(4, 22);
            this.LabelMarginsTabPage.Name = "LabelMarginsTabPage";
            this.LabelMarginsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LabelMarginsTabPage.Size = new System.Drawing.Size(265, 110);
            this.LabelMarginsTabPage.TabIndex = 1;
            this.LabelMarginsTabPage.Text = "Margins";
            this.LabelMarginsTabPage.UseVisualStyleBackColor = true;
            // 
            // UnitTypeInfoLabel2
            // 
            this.UnitTypeInfoLabel2.AutoSize = true;
            this.UnitTypeInfoLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnitTypeInfoLabel2.Location = new System.Drawing.Point(174, 94);
            this.UnitTypeInfoLabel2.Name = "UnitTypeInfoLabel2";
            this.UnitTypeInfoLabel2.Size = new System.Drawing.Size(84, 13);
            this.UnitTypeInfoLabel2.TabIndex = 8;
            this.UnitTypeInfoLabel2.Text = "* Unit in Percent";
            // 
            // LabelBottomMarginNumericUpDown
            // 
            this.LabelBottomMarginNumericUpDown.DecimalPlaces = 2;
            this.LabelBottomMarginNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LabelBottomMarginNumericUpDown.Location = new System.Drawing.Point(169, 26);
            this.LabelBottomMarginNumericUpDown.Name = "LabelBottomMarginNumericUpDown";
            this.LabelBottomMarginNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.LabelBottomMarginNumericUpDown.TabIndex = 5;
            this.LabelBottomMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelTopMarginLabel
            // 
            this.LabelTopMarginLabel.AutoSize = true;
            this.LabelTopMarginLabel.Location = new System.Drawing.Point(20, 28);
            this.LabelTopMarginLabel.Name = "LabelTopMarginLabel";
            this.LabelTopMarginLabel.Size = new System.Drawing.Size(26, 13);
            this.LabelTopMarginLabel.TabIndex = 0;
            this.LabelTopMarginLabel.Text = "Top";
            // 
            // LabelRightMarginNumericUpDown
            // 
            this.LabelRightMarginNumericUpDown.DecimalPlaces = 2;
            this.LabelRightMarginNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LabelRightMarginNumericUpDown.Location = new System.Drawing.Point(169, 53);
            this.LabelRightMarginNumericUpDown.Name = "LabelRightMarginNumericUpDown";
            this.LabelRightMarginNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.LabelRightMarginNumericUpDown.TabIndex = 7;
            this.LabelRightMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LabelRightMarginNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // LabelTopMarginNumericUpDown
            // 
            this.LabelTopMarginNumericUpDown.DecimalPlaces = 2;
            this.LabelTopMarginNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LabelTopMarginNumericUpDown.Location = new System.Drawing.Point(51, 26);
            this.LabelTopMarginNumericUpDown.Name = "LabelTopMarginNumericUpDown";
            this.LabelTopMarginNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.LabelTopMarginNumericUpDown.TabIndex = 1;
            this.LabelTopMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelRightMarginLabel
            // 
            this.LabelRightMarginLabel.AutoSize = true;
            this.LabelRightMarginLabel.Location = new System.Drawing.Point(122, 55);
            this.LabelRightMarginLabel.Name = "LabelRightMarginLabel";
            this.LabelRightMarginLabel.Size = new System.Drawing.Size(32, 13);
            this.LabelRightMarginLabel.TabIndex = 6;
            this.LabelRightMarginLabel.Text = "Right";
            // 
            // LabelLeftMarginLabel
            // 
            this.LabelLeftMarginLabel.AutoSize = true;
            this.LabelLeftMarginLabel.Location = new System.Drawing.Point(20, 55);
            this.LabelLeftMarginLabel.Name = "LabelLeftMarginLabel";
            this.LabelLeftMarginLabel.Size = new System.Drawing.Size(25, 13);
            this.LabelLeftMarginLabel.TabIndex = 2;
            this.LabelLeftMarginLabel.Text = "Left";
            // 
            // LabelLeftMarginNumericUpDown
            // 
            this.LabelLeftMarginNumericUpDown.DecimalPlaces = 2;
            this.LabelLeftMarginNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LabelLeftMarginNumericUpDown.Location = new System.Drawing.Point(51, 53);
            this.LabelLeftMarginNumericUpDown.Name = "LabelLeftMarginNumericUpDown";
            this.LabelLeftMarginNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.LabelLeftMarginNumericUpDown.TabIndex = 3;
            this.LabelLeftMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LabelLeftMarginNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // LabelBottomMarginLabel
            // 
            this.LabelBottomMarginLabel.AutoSize = true;
            this.LabelBottomMarginLabel.Location = new System.Drawing.Point(122, 28);
            this.LabelBottomMarginLabel.Name = "LabelBottomMarginLabel";
            this.LabelBottomMarginLabel.Size = new System.Drawing.Size(40, 13);
            this.LabelBottomMarginLabel.TabIndex = 4;
            this.LabelBottomMarginLabel.Text = "Bottom";
            // 
            // PrintLabelTypeLabel
            // 
            this.PrintLabelTypeLabel.AutoSize = true;
            this.PrintLabelTypeLabel.Location = new System.Drawing.Point(6, 14);
            this.PrintLabelTypeLabel.Name = "PrintLabelTypeLabel";
            this.PrintLabelTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.PrintLabelTypeLabel.TabIndex = 0;
            this.PrintLabelTypeLabel.Text = "Type";
            // 
            // PrintLabelTypeTextBox
            // 
            this.PrintLabelTypeTextBox.Location = new System.Drawing.Point(44, 11);
            this.PrintLabelTypeTextBox.Name = "PrintLabelTypeTextBox";
            this.PrintLabelTypeTextBox.Size = new System.Drawing.Size(152, 20);
            this.PrintLabelTypeTextBox.TabIndex = 5;
            this.PrintLabelTypeTextBox.Visible = false;
            // 
            // PagePrintSettingsTabPage
            // 
            this.PagePrintSettingsTabPage.Controls.Add(this.PaperSizeGroupBox);
            this.PagePrintSettingsTabPage.Controls.Add(this.PageMarginsGroupBox);
            this.PagePrintSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.PagePrintSettingsTabPage.Name = "PagePrintSettingsTabPage";
            this.PagePrintSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PagePrintSettingsTabPage.Size = new System.Drawing.Size(278, 108);
            this.PagePrintSettingsTabPage.TabIndex = 2;
            this.PagePrintSettingsTabPage.Text = "Page";
            this.PagePrintSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // PaperSizeGroupBox
            // 
            this.PaperSizeGroupBox.Controls.Add(this.PaperHeightNumericUpDown);
            this.PaperSizeGroupBox.Controls.Add(this.PaperWidthNumericUpDown);
            this.PaperSizeGroupBox.Controls.Add(this.PaperHeightLabel);
            this.PaperSizeGroupBox.Controls.Add(this.PaperWidthLabel);
            this.PaperSizeGroupBox.Location = new System.Drawing.Point(5, 8);
            this.PaperSizeGroupBox.Name = "PaperSizeGroupBox";
            this.PaperSizeGroupBox.Size = new System.Drawing.Size(271, 52);
            this.PaperSizeGroupBox.TabIndex = 0;
            this.PaperSizeGroupBox.TabStop = false;
            this.PaperSizeGroupBox.Text = "Paper Size";
            // 
            // PaperHeightNumericUpDown
            // 
            this.PaperHeightNumericUpDown.DecimalPlaces = 2;
            this.PaperHeightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PaperHeightNumericUpDown.Location = new System.Drawing.Point(178, 21);
            this.PaperHeightNumericUpDown.Name = "PaperHeightNumericUpDown";
            this.PaperHeightNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.PaperHeightNumericUpDown.TabIndex = 3;
            this.PaperHeightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PaperWidthNumericUpDown
            // 
            this.PaperWidthNumericUpDown.DecimalPlaces = 2;
            this.PaperWidthNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PaperWidthNumericUpDown.Location = new System.Drawing.Point(60, 21);
            this.PaperWidthNumericUpDown.Name = "PaperWidthNumericUpDown";
            this.PaperWidthNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.PaperWidthNumericUpDown.TabIndex = 1;
            this.PaperWidthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PaperHeightLabel
            // 
            this.PaperHeightLabel.AutoSize = true;
            this.PaperHeightLabel.Location = new System.Drawing.Point(131, 23);
            this.PaperHeightLabel.Name = "PaperHeightLabel";
            this.PaperHeightLabel.Size = new System.Drawing.Size(38, 13);
            this.PaperHeightLabel.TabIndex = 2;
            this.PaperHeightLabel.Text = "Height";
            // 
            // PaperWidthLabel
            // 
            this.PaperWidthLabel.AutoSize = true;
            this.PaperWidthLabel.Location = new System.Drawing.Point(13, 23);
            this.PaperWidthLabel.Name = "PaperWidthLabel";
            this.PaperWidthLabel.Size = new System.Drawing.Size(35, 13);
            this.PaperWidthLabel.TabIndex = 0;
            this.PaperWidthLabel.Text = "Width";
            // 
            // PageMarginsGroupBox
            // 
            this.PageMarginsGroupBox.Controls.Add(this.UnitTypeInfoLabel3);
            this.PageMarginsGroupBox.Controls.Add(this.PageOrientationComboBox);
            this.PageMarginsGroupBox.Controls.Add(this.PageBottomMarginNumericUpDown);
            this.PageMarginsGroupBox.Controls.Add(this.PageOrientationLabel);
            this.PageMarginsGroupBox.Controls.Add(this.PageTopMarginLabel);
            this.PageMarginsGroupBox.Controls.Add(this.PageRightMarginNumericUpDown);
            this.PageMarginsGroupBox.Controls.Add(this.PageTopMarginNumericUpDown);
            this.PageMarginsGroupBox.Controls.Add(this.PageRightMarginLabel);
            this.PageMarginsGroupBox.Controls.Add(this.PageLeftMarginLabel);
            this.PageMarginsGroupBox.Controls.Add(this.PageLeftMarginNumericUpDown);
            this.PageMarginsGroupBox.Controls.Add(this.PageBottomMarginLabel);
            this.PageMarginsGroupBox.Location = new System.Drawing.Point(5, 64);
            this.PageMarginsGroupBox.Name = "PageMarginsGroupBox";
            this.PageMarginsGroupBox.Size = new System.Drawing.Size(271, 106);
            this.PageMarginsGroupBox.TabIndex = 1;
            this.PageMarginsGroupBox.TabStop = false;
            this.PageMarginsGroupBox.Text = "Margins";
            // 
            // UnitTypeInfoLabel3
            // 
            this.UnitTypeInfoLabel3.AutoSize = true;
            this.UnitTypeInfoLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnitTypeInfoLabel3.Location = new System.Drawing.Point(196, 89);
            this.UnitTypeInfoLabel3.Name = "UnitTypeInfoLabel3";
            this.UnitTypeInfoLabel3.Size = new System.Drawing.Size(68, 13);
            this.UnitTypeInfoLabel3.TabIndex = 14;
            this.UnitTypeInfoLabel3.Text = "* Unit in Inch";
            // 
            // PageOrientationComboBox
            // 
            this.PageOrientationComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PageOrientationComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PageOrientationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PageOrientationComboBox.FormattingEnabled = true;
            this.PageOrientationComboBox.Location = new System.Drawing.Point(83, 77);
            this.PageOrientationComboBox.Name = "PageOrientationComboBox";
            this.PageOrientationComboBox.Size = new System.Drawing.Size(108, 21);
            this.PageOrientationComboBox.TabIndex = 13;
            // 
            // PageBottomMarginNumericUpDown
            // 
            this.PageBottomMarginNumericUpDown.DecimalPlaces = 2;
            this.PageBottomMarginNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PageBottomMarginNumericUpDown.Location = new System.Drawing.Point(165, 20);
            this.PageBottomMarginNumericUpDown.Name = "PageBottomMarginNumericUpDown";
            this.PageBottomMarginNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.PageBottomMarginNumericUpDown.TabIndex = 9;
            this.PageBottomMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PageOrientationLabel
            // 
            this.PageOrientationLabel.AutoSize = true;
            this.PageOrientationLabel.Location = new System.Drawing.Point(16, 80);
            this.PageOrientationLabel.Name = "PageOrientationLabel";
            this.PageOrientationLabel.Size = new System.Drawing.Size(58, 13);
            this.PageOrientationLabel.TabIndex = 12;
            this.PageOrientationLabel.Text = "Orientation";
            // 
            // PageTopMarginLabel
            // 
            this.PageTopMarginLabel.AutoSize = true;
            this.PageTopMarginLabel.Location = new System.Drawing.Point(16, 22);
            this.PageTopMarginLabel.Name = "PageTopMarginLabel";
            this.PageTopMarginLabel.Size = new System.Drawing.Size(26, 13);
            this.PageTopMarginLabel.TabIndex = 4;
            this.PageTopMarginLabel.Text = "Top";
            // 
            // PageRightMarginNumericUpDown
            // 
            this.PageRightMarginNumericUpDown.DecimalPlaces = 2;
            this.PageRightMarginNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PageRightMarginNumericUpDown.Location = new System.Drawing.Point(165, 47);
            this.PageRightMarginNumericUpDown.Name = "PageRightMarginNumericUpDown";
            this.PageRightMarginNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.PageRightMarginNumericUpDown.TabIndex = 11;
            this.PageRightMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PageTopMarginNumericUpDown
            // 
            this.PageTopMarginNumericUpDown.DecimalPlaces = 2;
            this.PageTopMarginNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PageTopMarginNumericUpDown.Location = new System.Drawing.Point(47, 20);
            this.PageTopMarginNumericUpDown.Name = "PageTopMarginNumericUpDown";
            this.PageTopMarginNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.PageTopMarginNumericUpDown.TabIndex = 5;
            this.PageTopMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PageRightMarginLabel
            // 
            this.PageRightMarginLabel.AutoSize = true;
            this.PageRightMarginLabel.Location = new System.Drawing.Point(118, 49);
            this.PageRightMarginLabel.Name = "PageRightMarginLabel";
            this.PageRightMarginLabel.Size = new System.Drawing.Size(32, 13);
            this.PageRightMarginLabel.TabIndex = 10;
            this.PageRightMarginLabel.Text = "Right";
            // 
            // PageLeftMarginLabel
            // 
            this.PageLeftMarginLabel.AutoSize = true;
            this.PageLeftMarginLabel.Location = new System.Drawing.Point(16, 49);
            this.PageLeftMarginLabel.Name = "PageLeftMarginLabel";
            this.PageLeftMarginLabel.Size = new System.Drawing.Size(25, 13);
            this.PageLeftMarginLabel.TabIndex = 6;
            this.PageLeftMarginLabel.Text = "Left";
            // 
            // PageLeftMarginNumericUpDown
            // 
            this.PageLeftMarginNumericUpDown.DecimalPlaces = 2;
            this.PageLeftMarginNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PageLeftMarginNumericUpDown.Location = new System.Drawing.Point(47, 47);
            this.PageLeftMarginNumericUpDown.Name = "PageLeftMarginNumericUpDown";
            this.PageLeftMarginNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.PageLeftMarginNumericUpDown.TabIndex = 7;
            this.PageLeftMarginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PageBottomMarginLabel
            // 
            this.PageBottomMarginLabel.AutoSize = true;
            this.PageBottomMarginLabel.Location = new System.Drawing.Point(118, 22);
            this.PageBottomMarginLabel.Name = "PageBottomMarginLabel";
            this.PageBottomMarginLabel.Size = new System.Drawing.Size(40, 13);
            this.PageBottomMarginLabel.TabIndex = 8;
            this.PageBottomMarginLabel.Text = "Bottom";
            // 
            // BarcodePrintSettingsTabPage
            // 
            this.BarcodePrintSettingsTabPage.Controls.Add(this.BarcodeSettingsTabControl);
            this.BarcodePrintSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.BarcodePrintSettingsTabPage.Name = "BarcodePrintSettingsTabPage";
            this.BarcodePrintSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BarcodePrintSettingsTabPage.Size = new System.Drawing.Size(278, 108);
            this.BarcodePrintSettingsTabPage.TabIndex = 1;
            this.BarcodePrintSettingsTabPage.Text = "Barcode";
            this.BarcodePrintSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // BarcodeSettingsTabControl
            // 
            this.BarcodeSettingsTabControl.Controls.Add(this.BarcodeTextTabPage);
            this.BarcodeSettingsTabControl.Controls.Add(this.BarcodeSizeTabPage);
            this.BarcodeSettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodeSettingsTabControl.Location = new System.Drawing.Point(3, 3);
            this.BarcodeSettingsTabControl.Name = "BarcodeSettingsTabControl";
            this.BarcodeSettingsTabControl.SelectedIndex = 0;
            this.BarcodeSettingsTabControl.Size = new System.Drawing.Size(272, 102);
            this.BarcodeSettingsTabControl.TabIndex = 0;
            // 
            // BarcodeTextTabPage
            // 
            this.BarcodeTextTabPage.Controls.Add(this.PrcFontStyleLabel);
            this.BarcodeTextTabPage.Controls.Add(this.ChangePrcTextFontStyleButton);
            this.BarcodeTextTabPage.Controls.Add(this.ShowBottomTextCheckBox);
            this.BarcodeTextTabPage.Controls.Add(this.ShowPrcPrnTextCheckBox);
            this.BarcodeTextTabPage.Controls.Add(this.PrcPrnTextTypeComboBox);
            this.BarcodeTextTabPage.Controls.Add(this.PrcPrnTextTypeLabel);
            this.BarcodeTextTabPage.Controls.Add(this.TopTextFontStyleLabel);
            this.BarcodeTextTabPage.Controls.Add(this.BottomTextTypeComboBox);
            this.BarcodeTextTabPage.Controls.Add(this.BottomTextTypeLabel);
            this.BarcodeTextTabPage.Controls.Add(this.TopTextTypeLabel);
            this.BarcodeTextTabPage.Controls.Add(this.TopTextTypeComboBox);
            this.BarcodeTextTabPage.Controls.Add(this.ShowTopTextCheckBox);
            this.BarcodeTextTabPage.Controls.Add(this.ChanteBottomTextFontStyleButton);
            this.BarcodeTextTabPage.Controls.Add(this.ChangeTopTextFontStyleButton);
            this.BarcodeTextTabPage.Controls.Add(this.BottomTextFontStyleLabel);
            this.BarcodeTextTabPage.Location = new System.Drawing.Point(4, 22);
            this.BarcodeTextTabPage.Name = "BarcodeTextTabPage";
            this.BarcodeTextTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BarcodeTextTabPage.Size = new System.Drawing.Size(264, 76);
            this.BarcodeTextTabPage.TabIndex = 1;
            this.BarcodeTextTabPage.Text = "Text";
            this.BarcodeTextTabPage.UseVisualStyleBackColor = true;
            // 
            // PrcFontStyleLabel
            // 
            this.PrcFontStyleLabel.AutoSize = true;
            this.PrcFontStyleLabel.Location = new System.Drawing.Point(115, 56);
            this.PrcFontStyleLabel.Name = "PrcFontStyleLabel";
            this.PrcFontStyleLabel.Size = new System.Drawing.Size(101, 13);
            this.PrcFontStyleLabel.TabIndex = 21;
            this.PrcFontStyleLabel.Text = "Courier New, 8.25pt";
            // 
            // ChangePrcTextFontStyleButton
            // 
            this.ChangePrcTextFontStyleButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePrcTextFontStyleButton.Location = new System.Drawing.Point(10, 51);
            this.ChangePrcTextFontStyleButton.Name = "ChangePrcTextFontStyleButton";
            this.ChangePrcTextFontStyleButton.Size = new System.Drawing.Size(99, 23);
            this.ChangePrcTextFontStyleButton.TabIndex = 20;
            this.ChangePrcTextFontStyleButton.Text = "AS Text Font";
            this.ChangePrcTextFontStyleButton.UseVisualStyleBackColor = true;
            // 
            // ShowBottomTextCheckBox
            // 
            this.ShowBottomTextCheckBox.AutoSize = true;
            this.ShowBottomTextCheckBox.Enabled = false;
            this.ShowBottomTextCheckBox.Location = new System.Drawing.Point(216, 102);
            this.ShowBottomTextCheckBox.Name = "ShowBottomTextCheckBox";
            this.ShowBottomTextCheckBox.Size = new System.Drawing.Size(53, 17);
            this.ShowBottomTextCheckBox.TabIndex = 8;
            this.ShowBottomTextCheckBox.Text = "Show";
            this.ShowBottomTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowPrcPrnTextCheckBox
            // 
            this.ShowPrcPrnTextCheckBox.AutoSize = true;
            this.ShowPrcPrnTextCheckBox.Enabled = false;
            this.ShowPrcPrnTextCheckBox.Location = new System.Drawing.Point(216, 125);
            this.ShowPrcPrnTextCheckBox.Name = "ShowPrcPrnTextCheckBox";
            this.ShowPrcPrnTextCheckBox.Size = new System.Drawing.Size(53, 17);
            this.ShowPrcPrnTextCheckBox.TabIndex = 15;
            this.ShowPrcPrnTextCheckBox.Text = "Show";
            this.ShowPrcPrnTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // PrcPrnTextTypeComboBox
            // 
            this.PrcPrnTextTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PrcPrnTextTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PrcPrnTextTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrcPrnTextTypeComboBox.Enabled = false;
            this.PrcPrnTextTypeComboBox.FormattingEnabled = true;
            this.PrcPrnTextTypeComboBox.Location = new System.Drawing.Point(83, 123);
            this.PrcPrnTextTypeComboBox.Name = "PrcPrnTextTypeComboBox";
            this.PrcPrnTextTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.PrcPrnTextTypeComboBox.TabIndex = 17;
            // 
            // PrcPrnTextTypeLabel
            // 
            this.PrcPrnTextTypeLabel.AutoSize = true;
            this.PrcPrnTextTypeLabel.Enabled = false;
            this.PrcPrnTextTypeLabel.Location = new System.Drawing.Point(7, 126);
            this.PrcPrnTextTypeLabel.Name = "PrcPrnTextTypeLabel";
            this.PrcPrnTextTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.PrcPrnTextTypeLabel.TabIndex = 16;
            this.PrcPrnTextTypeLabel.Text = "Prc/Prn Text";
            // 
            // TopTextFontStyleLabel
            // 
            this.TopTextFontStyleLabel.AutoSize = true;
            this.TopTextFontStyleLabel.Location = new System.Drawing.Point(115, 8);
            this.TopTextFontStyleLabel.Name = "TopTextFontStyleLabel";
            this.TopTextFontStyleLabel.Size = new System.Drawing.Size(101, 13);
            this.TopTextFontStyleLabel.TabIndex = 4;
            this.TopTextFontStyleLabel.Text = "Courier New, 8.25pt";
            // 
            // BottomTextTypeComboBox
            // 
            this.BottomTextTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BottomTextTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BottomTextTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BottomTextTypeComboBox.Enabled = false;
            this.BottomTextTypeComboBox.FormattingEnabled = true;
            this.BottomTextTypeComboBox.Location = new System.Drawing.Point(83, 100);
            this.BottomTextTypeComboBox.Name = "BottomTextTypeComboBox";
            this.BottomTextTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.BottomTextTypeComboBox.TabIndex = 12;
            // 
            // BottomTextTypeLabel
            // 
            this.BottomTextTypeLabel.AutoSize = true;
            this.BottomTextTypeLabel.Enabled = false;
            this.BottomTextTypeLabel.Location = new System.Drawing.Point(7, 103);
            this.BottomTextTypeLabel.Name = "BottomTextTypeLabel";
            this.BottomTextTypeLabel.Size = new System.Drawing.Size(64, 13);
            this.BottomTextTypeLabel.TabIndex = 11;
            this.BottomTextTypeLabel.Text = "Bottom Text";
            // 
            // TopTextTypeLabel
            // 
            this.TopTextTypeLabel.AutoSize = true;
            this.TopTextTypeLabel.Enabled = false;
            this.TopTextTypeLabel.Location = new System.Drawing.Point(7, 80);
            this.TopTextTypeLabel.Name = "TopTextTypeLabel";
            this.TopTextTypeLabel.Size = new System.Drawing.Size(50, 13);
            this.TopTextTypeLabel.TabIndex = 9;
            this.TopTextTypeLabel.Text = "Top Text";
            // 
            // TopTextTypeComboBox
            // 
            this.TopTextTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TopTextTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TopTextTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopTextTypeComboBox.Enabled = false;
            this.TopTextTypeComboBox.FormattingEnabled = true;
            this.TopTextTypeComboBox.Location = new System.Drawing.Point(83, 77);
            this.TopTextTypeComboBox.Name = "TopTextTypeComboBox";
            this.TopTextTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TopTextTypeComboBox.TabIndex = 10;
            // 
            // ShowTopTextCheckBox
            // 
            this.ShowTopTextCheckBox.AutoSize = true;
            this.ShowTopTextCheckBox.Enabled = false;
            this.ShowTopTextCheckBox.Location = new System.Drawing.Point(216, 76);
            this.ShowTopTextCheckBox.Name = "ShowTopTextCheckBox";
            this.ShowTopTextCheckBox.Size = new System.Drawing.Size(53, 17);
            this.ShowTopTextCheckBox.TabIndex = 5;
            this.ShowTopTextCheckBox.Text = "Show";
            this.ShowTopTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChanteBottomTextFontStyleButton
            // 
            this.ChanteBottomTextFontStyleButton.Location = new System.Drawing.Point(10, 27);
            this.ChanteBottomTextFontStyleButton.Name = "ChanteBottomTextFontStyleButton";
            this.ChanteBottomTextFontStyleButton.Size = new System.Drawing.Size(99, 23);
            this.ChanteBottomTextFontStyleButton.TabIndex = 6;
            this.ChanteBottomTextFontStyleButton.Text = "Size Text Font";
            this.ChanteBottomTextFontStyleButton.UseVisualStyleBackColor = true;
            // 
            // ChangeTopTextFontStyleButton
            // 
            this.ChangeTopTextFontStyleButton.Location = new System.Drawing.Point(10, 3);
            this.ChangeTopTextFontStyleButton.Name = "ChangeTopTextFontStyleButton";
            this.ChangeTopTextFontStyleButton.Size = new System.Drawing.Size(99, 23);
            this.ChangeTopTextFontStyleButton.TabIndex = 3;
            this.ChangeTopTextFontStyleButton.Text = "Style and Colour  Font";
            this.ChangeTopTextFontStyleButton.UseVisualStyleBackColor = true;
            // 
            // BottomTextFontStyleLabel
            // 
            this.BottomTextFontStyleLabel.AutoSize = true;
            this.BottomTextFontStyleLabel.Location = new System.Drawing.Point(115, 32);
            this.BottomTextFontStyleLabel.Name = "BottomTextFontStyleLabel";
            this.BottomTextFontStyleLabel.Size = new System.Drawing.Size(101, 13);
            this.BottomTextFontStyleLabel.TabIndex = 7;
            this.BottomTextFontStyleLabel.Text = "Courier New, 8.25pt";
            // 
            // BarcodeSizeTabPage
            // 
            this.BarcodeSizeTabPage.Controls.Add(this.BarcodeHeightScaleNumericUpDown);
            this.BarcodeSizeTabPage.Controls.Add(this.BarcodeHeightScaleLabel);
            this.BarcodeSizeTabPage.Controls.Add(this.BarcodeUnitInfoLabel);
            this.BarcodeSizeTabPage.Controls.Add(this.BarcodeWidthInfoLabel);
            this.BarcodeSizeTabPage.Controls.Add(this.BarcodeHeightInfoLabel);
            this.BarcodeSizeTabPage.Controls.Add(this.BarcodeWidthScaleNumericUpDown);
            this.BarcodeSizeTabPage.Controls.Add(this.BarcodeWidthScaleLabel);
            this.BarcodeSizeTabPage.Location = new System.Drawing.Point(4, 22);
            this.BarcodeSizeTabPage.Name = "BarcodeSizeTabPage";
            this.BarcodeSizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BarcodeSizeTabPage.Size = new System.Drawing.Size(264, 76);
            this.BarcodeSizeTabPage.TabIndex = 0;
            this.BarcodeSizeTabPage.Text = "Size";
            this.BarcodeSizeTabPage.UseVisualStyleBackColor = true;
            // 
            // BarcodeHeightScaleNumericUpDown
            // 
            this.BarcodeHeightScaleNumericUpDown.DecimalPlaces = 2;
            this.BarcodeHeightScaleNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.BarcodeHeightScaleNumericUpDown.Location = new System.Drawing.Point(190, 20);
            this.BarcodeHeightScaleNumericUpDown.Name = "BarcodeHeightScaleNumericUpDown";
            this.BarcodeHeightScaleNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.BarcodeHeightScaleNumericUpDown.TabIndex = 3;
            this.BarcodeHeightScaleNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BarcodeHeightScaleNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // BarcodeHeightScaleLabel
            // 
            this.BarcodeHeightScaleLabel.AutoSize = true;
            this.BarcodeHeightScaleLabel.Location = new System.Drawing.Point(136, 22);
            this.BarcodeHeightScaleLabel.Name = "BarcodeHeightScaleLabel";
            this.BarcodeHeightScaleLabel.Size = new System.Drawing.Size(38, 13);
            this.BarcodeHeightScaleLabel.TabIndex = 2;
            this.BarcodeHeightScaleLabel.Text = "Height";
            // 
            // BarcodeUnitInfoLabel
            // 
            this.BarcodeUnitInfoLabel.AutoSize = true;
            this.BarcodeUnitInfoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarcodeUnitInfoLabel.Location = new System.Drawing.Point(177, 56);
            this.BarcodeUnitInfoLabel.Name = "BarcodeUnitInfoLabel";
            this.BarcodeUnitInfoLabel.Size = new System.Drawing.Size(84, 13);
            this.BarcodeUnitInfoLabel.TabIndex = 6;
            this.BarcodeUnitInfoLabel.Text = "* Unit in Percent";
            // 
            // BarcodeWidthInfoLabel
            // 
            this.BarcodeWidthInfoLabel.AutoSize = true;
            this.BarcodeWidthInfoLabel.Location = new System.Drawing.Point(10, 56);
            this.BarcodeWidthInfoLabel.Name = "BarcodeWidthInfoLabel";
            this.BarcodeWidthInfoLabel.Size = new System.Drawing.Size(141, 26);
            this.BarcodeWidthInfoLabel.TabIndex = 4;
            this.BarcodeWidthInfoLabel.Text = "* Barcode Width\r\n   relative from Label margins";
            // 
            // BarcodeHeightInfoLabel
            // 
            this.BarcodeHeightInfoLabel.AutoSize = true;
            this.BarcodeHeightInfoLabel.Location = new System.Drawing.Point(10, 95);
            this.BarcodeHeightInfoLabel.Name = "BarcodeHeightInfoLabel";
            this.BarcodeHeightInfoLabel.Size = new System.Drawing.Size(160, 39);
            this.BarcodeHeightInfoLabel.TabIndex = 5;
            this.BarcodeHeightInfoLabel.Text = "* Barcode Height\r\n   relative from Label margins\r\n   and Top/Bottom Text font siz" +
    "e";
            // 
            // BarcodeWidthScaleNumericUpDown
            // 
            this.BarcodeWidthScaleNumericUpDown.DecimalPlaces = 2;
            this.BarcodeWidthScaleNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.BarcodeWidthScaleNumericUpDown.Location = new System.Drawing.Point(64, 18);
            this.BarcodeWidthScaleNumericUpDown.Name = "BarcodeWidthScaleNumericUpDown";
            this.BarcodeWidthScaleNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.BarcodeWidthScaleNumericUpDown.TabIndex = 1;
            this.BarcodeWidthScaleNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BarcodeWidthScaleNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // BarcodeWidthScaleLabel
            // 
            this.BarcodeWidthScaleLabel.AutoSize = true;
            this.BarcodeWidthScaleLabel.Location = new System.Drawing.Point(10, 20);
            this.BarcodeWidthScaleLabel.Name = "BarcodeWidthScaleLabel";
            this.BarcodeWidthScaleLabel.Size = new System.Drawing.Size(35, 13);
            this.BarcodeWidthScaleLabel.TabIndex = 0;
            this.BarcodeWidthScaleLabel.Text = "Width";
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.Controls.Add(this.DeleteCurrentLabelSettingsButton);
            this.ConfigPanel.Controls.Add(this.AddNewLabelSettingsButton);
            this.ConfigPanel.Controls.Add(this.ResetDefaultPrintSettingButton);
            this.ConfigPanel.Controls.Add(this.LoadPrintSettingButton);
            this.ConfigPanel.Controls.Add(this.SaveAsPrintSettingButton);
            this.ConfigPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConfigPanel.Location = new System.Drawing.Point(0, 134);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(286, 32);
            this.ConfigPanel.TabIndex = 1;
            // 
            // DeleteCurrentLabelSettingsButton
            // 
            this.DeleteCurrentLabelSettingsButton.Location = new System.Drawing.Point(232, 6);
            this.DeleteCurrentLabelSettingsButton.Name = "DeleteCurrentLabelSettingsButton";
            this.DeleteCurrentLabelSettingsButton.Size = new System.Drawing.Size(51, 23);
            this.DeleteCurrentLabelSettingsButton.TabIndex = 4;
            this.DeleteCurrentLabelSettingsButton.Text = "Delete";
            this.DeleteCurrentLabelSettingsButton.UseVisualStyleBackColor = true;
            // 
            // AddNewLabelSettingsButton
            // 
            this.AddNewLabelSettingsButton.Location = new System.Drawing.Point(171, 6);
            this.AddNewLabelSettingsButton.Name = "AddNewLabelSettingsButton";
            this.AddNewLabelSettingsButton.Size = new System.Drawing.Size(58, 23);
            this.AddNewLabelSettingsButton.TabIndex = 3;
            this.AddNewLabelSettingsButton.Text = "Add New";
            this.AddNewLabelSettingsButton.UseVisualStyleBackColor = true;
            // 
            // ResetDefaultPrintSettingButton
            // 
            this.ResetDefaultPrintSettingButton.Location = new System.Drawing.Point(118, 6);
            this.ResetDefaultPrintSettingButton.Name = "ResetDefaultPrintSettingButton";
            this.ResetDefaultPrintSettingButton.Size = new System.Drawing.Size(50, 23);
            this.ResetDefaultPrintSettingButton.TabIndex = 2;
            this.ResetDefaultPrintSettingButton.Text = "Default";
            this.ResetDefaultPrintSettingButton.UseVisualStyleBackColor = true;
            // 
            // LoadPrintSettingButton
            // 
            this.LoadPrintSettingButton.Location = new System.Drawing.Point(63, 6);
            this.LoadPrintSettingButton.Name = "LoadPrintSettingButton";
            this.LoadPrintSettingButton.Size = new System.Drawing.Size(51, 23);
            this.LoadPrintSettingButton.TabIndex = 1;
            this.LoadPrintSettingButton.Text = "Load";
            this.LoadPrintSettingButton.UseVisualStyleBackColor = true;
            // 
            // SaveAsPrintSettingButton
            // 
            this.SaveAsPrintSettingButton.Location = new System.Drawing.Point(6, 6);
            this.SaveAsPrintSettingButton.Name = "SaveAsPrintSettingButton";
            this.SaveAsPrintSettingButton.Size = new System.Drawing.Size(54, 23);
            this.SaveAsPrintSettingButton.TabIndex = 0;
            this.SaveAsPrintSettingButton.Text = "Save As";
            this.SaveAsPrintSettingButton.UseVisualStyleBackColor = true;
            // 
            // BarcodeTypeComboBox
            // 
            this.BarcodeTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BarcodeTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BarcodeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BarcodeTypeComboBox.FormattingEnabled = true;
            this.BarcodeTypeComboBox.Location = new System.Drawing.Point(512, 410);
            this.BarcodeTypeComboBox.Name = "BarcodeTypeComboBox";
            this.BarcodeTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.BarcodeTypeComboBox.TabIndex = 1;
            // 
            // PrintLabelTypeComboBox
            // 
            this.PrintLabelTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PrintLabelTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PrintLabelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrintLabelTypeComboBox.FormattingEnabled = true;
            this.PrintLabelTypeComboBox.Location = new System.Drawing.Point(512, 485);
            this.PrintLabelTypeComboBox.Name = "PrintLabelTypeComboBox";
            this.PrintLabelTypeComboBox.Size = new System.Drawing.Size(152, 21);
            this.PrintLabelTypeComboBox.TabIndex = 1;
            // 
            // PrinterComboBox
            // 
            this.PrinterComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PrinterComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PrinterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrinterComboBox.FormattingEnabled = true;
            this.PrinterComboBox.Location = new System.Drawing.Point(367, 340);
            this.PrinterComboBox.Name = "PrinterComboBox";
            this.PrinterComboBox.Size = new System.Drawing.Size(236, 21);
            this.PrinterComboBox.TabIndex = 1;
            // 
            // SearchTypeGroupBox
            // 
            this.SearchTypeGroupBox.Controls.Add(this.RefreshDocumentButton);
            this.SearchTypeGroupBox.Controls.Add(this.AddDetailItemsButton);
            this.SearchTypeGroupBox.Controls.Add(this.DocumentInfoTextBox);
            this.SearchTypeGroupBox.Controls.Add(this.DocumentTypeComboBox);
            this.SearchTypeGroupBox.Location = new System.Drawing.Point(452, 557);
            this.SearchTypeGroupBox.Name = "SearchTypeGroupBox";
            this.SearchTypeGroupBox.Size = new System.Drawing.Size(229, 10);
            this.SearchTypeGroupBox.TabIndex = 8;
            this.SearchTypeGroupBox.TabStop = false;
            this.SearchTypeGroupBox.Text = "Search By";
            // 
            // RefreshDocumentButton
            // 
            this.RefreshDocumentButton.Location = new System.Drawing.Point(315, 20);
            this.RefreshDocumentButton.Name = "RefreshDocumentButton";
            this.RefreshDocumentButton.Size = new System.Drawing.Size(71, 23);
            this.RefreshDocumentButton.TabIndex = 2;
            this.RefreshDocumentButton.Text = "Refresh";
            this.RefreshDocumentButton.UseVisualStyleBackColor = true;
            // 
            // AddDetailItemsButton
            // 
            this.AddDetailItemsButton.Location = new System.Drawing.Point(392, 20);
            this.AddDetailItemsButton.Name = "AddDetailItemsButton";
            this.AddDetailItemsButton.Size = new System.Drawing.Size(75, 23);
            this.AddDetailItemsButton.TabIndex = 3;
            this.AddDetailItemsButton.Text = "Add Items";
            this.AddDetailItemsButton.UseVisualStyleBackColor = true;
            // 
            // DocumentInfoTextBox
            // 
            this.DocumentInfoTextBox.Location = new System.Drawing.Point(9, 49);
            this.DocumentInfoTextBox.Multiline = true;
            this.DocumentInfoTextBox.Name = "DocumentInfoTextBox";
            this.DocumentInfoTextBox.ReadOnly = true;
            this.DocumentInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DocumentInfoTextBox.Size = new System.Drawing.Size(458, 74);
            this.DocumentInfoTextBox.TabIndex = 4;
            // 
            // DocumentTypeComboBox
            // 
            this.DocumentTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DocumentTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeComboBox.FormattingEnabled = true;
            this.DocumentTypeComboBox.Location = new System.Drawing.Point(9, 20);
            this.DocumentTypeComboBox.Name = "DocumentTypeComboBox";
            this.DocumentTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.DocumentTypeComboBox.TabIndex = 0;
            // 
            // DocumentKeyComboBox
            // 
            this.DocumentKeyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DocumentKeyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DocumentKeyComboBox.FormattingEnabled = true;
            this.DocumentKeyComboBox.Location = new System.Drawing.Point(489, 575);
            this.DocumentKeyComboBox.Name = "DocumentKeyComboBox";
            this.DocumentKeyComboBox.Size = new System.Drawing.Size(173, 21);
            this.DocumentKeyComboBox.TabIndex = 1;
            // 
            // CurrentDateTimeStatusLabel
            // 
            this.CurrentDateTimeStatusLabel.AutoSize = true;
            this.CurrentDateTimeStatusLabel.Location = new System.Drawing.Point(547, 459);
            this.CurrentDateTimeStatusLabel.Name = "CurrentDateTimeStatusLabel";
            this.CurrentDateTimeStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.CurrentDateTimeStatusLabel.TabIndex = 9;
            this.CurrentDateTimeStatusLabel.Text = "label9";
            // 
            // OrganizationStatusLabel
            // 
            this.OrganizationStatusLabel.AutoSize = true;
            this.OrganizationStatusLabel.Location = new System.Drawing.Point(486, 508);
            this.OrganizationStatusLabel.Name = "OrganizationStatusLabel";
            this.OrganizationStatusLabel.Size = new System.Drawing.Size(41, 13);
            this.OrganizationStatusLabel.TabIndex = 10;
            this.OrganizationStatusLabel.Text = "label10";
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 620);
            this.Controls.Add(this.OrganizationStatusLabel);
            this.Controls.Add(this.CurrentDateTimeStatusLabel);
            this.Controls.Add(this.PrintLabelTypeComboBox);
            this.Controls.Add(this.BarcodeTypeComboBox);
            this.Controls.Add(this.DetailGroupBox);
            this.Controls.Add(this.DocumentKeyComboBox);
            this.Controls.Add(this.SearchTypeGroupBox);
            this.Controls.Add(this.BarCodePreview);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.PrinterComboBox);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.cbRePrint);
            this.Controls.Add(this.MainStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BARCODE PRINTING SYSTEM";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.DetailGroupBox.ResumeLayout(false);
            this.DetailTableLayoutPanel.ResumeLayout(false);
            this.ItemDetailPanel.ResumeLayout(false);
            this.ItemDetailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDetailBindingNavigator)).EndInit();
            this.ItemDetailBindingNavigator.ResumeLayout(false);
            this.ItemDetailBindingNavigator.PerformLayout();
            this.FindItemPanel.ResumeLayout(false);
            this.FindItemPanel.PerformLayout();
            this.AddNewItemToolStrip.ResumeLayout(false);
            this.AddNewItemToolStrip.PerformLayout();
            this.FindItemToolStrip.ResumeLayout(false);
            this.FindItemToolStrip.PerformLayout();
            this.PrintSettingTableLayoutPanel.ResumeLayout(false);
            this.BarcodePreviewGroupBox.ResumeLayout(false);
            this.BarcodePreviewGroupBox.PerformLayout();
            this.BarcodePreviewPanel.ResumeLayout(false);
            this.BarcodePreviewPanel.PerformLayout();
            this.PrintSettingGroupBox.ResumeLayout(false);
            this.DetailPrintSettingTableLayoutPanel.ResumeLayout(false);
            this.PrinterPanel.ResumeLayout(false);
            this.PrinterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintStartColumnNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintStartRowNumericUpDown)).EndInit();
            this.DetailPrintSettingPanel.ResumeLayout(false);
            this.PrintSettingTabControl.ResumeLayout(false);
            this.LabelPrintSettingsTabPage.ResumeLayout(false);
            this.LabelPrintSettingsTabPage.PerformLayout();
            this.LabelSettingsTabControl.ResumeLayout(false);
            this.LabelSizeTabPage.ResumeLayout(false);
            this.LabelSizeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelRowSpaceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelColumnSpaceNumericUpDown)).EndInit();
            this.LabelMarginsTabPage.ResumeLayout(false);
            this.LabelMarginsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelBottomMarginNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelRightMarginNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelTopMarginNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelLeftMarginNumericUpDown)).EndInit();
            this.PagePrintSettingsTabPage.ResumeLayout(false);
            this.PaperSizeGroupBox.ResumeLayout(false);
            this.PaperSizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaperHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperWidthNumericUpDown)).EndInit();
            this.PageMarginsGroupBox.ResumeLayout(false);
            this.PageMarginsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageBottomMarginNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageRightMarginNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageTopMarginNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageLeftMarginNumericUpDown)).EndInit();
            this.BarcodePrintSettingsTabPage.ResumeLayout(false);
            this.BarcodeSettingsTabControl.ResumeLayout(false);
            this.BarcodeTextTabPage.ResumeLayout(false);
            this.BarcodeTextTabPage.PerformLayout();
            this.BarcodeSizeTabPage.ResumeLayout(false);
            this.BarcodeSizeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeHeightScaleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeWidthScaleNumericUpDown)).EndInit();
            this.ConfigPanel.ResumeLayout(false);
            this.SearchTypeGroupBox.ResumeLayout(false);
            this.SearchTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument OutputPrintDocument;
        private System.Windows.Forms.FontDialog BarcodeTextFontDialog;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox txtSPKYear;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSPKMid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtSPKNum;
        internal System.Windows.Forms.Button btnCetak;
        internal System.Windows.Forms.CheckBox cbRePrint;
        internal System.Windows.Forms.ComboBox cmbSize;
        internal System.Windows.Forms.ComboBox cmbWarna;
        internal System.Windows.Forms.ComboBox cmbStyle;
        internal System.Windows.Forms.ComboBox cmbMerk;
        internal System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.DataGridView dgResult;
        private C1.Win.C1BarCode.C1BarCode BarCodePreview;
        private System.Windows.Forms.GroupBox DetailGroupBox;
        private System.Windows.Forms.TableLayoutPanel DetailTableLayoutPanel;
        private System.Windows.Forms.Panel ItemDetailPanel;
        private System.Windows.Forms.DataGridView ItemDetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCodeDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemBarcodeDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintCountDgvColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPrintedDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPriceDgvColumn;
        private System.Windows.Forms.Panel FindItemPanel;
        private System.Windows.Forms.TableLayoutPanel PrintSettingTableLayoutPanel;
        private System.Windows.Forms.GroupBox BarcodePreviewGroupBox;
        private System.Windows.Forms.Panel BarcodePreviewPanel;
        private System.Windows.Forms.Label BarcodeMadeFromPreviewLabel;
        private System.Windows.Forms.Label BarcodeDateTextPreviewLabel;
        private System.Windows.Forms.Label BarcodeBrandTextPreviewLabel;
        private System.Windows.Forms.Label BarcodeSizeTextPreviewLabel;
        private C1.Win.C1BarCode.C1BarCode c1BarCode1;
        private System.Windows.Forms.Label BarcodeColourTextPreviewLabel;
        private System.Windows.Forms.Label BarcodeStyleTextPreviewLabel;
        private System.Windows.Forms.Label BarcodeAsTextPreviewLabel;
        private System.Windows.Forms.Label BarcodeTypeLabel;
        private System.Windows.Forms.ComboBox BarcodeTypeComboBox;
        private System.Windows.Forms.GroupBox PrintSettingGroupBox;
        private System.Windows.Forms.TableLayoutPanel DetailPrintSettingTableLayoutPanel;
        private System.Windows.Forms.Panel PrinterPanel;
        private System.Windows.Forms.NumericUpDown PrintStartColumnNumericUpDown;
        private System.Windows.Forms.NumericUpDown PrintStartRowNumericUpDown;
        private System.Windows.Forms.Label PrintStartColumnLabel;
        private System.Windows.Forms.Label PrintStartRowLabel;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label PrinterLabel;
        private System.Windows.Forms.ComboBox PrinterComboBox;
        private System.Windows.Forms.Label PrintStartFromLabel;
        private System.Windows.Forms.Panel DetailPrintSettingPanel;
        private System.Windows.Forms.TabControl PrintSettingTabControl;
        private System.Windows.Forms.TabPage LabelPrintSettingsTabPage;
        private System.Windows.Forms.Button SaveNewLabelSettingsButton;
        private System.Windows.Forms.TabControl LabelSettingsTabControl;
        private System.Windows.Forms.TabPage LabelSizeTabPage;
        private System.Windows.Forms.Label UnitTypeInfoLabel1;
        private System.Windows.Forms.NumericUpDown LabelWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown LabelRowSpaceNumericUpDown;
        private System.Windows.Forms.NumericUpDown LabelHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown LabelColumnSpaceNumericUpDown;
        private System.Windows.Forms.Label LabelHeightLabel;
        private System.Windows.Forms.Label LabelRowSpaceLabel;
        private System.Windows.Forms.Label LabelColumnSpaceLabel;
        private System.Windows.Forms.Label LabelWidthLabel;
        private System.Windows.Forms.TabPage LabelMarginsTabPage;
        private System.Windows.Forms.Label UnitTypeInfoLabel2;
        private System.Windows.Forms.NumericUpDown LabelBottomMarginNumericUpDown;
        private System.Windows.Forms.Label LabelTopMarginLabel;
        private System.Windows.Forms.NumericUpDown LabelRightMarginNumericUpDown;
        private System.Windows.Forms.NumericUpDown LabelTopMarginNumericUpDown;
        private System.Windows.Forms.Label LabelRightMarginLabel;
        private System.Windows.Forms.Label LabelLeftMarginLabel;
        private System.Windows.Forms.NumericUpDown LabelLeftMarginNumericUpDown;
        private System.Windows.Forms.Label LabelBottomMarginLabel;
        private System.Windows.Forms.ComboBox PrintLabelTypeComboBox;
        private System.Windows.Forms.Label PrintLabelTypeLabel;
        private System.Windows.Forms.TextBox PrintLabelTypeTextBox;
        private System.Windows.Forms.TabPage PagePrintSettingsTabPage;
        private System.Windows.Forms.GroupBox PaperSizeGroupBox;
        private System.Windows.Forms.NumericUpDown PaperHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown PaperWidthNumericUpDown;
        private System.Windows.Forms.Label PaperHeightLabel;
        private System.Windows.Forms.Label PaperWidthLabel;
        private System.Windows.Forms.GroupBox PageMarginsGroupBox;
        private System.Windows.Forms.Label UnitTypeInfoLabel3;
        private System.Windows.Forms.ComboBox PageOrientationComboBox;
        private System.Windows.Forms.NumericUpDown PageBottomMarginNumericUpDown;
        private System.Windows.Forms.Label PageOrientationLabel;
        private System.Windows.Forms.Label PageTopMarginLabel;
        private System.Windows.Forms.NumericUpDown PageRightMarginNumericUpDown;
        private System.Windows.Forms.NumericUpDown PageTopMarginNumericUpDown;
        private System.Windows.Forms.Label PageRightMarginLabel;
        private System.Windows.Forms.Label PageLeftMarginLabel;
        private System.Windows.Forms.NumericUpDown PageLeftMarginNumericUpDown;
        private System.Windows.Forms.Label PageBottomMarginLabel;
        private System.Windows.Forms.TabPage BarcodePrintSettingsTabPage;
        private System.Windows.Forms.TabControl BarcodeSettingsTabControl;
        private System.Windows.Forms.TabPage BarcodeTextTabPage;
        private System.Windows.Forms.Label PrcFontStyleLabel;
        private System.Windows.Forms.Button ChangePrcTextFontStyleButton;
        private System.Windows.Forms.CheckBox ShowBottomTextCheckBox;
        private System.Windows.Forms.CheckBox ShowPrcPrnTextCheckBox;
        private System.Windows.Forms.ComboBox PrcPrnTextTypeComboBox;
        private System.Windows.Forms.Label PrcPrnTextTypeLabel;
        private System.Windows.Forms.Label TopTextFontStyleLabel;
        private System.Windows.Forms.ComboBox BottomTextTypeComboBox;
        private System.Windows.Forms.Label BottomTextTypeLabel;
        private System.Windows.Forms.Label TopTextTypeLabel;
        private System.Windows.Forms.ComboBox TopTextTypeComboBox;
        private System.Windows.Forms.CheckBox ShowTopTextCheckBox;
        private System.Windows.Forms.Button ChanteBottomTextFontStyleButton;
        private System.Windows.Forms.Button ChangeTopTextFontStyleButton;
        private System.Windows.Forms.Label BottomTextFontStyleLabel;
        private System.Windows.Forms.TabPage BarcodeSizeTabPage;
        private System.Windows.Forms.NumericUpDown BarcodeHeightScaleNumericUpDown;
        private System.Windows.Forms.Label BarcodeHeightScaleLabel;
        private System.Windows.Forms.Label BarcodeUnitInfoLabel;
        private System.Windows.Forms.Label BarcodeWidthInfoLabel;
        private System.Windows.Forms.Label BarcodeHeightInfoLabel;
        private System.Windows.Forms.NumericUpDown BarcodeWidthScaleNumericUpDown;
        private System.Windows.Forms.Label BarcodeWidthScaleLabel;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.Button DeleteCurrentLabelSettingsButton;
        private System.Windows.Forms.Button AddNewLabelSettingsButton;
        private System.Windows.Forms.Button ResetDefaultPrintSettingButton;
        private System.Windows.Forms.Button LoadPrintSettingButton;
        private System.Windows.Forms.Button SaveAsPrintSettingButton;
        private System.Windows.Forms.GroupBox SearchTypeGroupBox;
        private System.Windows.Forms.Button RefreshDocumentButton;
        private System.Windows.Forms.Button AddDetailItemsButton;
        private System.Windows.Forms.TextBox DocumentInfoTextBox;
        private System.Windows.Forms.ComboBox DocumentKeyComboBox;
        private System.Windows.Forms.ComboBox DocumentTypeComboBox;
        private System.Windows.Forms.Label CurrentDateTimeStatusLabel;
        private System.Windows.Forms.Label OrganizationStatusLabel;
        private System.Windows.Forms.BindingNavigator ItemDetailBindingNavigator;
        private System.Windows.Forms.ToolStripLabel ItemDetailBindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton ItemDetailBindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton ItemDetailBindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator ItemDetailBindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox ItemDetailBindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator ItemDetailBindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ItemDetailBindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton ItemDetailBindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator ItemDetailBindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton ItemSavingToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem ExportItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ItemCheckingToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem CheckAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearAllItemChecksToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ItemRemovingToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveSelectedItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ResetAllItemsToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip AddNewItemToolStrip;
        private System.Windows.Forms.ToolStripTextBox NewItemCodeToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox NewItemNameToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox NewBarcodeToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox NewPrintCountToolStripTextBox;
        private System.Windows.Forms.ToolStripButton AddNewItemToolStripButton;
        private System.Windows.Forms.ToolStrip FindItemToolStrip;
        private System.Windows.Forms.ToolStripLabel FindItemColumnTypeToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox FindItemColumnTypeToolStripComboBox;
        private System.Windows.Forms.ToolStripLabel FindItemTextToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox FindItemTextToolStripTextBox;
        private System.Windows.Forms.ToolStripButton FindNextToolStripButton;
    }
}