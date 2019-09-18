namespace Soltius.RetailExcel.Helper {
    partial class ConnectionSettingForm {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.TestConnectionButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LevelNumberTextBox = new System.Windows.Forms.TextBox();
            this.LevelNumberLabel = new System.Windows.Forms.Label();
            this.OrganizationTextBox = new System.Windows.Forms.TextBox();
            this.OrganizationCodeLabel = new System.Windows.Forms.Label();
            this.CleaTextsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TestConnectionButton);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Controls.Add(this.UserIDTextBox);
            this.groupBox1.Controls.Add(this.UserIDLabel);
            this.groupBox1.Controls.Add(this.DatabaseTextBox);
            this.groupBox1.Controls.Add(this.DatabaseLabel);
            this.groupBox1.Controls.Add(this.ServerTextBox);
            this.groupBox1.Controls.Add(this.ServerLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(12, 261);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSettingsButton.TabIndex = 19;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // TestConnectionButton
            // 
            this.TestConnectionButton.Location = new System.Drawing.Point(116, 123);
            this.TestConnectionButton.Name = "TestConnectionButton";
            this.TestConnectionButton.Size = new System.Drawing.Size(98, 23);
            this.TestConnectionButton.TabIndex = 18;
            this.TestConnectionButton.Text = "Test Connection";
            this.TestConnectionButton.UseVisualStyleBackColor = true;
            this.TestConnectionButton.Click += new System.EventHandler(this.TestConnectionButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(116, 97);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(183, 20);
            this.PasswordTextBox.TabIndex = 17;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(16, 100);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 16;
            this.PasswordLabel.Text = "Password";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(116, 71);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(183, 20);
            this.UserIDTextBox.TabIndex = 15;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(16, 74);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(43, 13);
            this.UserIDLabel.TabIndex = 14;
            this.UserIDLabel.Text = "User ID";
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(116, 45);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(183, 20);
            this.DatabaseTextBox.TabIndex = 13;
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(16, 48);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(53, 13);
            this.DatabaseLabel.TabIndex = 12;
            this.DatabaseLabel.Text = "Database";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(116, 19);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(183, 20);
            this.ServerTextBox.TabIndex = 11;
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(16, 22);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(38, 13);
            this.ServerLabel.TabIndex = 10;
            this.ServerLabel.Text = "Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OrganizationTextBox);
            this.groupBox2.Controls.Add(this.OrganizationCodeLabel);
            this.groupBox2.Controls.Add(this.LevelNumberTextBox);
            this.groupBox2.Controls.Add(this.LevelNumberLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 77);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Retail Excel";
            // 
            // LevelNumberTextBox
            // 
            this.LevelNumberTextBox.Location = new System.Drawing.Point(116, 19);
            this.LevelNumberTextBox.Name = "LevelNumberTextBox";
            this.LevelNumberTextBox.Size = new System.Drawing.Size(183, 20);
            this.LevelNumberTextBox.TabIndex = 17;
            // 
            // LevelNumberLabel
            // 
            this.LevelNumberLabel.AutoSize = true;
            this.LevelNumberLabel.Location = new System.Drawing.Point(16, 22);
            this.LevelNumberLabel.Name = "LevelNumberLabel";
            this.LevelNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.LevelNumberLabel.TabIndex = 16;
            this.LevelNumberLabel.Text = "Level Number";
            // 
            // OrganizationTextBox
            // 
            this.OrganizationTextBox.Location = new System.Drawing.Point(116, 45);
            this.OrganizationTextBox.Name = "OrganizationTextBox";
            this.OrganizationTextBox.Size = new System.Drawing.Size(183, 20);
            this.OrganizationTextBox.TabIndex = 19;
            // 
            // OrganizationCodeLabel
            // 
            this.OrganizationCodeLabel.AutoSize = true;
            this.OrganizationCodeLabel.Location = new System.Drawing.Point(16, 48);
            this.OrganizationCodeLabel.Name = "OrganizationCodeLabel";
            this.OrganizationCodeLabel.Size = new System.Drawing.Size(94, 13);
            this.OrganizationCodeLabel.TabIndex = 18;
            this.OrganizationCodeLabel.Text = "Organization Code";
            // 
            // CleaTextsButton
            // 
            this.CleaTextsButton.Location = new System.Drawing.Point(93, 260);
            this.CleaTextsButton.Name = "CleaTextsButton";
            this.CleaTextsButton.Size = new System.Drawing.Size(75, 23);
            this.CleaTextsButton.TabIndex = 20;
            this.CleaTextsButton.Text = "Clear";
            this.CleaTextsButton.UseVisualStyleBackColor = true;
            this.CleaTextsButton.Click += new System.EventHandler(this.CleaTextsButton_Click);
            // 
            // ConnectionSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 295);
            this.Controls.Add(this.CleaTextsButton);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ConnectionSettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Connection Setting";
            this.Load += new System.EventHandler(this.ConnectionSettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TestConnectionButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OrganizationTextBox;
        private System.Windows.Forms.Label OrganizationCodeLabel;
        private System.Windows.Forms.TextBox LevelNumberTextBox;
        private System.Windows.Forms.Label LevelNumberLabel;
        private System.Windows.Forms.Button CleaTextsButton;

    }
}