using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
//using Finisar.SQLite;
using System.IO;

namespace CRS
{
    public partial class Form2 : Form
    {
        // We use these three SQLite objects:
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");

        private SQLiteCommand sqlite_cmd;
        public Form2()
        {
            InitializeComponent();
            sqlite_conn.Open();
        }

       void load_table()
        {
            // create a new database connection:



            // But how do we read something out of our table ?

            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT * FROM test", sqlite_conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // [snip] - As C# is purely object-oriented the following lines must be put into a class:

            // create a new database connection:
            //sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            //// Let the SQLiteCommand object know our SQL-Query:
            //sqlite_cmd.CommandText = "CREATE TABLE test (id integer primary key, text varchar(100));";

            //// Now lets execute the SQL ;D
            //sqlite_cmd.ExecuteNonQuery();

            //// Lets insert something into our new table:
            //sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (1, 'Test Text 1');";

            //// And execute this again ;D
            //sqlite_cmd.ExecuteNonQuery();

            //// ...and inserting another line:
            //sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (2, 'Test Text 2');";

            // And execute this again ;D
            sqlite_cmd.ExecuteNonQuery();


             //But how do we read something out of our table ?
 
            try
            {
                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM test", sqlite_conn);
                da.Fill(ds);
                //ds.Tables[0].Columns[2].DefaultValue;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }

            // We are ready, now lets cleanup and close our connection:
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Logo";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string s = ofd.FileName;
                pictureBox1.ImageLocation = s;
                //byte[] logo = File.ReadAllBytes(ofd.FileName);
            
                SQLiteDataAdapter da = new SQLiteDataAdapter("Select * From MyImages", sqlite_conn);
                SQLiteCommandBuilder MyCB = new SQLiteCommandBuilder(da);
                DataSet ds = new DataSet("MyImages");

                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                FileStream fs = new FileStream(s, FileMode.OpenOrCreate, FileAccess.Read);

                byte[] MyData = new byte[fs.Length];
                fs.Read(MyData, 0, System.Convert.ToInt32(fs.Length));

                fs.Close();

                da.Fill(ds, "MyImages");

                DataRow myRow = ds.Tables["MyImages"].NewRow();

                myRow["Description"] = "This would be description text";
                myRow["imgField"] = MyData;
                ds.Tables["MyImages"].Rows.Add(myRow);
                da.Update(ds, "MyImages");

                //sqlite_conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select * From MyImages", sqlite_conn);
            SQLiteCommandBuilder MyCB = new SQLiteCommandBuilder(da);
            DataSet ds = new DataSet("MyImages");

            byte[] MyData= new byte[0];
			
            da.Fill(ds, "MyImages");
            DataRow myRow;
            myRow=ds.Tables["MyImages"].Rows[0];
           
            MyData =  (byte[])myRow["imgField"];
            int ArraySize = new int();
            ArraySize = MyData.GetUpperBound(0); 

            FileStream fs = new FileStream(@"C:\winnt\Gone Fishing2.BMP", FileMode.OpenOrCreate, FileAccess.Write);
            fs.Write(MyData, 0,ArraySize);
            fs.Close();
        }
    }
}
