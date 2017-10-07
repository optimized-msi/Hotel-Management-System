using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Data.Odbc;


namespace OrderSystem
{
    class Database
    {

        public static OdbcConnection con;
        public static OdbcConnection ReaderCon;
        //Final
        static internal string dbName = "MOCPPOS.FDB";
        static internal string fbUser = "SYSDBA";
        static internal string fbPass = "masterkey";
        static internal DataSet fbDataSet = new DataSet();

        static internal string conStr = string.Empty;

        //Database version.
        private static string DBversion = "1";
        //verification if the database is connected.
        private static string[] language = { "Connection error failed." };
        /// <summary>
        /// This method shows the connection string of a database.
        /// Also here we open the database.
        /// </summary>
        /// <remarks></remarks>
        public static void dbOpen()
        {
            conStr = "DRIVER=Firebird/InterBase(r) driver;User=" + fbUser + ";Password=" + fbPass + ";Database=" + dbName + ";";

            con = new OdbcConnection(conStr);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                con.Dispose();
                //Interaction.MsgBox(language[0] + Constants.vbCrLf + ex.Message.ToString(), Constants.vbCritical, "Connecting Error");
                //Log_Report(ex.Message.ToString());
                //Log_Report(string.Format("User: {0}", fbUser));
                //Log_Report(string.Format("Database: {0}", dbName));
                return;
            }
        }

        /// <summary>
        /// This method is for closing after database was open here is the close.
        /// </summary>
        /// <remarks></remarks>
        public static void dbClose()
        {
            con.Close();
        }
        /// <summary>
        /// The database is ready to open.
        /// </summary>
        /// <returns>return false if the database is not ready.</returns>
        /// <remarks></remarks>
        static internal bool isReady()
        {
            bool ready = false;
            try
            {
                dbOpen();
                ready = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR] " + ex.Message.ToString());
                return false;
            }

            return ready;
        }

        /// <summary>
        /// Module 001
        /// Save the Dataset to the database
        /// </summary>
        /// <param name="dsEntry">Database with Table Name as Database Table Name</param>
        /// <returns>Boolean: Success Result</returns>
        /// <remarks></remarks>
        static internal bool SaveEntry(DataSet dsEntry, bool isNew = true)
        {
     
            if (dsEntry == null)
            {
                return false;
            }

            dbOpen();

            OdbcDataAdapter da = null;
            DataSet ds = new DataSet();
            string mySql = null;
            string fillData = null;
            ds = dsEntry;

            //Save all tables in the dataset
            foreach (DataTable dsTable in dsEntry.Tables)
            {
                fillData = dsTable.TableName;
                mySql = "SELECT * FROM " + fillData;
                if (!isNew)
                {
                    string colName = dsTable.Columns[0].ColumnName;
                    int idx = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                  mySql += string.Format(" WHERE {0} = {1}", colName, idx);

                   Console.WriteLine("ModifySQL: " + mySql);
                }

                da = new OdbcDataAdapter(mySql, con);   
                OdbcCommandBuilder cb = new OdbcCommandBuilder(da);
                //Required in Saving/Update to Database
                da.Update(ds, fillData);
            }

            dbClose();
            return true;
        }

        static internal void SQLCommand(string sql)
        {
            conStr = "DRIVER=Firebird/InterBase(r) driver;User=" + fbUser + ";Password=" + fbPass + ";Database=" + dbName + ";";
            con = new OdbcConnection(conStr);

            OdbcCommand cmd = null;
            cmd = new OdbcCommand(sql, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                //Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical);
                //Log_Report(string.Format("[{0}] - ", sql) + ex.ToString());
                con.Dispose();
                return;
            }

            System.Threading.Thread.Sleep(1000);
        }

        /// <summary>
        ///This function will check the compatibility of database version if it is match.
        /// </summary>
        /// <returns>return false if the database version is not match.</returns>
        /// <remarks></remarks>
        static internal bool DBCompatibilityCheck()
        {
            Console.WriteLine("Checking database compatibility...");
            string strDB = GetOption("DBVersion");

            if (DBversion == strDB)
            {
                Console.WriteLine("Success!");
                return true;
            }
            else
            {
                Console.WriteLine("Database Version didn't match... " + strDB);
                return false;
            }
        }

        /// <summary>
        ///This function where the table load to dataset.
        /// </summary>
        /// <param name="mySql">mysql where the data pass by.</param>
        /// <param name="tblName">tblName here is a variable that hold the data.</param>
        /// <returns>return ds after reading the mysql data.</returns>
        /// <remarks></remarks>
        static internal DataSet LoadSQL(string mySql, string tblName = "QuickSQL")
        {
            dbOpen();
            //open the database.

            OdbcDataAdapter da = null;
            DataSet ds = new DataSet();
            string fillData = tblName;
            try
            {
                da = new OdbcDataAdapter(mySql, con);
                da.Fill(ds, fillData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>>>>" + mySql);
            // MessageBox.show(ex.ToString());
               // Log_Report("LoadSQL - " + ex.ToString());
                ds = null;
            }

            dbClose();

            return ds;
        }

        /// <summary>
        /// This function is the declaration of odbccommand and odbcdatareader.
        /// </summary>
        /// <param name="mySql">mysql where the data pass</param>
        /// <returns></returns>
        /// <remarks></remarks>
        static internal OdbcDataReader LoadSQL_byDataReader(string mySql)
        {
            OdbcCommand myCom = new OdbcCommand(mySql, ReaderCon);
            OdbcDataReader reader = myCom.ExecuteReader();

            return reader;
        }
        /// <summary>
        /// The conStr here a variable that hold the connectionstring of the database.
        /// </summary>
        /// <remarks></remarks>
        public static void dbReaderOpen()
        {
            conStr = "DRIVER=Firebird/InterBase(r) driver;User=" + fbUser + ";Password=" + fbPass + ";Database=" + dbName + ";";

            ReaderCon = new OdbcConnection(conStr);
            try
            {
                ReaderCon.Open();
                //open the database.
            }
            catch (Exception ex)
            {
                ReaderCon.Dispose();
               // Interaction.MsgBox(language[0] + vbCrLf + ex.Message.ToString(), Constants.vbCritical, "Connecting Error");
               // Log_Report(ex.Message.ToString());
                return;
            }
        }
        /// <summary>
        /// close the database.
        /// </summary>
        /// <remarks></remarks>
        public static void dbReaderClose()
        {
            ReaderCon.Close();
        }

        /// <summary>
        /// This function select all data from tblmaintenance.
        /// </summary>
        /// <param name="keys">keys is the parameter </param>
        /// <returns>return ret after reading the dataset.</returns>
        /// <remarks></remarks>
        static internal string GetOption(string keys)
        {
            string mySql = "SELECT * FROM tblmaintenance WHERE opt_keys = '" + keys + "'";
            string ret = null;
            try
            {
                DataSet ds = LoadSQL(mySql);
               // ret = ds.Tables[0].Rows[0]["opt_values"];
            }
            catch (Exception ex)
            {
                ret = " ";
            }

            return ret;
        }

        private double _qty;
        public double Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        private double _rowTotal;
        public double RowTotal
        {
            get { return _rowTotal; }
        }

        private string _remarks;
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
    
    }
}
