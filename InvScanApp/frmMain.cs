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

                //Set column order
                dgvMain.Columns[2].DisplayIndex = 0;
                dgvMain.Columns[1].DisplayIndex = 1;
                dgvMain.Columns[5].DisplayIndex = 2;
                dgvMain.Columns[3].DisplayIndex = 3;
                dgvMain.Columns[4].DisplayIndex = 4;
                dgvMain.Columns[0].DisplayIndex = 5;

                //Set column names
                dgvMain.Columns[0].HeaderText = "Barcode";
                dgvMain.Columns[1].HeaderText = "Name";
                dgvMain.Columns[2].HeaderText = "Category";
                dgvMain.Columns[3].HeaderText = "Vendor";
                dgvMain.Columns[4].HeaderText = "URL";
                dgvMain.Columns[5].HeaderText = "Qty";

                //Set column widths
                dgvMain.Columns[0].Width = 100;
                dgvMain.Columns[1].Width = 150;
                dgvMain.Columns[2].Width = 125;
                dgvMain.Columns[3].Width = 125;
                dgvMain.Columns[4].Width = 75;
                dgvMain.Columns[5].Width = 72;

                //Sort by category
                dgvMain.Sort(dgvMain.Columns[2], ListSortDirection.Ascending);

                //Highlight zero qty items
                foreach(DataGridViewRow row in dgvMain.Rows)
                {

                    Console.WriteLine(row.Cells[5].ToString());

                    //Check quantity cell
                    if(row.Cells[5].Value.ToString() == "0")
                    {
                        //Make row red
                        row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
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
            Form f = new frmAddEdit();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Show settings form
            Form f = new frmRemove();
            f.Show();
            f.Location = Location;

            //Hide main form
            Hide();
        }
    }
}
