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
                        Properties.Settings.Default.dbDBName = strTemp;
                        break;
                    case "Data Base Path":
                        Properties.Settings.Default.dbDBPath = strTemp;
                        break;
                    case "Server Name":
                        Properties.Settings.Default.dbServerName = strTemp;
                        break;
                    case "User Name":
                        Properties.Settings.Default.dbUser= strTemp;
                        break;
                    case "User Password":
                        Properties.Settings.Default.dbPassword= strTemp;
                        break;
                }

                //Save
                Properties.Settings.Default.Save();
            } else
            {
                MessageBox.Show("Fill out textbox first!");
            }
        }

        private void btnSQLConnect_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain.strConnection = "SERVER=" + Properties.Settings.Default.dbServerName 
                + ";DATABASE=" + Properties.Settings.Default.dbDBName
                + ";Integrated Security=SSPI;AttachDbFileName=" + Properties.Settings.Default.dbDBPath;

            //Show main form
            Form f = new frmMain();
            f.Show();
            f.Location = Location;

            //Hide settings form
            Close();
        }
    }
}
