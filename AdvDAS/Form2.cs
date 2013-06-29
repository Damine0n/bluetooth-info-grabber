using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace AdvDAS
{
    public partial class Form2 : Form
    {
        // We use these three SQLite objects:
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        public Form2()
        {
            InitializeComponent();
        }

       void load_table()
        {
            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");



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
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            sqlite_conn.Open();

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
                var da = new SQLiteDataAdapter("SELECT * FROM test", sqlite_conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();
        }
    }
}
