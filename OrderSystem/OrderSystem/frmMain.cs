using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Save to database
           //string mysql ="SELECT * FROM TBLMAINTENANCE";
           //DataSet ds = Database.LoadSQL(mysql, "TBLMAINTENANCE");

           //DataRow dsNewRow = null;
           //dsNewRow = ds.Tables["TBLMAINTENANCE"].NewRow();

           //dsNewRow[0] = 105;
           //dsNewRow[1] = "Sample";
           //dsNewRow[2] = "apples";

           //ds.Tables["TBLMAINTENANCE"].Rows.Add(dsNewRow);
           //Database.SaveEntry(ds,true );

            //Load from database
            //DataSet ds;
            //string mysql = "SELECT * FROM TBLMAINTENANCE";
            //ds = Database.LoadSQL(mysql, "TBLMAINTENANCE");

            //int a;
            //a = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
            //string key = Convert.ToString(ds.Tables[0].Rows[0]["OPT_KEYS"]);

            //MessageBox.Show(key.ToString());


            //Update
            Updates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateAdministrator();
        }

        //Save to database
        private string fillData = "TBLMAINTENANCE";
        public void CreateAdministrator(string pass = "misAdmin2016")
        {
            string mySql;
            mySql = "SELECT * FROM " + fillData;
            DataSet ds = null;
            Console.WriteLine("Create SQL: " + mySql);

            ds = Database.LoadSQL(mySql, fillData);
          
            DataRow dsNewRow = null;
            dsNewRow = ds.Tables[fillData].NewRow();

            var _with1 = dsNewRow;
            _with1[1] = "DiPota";
            _with1[2] = "Arte kau ka";

            ds.Tables[fillData].Rows.Add(_with1);
            Database.SaveEntry(ds, true);
        }



        public void Updates()
        {
            string mySql;
            mySql = "SELECT * FROM " + fillData + " WHERE ID = " + 1;
            DataSet ds = Database.LoadSQL(mySql, fillData);
            ds.Tables[0].Rows[0][1] = "Yes Update";
            Database.SaveEntry(ds, false);
            Console.WriteLine("Login Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory();
        }

       

        private void Inventory()
        {
            string mysql = null;
           
                mysql = "Select * From tblMaintenance";
           
            Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("txtMonthOf", "As of " + monCal.SelectionRange.Start.ToShortDateString());
            //dic.Add("branchName", mod_system.branchName);
            //dic.Add("txtUsername", mod_system.SystemUser.USERNAME);


            frmReport f1 = new frmReport();
            f1.ReportInit(mysql, "dsMain", "rptMaintenance.rdlc", dic);
            f1.Show();


        }
    }
}
