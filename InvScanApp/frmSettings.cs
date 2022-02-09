using InvScanApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvScanApp
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtSQLString.Text.Length > 0)
            {
                string strTemp = txtSQLString.Text;
                    
                switch (cmbString.SelectedItem)
                { 
                    case "Data Base Name":
                        Settings.Default.dbDBName = strTemp;
                        break;
                    case "Data Base Path":
                        Settings.Default.dbDBPath = strTemp;
                        break;
                    case "Server Name":
                        Settings.Default.dbServerName = strTemp;
                        break;
                    case "User Name":
                        Settings.Default.dbUser= strTemp;
                        break;
                    case "User Password":
                        Settings.Default.dbPassword= strTemp;
                        break;
                }

                //Save
                Settings.Default.Save();
            } else
            {
                MessageBox.Show("Fill out textbox first!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Show main form
            Form f = new frmMain();
            f.Show();
            f.Location = Location;

            //Hide settings form
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmailUsername.Text = "";
            txtEmailPassword.Text = "";
            txtSMTPClient.Text = "";
            txtToEmail.Text = "";
            txtSMTPPort.Text = "";
        }

        private void btnSaveEmail_Click(object sender, EventArgs e)
        {
            if(txtEmailUsername.Text.Length > 0 && txtEmailPassword.Text.Length > 0 && txtSMTPClient.Text.Length > 0 && txtToEmail.Text.Length > 0 && txtSMTPPort.Text.Length > 0)
            {
                Settings.Default.strEmailUsername = txtEmailUsername.Text;
                Settings.Default.strEmailPassword = txtEmailPassword.Text;
                Settings.Default.strToEmail = txtToEmail.Text;
                Settings.Default.strSMTPPort = txtSMTPPort.Text;
                Settings.Default.strSMTPClient = txtSMTPClient.Text;
                //smtp.gmail.com - Gmail
                //smtp.live.com - Windows live / Hotmail
                //smtp.mail.yahoo.com - Yahoo
                //smtp.aim.com - AIM
                //my.inbox.com - Inbox

                Settings.Default.Save();
            }
        }
    }
}
