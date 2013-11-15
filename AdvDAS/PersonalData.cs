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
//using System.Data.SQLite;
using Finisar.SQLite;

namespace CRS
{
    public partial class PersonalData : Form
    {

        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database1.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        DataTable ds = new DataTable();
        private string picPath = "";

        public PersonalData()
        {
            InitializeComponent();
            PersonalData_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Logo";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picPath = ofd.FileName;
                pictureBox1.ImageLocation = picPath;

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

            //// We use these three SQLite objects:
            sqlite_conn.Open();


            try
            {
                var da = new SQLiteDataAdapter("SELECT * FROM Personal_Data WHERE PData = 1;", sqlite_conn);
                da.Fill(ds);
                bindingSource1.DataSource = ds;

                textBox1.DataBindings.Add("Text", bindingSource1, "Engineer");
                textBox2.DataBindings.Add("Text", bindingSource1, "Company");
                textBox3.DataBindings.Add("Text", bindingSource1, "Phone");
                comboBox1.DataBindings.Add("Text", bindingSource1, "State");
                textBox4.DataBindings.Add("Text", bindingSource1, "Street");
                textBox5.DataBindings.Add("Text", bindingSource1, "Zip");
                textBox6.DataBindings.Add("Text", bindingSource1, "City");
                textBox7.DataBindings.Add("Text", bindingSource1, "Fax");
                textBox8.DataBindings.Add("Text", bindingSource1, "CellPhone");
                textBox9.DataBindings.Add("Text", bindingSource1, "Email");
                textBox10.DataBindings.Add("Text", bindingSource1, "HomePage");
                analyzerBox.DataBindings.Add("Text", bindingSource1, "Analyzer");
                serialNoBox.DataBindings.Add("Text", bindingSource1, "SerialNo");
                sqlite_cmd = new SQLiteCommand("SELECT * FROM Personal_Data WHERE PData = 1;", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {
                    picPath = sqlite_datareader[14].ToString();
                }
                pictureBox1.ImageLocation = picPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personal Data: " + ex.Message + ex.StackTrace);
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox5.Text);
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                // Lets insert something into our new table:
                sqlite_cmd.CommandText = "UPDATE Personal_Data SET Engineer = '" + textBox1.Text + "', Company = '" + textBox2.Text
                        + "', Phone = '" + textBox3.Text + "', State = '" + comboBox1.Text + "', Street = '" + textBox4.Text + "', Zip = '" + textBox5.Text
                        + "', City = '" + textBox6.Text + "', Fax = '" + textBox7.Text + "', CellPhone = '" + textBox8.Text
                        + "', Email = '" + textBox9.Text + "', HomePage = '" + textBox10.Text + "', Analyzer = '" + analyzerBox.Text
                        + "', SerialNo = '" + serialNoBox.Text + "', LOGO = '" + picPath + "';";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

    }
}
