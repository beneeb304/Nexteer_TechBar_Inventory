using InvScanApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvScanApp
{
    public partial class frmSettings : Form
    {
        //Class vars
        private bool blnID = false;

        public frmSettings()
        {
            InitializeComponent();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (tbcSettings.SelectedIndex)
            {
                case 0:
                    //Make sure all fields are filled out
                    if (txtCategory.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + txtCategory.Text +
                            " as a new category?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (clsDatabase.ExecuteSQLNonQ("USE TBInvDB; INSERT INTO dbo.tblCategory VALUES ('" + txtCategory.Text + "'," + nudQty.Value + ");"))
                            {
                                MessageBox.Show("Added " + txtCategory.Text + " as a new category!", "Success");
                                btnBack_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + txtCategory.Text + " as a new category!", "Error");
                            }
                        }
                    }

                    break;
                case 1:
                    //Make sure all fields are filled out
                    if (txtVendor.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + txtVendor.Text +
                            " as a new vendor?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (clsDatabase.ExecuteSQLNonQ("USE TBInvDB; INSERT INTO dbo.tblVendor VALUES ('" + txtVendor.Text + "');"))
                            {
                                MessageBox.Show("Added " + txtVendor.Text + " as a new vendor!", "Success");
                                btnBack_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + txtVendor.Text + " as a new vendor!", "Error");
                            }
                        }
                    }

                    break;
                case 2:
                    //Make sure all fields are filled out
                    if (txtStaff.Text.Length > 0 && txtStaffID.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + txtStaff.Text +
                            " as a new staff member?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (clsDatabase.ExecuteSQLNonQ("USE TBInvDB; INSERT INTO dbo.tblStaff VALUES ('" + txtStaffID.Text + "', '" + txtStaff.Text + "');"))
                            {
                                MessageBox.Show("Added " + txtStaff.Text + " as a new staff member!", "Success");
                                btnBack_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + txtStaff.Text + " as a new staff member!", "Error");
                            }
                        }
                    }

                    break;
                case 3:
                    if (cmbField.Text.Length > 0)
                    {
                        //Get table and field
                        string[] strData = GetTableField();

                        //Make sure the user wants to make this deletion
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + cmbField.Text + " as a " + strData[0] +
                            " from " + strData[1] + "?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //Go through each table and delete where the selected item is the primary key
                            clsDatabase.ExecuteSQLNonQ("USE TBInvDB; DELETE FROM " + strData[1] + " WHERE " + strData[0] + " = '" + cmbField.Text + "';");
                            btnBack_Click(sender, e);
                        }
                    }

                    break;
                case 4:
                    if (txtEmailUsername.Text.Length > 0 && txtEmailPassword.Text.Length > 0 && txtSMTPClient.Text.Length > 0 && txtToEmail.Text.Length > 0 && txtSMTPPort.Text.Length > 0)
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

                        //Alert user
                        MessageBox.Show("Saved Email Settings", "Success");

                        btnBack_Click(sender, e);
                    }
                    
                    break;
                case 5:
                    //Make sure all fields are filled out
                    if (txtSQLServerName.Text.Length > 0)
                    {
                        //Set value
                        Settings.Default.dbServerName = txtSQLServerName.Text;

                        //Save
                        Settings.Default.Save();

                        //Alert user
                        MessageBox.Show("Saved SQL Server Name", "Success");

                        btnBack_Click(sender, e);
                    }

                    break;
            }
        }

        private void SetControls(object sender, EventArgs e)
        {
            txtDetails.Text = "";

            //Get the table and field
            string[] strData = GetTableField();

            //Make datatable
            DataTable dtName = new DataTable();

            //Get list of item names for selected category and populate combobox
            dtName.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT " + strData[0] + " FROM dbo." + strData[1] + ";"));
            cmbField.DataSource = dtName;
            cmbField.ValueMember = strData[0];
        }

        private string[] GetTableField()
        {
            //Make string array with 2 elements
            string[] strData = new string[2];

            foreach (RadioButton rdo in gpbTables.Controls.OfType<RadioButton>())
            {
                switch (rdo.Name)
                {
                    case "rdoCategory":
                        if (rdoCategory.Checked)
                        {
                            strData[0] = "Category_Name";
                            strData[1] = "tblCategory";
                        }
                        break;
                    case "rdoCommodity":
                        if (rdoCommodity.Checked)
                        {
                            strData[0] = "Commodity_Barcode";
                            strData[1] = "tblCommodity";
                        }
                        break;
                    case "rdoStaff":
                        if (rdoStaff.Checked)
                        {
                            strData[0] = "Staff_ID";
                            strData[1] = "tblStaff";
                        }
                        break;
                    case "rdoVendor":
                        if (rdoVendor.Checked)
                        {
                            strData[0] = "Vendor_Name";
                            strData[1] = "tblVendor";
                        }
                        break;
                }
            }

            return strData;
        }

        private void txtStaffID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(rdoScan.Checked)
            {
                //Checking if scanner starts with a TAB and ends with a CR
                if (e.KeyData == Keys.Tab)
                {
                    e.IsInputKey = true;
                    blnID = true;
                    txtStaffID.Text = "";
                }
                else
                {
                    if (blnID)
                    {
                        if (e.KeyData == Keys.Enter)
                        {
                            blnID = false;
                        }
                    }
                    else
                    {
                        txtStaffID.Text = "";
                    }
                }
            }
        }

        private void txtStaffID_KeyUp(object sender, KeyEventArgs e)
        {
            if(rdoScan.Checked)
            {
                if (txtStaffID.Text.Length == 1 && blnID == false)
                {
                    txtStaffID.Text = "";
                }
            }
        }

        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Because of how the combobox is populated, this conditional statement is required
            if (cmbField.Text != "System.Data.DataRowView")
            {
                txtDetails.Text = "";

                if (rdoCategory.Checked)
                {
                    //Make datatable
                    DataTable dtName = new DataTable();
                    SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT * FROM dbo.tblCategory WHERE Category_Name = '" + cmbField.Text + "';");

                    while (dataReader.Read())
                    {
                        txtDetails.Text = "Low Quantity Alert: " + dataReader["Qty_Alert"].ToString();
                    }

                    dataReader.Close();
                }
                else if (rdoCommodity.Checked)
                {
                    //Make datatable
                    DataTable dtName = new DataTable();
                    SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT * FROM dbo.tblCommodity WHERE Commodity_Barcode = '" + cmbField.Text + "';");

                    while (dataReader.Read())
                    {
                        txtDetails.Text = "Commodity Name: " + dataReader["Commodity_Name"].ToString() + "\r\n";
                        txtDetails.Text += "Commodity Category: " + dataReader["Commodity_Category"].ToString() + "\r\n";
                        txtDetails.Text += "Commodity Quantity: " + dataReader["Commodity_Qty"].ToString() + "\r\n";
                        txtDetails.Text += "Vendor Name: " + dataReader["Vendor_Name"].ToString() + "\r\n";
                    }

                    dataReader.Close();
                }
                else if (rdoStaff.Checked)
                {
                    //Make datatable
                    DataTable dtName = new DataTable();
                    SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT * FROM dbo.tblStaff WHERE Staff_ID = " + cmbField.Text + ";");

                    while (dataReader.Read())
                    {
                        txtDetails.Text = "Staff Name: " + dataReader["Staff_Name"].ToString();
                    }

                    dataReader.Close();
                }
            }
        }

        private void tbcSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbcSettings.SelectedTab == tbpEmail)
            {
                txtEmailPassword.Text = Settings.Default.strEmailPassword;
                txtEmailUsername.Text = Settings.Default.strEmailUsername;
                txtToEmail.Text = Settings.Default.strToEmail;
                txtSMTPClient.Text = Settings.Default.strSMTPClient;
                txtSMTPPort.Text = Settings.Default.strSMTPPort;
            }
        }
    }
}
