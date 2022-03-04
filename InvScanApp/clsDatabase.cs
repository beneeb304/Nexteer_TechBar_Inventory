using InvScanApp.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace InvScanApp
{
    class clsDatabase
    {
        //SQL Connection object
        static SqlConnection DBConn;

        private static string GetConnectionString()
        {
            while (Settings.Default.dbServerName == "")
            {
                //Ask user for server name
                Settings.Default.dbServerName = Microsoft.VisualBasic.Interaction.InputBox
                    ("Check SSMS to obtain server name. This is usually:\r\r(LocalDB)\\MSSQLLocalDB\r   or\rlocalhost\\SQLEXPRESS", "Enter SQL Server Name", "(LocalDB)\\MSSQLLocalD");

                //Save
                Settings.Default.Save();
            }

            if(Settings.Default.dbServerName == "")
            {
                //Quit app
                Application.Exit();
            }

            return "Server=" + Settings.Default.dbServerName + ";Database=master;Trusted_Connection=True;";
        }

        public static void ConnectToServer()
        {
            DBConn = new SqlConnection();

            try
            {
                //Make connection to DB
                DBConn = new SqlConnection(GetConnectionString());
                DBConn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting to DB.");
            }

            //If the database doesn't exist, create it
            InitializeDB();
        }

        public static void InitializeDB()
        {
            try
            {
                //Use a string builder to help simplify some of the SQL
                StringBuilder sbSQL = new StringBuilder();

                //Create DB if it doesn't exist
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT * FROM sys.databases WHERE name = 'TBInvDB')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE DATABASE TBInvDB");
                sbSQL.Append(" END;");

                //Execute
                ExecuteSQLNonQ(sbSQL.ToString());

                //Clear string builder for next build
                sbSQL.Clear();

                //Create Category Table
                sbSQL.Append("USE TBInvDB; ");
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT 1 FROM sys.tables WHERE name = 'tblCategory')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE TABLE dbo.tblCategory (");
                sbSQL.Append(" Category_Name VARCHAR(100) PRIMARY KEY,");
                sbSQL.Append(" Qty_Alert INT NOT NULL);");
                sbSQL.Append(" END;");

                //Create Commodity Table
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT 1 FROM sys.tables WHERE name = 'tblCommodity')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE TABLE tblCommodity (");
                sbSQL.Append(" Commodity_Barcode VARCHAR(200) PRIMARY KEY,");
                sbSQL.Append(" Commodity_Name VARCHAR(100) NOT NULL UNIQUE,");
                sbSQL.Append(" Commodity_Category VARCHAR(100) NOT NULL FOREIGN KEY REFERENCES tblCategory(Category_Name),");
                sbSQL.Append(" Vendor_Name VARCHAR(100),");
                sbSQL.Append(" Vendor_URL VARCHAR(MAX),");
                sbSQL.Append(" Commodity_Qty INT CHECK (Commodity_Qty >= 0));");
                sbSQL.Append(" END;");

                //Create Vendor Table
                sbSQL.Append("USE TBInvDB; ");
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT 1 FROM sys.tables WHERE name = 'tblVendor')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE TABLE dbo.tblVendor (");
                sbSQL.Append(" Vendor_Name VARCHAR(100) PRIMARY KEY);");
                sbSQL.Append(" END;");

                //Create Staff Table
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT 1 FROM sys.tables WHERE name = 'tblStaff')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE TABLE tblStaff (");
                sbSQL.Append(" Staff_ID INT PRIMARY KEY,");
                sbSQL.Append(" Staff_Name VARCHAR(100) NOT NULL);");
                sbSQL.Append(" END;");

                //Create Log Table
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT 1 FROM sys.tables WHERE name = 'tblLog')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE TABLE tblLog (");
                sbSQL.Append(" Log_TUID INT IDENTITY(1,1) PRIMARY KEY,");
                sbSQL.Append(" Staff_Name VARCHAR(100),");
                sbSQL.Append(" Recipient_Name VARCHAR(100),");
                sbSQL.Append(" Commodity_Category VARCHAR(100),");
                sbSQL.Append(" Commodity_Name VARCHAR(100),");
                sbSQL.Append(" Staff_Action VARCHAR(10) NOT NULL,");
                sbSQL.Append(" Qty_Action INT NOT NULL,");
                sbSQL.Append(" Qty_New INT NOT NULL,");
                sbSQL.Append(" Action_Time DATETIME NOT NULL);");
                sbSQL.Append(" END;");

                //Execute
                ExecuteSQLNonQ(sbSQL.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Initializing DB.");
            }

            if (DBConn.State == System.Data.ConnectionState.Open)
            {
                DBConn.Close();
            }
        }

        public static bool ExecuteSQLNonQ(string strSQL)
        {
            if(DBConn.State == ConnectionState.Closed)
            {
                DBConn.Open();
            }
            
            //Create SQL command
            SqlCommand DBCmd = new SqlCommand(strSQL, DBConn);

            try
            {
                DBCmd.ExecuteNonQuery();
                return true;
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error executing SQL statement");
                return false;
            }
        }

        public static SqlDataReader ExecuteSqlReader(string strSQL)
        {
            if (DBConn.State == ConnectionState.Closed)
            {
                DBConn.Open();
            }

            SqlCommand DBCmd = new SqlCommand(strSQL, DBConn);
            SqlDataReader dataReader = null;

            try
            {
                dataReader = DBCmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error reading SQL");
            }

            return dataReader;
        }

        public static DataTable PopulateDGV()
        {
            SqlCommand DBCmd = new SqlCommand();

            try
            {
                DBCmd.CommandText = "USE TBInvDB; SELECT * FROM tblCommodity";
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(DBCmd.CommandText, DBConn);

                DataSet myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet);

                return myDataSet.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
