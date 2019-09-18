namespace Soltius.RetailExcel.Helper {
    partial class LicenseValidatorForm {
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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ApplyLicenseButton = new System.Windows.Forms.Button();
            this.LicenseFileTextBox = new System.Windows.Forms.TextBox();
            this.LicenseFileLabel = new System.Windows.Forms.Label();
            this.SearchLicenseFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(15, 41);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CompanyNameLabel.TabIndex = 3;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(103, 38);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(195, 21);
            this.CompanyNameTextBox.TabIndex = 4;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(103, 64);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(195, 21);
            this.UserNameTextBox.TabIndex = 6;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(15, 67);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(59, 13);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "User Name";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(103, 90);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(195, 21);
            this.EmailTextBox.TabIndex = 8;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(15, 93);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(31, 13);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email";
            // 
            // ApplyLicenseButton
            // 
            this.ApplyLicenseButton.Location = new System.Drawing.Point(103, 119);
            this.ApplyLicenseButton.Name = "ApplyLicenseButton";
            this.ApplyLicenseButton.Size = new System.Drawing.Size(108, 23);
            this.ApplyLicenseButton.TabIndex = 9;
            this.ApplyLicenseButton.Text = "Apply License";
            this.ApplyLicenseButton.UseVisualStyleBackColor = true;
            this.ApplyLicenseButton.Click += new System.EventHandler(this.ApplyLicenseButton_Click);
            // 
            // LicenseFileTextBox
            // 
            this.LicenseFileTextBox.Location = new System.Drawing.Point(103, 12);
            this.LicenseFileTextBox.Name = "LicenseFileTextBox";
            this.LicenseFileTextBox.Size = new System.Drawing.Size(195, 21);
            this.LicenseFileTextBox.TabIndex = 1;
            // 
            // LicenseFileLabel
            // 
            this.LicenseFileLabel.AutoSize = true;
            this.LicenseFileLabel.Location = new System.Drawing.Point(15, 15);
            this.LicenseFileLabel.Name = "LicenseFileLabel";
            this.LicenseFileLabel.Size = new System.Drawing.Size(61, 13);
            this.LicenseFileLabel.TabIndex = 0;
            this.LicenseFileLabel.Text = "License File";
            // 
            // SearchLicenseFileButton
            // 
            this.SearchLicenseFileButton.Location = new System.Drawing.Point(301, 11);
            this.SearchLicenseFileButton.Name = "SearchLicenseFileButton";
            this.SearchLicenseFileButton.Size = new System.Drawing.Size(28, 24);
            this.SearchLicenseFileButton.TabIndex = 2;
            this.SearchLicenseFileButton.Text = "...";
            this.SearchLicenseFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchLicenseFileButton.UseVisualStyleBackColor = true;
            this.SearchLicenseFileButton.Click += new System.EventHandler(this.SearchLicenseFileButton_Click);
            // 
            // LicenseValidatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 155);
            this.Controls.Add(this.SearchLicenseFileButton);
            this.Controls.Add(this.LicenseFileTextBox);
            this.Controls.Add(this.LicenseFileLabel);
            this.Controls.Add(this.ApplyLicenseButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.CompanyNameLabel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseValidatorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "License Info";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LicenseValidatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button ApplyLicenseButton;
        private System.Windows.Forms.TextBox LicenseFileTextBox;
        private System.Windows.Forms.Label LicenseFileLabel;
        private System.Windows.Forms.Button SearchLicenseFileButton;
    }
}