using InvScanApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvScanApp
{
    public partial class frmMain : Form
    {
        //Global vars
        public static string strConnection;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //If the database doesn't exist, create it
            if(!File.Exists(Settings.Default.dbDBPath.ToString()))
            {
                //Create database, build tables, and insert initial data
                clsDatabase.InitializeDB();
            }
            else
            {
                //Connect to the DB
                clsDatabase.ConnectToDB();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Close the program
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Show settings form
            Form f = new frmSettings();
            f.Show();
            f.Location = Location;

            //Hide main form
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Show settings form
            Form f = new frmAdd();
            f.Show();
            f.Location = Location;

            //Hide main form
            Hide();
        }
    }
}
