using InvScanApp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvScanApp
{
    class clsDatabase
    {
        //SQL Connection object
        static SqlConnection DBConn;

        private static string GetConnectionString()
        {
            //Build connection string
            return "server=" + Properties.Settings.Default.dbServerName + 
                ";database=" + Properties.Settings.Default.dbServerName + 
                "; UID=" + Properties.Settings.Default.dbUser + 
                ";password=" + Properties.Settings.Default.dbPassword;
        }

        public static SqlConnection ConnectToDB()
        {
            SqlConnection DBConn = new SqlConnection();

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

            return DBConn;
        }

        public static void InitializeDB()
        {
            //Make connection to DB
            SqlConnection DBConn = new SqlConnection("Server=" + Properties.Settings.Default.dbServerName.ToString());

            SqlCommand DBCmd = new SqlCommand();

            try
            {
                //NOTE: if the client fails to connect, nothing beyond this line of this method will execute!!!
                //It will instead go right to the Catch().

                //Connect to database
                DBConn.Open();

                //Use a string builder to help simplify some of the SQL
                StringBuilder sbSQL = new StringBuilder();

                //Create DB if it doesn't exist
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT * FROM sys.databases WHERE name = 'TBInvDB')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE DATABASE TBInvDB");
                sbSQL.Append(" END;");

                //Execute
                DBCmd.CommandText = sbSQL.ToString();
                DBCmd.Connection = DBConn;
                DBCmd.ExecuteNonQuery();

                //Clear string builder for next build
                sbSQL.Clear();

                //Create Category Table if it doesn't exist
                sbSQL.Append("USE TBInvDB; ");
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT 1 FROM sys.tables WHERE name = 'tblCategory')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE TABLE dbo.tblCategory (");
                sbSQL.Append(" Category_Name VARCHAR(100) PRIMARY KEY);");
                sbSQL.Append(" END;");

                //Create Commodity Table if it doesn't exist
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT 1 FROM sys.tables WHERE name = 'tblCommodity')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE TABLE tblCommodity (");
                sbSQL.Append(" Commodity_Barcode VARCHAR(100) PRIMARY KEY,");
                sbSQL.Append(" Commodity_Name VARCHAR(100) NOT NULL UNIQUE,");
                sbSQL.Append(" Commodity_Category VARCHAR(100) NOT NULL UNIQUE FOREIGN KEY REFERENCES tblCategory(Category_Name),");
                sbSQL.Append(" Vendor_Name VARCHAR(100),");
                sbSQL.Append(" Vendor_URL VARCHAR(100),");
                sbSQL.Append(" Commodity_Qty INT CHECK (Commodity_Qty >= 0));");
                sbSQL.Append(" END;");

                //Create Staff Table if it doesn't exist
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT 1 FROM sys.tables WHERE name = 'tblStaff')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE TABLE tblStaff (");
                sbSQL.Append(" Staff_Barcode VARCHAR(100) PRIMARY KEY,");   //Will be used as barcode
                sbSQL.Append(" Staff_Name VARCHAR(100) NOT NULL UNIQUE);");
                sbSQL.Append(" END;");

                //Execute
                DBCmd.CommandText = sbSQL.ToString();
                DBCmd.Connection = DBConn;
                DBCmd.ExecuteNonQuery();

                //Clear string builder for next build
                sbSQL.Clear();

                //Create Log Table if it doesn't exist
                sbSQL.Append("IF NOT EXISTS (");
                sbSQL.Append(" SELECT 1 FROM sys.tables WHERE name = 'tblLog')");
                sbSQL.Append(" BEGIN");
                sbSQL.Append(" CREATE TABLE tblLog (");
                sbSQL.Append(" Log_TUID INT IDENTITY(1,1) PRIMARY KEY,");   //Will be used as barcode
                sbSQL.Append(" Staff_Name VARCHAR(100) FOREIGN KEY REFERENCES tblStaff(Staff_Name),");
                sbSQL.Append(" User_Name VARCHAR(100) NOT NULL,");
                sbSQL.Append(" Commodity_Name VARCHAR(100) FOREIGN KEY REFERENCES tblCommodity(Commodity_Name),");
                sbSQL.Append(" Commodity_Category VARCHAR(100) FOREIGN KEY REFERENCES tblCommodity(Commodity_Category),");
                sbSQL.Append(" Qty_Action INT);");
                sbSQL.Append(" END;");

                Console.WriteLine(sbSQL.ToString());

                DBCmd.CommandText = sbSQL.ToString();
                DBCmd.Connection = DBConn;
                DBCmd.ExecuteNonQuery();
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

        private static void ExecuteSQLNonQ(string strSQL)
        {
            SqlCommand DBCmd = new SqlCommand();
            DBCmd.CommandText = strSQL;
            DBCmd.Connection = DBConn;

            try
            {
                DBCmd.ExecuteNonQuery();
            } catch
            {
                MessageBox.Show("Error executing SQL statement");
            }
        }

        public static DataTable PopulateDGV()
        {
            //Make connection to DB
            SqlConnection DBConn = ConnectToDB();

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

        //public static int SelectID(int intSelectedID)
        //{
        //    //Make connection to DB
        //    SqlConnection DBConn = ConnectToDB();

        //    SqlCommand DBCmd = new SqlCommand();

        //    try
        //    {
        //        //SELECT FROM Register table and store in container (string array for now)
        //        DBCmd.CommandText = "USE ScaleVue; SELECT COUNT(1) FROM Register WHERE ID = " + intSelectedID;
        //        DBCmd.Connection = DBConn;

        //        SqlDataReader myDataReader;
        //        myDataReader = DBCmd.ExecuteReader();

        //        int intCtr = 0;

        //        while (myDataReader.Read())
        //        {
        //            intCtr = int.Parse(myDataReader[0].ToString());
        //        }

        //        //Close data reader since we're done with it
        //        myDataReader.Close();

        //        return intCtr;
        //    }
        //    catch (Exception)
        //    {
        //        //FIND ME
        //        return -1;
        //    }
        //}
    }
}
