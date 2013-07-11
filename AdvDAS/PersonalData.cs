using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Finisar.SQLite;

namespace CRS
{
    public partial class PersonalData : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        DataSet ds = new DataSet();

        public PersonalData()
        {
            InitializeComponent();
            PersonalData_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Logo";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string s = ofd.FileName;
                pictureBox1.ImageLocation = s;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox6.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void PersonalData_Load()
        {
             // [snip] - As C# is purely object-oriented the following lines must be put into a class:

            // We use these three SQLite objects:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            //sqlite_cmd.CommandText = "CREATE TABLE Customers (CustomerID integer primary key, Company VARCHAR(255), Contact VARCHAR(255), Phone integer, Street VARCHAR(255), Zip integer, City VARCHAR(255), Fax integer, CellPhone integer, Email VARCHAR(255), Notes VARCHAR(2000));";

            // Now lets execute the SQL ;D
            sqlite_cmd.ExecuteNonQuery();

            try
            {
                var da = new SQLiteDataAdapter("SELECT * FROM Personal_Data WHERE PData = 1;", sqlite_conn);
                da.Fill(ds);
                bindingSource1.DataSource = ds.Tables[0];
                                
                textBox1.DataBindings.Add("Text", bindingSource1, "Engineer");
                textBox2.DataBindings.Add("Text", bindingSource1, "Company");
                textBox3.DataBindings.Add("Text", bindingSource1, "Phone");
                textBox4.DataBindings.Add("Text", bindingSource1, "Street");
                textBox5.DataBindings.Add("Text", bindingSource1, "Zip");
                textBox6.DataBindings.Add("Text", bindingSource1, "City");
                textBox7.DataBindings.Add("Text", bindingSource1, "Fax");
                textBox8.DataBindings.Add("Text", bindingSource1, "CellPhone");
                textBox9.DataBindings.Add("Text", bindingSource1, "Email");
                textBox10.DataBindings.Add("Text", bindingSource1, "HomePage");
                //pictureBox1.DataBindings.Add()
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personal Data: " + ex.Message);
            }
        
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                    // Lets insert something into our new table:
                sqlite_cmd.CommandText = "UPDATE Personal_Data SET Engineer = '" + textBox1.Text + "', Company = '" + textBox2.Text
                        + "', Phone = '" + textBox3.Text + "', Street = '" + textBox4.Text + "', Zip = '" + textBox5.Text 
                        + "', City = '" + textBox6.Text + "', Fax = '" + textBox7.Text + "', CellPhone = '" + textBox8.Text 
                        + "', Email = '" + textBox9.Text + "', HomePage = '" + textBox10.Text + "' WHERE PData = 1;";

                    // And execute this again ;D
                    sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        
        }

        static byte[] GetBytes(SQLiteDataReader reader)
        {
            const int CHUNK_SIZE = 2 * 1024;
            byte[] buffer = new byte[CHUNK_SIZE];
            long bytesRead;
            long fieldOffset = 0;
            using (MemoryStream stream = new MemoryStream())
            {
                while ((bytesRead = reader.GetBytes(0, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, (int)bytesRead);
                    fieldOffset += bytesRead;
                }
                return stream.ToArray();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter numerical digits only.");
            }
            
        }
    }
}
