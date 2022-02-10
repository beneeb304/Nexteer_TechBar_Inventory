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
    public partial class frmAddEdit : Form
    {
        //Class vars
        private bool blnBarcode = false;
        private bool blnID = false;

        public frmAddEdit()
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
            switch (tbcAdd.SelectedIndex)
            {
                case 0:
                    //Make sure all fields are filled out
                    if (cmb0Category.Text.Length > 0 && cmb0Commodities.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + nud0Qty.Value +
                            " " + cmb0Commodities.Text + " to the inventory?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //Get current quantity in inventory
                            int intQty = 0;
                            SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Qty FROM dbo.tblCommodity WHERE Commodity_Category = '"
                                + cmb0Category.Text + "' AND Commodity_Name = '" + cmb0Commodities.Text + "';");

                            while (dataReader.Read())
                            {
                                intQty = int.Parse(dataReader["Commodity_Qty"].ToString());
                            }

                            dataReader.Close();

                            //Add to inventory
                            if (clsDatabase.ExecuteSQLNonQ("UPDATE dbo.tblCommodity SET Commodity_Qty = " +
                                (intQty + nud0Qty.Value) +
                                " WHERE Commodity_Category = '" + cmb0Category.Text + "' AND Commodity_Name = '" + cmb0Commodities.Text + "'"))
                            {
                                MessageBox.Show("Added " + nud0Qty.Value + " " + cmb0Commodities.Text + " to the inventory!", "Success");

                                //Add transaction to Log table
                                clsDatabase.ExecuteSQLNonQ("INSERT INTO dbo.tblLog VALUES(" +
                                    "''," + //staff name
                                    "''," + //user name
                                    "'" + cmb0Commodities.Text + "'," +
                                    "'" + cmb0Category.Text + "'," +
                                    "1," +  //staff action (1 = adding, 0 = subtracting)
                                    nud0Qty.Value + "," +
                                    (intQty + nud0Qty.Value) + "," +
                                    "'" + DateTime.Now.ToString() + "');");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + nud0Qty.Value + " " + cmb0Commodities.Text + " to the inventory!", "Error");
                            }
                        }
                    }

                    break;
                case 1:
                    //Make sure all fields are filled out
                    if (txt1Barcode.Text.Length > 0 && txt1Commodity.Text.Length > 0 && cmb1Category.Text.Length > 0 && cmb1Vendor.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + nud1Qty.Value +
                            " " + txt1Commodity.Text + " to the inventory?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (clsDatabase.ExecuteSQLNonQ("USE TBInvDB; INSERT INTO dbo.tblCommodity VALUES (" +
                                "'" + txt1Barcode.Text + "'," +
                                "'" + txt1Commodity.Text + "'," +
                                "'" + cmb1Category.Text + "'," +
                                "'" + cmb1Vendor.Text + "'," +
                                "'" + txt1VendorURL.Text + "'," +
                                nud1Qty.Value + ");"))
                            {
                                MessageBox.Show("Added " + txt1Commodity.Text + " as a new commodity!", "Success");

                                //Add transaction to Log table
                                clsDatabase.ExecuteSQLNonQ("INSERT INTO dbo.tblLog VALUES(" +
                                    "''," + //staff name
                                    "''," + //user name
                                    "'" + txt1Commodity.Text + "'," +
                                    "'" + cmb1Category.Text + "'," +
                                    "1," +  //staff action (1 = adding, 0 = subtracting)
                                    nud1Qty.Value + "," +
                                    nud1Qty.Value + "," +
                                    "'" + DateTime.Now.ToString() + "');");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + txt1Commodity.Text + " as a new commodity!", "Error");
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
                    
                    if(cmb2Category.Text != "" && cmb2Commodities.Text != "" && cmb2NewCategory.Text != "" && cmb2NewVendor.Text != "" && txt2Barcode.Text != "" && txt2NewCommodity.Text != "")
                    {
                        string strCmd;

                        if (chk2Qty.Checked)
                        {
                            strCmd = "UPDATE dbo.tblCommodity SET " +
                            "Commodity_Barcode = '" + txt2Barcode.Text + "', " +
                            "Commodity_Name = '" + txt2NewCommodity.Text + "', " +
                            "Commodity_Category = '" + cmb2NewCategory.Text + "', " +
                            "Vendor_Name = '" + cmb2NewVendor.Text + "', " +
                            "Vendor_URL = '" + txt2VendorURL.Text + "', " +
                            "Commodity_Qty = " + nud2Qty.Value +
                            " WHERE Commodity_Category = '" + cmb2Category.Text + "' AND Commodity_Name = '" + cmb2Commodities.Text + "';";
                        }
                        else
                        {
                            strCmd = "UPDATE dbo.tblCommodity SET " +
                            "Commodity_Barcode = '" + txt2Barcode.Text + "', " +
                            "Commodity_Name = '" + txt2NewCommodity.Text + "', " +
                            "Commodity_Category = '" + cmb2NewCategory.Text + "', " +
                            "Vendor_Name = '" + cmb2NewVendor.Text + "', " +
                            "Vendor_URL = '" + txt2VendorURL.Text + "' " +
                            " WHERE Commodity_Category = '" + cmb2Category.Text + "' AND Commodity_Name = '" + cmb2Commodities.Text + "';";
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
                    //Make sure all fields are filled out
                    if (txt3Category.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + txt3Category.Text +
                            " as a new category?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (clsDatabase.ExecuteSQLNonQ("USE TBInvDB; INSERT INTO dbo.tblCategory VALUES ('" + txt3Category.Text + "'," + nud3Qty.Value + ");"))
                            {
                                MessageBox.Show("Added " + txt3Category.Text + " as a new category!", "Success");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + txt3Category.Text + " as a new category!", "Error");
                            }
                        }
                    }

                    break;
                case 4:
                    //Make sure all fields are filled out
                    if (txt4Vendor.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + txt4Vendor.Text +
                            " as a new vendor?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (clsDatabase.ExecuteSQLNonQ("USE TBInvDB; INSERT INTO dbo.tblVendor VALUES ('" + txt4Vendor.Text + "');"))
                            {
                                MessageBox.Show("Added " + txt4Vendor.Text + " as a new vendor!", "Success");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + txt4Vendor.Text + " as a new vendor!", "Error");
                            }
                        }
                    }

                    break;

                case 5:
                    //Make sure all fields are filled out
                    if (txt5Staff.Text.Length > 0 && txt5StaffID.Text.Length > 0)
                    {
                        //Make sure the user wants to make this addition
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + txt5Staff.Text +
                            " as a new staff member?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (clsDatabase.ExecuteSQLNonQ("USE TBInvDB; INSERT INTO dbo.tblStaff VALUES ('" + txt5StaffID.Text + "', '" + txt5Staff.Text + "');"))
                            {
                                MessageBox.Show("Added " + txt5Staff.Text + " as a new staff member!", "Success");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + txt5Staff.Text + " as a new staff member!", "Error");
                            }
                        }
                    }
                    
                    break;
            }

            //Back to home
            btnBack_Click(sender, e);
        }

        private void tbcAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbcAdd.SelectedIndex)
            {
                case 0:
                    //Make datatable
                    DataTable dtAddCategory = new DataTable();

                    //Get list of commodities
                    dtAddCategory.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
                    cmb0Category.DataSource = dtAddCategory;
                    cmb0Category.ValueMember = "Category_Name";
                    cmb0Category.SelectedIndex = -1;
                    break;
                case 1:
                    //Make datatable
                    DataTable dtCategory = new DataTable();
                    DataTable dtVendor = new DataTable();

                    //Get list of item categories
                    dtCategory.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
                    cmb1Category.DataSource = dtCategory;
                    cmb1Category.ValueMember = "Category_Name";
                    cmb1Category.SelectedIndex = -1;

                    //Get list of vendors
                    dtVendor.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Vendor_Name FROM dbo.tblVendor;"));
                    cmb1Vendor.DataSource = dtVendor;
                    cmb1Vendor.ValueMember = "Vendor_Name";
                    cmb1Vendor.SelectedIndex = -1;

                    break;
                case 2:
                    //Make datatable
                    DataTable dt2OldCategory = new DataTable();

                    //Get list of commodities
                    dt2OldCategory.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
                    cmb2Category.DataSource = dt2OldCategory;
                    cmb2Category.ValueMember = "Category_Name";
                    cmb2Category.SelectedIndex = -1;
                    break;
                case 3:
                    break;
            }
        }

        private void cmb0Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make datatable
            DataTable dtCommodity = new DataTable();

            //Get list of commodities
            dtCommodity.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name FROM dbo.tblCommodity WHERE Commodity_Category = '" 
                + cmb0Category.Text + "';"));
            cmb0Commodities.DataSource = dtCommodity;
            cmb0Commodities.ValueMember = "Commodity_Name";
            cmb0Commodities.SelectedIndex = -1;
        }

        private void cmb2Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            //First, clear any data from beneath
            cmb2NewCategory.DataSource = null;
            cmb2NewCategory.Items.Clear();
            cmb2NewVendor.DataSource = null;
            cmb2NewVendor.Items.Clear();
            txt2Barcode.Text = "";
            txt2NewCommodity.Text = "";
            txt2VendorURL.Text = "";
            nud2Qty.Value = 1;
            chk2Qty.Checked = false;

            //Make datatable
            DataTable dtCommodity = new DataTable();

            //Get list of commodities
            dtCommodity.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name FROM dbo.tblCommodity WHERE Commodity_Category = '"
                + cmb2Category.Text + "';"));
            cmb2Commodities.DataSource = dtCommodity;
            cmb2Commodities.ValueMember = "Commodity_Name";
            cmb2Commodities.SelectedIndex = -1;
        }

        private void chk2Qty_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2Qty.Checked)
            {
                nud2Qty.Enabled = true;
                lblNewQty.Enabled = true;
            }
            else
            {
                nud2Qty.Enabled = false;
                lblNewQty.Enabled = false;
            }
        }

        private void btn2Lookup_Click(object sender, EventArgs e)
        {
            //Make sure all fields are filled out
            if (cmb2Category.Text.Length > 0 && cmb2Commodities.Text.Length > 0)
            {
                //Comboboxes
                DataTable dt2NewCategory = new DataTable();
                DataTable dt2Vendor = new DataTable();

                //Get list of commodities
                dt2NewCategory.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
                cmb2NewCategory.DataSource = dt2NewCategory;
                cmb2NewCategory.ValueMember = "Category_Name";

                //Get list of vendors
                dt2Vendor.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Vendor_Name FROM dbo.tblVendor;"));
                cmb2NewVendor.DataSource = dt2Vendor;
                cmb2NewVendor.ValueMember = "Vendor_Name";

                //Comboboxes and textboxes
                string strBarcode = "", strURL = "";
                int intQty = 0;

                txt2NewCommodity.Text = cmb2Commodities.Text;

                SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Vendor_URL, Commodity_Barcode, Commodity_Qty FROM dbo.tblCommodity WHERE Commodity_Name = '"
                    + cmb2Commodities.Text + "' AND Commodity_Category = '" + cmb2Category.Text + "';");

                while (dataReader.Read())
                {
                    strBarcode = dataReader["Commodity_Barcode"].ToString();
                    strURL = dataReader["Vendor_URL"].ToString();
                    intQty = int.Parse(dataReader["Commodity_Qty"].ToString());
                }

                dataReader.Close();

                txt2Barcode.Text = strBarcode;
                txt2VendorURL.Text = strURL;
                nud2Qty.Value = intQty;
            }
            else
            {
                MessageBox.Show("Please fill out all the fields", "Alert");
            }
        }

        private void cmb2Commodities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //First, clear any data from beneath
            cmb2NewCategory.DataSource = null;
            cmb2NewCategory.Items.Clear();
            cmb2NewVendor.DataSource = null;
            cmb2NewVendor.Items.Clear();
            txt2Barcode.Text = "";
            txt2NewCommodity.Text = "";
            txt2VendorURL.Text = "";
            nud2Qty.Value = 1;
            chk2Qty.Checked = false;
        }

        private void txt0Barcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Checking if scanner starts with a TAB and ends with a CR
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
                blnBarcode = true;
                txt0Barcode.Text = "";
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
                    txt0Barcode.Text = "";
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
                txt1Barcode.Text = "";
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
                    txt1Barcode.Text = "";
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
                txt2Barcode.Text = "";
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
                    txt2Barcode.Text = "";
                }
            }
        }

        private void txt5StaffID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Checking if scanner starts with a TAB and ends with a CR
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
                blnID = true;
                txt5StaffID.Text = "";
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
                    txt5StaffID.Text = "";
                }
            }
        }

        private void txt0Barcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt0Barcode.Text.Length == 1 && blnBarcode == false)
            {
                txt0Barcode.Text = "";
            }
            else if (txt0Barcode.Text.Length > 2 && blnBarcode == false)
            {
                //Lookup staff name
                SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name, Commodity_Category FROM dbo.tblCommodity WHERE Commodity_Barcode = '" + txt0Barcode.Text + "';");
                string strName = "", strCategory = "";

                while (dataReader.Read())
                {
                    strCategory = dataReader["Commodity_Category"].ToString();
                    strName = dataReader["Commodity_Name"].ToString();
                }

                dataReader.Close();

                cmb0Category.Text = strCategory;
                cmb0Commodities.Text = strName;

                //Check if barcode was valid
                if (cmb0Commodities.Text == "")
                {
                    txt0Barcode.Text = "";
                    MessageBox.Show("No commodities with this barcode in inventory", "Alert");
                }
            }
        }

        private void txt1Barcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt1Barcode.Text.Length == 1 && blnBarcode == false)
            {
                txt1Barcode.Text = "";
            }
        }

        private void txt2Barcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt2Barcode.Text.Length == 1 && blnBarcode == false)
            {
                txt2Barcode.Text = "";
            }
        }

        private void txt5StaffID_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt5StaffID.Text.Length == 1 && blnID == false)
            {
                txt5StaffID.Text = "";
            }
        }
    }
}