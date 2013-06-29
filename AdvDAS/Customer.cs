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
using System.IO;

namespace AdvDAS
{
    public partial class Customer : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        public Customer()
        {
            InitializeComponent();
            load_table();
        }
        private void load_table()
        {
            // [snip] - As C# is purely object-oriented the following lines must be put into a class:

            // We use these three SQLite objects:
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            //sqlite_cmd.CommandText = "CREATE TABLE Customers (CustomerNumber integer primary key, Company VARCHAR(255), Contact VARCHAR(255), Phone integer, Street VARCHAR(255), Zip integer, City VARCHAR(255), Fax integer, CellPhone integer, Email VARCHAR(255), Notes VARCHAR(2000));";

            // Now lets execute the SQL ;D
            sqlite_cmd.ExecuteNonQuery();

            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT * FROM Customers;", sqlite_conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLogo_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Logo";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string s = ofd.FileName;
                            tbLogo.Text = s;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            sqlite_cmd.ExecuteNonQuery();
            if (tbCustomerID.Text!="")
            // Lets insert something into our new table:
            sqlite_cmd.CommandText = "INSERT INTO Customers (CustomerNumber, Company, Contact, Phone, Street, Zip, City, Fax, CellPhone, Email, Notes) VALUES ("+
                int.Parse(tbCustomerID.Text)+","+tbCompany.Text+","+tbContact.Text+","+int.Parse(tbPhone.Text)+","+tbStreet.Text+","+
                int.Parse(tbZip.Text)+","+tbCity.Text+","+int.Parse(tbFax.Text)+","+int.Parse(tbCellPhone.Text)+","+tbEmail.Text+","+
                tbNotes.Text+");";

            // And execute this again ;D
            sqlite_cmd.ExecuteNonQuery();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
        //Change Data
    }
}
