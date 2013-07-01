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
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader; 
        DataSet ds = new DataSet();
        public Customer()
        {
            InitializeComponent();
            load_table(); 
            
        }
        private void load_table()
        {
            // [snip] - As C# is purely object-oriented the following lines must be put into a class:

            // We use these three SQLite objects:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            //sqlite_cmd.CommandText = "CREATE TABLE Customers (CustomerNumber integer primary key, Company VARCHAR(255), Contact VARCHAR(255), Phone integer, Street VARCHAR(255), Zip integer, City VARCHAR(255), Fax integer, CellPhone integer, Email VARCHAR(255), Notes VARCHAR(2000));";

            // Now lets execute the SQL ;D
            sqlite_cmd.ExecuteNonQuery();

            try
            {
                var da = new SQLiteDataAdapter("SELECT * FROM Customers;", sqlite_conn);
                da.Fill(ds);
                bindingSource1.DataSource = ds.Tables[0];
                //ds.
                //bindingSource1.DataMember = "Customers";
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                
                
                tbCustomerID.DataBindings.Add("Text", bindingSource1, "CustomerNumber");
                tbCompany.DataBindings.Add("Text", bindingSource1, "Company");
                tbContact.DataBindings.Add("Text", bindingSource1, "Contact");
                tbPhone.DataBindings.Add("Text", bindingSource1, "Phone");
                tbStreet.DataBindings.Add("Text", bindingSource1, "Street");
                tbZip.DataBindings.Add("Text", bindingSource1, "Zip");
                tbCity.DataBindings.Add("Text", bindingSource1, "City");
                tbFax.DataBindings.Add("Text", bindingSource1, "Fax");
                tbCellPhone.DataBindings.Add("Text", bindingSource1, "CellPhone");
                tbEmail.DataBindings.Add("Text", bindingSource1, "Email");
                tbNotes.DataBindings.Add("Text", bindingSource1, "Notes");
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
            // [snip] - As C# is purely object-oriented the following lines must be put into a class:

            // We use these three SQLite objects:
            sqlite_conn.Open();

            if (tbCustomerID.Text != "")
            {
                // Lets insert something into our new table:
                sqlite_cmd.CommandText = "INSERT INTO Customers (CustomerNumber, Company, Contact, Phone, Street, Zip, City, Fax, CellPhone, Email, Notes) VALUES (" +
                    tbCustomerID.Text + "," + tbCompany.Text + "," + tbContact.Text + "," + int.Parse(tbPhone.Text) + "," + tbStreet.Text + "," +
                    int.Parse(tbZip.Text) + "," + tbCity.Text + "," + int.Parse(tbFax.Text) + "," + int.Parse(tbCellPhone.Text) + "," + tbEmail.Text + "," +
                    tbNotes.Text + ");";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // [snip] - As C# is purely object-oriented the following lines must be put into a class:

            // We use these three SQLite objects:
            //sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "Update Customers SET CustomerNumber =, Company, Contact, Phone, Street, Zip, City, Fax, CellPhone, Email, Notes) VALUES (" +
                    tbCustomerID.Text + "," + tbCompany.Text + "," + tbContact.Text + "," + int.Parse(tbPhone.Text) + "," + tbStreet.Text + "," +
                    int.Parse(tbZip.Text) + "," + tbCity.Text + "," + int.Parse(tbFax.Text) + "," + int.Parse(tbCellPhone.Text) + "," + tbEmail.Text + "," +
                    tbNotes.Text + ");";
            // Now lets execute the SQL ;D
            sqlite_cmd.ExecuteNonQuery();

            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT * FROM Customers;", sqlite_conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                bindingSource1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Change Data
    }
}
