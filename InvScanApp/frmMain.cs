using InvScanApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                //If the database doesn't exist, create it
                if (!File.Exists(Settings.Default.dbDBPath.ToString()))
                {
                    //Create database, build tables, and insert initial data
                    clsDatabase.InitializeDB();
                }
                else
                {
                    //Connect to the DB
                    clsDatabase.ConnectToDB();
                }

                //Populate DGV
                DataTable dt = new DataTable();
                dt.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT * FROM dbo.tblCommodity;"));
                dgvMain.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error with Database connections");
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

        private void btnHandOut_Click(object sender, EventArgs e)
        {
            //Show settings form
            Form f = new frmHandOut();
            f.Show();
            f.Location = Location;

            //Hide main form
            Hide();
        }
    }
}
