using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SQLite;
using Finisar.SQLite;
using System.IO;

namespace CRS
{
    public partial class Customer : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + "\\database1.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        private EquipmentSite eSite = new EquipmentSite();
        DataTable ds = new DataTable();
        public Customer()
        {
            InitializeComponent();
            load_table();
            AutoCompleteTest();
            eSite.Customer = tbCustomerID.Text;
            MainMenu.eSite = this.eSite;
        }
        private void load_table()
        {
            dataGridView1.Rows.Clear();
            // We use these three SQLite objects:
            sqlite_conn.Open();
            try
            {
                var da = new SQLiteDataAdapter("SELECT * FROM Customers;", sqlite_conn);
                da.Fill(ds);
                bindingSource1.DataSource = ds;
                dataGridView1.DataSource = bindingSource1;
                
                tbCustomerID.DataBindings.Add("Text", bindingSource1, "CustomerID");
                tbCompany.DataBindings.Add("Text", bindingSource1, "Company");
                tbContact.DataBindings.Add("Text", bindingSource1, "Contact");
                tbPhone.DataBindings.Add("Text", bindingSource1, "Phone");
                tbStreet.DataBindings.Add("Text", bindingSource1, "Street");
                tbZip.DataBindings.Add("Text", bindingSource1, "Zip");
                tbCity.DataBindings.Add("Text", bindingSource1, "City");
                comboBox1.DataBindings.Add("Text", bindingSource1, "Fax");
                tbCellPhone.DataBindings.Add("Text", bindingSource1, "CellPhone");
                tbEmail.DataBindings.Add("Text", bindingSource1, "Email");
                tbNotes.DataBindings.Add("Text", bindingSource1, "Notes");
                da.Update(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        + tbStreet.Text + "','" + tbZip.Text + "','" + tbCity.Text + "','" + comboBox1.Text + "','" 
                        + tbCellPhone.Text + "','" + tbEmail.Text + "','" + tbNotes.Text + "');";

                    // And execute this again ;D
                    sqlite_cmd.ExecuteNonQuery();
                    load_table();
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
                sqlite_cmd.CommandText = "Update Customers SET CustomerID = '" + this.tbCustomerID.Text + "', Company = '" + this.tbCompany.Text 
                    + "', Contact = '" + this.tbContact.Text + "', Phone = '" + this.tbPhone.Text + "', Street = '" + this.tbStreet.Text + "', Zip = '" + this.tbZip.Text 
                    + "', City = '" + this.tbCity.Text + "', Fax = '" + this.comboBox1.Text + "', CellPhone = '" + this.tbCellPhone.Text 
                    + "', Email = '" + this.tbEmail.Text + "', Notes = '" + this.tbNotes.Text + "' WHERE CustomerID = '" + this.tbCustomerID.Text + "';";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this customer from the Database?", "Delete Customer", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sqlite_cmd = sqlite_conn.CreateCommand();
                try
                {
                    // Let the SQLiteCommand object know our SQL-Query:
                    sqlite_cmd.CommandText = "DELETE FROM Customers WHERE CustomerID = '" + this.tbCustomerID.Text + "';";
                    // Now lets execute the SQL ;D
                    sqlite_cmd.ExecuteNonQuery();
                    load_table();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                return;
        }

        private void customerUpdate_Leave(object sender, EventArgs e)
        {
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "Update Customers SET CustomerID = '" + this.tbCustomerID.Text + "', Company = '" + this.tbCompany.Text + "', Contact = '" + this.tbContact.Text
                    + "', Phone = '" + this.tbPhone.Text + "', Street = '" + this.tbStreet.Text + "', Zip = '" + this.tbZip.Text
                    + "', City = '" + this.tbCity.Text + "', Fax = '" + this.comboBox1.Text + "', CellPhone = '" + this.tbCellPhone.Text
                    + "', Email = '" + this.tbEmail.Text + "', Notes = '" + this.tbNotes.Text + "' WHERE CustomerID = '" + this.tbCustomerID.Text + "';";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "Update Customers SET CustomerID = '" + this.tbCustomerID.Text + "', Company = '" + this.tbCompany.Text + "', Contact = '" + this.tbContact.Text
                    + "', Phone = '" + this.tbPhone.Text + "', Street = '" + this.tbStreet.Text + "', Zip = '" + this.tbZip.Text
                    + "', City = '" + this.tbCity.Text + "', Fax = '" + this.comboBox1.Text + "', CellPhone = '" + this.tbCellPhone.Text
                    + "', Email = '" + this.tbEmail.Text + "', Notes = '" + this.tbNotes.Text + "' WHERE CustomerID = '" + this.tbCustomerID.Text + "';";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.Text = tbCustomerID.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            eSite.Customer = tbCustomerID.Text;
            eSite.ShowDialog();
        }
        void AutoCompleteTest()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            try
            {
                sqlite_cmd = new SQLiteCommand("SELECT * FROM Test_Tables;", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string tests = sqlite_datareader[1].ToString();
                    coll.Add(tests);
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SearchBar.AutoCompleteCustomSource = coll;
        }
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(ds);
            DV.RowFilter = string.Format("CustomerID LIKE '%{0}%' or Company LIKE '%{0}%' or Contact LIKE '%{0}%' or Phone LIKE '%{0}%' "+
                "or Street LIKE '%{0}%' or Zip LIKE '%{0}%' or City LIKE '%{0}%' or Fax LIKE '%{0}%' or CellPhone LIKE '%{0}%' or Email LIKE '%{0}%' or Notes LIKE '%{0}%'", SearchBar.Text);
            dataGridView1.DataSource = DV;
        }

    }
}
