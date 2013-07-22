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

namespace CRS
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



            try
            {
                var da = new SQLiteDataAdapter("SELECT * FROM Customers;", sqlite_conn);
                da.Fill(ds);
                bindingSource1.DataSource = ds.Tables[0];
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                
                
                tbCustomerID.DataBindings.Add("Text", bindingSource1, "CustomerID");
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
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                if (tbCustomerID.Text != "")
                {
                    // Lets insert something into our new table:
                    sqlite_cmd.CommandText = "INSERT INTO Customers (CustomerID, Company, Contact, Phone, Street, Zip, City, Fax, CellPhone, Email, Notes) VALUES ('" 
                        + tbCustomerID.Text + "','" + tbCompany.Text + "','" + tbContact.Text + "','" + tbPhone.Text + "','" 
                        + tbStreet.Text + "','" + tbZip.Text + "','" + tbCity.Text + "','" + tbFax.Text + "','" 
                        + tbCellPhone.Text + "','" + tbEmail.Text + "','" + tbNotes.Text + "');";

                    // And execute this again ;D
                    sqlite_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("You must have a value in Customer ID.");
                }
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
            try
            {
                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "Update Customers SET CustomerID = '" + this.tbCustomerID.Text + "', Company = '" + this.tbCompany.Text + "', Contact = '" + this.tbContact.Text
                    + "', Phone = '" + this.tbPhone.Text + "', Street = '" + this.tbStreet.Text + "', Zip = '" + this.tbZip.Text 
                    + "', City = '" + this.tbCity.Text + "', Fax = '" + this.tbFax.Text + "', CellPhone = '" + this.tbCellPhone.Text 
                    + "', Email = '" + this.tbEmail.Text + "', Notes = '" + this.tbNotes.Text + "' WHERE CustomerID = '" + this.tbCustomerID.Text + "';";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "DELETE FROM Customers WHERE CustomerID = '"+this.tbCustomerID.Text+"';";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Change Data
    }
}
