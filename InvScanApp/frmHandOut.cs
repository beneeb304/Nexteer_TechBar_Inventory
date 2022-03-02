using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvScanApp
{
    public partial class frmHandOut : Form
    {
        bool blnBarcode = false;
        string strBarcode = "";

        public frmHandOut()
        {
            InitializeComponent();
        }

        private void frmHandOut_Load(object sender, EventArgs e)
        {
            //Make datatables
            DataTable dtCat = new DataTable();
            DataTable dtStaff = new DataTable();

            //Get list of staff names and populate combobox
            dtStaff.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Staff_Name FROM dbo.tblStaff;"));
            cmbStaffName.DataSource = dtStaff;
            cmbStaffName.ValueMember = "Staff_Name";
            cmbStaffName.SelectedIndex = -1;

            //Get list of categories and populate combobox
            dtCat.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
            cmbCommodityCategory.DataSource = dtCat;
            cmbCommodityCategory.ValueMember = "Category_Name";
            cmbCommodityCategory.SelectedIndex = -1;
        }

        private void btnHandOut_Click(object sender, EventArgs e)
        {
            string strRecipient = "";
            
            string strError = "Please fill out the following information before continuing!\n\n";

            //Make sure Item info is filled out
            if (cmbCommodityCategory.Text == "" || cmbCommodityName.Text == "")
            {
                //Something isn't filled out, so inform user
                strError += "Item Category, Item Name OR Item ID (barcode)\n";
            }

            //Make sure Staff info is filled out
            if (cmbStaffName.Text == "")
            {
                //Something isn't filled out, so inform user
                strError += "Staff Name OR Staff ID (QR code)\n";
            }

            //Make sure Recipient info is filled out
            if (cmbRecipientName.Text == "")
            {
                if(txtRecipientName.Text == "")
                {
                    //Something isn't filled out, so inform user
                    strError += "Recipient Name\n";
                }
                else
                {
                    strRecipient = txtRecipientName.Text;
                }
            }
            else
            {
                strRecipient = cmbRecipientName.Text;
            }

            //Check if we had any errors
            if (strError.Contains("Item") || strError.Contains("Staff") || strError.Contains("Recipient"))
            {
                MessageBox.Show(strError, "Error");
            }
            else
            {
                try
                {
                    //Make sure there is enough quantity available to subtract
                    int intQty = 0;
                    string strVendor = "", strVendorURL = "";
                    SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Qty, Vendor_Name, Vendor_URL FROM dbo.tblCommodity WHERE Commodity_Name = '" + cmbCommodityName.Text + "';");

                    while (dataReader.Read())
                    {
                        intQty = int.Parse(dataReader["Commodity_Qty"].ToString());
                        strVendor = dataReader["Vendor_Name"].ToString();
                        strVendorURL = dataReader["Vendor_URL"].ToString();
                    }

                    dataReader.Close();

                    if (nudQty.Value > intQty)
                    {
                        MessageBox.Show("There are not enough items in inventory for this transaction!", "Alert");
                    }
                    else
                    {
                        intQty = (intQty - (int)nudQty.Value);

                        //Add transaction to Log table
                        if (clsDatabase.ExecuteSQLNonQ("INSERT INTO dbo.tblLog VALUES(" +
                            "'" + cmbStaffName.Text + "'," +
                            "'" + strRecipient + "'," +
                            "'" + cmbCommodityCategory.Text + "'," +
                            "'" + cmbCommodityName.Text + "'," +
                            "'Hand-Out'," +
                            nudQty.Value + "," +
                            (intQty) + "," +
                            "'" + DateTime.Now.ToString() + "');"))
                        {
                            //Remove items from Commodity table
                            if (clsDatabase.ExecuteSQLNonQ("UPDATE dbo.tblCommodity SET Commodity_Qty = " +
                                (intQty) +
                                " WHERE Commodity_Category = '" + cmbCommodityCategory.Text + "' AND Commodity_Name = '" + cmbCommodityName.Text + "'"))
                            {
                                MessageBox.Show("Handed-Out " + nudQty.Value + " " + cmbCommodityName.Text + " to " + strRecipient, "Success");
                            }

                            //Check if we hit the low quantity threshold
                            int intLowQty = 0;
                            dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Qty_Alert FROM dbo.tblCategory WHERE Category_Name = '" + cmbCommodityCategory.Text + "';");

                            while (dataReader.Read())
                            {
                                intLowQty = int.Parse(dataReader["Qty_Alert"].ToString());
                            }

                            dataReader.Close();

                            if (intQty <= intLowQty)
                            {
                                string strBody = "Low quantity alert triggered for " + cmbCommodityName.Text + ".\r" +
                                    "The current in-stock quantity is " + intQty + ".\r" +
                                    "Consider re-ordering these from " + strVendor + ".\r" +
                                    strVendorURL + "\r\r" +
                                    "Regards,\r" +
                                    "- Ben Bot\r";

                                clsEmail.SendEmail(strBody, "Tech Bar Inventory - Low Quantity Alert", "", "");
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong handing this item out!", "Error");
                }

                //Back to home
                btnBack_Click(sender, e);
            }
        }

        private void cmbItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make datatable
            DataTable dtName = new DataTable();

            //Get list of item names for selected category and populate combobox
            dtName.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name FROM dbo.tblCommodity WHERE Commodity_Category = '" + cmbCommodityCategory.Text + "';"));
            cmbCommodityName.DataSource = dtName;
            cmbCommodityName.ValueMember = "Commodity_Name";
            cmbCommodityName.SelectedIndex = -1;
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

        //private void txtStaffID_KeyUp(object sender, KeyEventArgs e)
        //{
        //    //Set name combobox back to blank
        //    cmbStaffName.SelectedIndex = -1;

        //    if (txtStaffID.Text.Length == 1 && blnStaffID == false)
        //    {
        //        txtStaffID.Text = "";
        //    }
        //    else if (txtStaffID.Text.Length == 5 && blnStaffID == false)
        //    {
        //        //Lookup staff name
        //        SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Staff_Name FROM dbo.tblStaff WHERE Staff_ID = " + txtStaffID.Text + ";");

        //        while (dataReader.Read())
        //        {
        //            cmbStaffName.Text = dataReader["Staff_Name"].ToString();
        //        }

        //        dataReader.Close();

        //        //Check if barcode was valid
        //        if (cmbStaffName.Text == "")
        //        {
        //            txtStaffID.Text = "";
        //            MessageBox.Show("No users with this ID", "Alert");
        //        }
        //    }
        //}

        //private void txtCommodityBarcode_KeyUp(object sender, KeyEventArgs e)
        //{
        //    //Set name combobox back to blank
        //    cmbCommodityCategory.SelectedIndex = -1;
        //    cmbCommodityName.SelectedIndex = -1;

        //    if (txtCommodityBarcode.Text.Length == 1 && blnCommodityID == false)
        //    {
        //        txtCommodityBarcode.Text = "";
        //    }
        //    else if (txtCommodityBarcode.Text.Length > 2 && blnCommodityID == false)
        //    {
        //        //Lookup staff name
        //        SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name, Commodity_Category FROM dbo.tblCommodity WHERE Commodity_Barcode = '" + txtCommodityBarcode.Text + "';");
        //        string strName = "", strCategory = "";

        //        while (dataReader.Read())
        //        {
        //            strCategory = dataReader["Commodity_Category"].ToString();
        //            strName = dataReader["Commodity_Name"].ToString();
        //        }

        //        dataReader.Close();

        //        cmbCommodityCategory.Text = strCategory;
        //        cmbCommodityName.Text = strName;

        //        //Check if barcode was valid
        //        if (cmbCommodityName.Text == "")
        //        {
        //            txtCommodityBarcode.Text = "";
        //            MessageBox.Show("No commodities with this barcode in inventory", "Alert");
        //        }
        //    }
        //}

        private void txtRecipientName_TextChanged(object sender, EventArgs e)
        {
            if(txtRecipientName.Text.Length > 2)
            {
                List<string> lstUsers = GetADUsers(txtRecipientName.Text);
                cmbRecipientName.Enabled = true;
                cmbRecipientName.DataSource = lstUsers;
            }
            else
            {
                cmbRecipientName.SelectedIndex = -1;
                cmbRecipientName.Enabled = false;
            }
        }

        public List<string> GetADUsers(string searchQuery)
        {
            try
            {
                List<string> lstADUsers = new List<string>();
                DirectoryEntry searchRoot = new DirectoryEntry();
                DirectorySearcher search = new DirectorySearcher(searchRoot);
                search.Filter = "(&(objectClass=User)(objectCategory=person)(anr=" + searchQuery + "))";
                search.PropertiesToLoad.Add("samaccountname");
                search.PropertiesToLoad.Add("mail");
                search.PropertiesToLoad.Add("usergroup");
                search.PropertiesToLoad.Add("displayname");
                SearchResult result;
                SearchResultCollection resultCol = search.FindAll();
                if (resultCol != null)
                {
                    for (int counter = 0; counter < resultCol.Count; counter++)
                    {
                        result = resultCol[counter];
                        if (result.Properties.Contains("samaccountname") &&
                                 result.Properties.Contains("mail") &&
                            result.Properties.Contains("displayname"))
                        {
                            lstADUsers.Add((string)result.Properties["mail"][0]);
                        }
                    }
                }
                return lstADUsers;
            }
            catch (Exception)
            {
                return null;
            }
        }

        void BarcodeKeyPress(object sender, KeyPressEventArgs e)
        {
            //Assume this is barcode data
            e.Handled = true;
            
            if(e.KeyChar == 2)
            {
                //Set flag to start scanning
                blnBarcode = true;
            }
            else if(e.KeyChar == 3)
            {
                //Set flag to stop scanning
                blnBarcode = false;

                //Determine if ID or commodity
                if(strBarcode.Length == 5 && !strBarcode.Any(x => char.IsLetter(x)))
                {
                    //Lookup staff name
                    SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Staff_Name FROM dbo.tblStaff WHERE Staff_ID = " + strBarcode + ";");

                    while (dataReader.Read())
                    {
                        cmbStaffName.Text = dataReader["Staff_Name"].ToString();
                    }

                    dataReader.Close();

                    //Check if barcode was valid
                    if (cmbStaffName.Text == "")
                    {
                        MessageBox.Show("No users with this ID", "Alert");
                    }
                }
                else
                {
                    //Lookup category and commodity
                    SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name, Commodity_Category FROM dbo.tblCommodity WHERE Commodity_Barcode = '" + strBarcode + "';");
                    string strName = "", strCategory = "";

                    while (dataReader.Read())
                    {
                        strCategory = dataReader["Commodity_Category"].ToString();
                        strName = dataReader["Commodity_Name"].ToString();
                    }

                    dataReader.Close();

                    cmbCommodityCategory.Text = strCategory;
                    cmbCommodityName.Text = strName;

                    //Check if barcode was valid
                    if (cmbCommodityName.Text == "")
                    {
                        MessageBox.Show("No commodities with this barcode in inventory", "Alert");
                    }

                    dataReader.Close();
                }

                //Empty barcode string
                strBarcode = "";
            }
            else if (blnBarcode)
            {
                //Only allow if ascii a letter or number
                if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122))
                {
                    //Get char
                    char c = e.KeyChar;

                    //Add char to string
                    strBarcode += c;
                }
            }
            else
            {
                //If not barcode data, pass it through
                e.Handled = false;
            }
        }
    }
}
