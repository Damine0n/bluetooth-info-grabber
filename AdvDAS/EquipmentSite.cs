using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Data.SQLite;
//using Finisar.SQLite;

namespace CRS
{
    public partial class EquipmentSite : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        DataSet ds = new DataSet();
        private MassEBC ebc = new MassEBC();
        private string Customer;
        public EquipmentSite(string Customer)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            sqlite_conn.Open();
            this.Customer = Customer;
            Fillcombo();

        }
        void Fillcombo()
        {
            siteBox.Items.Clear();
            equipBox.Items.Clear();
            try
            {
                sqlite_cmd = new SQLiteCommand("SELECT * FROM Sites WHERE Customer ='" + this.Customer + "';", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string sites = sqlite_datareader[0].ToString();
                    siteBox.Items.Add(sites);
                }
                sqlite_datareader.Close();
                siteBox.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Please, create site and equipment");
            }
        }

        private void btnDeleteSite_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete the site: " + this.siteBox.SelectedItem.ToString() + "?", "Delete Site", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "DELETE FROM Sites WHERE Site = '" + this.siteBox.SelectedItem.ToString() + "';";
                    sqlite_cmd.ExecuteNonQuery();
                    Fillcombo();
                    siteBox.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DirectoryInfo di = new DirectoryInfo(@"Reports\" + this.siteBox.SelectedItem.ToString());
                di.Delete();
            }
            else
                return;
        }

        private void btnDeleteEquip_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this equipment?", "Delete Equipment", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                if (dialog == DialogResult.Yes)
                {
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "DELETE FROM Equipments WHERE owner = '" + this.siteBox.SelectedItem.ToString()
                                                    + "' And equipment = '" + this.equipBox.SelectedItem.ToString() + "';";
                    sqlite_cmd.ExecuteNonQuery();
                    equipBox.Items.Clear();
                    Fillcombo();
                    equipBox.SelectedIndex = 0;
                    DirectoryInfo di = new DirectoryInfo(Path.Combine(@"Reports\" + this.siteBox.SelectedItem.ToString(), this.equipBox.SelectedItem.ToString()));
                    di.Delete();
                }
                else
                    return;
        }
        private void btnCreateSite_Click(object sender, EventArgs e)
        {
            string x="";
            try
            {
                 x= Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the new site.", "New Site", "");
                sqlite_cmd.CommandText = "INSERT INTO Sites (Site,Customer) VALUES ('" + x + "','" + Customer + "');";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Site name must be unique.");
            }
            string path = @"Reports\" + x;
            try
            {
                // Determine whether the directory exists. 
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);

            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
            

            CreateEquipment(x);
            siteBox.Items.Clear();
            equipBox.Items.Clear();
            Fillcombo();
            siteBox.SelectedItem = x;
            
        }



        private void CreateEquipment(string x)
        {
            string y = Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the new equipment.", "New Equipment", "");
            try
            {
                sqlite_cmd.CommandText = "INSERT INTO Equipments (owner, equipment) VALUES ('" + x + "','" + y + "');";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string path = @"Reports\" + x;
            try
            {
                // Determine whether the directory exists. 
                if (Directory.Exists(Path.Combine(path,y)))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(Path.Combine(path,y));

            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
        }

        private void btnCreateEquip_Click(object sender, EventArgs e)
        {
            if (siteBox.Text.ToString() != "")
            {
                CreateEquipment(this.siteBox.Text.ToString());
                equipBox.Items.Clear();
                Fillcombo();
            }
            else
                MessageBox.Show("You must select a site first.");
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                sqlite_cmd = sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "Update Equipments SET unitNum  = '" + this.tbUnitNum.Text + "' , model  = '" + this.tbModel.Text + "', serialNum  = '"
                    + this.tbSerialNum.Text + "', service = '" + this.tbService.Text + "', ignitionTiming = '" + this.tbIgnitionTiming.Text + "', stackFlow = '"
                    + this.tbStackFlow.Text + "', stackTemp = '" + this.tbStackTemp.Text + "', intakeMPL = '" + this.tbIntakeMPL.Text + "', intakeMPR = '"
                    + this.tbIntakeMPR.Text + "', intakeMTL = '" + this.tbIntakeMTL.Text + "', intakeMTR = '" + this.tbIntakeMTR.Text + "', stackHeightFT = '"
                    + this.tbStackHeightFT.Text + "', stackHeightIN = '" + this.tbStackHeightIN.Text + "', fuelSG = '" + this.tbFuelSG.Text + "', RPM = '"
                    + this.tbRPM.Text + "', AFControllerMake = '" + this.AFControllerMake.Text + "', AFControllerModel = '" + this.AFControllerModel.Text + "', catalyticConverterMake = '"
                    + this.tbCatalyticConverterMake.Text + "', catalyticConverterModeL = '" + this.tbCatalyticConverterModel.Text + "', AirPermit = '" 
                    + this.tbAirPermit.Text + "', permitDate = '" + this.tbPermitDate.Value + "', permitEquip = '" + this.tbPermitEquip
                    + "'  WHERE equipment = '" + this.equipBox.SelectedText + "';";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "UPDATE Sites SET Area =  '" + this.textBox1.Text + "', Facility ='"
                    + this.textBox2.Text + "' Where site = '" + this.siteBox.Text.ToString() + "' ;";
                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void siteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                equipBox.Items.Clear();
                sqlite_cmd = new SQLiteCommand("SELECT Sites.area, Sites.facility, Equipments.equipment FROM Sites INNER JOIN Equipments ON Sites.site"
                    + " = Equipments.owner WHERE Site = '" + this.siteBox.Text.ToString() + "';", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {
                    string area = sqlite_datareader[0].ToString();
                    textBox1.Text = area;
                    string facility = sqlite_datareader[1].ToString();
                    textBox2.Text = facility;
                    string equipments = sqlite_datareader[2].ToString();
                    equipBox.Items.Add(equipments);
                }
                sqlite_datareader.Close();
                equipBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personal Data: " + ex.Message);
            }
        }

        private void equipBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                sqlite_cmd = new SQLiteCommand("SELECT * FROM Equipments WHERE owner = '" + this.siteBox.Text.ToString()
                    + "' AND equipment = '" + this.equipBox.Text.ToString() + "';", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {
                    string unitNum = sqlite_datareader[2].ToString();
                    tbUnitNum.Text = unitNum;

                    string model = sqlite_datareader[3].ToString();
                    tbModel.Text = model;

                    string serialNum = sqlite_datareader[4].ToString();
                    tbSerialNum.Text = serialNum;

                    string service = sqlite_datareader[5].ToString();
                    tbService.Text = service;

                    string ignitionTiming = sqlite_datareader[6].ToString();
                    tbIgnitionTiming.Text = ignitionTiming;

                    string stackFlow = sqlite_datareader[7].ToString();
                    tbStackFlow.Text = stackFlow;

                    string stackTemp = sqlite_datareader[8].ToString();
                    tbStackTemp.Text = stackTemp;

                    string intakeMPL = sqlite_datareader[9].ToString();
                    tbIntakeMPL.Text = intakeMPL;

                    string intakeMPR = sqlite_datareader[10].ToString();
                    tbIntakeMPR.Text = intakeMPR;

                    string intakeMTL = sqlite_datareader[11].ToString();
                    tbIntakeMTL.Text = intakeMTL;

                    string intakeMTR = sqlite_datareader[12].ToString();
                    tbIntakeMTR.Text = intakeMTR;

                    string stackHeightFT = sqlite_datareader[13].ToString();
                    tbStackHeightFT.Text = stackHeightFT;

                    string stackHeightIN = sqlite_datareader[14].ToString();
                    tbStackHeightIN.Text = stackHeightIN;

                    string fuelSG = sqlite_datareader[15].ToString();
                    tbFuelSG.Text = fuelSG;

                    string RPM = sqlite_datareader[16].ToString();
                    tbRPM.Text = RPM;

                    string controllerMake = sqlite_datareader[17].ToString();
                    AFControllerMake.Text = controllerMake;

                    string controllerModel = sqlite_datareader[18].ToString();
                    AFControllerModel.Text = controllerModel;

                    string catalyticConverterMake = sqlite_datareader[19].ToString();
                    tbCatalyticConverterMake.Text = catalyticConverterMake;

                    string catalyticConverterModel = sqlite_datareader[20].ToString();
                    tbCatalyticConverterModel.Text = catalyticConverterModel;

                    string AirPermit = sqlite_datareader[21].ToString();
                    this.tbAirPermit.Text = AirPermit;

                    DateTime permitDate = Convert.ToDateTime(sqlite_datareader[22]);
                    this.tbPermitDate.Value = permitDate;

                    string permitEquip = sqlite_datareader[23].ToString();
                    this.tbPermitEquip.Text = permitEquip;
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personal Data: " + ex.Message);
            }
            GasAnalysis.equipment = this.equipBox.Text.ToString();
            GasAnalysis.site = this.siteBox.Text.ToString();
            MainMenu.equipment = "Equipment: " + this.equipBox.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ebc.ShowDialog();
        }
        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox src = sender as CheckBox;
            if (src.Checked == true)
            {
                MessageBox.Show("Select '" + src.Text + " - Corrected' in the tile dropdown menu to view.");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            TextBox Box = (TextBox)sender;
            try
            {
                sqlite_cmd = sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "UPDATE Equipments SET COLimit =  '" + Box.Text + "'  WHERE equipment = '" + this.equipBox.SelectedText + "';";
                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            TextBox Box = (TextBox)sender;
            try
            {
                sqlite_cmd = sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "UPDATE Equipments SET NOxLimit =  '" + Box.Text + "'  WHERE equipment = '" + this.equipBox.SelectedText + "';";
                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
