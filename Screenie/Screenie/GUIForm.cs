using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Screenie
{
    public partial class ScreenieForm : Form
    {
        private Settings _settings;

        public ScreenieForm()
        {
            InitializeComponent();
        }

        private void ScreenieForm_Load(object sender, EventArgs e)
        {
            // if xml file exists load it
            try
            {
                _settings = Settings.LoadSettings();
                SetGuiSettings();
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
                Console.WriteLine(er.InnerException.Message);
                Console.WriteLine(er.InnerException.InnerException.Message);
            }
            Screenie abc = new Screenie(_settings);

            //FtpUploader ftpUploader = new FtpUploader(new UserCredentials("144019_master", "Dezy54gh."), @"ftp://ftp.nandreasson.se/nandreasson.se/public_html/");
            //ftpUploader.UploadFile(@"minFil.txt");
            //abc.printScreen(new Point(0, 0), new Point(3, 2));
        }

        private void SetGuiSettings()
        {
            ftpEnabledCheckBox.Checked = _settings.FtpEnabled;
            ftpAddressTextBox.Text = _settings.FtpAddress;
            usernameTextBox.Text = _settings.Username;
            passwordTextBox.Text = _settings.Password;
        }

        private void ScreenieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // write all fields to an xml file
            Settings.SaveSettings(_settings);
        }

        private void ScreenieForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                hideProgram();
            }
        }

        private void hideProgram()
        {
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                // get the path and set to settings file
            }
        }

        private void enableFtpCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ftpEnabledCheckBox.Checked)
            {
                ftpAddressTextBox.Enabled = true;
                usernameTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
            }
            else
            {
                ftpAddressTextBox.Enabled = false;
                usernameTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
            }
        }
    }
}
