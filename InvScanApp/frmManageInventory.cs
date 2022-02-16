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
    public partial class frmManageInventory : Form
    {
        //Class vars
        private bool blnBarcode = false;

        public frmManageInventory()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            //Click the tab control to populate combo boxes
            tbcAdd_SelectedIndexChanged(sender, e);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (tbcManage.SelectedIndex)
            {
                case 0:
                    //Make sure all fields are filled out
                    if (cmbAddCategory.Text.Length > 0 && cmbAddCommodities.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + nudAddQty.Value +
                            " " + cmbAddCommodities.Text + " to the inventory?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //Get current quantity in inventory
                            int intQty = 0;
                            SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Qty FROM dbo.tblCommodity WHERE Commodity_Category = '"
                                + cmbAddCategory.Text + "' AND Commodity_Name = '" + cmbAddCommodities.Text + "';");

                            while (dataReader.Read())
                            {
                                intQty = int.Parse(dataReader["Commodity_Qty"].ToString());
                            }

                            dataReader.Close();

                            //Add to inventory
                            if (clsDatabase.ExecuteSQLNonQ("UPDATE dbo.tblCommodity SET Commodity_Qty = " +
                                (intQty + nudAddQty.Value) +
                                " WHERE Commodity_Category = '" + cmbAddCategory.Text + "' AND Commodity_Name = '" + cmbAddCommodities.Text + "'"))
                            {
                                MessageBox.Show("Added " + nudAddQty.Value + " " + cmbAddCommodities.Text + " to the inventory!", "Success");

                                //Add transaction to Log table
                                clsDatabase.ExecuteSQLNonQ("INSERT INTO dbo.tblLog VALUES(" +
                                    "''," + //staff name
                                    "''," + //user name
                                    "'" + cmbAddCommodities.Text + "'," +
                                    "'" + cmbAddCategory.Text + "'," +
                                    "'Add'," +
                                    nudAddQty.Value + "," +
                                    (intQty + nudAddQty.Value) + "," +
                                    "'" + DateTime.Now.ToString() + "');");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + nudAddQty.Value + " " + cmbAddCommodities.Text + " to the inventory!", "Error");
                            }
                        }
                    }

                    break;
                case 1:
                    //Make sure all fields are filled out
                    if (txtCreateBarcode.Text.Length > 0 && txtCreateCommodity.Text.Length > 0 && cmbCreateCategory.Text.Length > 0 && cmbCreateVendor.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + nudCreateQty.Value +
                            " " + txtCreateCommodity.Text + " to the inventory?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (clsDatabase.ExecuteSQLNonQ("USE TBInvDB; INSERT INTO dbo.tblCommodity VALUES (" +
                                "'" + txtCreateBarcode.Text + "'," +
                                "'" + txtCreateCommodity.Text + "'," +
                                "'" + cmbCreateCategory.Text + "'," +
                                "'" + cmbCreateVendor.Text + "'," +
                                "'" + txtCreateVendorURL.Text + "'," +
                                nudCreateQty.Value + ");"))
                            {
                                MessageBox.Show("Added " + txtCreateCommodity.Text + " as a new commodity!", "Success");

                                //Add transaction to Log table
                                clsDatabase.ExecuteSQLNonQ("INSERT INTO dbo.tblLog VALUES(" +
                                    "''," + //staff name
                                    "''," + //user name
                                    "'" + txtCreateCommodity.Text + "'," +
                                    "'" + cmbCreateCategory.Text + "'," +
                                    "'Add'," +
                                    nudCreateQty.Value + "," +
                                    nudCreateQty.Value + "," +
                                    "'" + DateTime.Now.ToString() + "');");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + txtCreateCommodity.Text + " as a new commodity!", "Error");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill out all the fields", "Alert");
                    }

                    break;
                case 2:
                    //Update inventory (with or without quantity)
                    
                    if(cmbEditCategory.Text != "" && cmbEditCommodities.Text != "" && cmbEditNewCategory.Text != "" && cmbEditNewVendor.Text != "" && txtEditBarcode.Text != "" && txtEditNewCommodity.Text != "")
                    {
                        string strCmd;

                        if (chkEditQty.Checked)
                        {
                            strCmd = "UPDATE dbo.tblCommodity SET " +
                            "Commodity_Barcode = '" + txtEditBarcode.Text + "', " +
                            "Commodity_Name = '" + txtEditNewCommodity.Text + "', " +
                            "Commodity_Category = '" + cmbEditNewCategory.Text + "', " +
                            "Vendor_Name = '" + cmbEditNewVendor.Text + "', " +
                            "Vendor_URL = '" + txtEditVendorURL.Text + "', " +
                            "Commodity_Qty = " + nudEditQty.Value +
                            " WHERE Commodity_Category = '" + cmbEditCategory.Text + "' AND Commodity_Name = '" + cmbEditCommodities.Text + "';";
                        }
                        else
                        {
                            strCmd = "UPDATE dbo.tblCommodity SET " +
                            "Commodity_Barcode = '" + txtEditBarcode.Text + "', " +
                            "Commodity_Name = '" + txtEditNewCommodity.Text + "', " +
                            "Commodity_Category = '" + cmbEditNewCategory.Text + "', " +
                            "Vendor_Name = '" + cmbEditNewVendor.Text + "', " +
                            "Vendor_URL = '" + txtEditVendorURL.Text + "' " +
                            " WHERE Commodity_Category = '" + cmbEditCategory.Text + "' AND Commodity_Name = '" + cmbEditCommodities.Text + "';";
                        }

                        if (clsDatabase.ExecuteSQLNonQ(strCmd))
                        {
                            MessageBox.Show("Updated inventory!", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the inventory!", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill out all the fields", "Alert");
                    }

                    break;
                case 3:
                    if(cmbQtyCategory.Text != "" && nudQtyAlert.Value >= 0)
                    {
                        string strQtyCmd = "UPDATE dbo.tblCategory SET " +
                            "Qty_Alert = " + nudQtyAlert.Value +
                            " WHERE Category_Name = '" + cmbQtyCategory.Text + "';";

                        if (clsDatabase.ExecuteSQLNonQ(strQtyCmd))
                        {
                            MessageBox.Show("Updated quantity alert!", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update quantity alert!", "Error");
                        }
                    }

                    break;
            }

            //Back to home
            btnBack_Click(sender, e);
        }

        private void tbcAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbcManage.SelectedIndex)
            {
                case 0:
                    //Make datatable
                    DataTable dtAddCategory = new DataTable();

                    //Get list of commodities
                    dtAddCategory.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
                    cmbAddCategory.DataSource = dtAddCategory;
                    cmbAddCategory.ValueMember = "Category_Name";
                    cmbAddCategory.SelectedIndex = -1;
                    break;
                case 1:
                    //Make datatable
                    DataTable dtCategory = new DataTable();
                    DataTable dtVendor = new DataTable();

                    //Get list of item categories
                    dtCategory.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
                    cmbCreateCategory.DataSource = dtCategory;
                    cmbCreateCategory.ValueMember = "Category_Name";
                    cmbCreateCategory.SelectedIndex = -1;

                    //Get list of vendors
                    dtVendor.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Vendor_Name FROM dbo.tblVendor;"));
                    cmbCreateVendor.DataSource = dtVendor;
                    cmbCreateVendor.ValueMember = "Vendor_Name";
                    cmbCreateVendor.SelectedIndex = -1;

                    break;
                case 2:
                    //Make datatable
                    DataTable dt2OldCategory = new DataTable();

                    //Get list of commodities
                    dt2OldCategory.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
                    cmbEditCategory.DataSource = dt2OldCategory;
                    cmbEditCategory.ValueMember = "Category_Name";
                    cmbEditCategory.SelectedIndex = -1;
                    break;
                case 3:
                    //Make datatable
                    DataTable dtQtyCategory = new DataTable();

                    //Get list of item categories
                    dtQtyCategory.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
                    cmbQtyCategory.DataSource = dtQtyCategory;
                    cmbQtyCategory.ValueMember = "Category_Name";
                    cmbQtyCategory.SelectedIndex = -1;
                    break;
            }
        }

        private void cmb0Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make datatable
            DataTable dtCommodity = new DataTable();

            //Get list of commodities
            dtCommodity.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name FROM dbo.tblCommodity WHERE Commodity_Category = '" 
                + cmbAddCategory.Text + "';"));
            cmbAddCommodities.DataSource = dtCommodity;
            cmbAddCommodities.ValueMember = "Commodity_Name";
            cmbAddCommodities.SelectedIndex = -1;
        }

        private void cmb2Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            //First, clear any data from beneath
            cmbEditNewCategory.DataSource = null;
            cmbEditNewCategory.Items.Clear();
            cmbEditNewVendor.DataSource = null;
            cmbEditNewVendor.Items.Clear();
            txtEditBarcode.Text = "";
            txtEditNewCommodity.Text = "";
            txtEditVendorURL.Text = "";
            nudEditQty.Value = 1;
            chkEditQty.Checked = false;

            //Make datatable
            DataTable dtCommodity = new DataTable();

            //Get list of commodities
            dtCommodity.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name FROM dbo.tblCommodity WHERE Commodity_Category = '"
                + cmbEditCategory.Text + "';"));
            cmbEditCommodities.DataSource = dtCommodity;
            cmbEditCommodities.ValueMember = "Commodity_Name";
            cmbEditCommodities.SelectedIndex = -1;
        }

        private void chk2Qty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditQty.Checked)
            {
                nudEditQty.Enabled = true;
                lblNewQty.Enabled = true;
            }
            else
            {
                nudEditQty.Enabled = false;
                lblNewQty.Enabled = false;
            }
        }

        private void btn2Lookup_Click(object sender, EventArgs e)
        {
            //Make sure all fields are filled out
            if (cmbEditCategory.Text.Length > 0 && cmbEditCommodities.Text.Length > 0)
            {
                //Comboboxes
                DataTable dt2NewCategory = new DataTable();
                DataTable dt2Vendor = new DataTable();

                //Get list of commodities
                dt2NewCategory.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
                cmbEditNewCategory.DataSource = dt2NewCategory;
                cmbEditNewCategory.ValueMember = "Category_Name";

                //Get list of vendors
                dt2Vendor.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Vendor_Name FROM dbo.tblVendor;"));
                cmbEditNewVendor.DataSource = dt2Vendor;
                cmbEditNewVendor.ValueMember = "Vendor_Name";

                //Comboboxes and textboxes
                string strBarcode = "", strURL = "";
                int intQty = 0;

                txtEditNewCommodity.Text = cmbEditCommodities.Text;

                SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Vendor_URL, Commodity_Barcode, Commodity_Qty FROM dbo.tblCommodity WHERE Commodity_Name = '"
                    + cmbEditCommodities.Text + "' AND Commodity_Category = '" + cmbEditCategory.Text + "';");

                while (dataReader.Read())
                {
                    strBarcode = dataReader["Commodity_Barcode"].ToString();
                    strURL = dataReader["Vendor_URL"].ToString();
                    intQty = int.Parse(dataReader["Commodity_Qty"].ToString());
                }

                dataReader.Close();

                txtEditBarcode.Text = strBarcode;
                txtEditVendorURL.Text = strURL;
                nudEditQty.Value = intQty;
            }
            else
            {
                MessageBox.Show("Please fill out all the fields", "Alert");
            }
        }

        private void cmb2Commodities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //First, clear any data from beneath
            cmbEditNewCategory.DataSource = null;
            cmbEditNewCategory.Items.Clear();
            cmbEditNewVendor.DataSource = null;
            cmbEditNewVendor.Items.Clear();
            txtEditBarcode.Text = "";
            txtEditNewCommodity.Text = "";
            txtEditVendorURL.Text = "";
            nudEditQty.Value = 1;
            chkEditQty.Checked = false;
        }

        private void cmbQtyCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbQtyCategory.Text != "")
            {
                SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Qty_Alert FROM dbo.tblCategory WHERE Category_Name = '"
        + cmbQtyCategory.Text + "';");

                while (dataReader.Read())
                {
                    txtQtyAlert.Text = dataReader["Qty_Alert"].ToString();
                    nudQtyAlert.Value = int.Parse(dataReader["Qty_Alert"].ToString());
                }

                dataReader.Close();
            }
            else
            {
                txtQtyAlert.Text = "";
                nudQtyAlert.Value = 0;
                nudQtyAlert.ResetText();
            }
        }

        private void txt0Barcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Checking if scanner starts with a TAB and ends with a CR
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
                blnBarcode = true;
                txtAddBarcode.Text = "";
            }
            else
            {
                if (blnBarcode)
                {
                    if (e.KeyData == Keys.Enter)
                    {
                        blnBarcode = false;
                    }
                }
                else
                {
                    txtAddBarcode.Text = "";
                }
            }
        }

        private void txt1Barcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Checking if scanner starts with a TAB and ends with a CR
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
                blnBarcode = true;
                txtCreateBarcode.Text = "";
            }
            else
            {
                if (blnBarcode)
                {
                    if (e.KeyData == Keys.Enter)
                    {
                        blnBarcode = false;
                    }
                }
                else
                {
                    txtCreateBarcode.Text = "";
                }
            }
        }

        private void txt2Barcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Checking if scanner starts with a TAB and ends with a CR
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
                blnBarcode = true;
                txtEditBarcode.Text = "";
            }
            else
            {
                if (blnBarcode)
                {
                    if (e.KeyData == Keys.Enter)
                    {
                        blnBarcode = false;
                    }
                }
                else
                {
                    txtEditBarcode.Text = "";
                }
            }
        }

        private void txt0Barcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAddBarcode.Text.Length == 1 && blnBarcode == false)
            {
                txtAddBarcode.Text = "";
            }
            else if (txtAddBarcode.Text.Length > 2 && blnBarcode == false)
            {
                //Lookup staff name
                SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name, Commodity_Category FROM dbo.tblCommodity WHERE Commodity_Barcode = '" + txtAddBarcode.Text + "';");
                string strName = "", strCategory = "";

                while (dataReader.Read())
                {
                    strCategory = dataReader["Commodity_Category"].ToString();
                    strName = dataReader["Commodity_Name"].ToString();
                }

                dataReader.Close();

                cmbAddCategory.Text = strCategory;
                cmbAddCommodities.Text = strName;

                //Check if barcode was valid
                if (cmbAddCommodities.Text == "")
                {
                    txtAddBarcode.Text = "";
                    MessageBox.Show("No commodities with this barcode in inventory", "Alert");
                }
            }
        }

        private void txt1Barcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCreateBarcode.Text.Length == 1 && blnBarcode == false)
            {
                txtCreateBarcode.Text = "";
            }
        }

        private void txt2Barcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtEditBarcode.Text.Length == 1 && blnBarcode == false)
            {
                txtEditBarcode.Text = "";
            }
        }
    }
}