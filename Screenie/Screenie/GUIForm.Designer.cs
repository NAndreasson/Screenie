namespace Screenie
{
    partial class ScreenieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenieForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.ftpEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.ftpAddressLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.ftpAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printScreenTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printScreenComboBox = new System.Windows.Forms.ComboBox();
            this.printScreenSectionComboBox = new System.Windows.Forms.ComboBox();
            this.printScreenSectionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Screenie";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFolderButton.Location = new System.Drawing.Point(227, 36);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(133, 37);
            this.chooseFolderButton.TabIndex = 0;
            this.chooseFolderButton.Text = "Choose folder";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPathLabel.Location = new System.Drawing.Point(12, 41);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(106, 24);
            this.folderPathLabel.TabIndex = 1;
            this.folderPathLabel.Text = "Folder path";
            // 
            // ftpEnabledCheckBox
            // 
            this.ftpEnabledCheckBox.AutoSize = true;
            this.ftpEnabledCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpEnabledCheckBox.Location = new System.Drawing.Point(16, 101);
            this.ftpEnabledCheckBox.Name = "ftpEnabledCheckBox";
            this.ftpEnabledCheckBox.Size = new System.Drawing.Size(144, 24);
            this.ftpEnabledCheckBox.TabIndex = 2;
            this.ftpEnabledCheckBox.Text = "Upload with FTP";
            this.ftpEnabledCheckBox.UseVisualStyleBackColor = true;
            this.ftpEnabledCheckBox.CheckedChanged += new System.EventHandler(this.enableFtpCheckbox_CheckedChanged);
            // 
            // ftpAddressLabel
            // 
            this.ftpAddressLabel.AutoSize = true;
            this.ftpAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpAddressLabel.Location = new System.Drawing.Point(40, 128);
            this.ftpAddressLabel.Name = "ftpAddressLabel";
            this.ftpAddressLabel.Size = new System.Drawing.Size(87, 16);
            this.ftpAddressLabel.TabIndex = 3;
            this.ftpAddressLabel.Text = "FTP address";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(56, 178);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 16);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(59, 209);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 16);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(133, 209);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(114, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Location = new System.Drawing.Point(133, 178);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(114, 20);
            this.usernameTextBox.TabIndex = 7;
            // 
            // ftpAddressTextBox
            // 
            this.ftpAddressTextBox.Enabled = false;
            this.ftpAddressTextBox.Location = new System.Drawing.Point(133, 126);
            this.ftpAddressTextBox.Name = "ftpAddressTextBox";
            this.ftpAddressTextBox.Size = new System.Drawing.Size(114, 20);
            this.ftpAddressTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Example: ftp://examplepage.com/folder/";
            // 
            // printScreenTextBox
            // 
            this.printScreenTextBox.Location = new System.Drawing.Point(147, 330);
            this.printScreenTextBox.MaxLength = 1;
            this.printScreenTextBox.Name = "printScreenTextBox";
            this.printScreenTextBox.Size = new System.Drawing.Size(100, 20);
            this.printScreenTextBox.TabIndex = 10;
            this.printScreenTextBox.TextChanged += new System.EventHandler(this.printAreaButtonTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Printscreen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Printscreen section";
            // 
            // printScreenComboBox
            // 
            this.printScreenComboBox.FormattingEnabled = true;
            this.printScreenComboBox.Items.AddRange(new object[] {
            "None",
            "Ctrl",
            "Alt",
            "Shift",
            "PrtScn"});
            this.printScreenComboBox.Location = new System.Drawing.Point(19, 328);
            this.printScreenComboBox.Name = "printScreenComboBox";
            this.printScreenComboBox.Size = new System.Drawing.Size(94, 21);
            this.printScreenComboBox.TabIndex = 13;
            this.printScreenComboBox.Text = "None";
            this.printScreenComboBox.SelectedIndexChanged += new System.EventHandler(this.printScreenComboBox_SelectedIndexChanged);
            // 
            // printScreenSectionComboBox
            // 
            this.printScreenSectionComboBox.FormattingEnabled = true;
            this.printScreenSectionComboBox.Location = new System.Drawing.Point(19, 405);
            this.printScreenSectionComboBox.Name = "printScreenSectionComboBox";
            this.printScreenSectionComboBox.Size = new System.Drawing.Size(94, 21);
            this.printScreenSectionComboBox.TabIndex = 14;
            // 
            // printScreenSectionTextBox
            // 
            this.printScreenSectionTextBox.Location = new System.Drawing.Point(147, 406);
            this.printScreenSectionTextBox.MaxLength = 1;
            this.printScreenSectionTextBox.Name = "printScreenSectionTextBox";
            this.printScreenSectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.printScreenSectionTextBox.TabIndex = 15;
            this.printScreenSectionTextBox.TextChanged += new System.EventHandler(this.printScreenSectionTextBox_TextChanged);
            // 
            // ScreenieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 524);
            this.Controls.Add(this.printScreenSectionTextBox);
            this.Controls.Add(this.printScreenSectionComboBox);
            this.Controls.Add(this.printScreenComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printScreenTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ftpAddressTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.ftpAddressLabel);
            this.Controls.Add(this.ftpEnabledCheckBox);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.chooseFolderButton);
            this.Name = "ScreenieForm";
            this.Text = "Screenie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScreenieForm_FormClosing);
            this.Load += new System.EventHandler(this.ScreenieForm_Load);
            this.Resize += new System.EventHandler(this.ScreenieForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.CheckBox ftpEnabledCheckBox;
        private System.Windows.Forms.Label ftpAddressLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox ftpAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox printScreenTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox printScreenComboBox;
        private System.Windows.Forms.ComboBox printScreenSectionComboBox;
        private System.Windows.Forms.TextBox printScreenSectionTextBox;


    }
}

