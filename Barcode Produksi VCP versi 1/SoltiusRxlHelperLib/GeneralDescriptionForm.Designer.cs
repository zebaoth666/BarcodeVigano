namespace Soltius.RetailExcel.Helper {
    partial class GeneralDescriptionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralDescriptionForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.NavigatorPanel = new System.Windows.Forms.Panel();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.ShortDescriptionDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongDescriptionDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.MainBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.MainBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.MainBindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.MainBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.MainBindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MainBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.MainBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.MainBindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MainBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.MainBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.MainBindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MainBindingNavigatorEdit = new System.Windows.Forms.ToolStripButton();
            this.MainBindingNavigatorCancel = new System.Windows.Forms.ToolStripButton();
            this.MainTableLayoutPanel.SuspendLayout();
            this.DataGridPanel.SuspendLayout();
            this.NavigatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingNavigator)).BeginInit();
            this.MainBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.Controls.Add(this.DataGridPanel, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.NavigatorPanel, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.91209F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.08791F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(426, 273);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.Controls.Add(this.MainBindingNavigator);
            this.DataGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridPanel.Location = new System.Drawing.Point(3, 242);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(420, 28);
            this.DataGridPanel.TabIndex = 0;
            // 
            // NavigatorPanel
            // 
            this.NavigatorPanel.Controls.Add(this.MainDataGridView);
            this.NavigatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigatorPanel.Location = new System.Drawing.Point(3, 3);
            this.NavigatorPanel.Name = "NavigatorPanel";
            this.NavigatorPanel.Size = new System.Drawing.Size(420, 233);
            this.NavigatorPanel.TabIndex = 1;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AllowUserToDeleteRows = false;
            this.MainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShortDescriptionDgvColumn,
            this.LongDescriptionDgvColumn});
            this.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.Size = new System.Drawing.Size(420, 233);
            this.MainDataGridView.TabIndex = 0;
            // 
            // ShortDescriptionDgvColumn
            // 
            this.ShortDescriptionDgvColumn.HeaderText = "Description";
            this.ShortDescriptionDgvColumn.Name = "ShortDescriptionDgvColumn";
            this.ShortDescriptionDgvColumn.ReadOnly = true;
            // 
            // LongDescriptionDgvColumn
            // 
            this.LongDescriptionDgvColumn.HeaderText = "Description";
            this.LongDescriptionDgvColumn.Name = "LongDescriptionDgvColumn";
            this.LongDescriptionDgvColumn.ReadOnly = true;
            this.LongDescriptionDgvColumn.Visible = false;
            // 
            // MainBindingNavigator
            // 
            this.MainBindingNavigator.AddNewItem = null;
            this.MainBindingNavigator.CountItem = this.MainBindingNavigatorCountItem;
            this.MainBindingNavigator.DeleteItem = null;
            this.MainBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainBindingNavigatorMoveFirstItem,
            this.MainBindingNavigatorMovePreviousItem,
            this.MainBindingNavigatorSeparator1,
            this.MainBindingNavigatorPositionItem,
            this.MainBindingNavigatorCountItem,
            this.MainBindingNavigatorSeparator2,
            this.MainBindingNavigatorMoveNextItem,
            this.MainBindingNavigatorMoveLastItem,
            this.MainBindingNavigatorSeparator3,
            this.MainBindingNavigatorAddNewItem,
            this.MainBindingNavigatorDeleteItem,
            this.MainBindingNavigatorSeparator4,
            this.MainBindingNavigatorEdit,
            this.MainBindingNavigatorCancel});
            this.MainBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.MainBindingNavigator.MoveFirstItem = this.MainBindingNavigatorMoveFirstItem;
            this.MainBindingNavigator.MoveLastItem = this.MainBindingNavigatorMoveLastItem;
            this.MainBindingNavigator.MoveNextItem = this.MainBindingNavigatorMoveNextItem;
            this.MainBindingNavigator.MovePreviousItem = this.MainBindingNavigatorMovePreviousItem;
            this.MainBindingNavigator.Name = "MainBindingNavigator";
            this.MainBindingNavigator.PositionItem = this.MainBindingNavigatorPositionItem;
            this.MainBindingNavigator.Size = new System.Drawing.Size(420, 25);
            this.MainBindingNavigator.TabIndex = 0;
            // 
            // MainBindingNavigatorMoveFirstItem
            // 
            this.MainBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainBindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("MainBindingNavigatorMoveFirstItem.Image")));
            this.MainBindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.MainBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.MainBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.MainBindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // MainBindingNavigatorMovePreviousItem
            // 
            this.MainBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainBindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("MainBindingNavigatorMovePreviousItem.Image")));
            this.MainBindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.MainBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.MainBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.MainBindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // MainBindingNavigatorSeparator1
            // 
            this.MainBindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.MainBindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MainBindingNavigatorPositionItem
            // 
            this.MainBindingNavigatorPositionItem.AccessibleName = "Position";
            this.MainBindingNavigatorPositionItem.AutoSize = false;
            this.MainBindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.MainBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.MainBindingNavigatorPositionItem.Text = "0";
            this.MainBindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // MainBindingNavigatorCountItem
            // 
            this.MainBindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.MainBindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.MainBindingNavigatorCountItem.Text = "of {0}";
            this.MainBindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // MainBindingNavigatorSeparator2
            // 
            this.MainBindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.MainBindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MainBindingNavigatorMoveNextItem
            // 
            this.MainBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainBindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("MainBindingNavigatorMoveNextItem.Image")));
            this.MainBindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.MainBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.MainBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.MainBindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // MainBindingNavigatorMoveLastItem
            // 
            this.MainBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainBindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("MainBindingNavigatorMoveLastItem.Image")));
            this.MainBindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.MainBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.MainBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.MainBindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // MainBindingNavigatorSeparator3
            // 
            this.MainBindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.MainBindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // MainBindingNavigatorAddNewItem
            // 
            this.MainBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainBindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("MainBindingNavigatorAddNewItem.Image")));
            this.MainBindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.MainBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.MainBindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 22);
            this.MainBindingNavigatorAddNewItem.Text = "New";
            // 
            // MainBindingNavigatorDeleteItem
            // 
            this.MainBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainBindingNavigatorDeleteItem.Enabled = false;
            this.MainBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("MainBindingNavigatorDeleteItem.Image")));
            this.MainBindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.MainBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.MainBindingNavigatorDeleteItem.Size = new System.Drawing.Size(47, 22);
            this.MainBindingNavigatorDeleteItem.Text = "Delete";
            // 
            // MainBindingNavigatorSeparator4
            // 
            this.MainBindingNavigatorSeparator4.Name = "MainBindingNavigatorSeparator4";
            this.MainBindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // MainBindingNavigatorEdit
            // 
            this.MainBindingNavigatorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainBindingNavigatorEdit.Image = ((System.Drawing.Image)(resources.GetObject("MainBindingNavigatorEdit.Image")));
            this.MainBindingNavigatorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainBindingNavigatorEdit.Name = "MainBindingNavigatorEdit";
            this.MainBindingNavigatorEdit.Size = new System.Drawing.Size(32, 22);
            this.MainBindingNavigatorEdit.Text = "Edit";
            // 
            // MainBindingNavigatorCancel
            // 
            this.MainBindingNavigatorCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainBindingNavigatorCancel.Enabled = false;
            this.MainBindingNavigatorCancel.Image = ((System.Drawing.Image)(resources.GetObject("MainBindingNavigatorCancel.Image")));
            this.MainBindingNavigatorCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainBindingNavigatorCancel.Name = "MainBindingNavigatorCancel";
            this.MainBindingNavigatorCancel.Size = new System.Drawing.Size(50, 22);
            this.MainBindingNavigatorCancel.Text = "Cancel";
            // 
            // GeneralDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 273);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.KeyPreview = true;
            this.Name = "GeneralDescriptionForm";
            this.Text = "General Description";
            this.Load += new System.EventHandler(this.GeneralDescriptionForm_Load);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.DataGridPanel.ResumeLayout(false);
            this.DataGridPanel.PerformLayout();
            this.NavigatorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingNavigator)).EndInit();
            this.MainBindingNavigator.ResumeLayout(false);
            this.MainBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.Panel NavigatorPanel;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortDescriptionDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongDescriptionDgvColumn;
        private System.Windows.Forms.BindingNavigator MainBindingNavigator;
        private System.Windows.Forms.ToolStripButton MainBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel MainBindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton MainBindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton MainBindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton MainBindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator MainBindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox MainBindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator MainBindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton MainBindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton MainBindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator MainBindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripSeparator MainBindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton MainBindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton MainBindingNavigatorCancel;

    }
}