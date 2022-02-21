using InvScanApp.Properties;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Show main form
            Form f = new frmMain();
            f.Show();
            f.Location = Location;

            //Hide hand-out form
            Close();
        }

        private void PopulateDGV()
        {
            //Reset DGV
            dgvReport.DataSource = null;
            
            try
            {
                //Populate DGV
                DataTable dt = new DataTable();

                //SQL query
                string strSQL = "USE TBInvDB; ";

                switch (cmbReportType.SelectedIndex)
                {
                    case 0:
                        //Set SQL query
                        strSQL += "SELECT o.Commodity_Name, o.Commodity_Qty, a.Qty_Alert " +
                        "FROM dbo.tblCommodity o " +
                        "INNER JOIN dbo.tblCategory a " +
                        "ON o.Commodity_Category = a.Category_Name " +
                        "WHERE o.Commodity_Qty < a.Qty_Alert;";

                        //Load the datatable
                        dt.Load(clsDatabase.ExecuteSqlReader(strSQL));
                        
                        //Set the DGV
                        dgvReport.DataSource = dt;

                        //Set column names
                        dgvReport.Columns[0].HeaderText = "Commodity";
                        dgvReport.Columns[1].HeaderText = "Current Qty";
                        dgvReport.Columns[2].HeaderText = "Alert Qty";

                        //Set column widths
                        dgvReport.Columns[0].Width = 150;
                        dgvReport.Columns[1].Width = 150;
                        dgvReport.Columns[2].Width = 125;

                        //Unselect row
                        dgvReport.ClearSelection();
                        break;
                    case 1:
                        CategoryBreakdown();
                        break;
                    case 2:
                        LogDays();
                        break;
                    case 3:
                        RecipientList();
                        break;
                    case 4:
                        StaffList();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error with Database connections");
            }
        }

        private void CategoryBreakdown()
        {
            Dictionary<string, string> dctCategories = new Dictionary<string, string>();

            SqlDataReader dataReader;

            DataTable dt = new DataTable();

            //Load the datatable
            dt.Load(clsDatabase.ExecuteSqlReader("SELECT Category_Name FROM dbo.tblCategory"));

            foreach (DataRow row in dt.Rows)
            {
                dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT SUM(Qty_Action) AS Quantity FROM dbo.tblLog " +
                "WHERE Staff_Action = 'Hand-Out' AND " +
                "Commodity_Category = '" + row[0].ToString() + "' AND " +
                "Action_Time > GETDATE() - " + nudDays.Value + ";");

                while (dataReader.Read())
                {
                    dctCategories.Add(row[0].ToString(), dataReader["Quantity"].ToString());
                }

                dataReader.Close();
            }

            var dctCategoriesLINQ = from row in dctCategories select new { Item = row.Key, Price = row.Value };

            dgvReport.DataSource = dctCategoriesLINQ.ToArray();

            //Set column names
            dgvReport.Columns[0].HeaderText = "Category";
            dgvReport.Columns[1].HeaderText = "Qty Handed Out";

            //Set column widths
            dgvReport.Columns[0].Width = 125;
            dgvReport.Columns[1].Width = 200;

            //Unselect row
            dgvReport.ClearSelection();
        }

        private void StaffList()
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataRow dr = null;

            dt2.Columns.Add("Staff");
            dt2.Columns.Add("Commodity");
            dt2.Columns.Add("Qty Given");

            string strSQL = "SELECT DISTINCT Staff_Name FROM dbo.tblLog";

            SqlDataReader dataReader;

            //Load the datatable
            dt1.Load(clsDatabase.ExecuteSqlReader(strSQL));

            foreach (DataRow row in dt1.Rows)
            {
                dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT SUM(Qty_Action) AS Quantity, Commodity_Name FROM dbo.tblLog " +
                "WHERE Staff_Action = 'Hand-Out' AND " +
                "Staff_Name = '" + row[0].ToString() + "' AND " +
                "Action_Time > GETDATE() - " + nudDays.Value + " " +
                "GROUP BY Commodity_Name; ");

                while (dataReader.Read())
                {
                    dr = dt2.NewRow();
                    dr["Staff"] = row[0].ToString();
                    dr["Commodity"] = dataReader["Commodity_Name"].ToString();
                    dr["Qty Given"] = dataReader["Quantity"].ToString();
                    dt2.Rows.Add(dr);
                }

                dataReader.Close();
            }

            //Set DGV datasource
            dgvReport.DataSource = dt2;

            //Set column names
            dgvReport.Columns[0].HeaderText = "Staff";
            dgvReport.Columns[1].HeaderText = "Commodity";
            dgvReport.Columns[2].HeaderText = "Qty Handed Out";

            //Set column widths
            dgvReport.Columns[0].Width = 125;
            dgvReport.Columns[1].Width = 200;
            dgvReport.Columns[1].Width = 200;

            //Unselect row
            dgvReport.ClearSelection();
        }

        private void RecipientList()
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataRow dr = null;

            dt2.Columns.Add("Recipient");
            dt2.Columns.Add("Commodity");
            dt2.Columns.Add("Qty Given");
            
            string strSQL = "SELECT DISTINCT Recipient_Name FROM dbo.tblLog";

            SqlDataReader dataReader;

            //Load the datatable
            dt1.Load(clsDatabase.ExecuteSqlReader(strSQL));

            foreach (DataRow row in dt1.Rows)
            {
                dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT SUM(Qty_Action) AS Quantity, Commodity_Name FROM dbo.tblLog " +
                "WHERE Staff_Action = 'Hand-Out' AND " +
                "Recipient_Name = '" + row[0].ToString() + "' AND " +
                "Action_Time > GETDATE() - " + nudDays.Value + " " +
                "GROUP BY Commodity_Name; ");

                while (dataReader.Read())
                {
                    dr = dt2.NewRow();
                    dr["Recipient"] = row[0].ToString();
                    dr["Commodity"] = dataReader["Commodity_Name"].ToString();
                    dr["Qty Given"] = dataReader["Quantity"].ToString();
                    dt2.Rows.Add(dr);
                }

                dataReader.Close();
            }

            //Set DGV datasource
            dgvReport.DataSource = dt2;

            //Set column names
            dgvReport.Columns[0].HeaderText = "Recipient";
            dgvReport.Columns[1].HeaderText = "Commodity";
            dgvReport.Columns[2].HeaderText = "Qty Given";

            //Set column widths
            dgvReport.Columns[0].Width = 125;
            dgvReport.Columns[1].Width = 200;
            dgvReport.Columns[2].Width = 200;

            //Unselect row
            dgvReport.ClearSelection();
        }

        private void LogDays()
        {
            DataTable dt = new DataTable();

            //Load the datatable
            dt.Load(clsDatabase.ExecuteSqlReader("SELECT * FROM dbo.tblLog WHERE Action_Time > GETDATE() - " + nudDays.Value + ";"));

            //Set the DGV
            dgvReport.DataSource = dt;

            //Hide TUID
            dgvReport.Columns[0].Visible = false;

            //Set column names
            dgvReport.Columns[1].HeaderText = "Staff";
            dgvReport.Columns[2].HeaderText = "Recipient";
            dgvReport.Columns[3].HeaderText = "Category";
            dgvReport.Columns[4].HeaderText = "Commodity";
            dgvReport.Columns[5].HeaderText = "Action";
            dgvReport.Columns[6].HeaderText = "Qty";
            dgvReport.Columns[7].HeaderText = "New Qty";
            dgvReport.Columns[8].HeaderText = "Date/Time";

            //Set column widths
            dgvReport.Columns[1].Width = 150;
            dgvReport.Columns[2].Width = 150;
            dgvReport.Columns[3].Width = 110;
            dgvReport.Columns[4].Width = 125;
            dgvReport.Columns[5].Width = 80;
            dgvReport.Columns[6].Width = 50;
            dgvReport.Columns[7].Width = 120;
            dgvReport.Columns[8].Width = 150;

            //Unselect row
            dgvReport.ClearSelection();
        }

        private void nudDays_ValueChanged(object sender, EventArgs e)
        {
            switch (cmbReportType.SelectedIndex)
            {
                case 1:
                    CategoryBreakdown();
                    break;
                case 2:
                    LogDays();
                    break;
                case 3:
                    RecipientList();
                    break;
                case 4:
                    StaffList();
                    break;
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            //Only continue if there is data to email
            if(dgvReport.Rows.Count > 0)
            {
                //Allow user to send to a different email
                string strEmail = Interaction.InputBox("To what address should I email the report?", "Confirm Email", Settings.Default.strToEmail);

                //Set path
                string strPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TechBarReports\\";

                //Create directory if needed
                Directory.CreateDirectory(strPath);

                //Set file name
                string strFile = "report" + DateTimeOffset.Now.ToUnixTimeSeconds() + ".csv";
                
                try
                {
                    //See if valid email
                    var addEmail = new System.Net.Mail.MailAddress(strEmail);
                    strEmail = addEmail.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("You must enter a valid address before emailing the report", "Error");
                    return;
                }

                try
                {
                    //Make CSV file
                    var sb = new StringBuilder();

                    var headers = dgvReport.Columns.Cast<DataGridViewColumn>();
                    sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                    }

                    File.WriteAllText(strPath + strFile, sb.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting report\r\n" + ex.Message, "Error");
                    return;
                }

                //Send email
                string strWhichReport = cmbReportType.Text;

                if(cmbReportType.SelectedIndex > 0)
                {
                    strWhichReport += " for the last " + nudDays.Value + " days";
                }

                string strBody = "A Tech Bar Inventory report has been generated for " + strWhichReport + ".\r" +
                    "Please reference '" + strFile + "' (attached to this email) using Excel to view the report.\r\r" +
                    "Regards,\r" +
                    "- Ben Bot\r";

                //Send email with attachment
                clsEmail.SendEmail(strBody, "Tech Bar Inventory - Report Export", strEmail, strPath + strFile);
            }
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex > 0)
            {
                lblLast.Visible = true;
                lblDays.Visible = true;
                nudDays.Visible = true;
            }
            else
            {
                lblLast.Visible = false;
                lblDays.Visible = false;
                nudDays.Visible = false;
            }

            //Set the data
            PopulateDGV();
        }
    }
}
