namespace Soltius.RetailExcel.Helper {
    partial class LoginForm {
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
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OrganizationComboBox = new System.Windows.Forms.ComboBox();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.RefreshOrganizationButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(89, 43);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(235, 20);
            this.UserNameTextBox.TabIndex = 4;
            this.UserNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserNameTextBox_KeyUp);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(89, 69);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(235, 20);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyUp);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(17, 46);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(60, 13);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "User Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(17, 72);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(89, 95);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(170, 95);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OrganizationComboBox
            // 
            this.OrganizationComboBox.FormattingEnabled = true;
            this.OrganizationComboBox.Location = new System.Drawing.Point(89, 16);
            this.OrganizationComboBox.Name = "OrganizationComboBox";
            this.OrganizationComboBox.Size = new System.Drawing.Size(235, 21);
            this.OrganizationComboBox.TabIndex = 1;
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Location = new System.Drawing.Point(17, 19);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(66, 13);
            this.OrganizationLabel.TabIndex = 0;
            this.OrganizationLabel.Text = "Organization";
            // 
            // RefreshOrganizationButton
            // 
            this.RefreshOrganizationButton.Location = new System.Drawing.Point(330, 15);
            this.RefreshOrganizationButton.Name = "RefreshOrganizationButton";
            this.RefreshOrganizationButton.Size = new System.Drawing.Size(55, 22);
            this.RefreshOrganizationButton.TabIndex = 2;
            this.RefreshOrganizationButton.TabStop = false;
            this.RefreshOrganizationButton.Text = "Refresh";
            this.RefreshOrganizationButton.UseVisualStyleBackColor = true;
            this.RefreshOrganizationButton.Click += new System.EventHandler(this.RefreshOrganizationButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.OrganizationComboBox);
            this.MainPanel.Controls.Add(this.RefreshOrganizationButton);
            this.MainPanel.Controls.Add(this.UserNameTextBox);
            this.MainPanel.Controls.Add(this.OrganizationLabel);
            this.MainPanel.Controls.Add(this.PasswordTextBox);
            this.MainPanel.Controls.Add(this.UserNameLabel);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.PasswordLabel);
            this.MainPanel.Controls.Add(this.LoginButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(397, 130);
            this.MainPanel.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 130);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox OrganizationComboBox;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Button RefreshOrganizationButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}