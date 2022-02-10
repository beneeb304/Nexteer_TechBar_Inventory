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
    public partial class frmRemove : Form
    {
        public frmRemove()
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

        private string[] GetTableField(){
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cmbField.Text.Length > 0)
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
    }
}
