﻿using System;
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
    public partial class frmHandOut : Form
    {
        //Current available quantity of selected item in stock
        private int intAvailableQty;

        public frmHandOut()
        {
            InitializeComponent();
        }

        private void frmHandOut_Load(object sender, EventArgs e)
        {
            //Make datatables
            DataTable dtCat = new DataTable();
            DataTable dtStaff = new DataTable();

            //Get list of categories and populate combobox
            dtCat.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Category_Name FROM dbo.tblCategory;"));
            cmbItemCategory.DataSource = dtCat;
            cmbItemCategory.ValueMember = "Category_Name";
            cmbItemCategory.SelectedIndex = -1;

            //Get list of staff names and populate combobox
            dtStaff.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Staff_Name FROM dbo.tblStaff;"));
            cmbStaffName.DataSource = dtStaff;
            cmbStaffName.ValueMember = "Staff_Name";
            cmbStaffName.SelectedIndex = -1;
        }

        private void cmbItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make datatable
            DataTable dtName = new DataTable();

            //Get list of item names for selected category and populate combobox
            dtName.Load(clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Name FROM dbo.tblCommodity WHERE Commodity_Category = '" + cmbItemCategory.Text + "';"));
            cmbItemName.DataSource = dtName;
            cmbItemName.ValueMember = "Commodity_Name";
            cmbItemName.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strError = "Please fill out the following information before continuing!\n\n";

            //Make sure Item info is filled out
            if((cmbItemCategory.Text == "" || cmbItemName.Text == "") && txtItemID.Text == "")
            {
                //Something isn't filled out, so inform user
                strError += "Item Category, Item Name OR Item ID (barcode)\n";
            }

            //Make sure Staff info is filled out
            if(cmbStaffName.Text == "" && txtStaffID.Text == "")
            {
                //Something isn't filled out, so inform user
                strError += "Staff Name OR Staff ID (QR code)\n";
            }

            //Make sure Recipient info is filled out
            if(txtRecipientName.Text == "" && txtRecipientID.Text == "")
            {
                //Something isn't filled out, so inform user
                strError += "Recipient Name OR Recipient ID (QR code)\n";
            }

            //Check if we had any errors
            if(strError.Contains("Item") || strError.Contains("Staff") || strError.Contains("Recipient"))
            {
                MessageBox.Show(strError, "Error");
            }
            else
            {
                //Make sure there is enough quantity available to subtract


                //If so, add transaction to Log table
                clsDatabase.ExecuteSQLNonQ("INSERT INTO dbo.tblLog VALUES ();");
                //staff name
                //user name
                //commodity category
                //commodity name
                //qty removed

                //Remove items from Commodity table

            }
        }

        private void cmbStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear textbox
            txtStaffID.Text = "";
        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear textbox
            txtItemID.Text = "";
        }

        private void txtRecipientName_TextChanged(object sender, EventArgs e)
        {
            //Clear textbox
            txtRecipientID.Text = "";
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

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            //Set name combobox back to blank
            cmbItemCategory.SelectedIndex = -1;
            cmbItemName.SelectedIndex = -1;

            try
            {
                string strCat = "", strName = "";

                SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Commodity_Category, Commodity_Name FROM dbo.tblCommodity WHERE Commodity_Barcode = '" + txtItemID.Text + "'");

                while (dataReader.Read())
                {
                    strCat = dataReader["Commodity_Category"].ToString();
                    strName = dataReader["Commodity_Name"].ToString();
                }

                dataReader.Close();

                cmbItemCategory.SelectedValue = strCat;
                cmbItemName.SelectedValue = strName;
            }
            catch
            {
                MessageBox.Show("Error retreiving Item ID");
            }
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            //Set name combobox back to blank
            cmbStaffName.SelectedIndex = -1;

            //Only continue if the input is all digits
            if (txtStaffID.Text.Length > 0 && txtStaffID.Text.All(Char.IsDigit))
            {
                try
                {
                    SqlDataReader dataReader = clsDatabase.ExecuteSqlReader("USE TBInvDB; SELECT Staff_Name FROM dbo.tblStaff WHERE Staff_ID = " + txtStaffID.Text);

                    while (dataReader.Read())
                    {
                        cmbStaffName.SelectedValue = dataReader["Staff_Name"];
                    }

                    dataReader.Close();
                }
                catch
                {
                    MessageBox.Show("Error retreiving Staff ID");
                }
            }
        }
    }
}
