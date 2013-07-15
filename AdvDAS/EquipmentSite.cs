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
using Finisar.SQLite;

namespace CRS
{
    public partial class EquipmentSite : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        DataSet ds = new DataSet();
        public EquipmentSite()
        {
            InitializeComponent();
            sqlite_conn.Open();
            Fillcombo();
        }
        void Fillcombo()
        {
            siteBox.Items.Clear();
            try
            {
                int i=0;
                sqlite_cmd = new SQLiteCommand("SELECT * FROM Sites;", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string sites = sqlite_datareader[0].ToString();
                    siteBox.Items.Add(sites);
                    i++;
                }
                sqlite_datareader.Close();
                siteBox.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personal Data: " + ex.Message);
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
                    siteBox.Items.Clear();
                    Fillcombo();
                    siteBox.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    sqlite_cmd.CommandText = "DELETE FROM Equipment WHERE owner = '" + this.siteBox.SelectedItem.ToString() 
                                                    + "' And equipment = '" + this.equipBox.SelectedItem.ToString() + "';";
                    sqlite_cmd.ExecuteNonQuery();
                    siteBox.Items.Clear();
                    Fillcombo();
                    siteBox.SelectedIndex = 0;
                    sqlite_conn.Close();
                }
            else
                return;
        }
        private void btnCreateSite_Click(object sender, EventArgs e)
        {
            string x = Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the new site.", "New Site", "");
            sqlite_cmd.CommandText = "INSERT INTO Sites (Site) VALUES ('" + x + "');";
            sqlite_cmd.ExecuteNonQuery();
            CreateEquipment(x);           
            siteBox.Items.Clear();
            Fillcombo();
        }

        private void CreateEquipment(string x)
        {
            string y = Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the new equipment.", "New Equipment", "");
            try
            {
                sqlite_cmd.CommandText = "INSERT INTO Equipment (owner, equipment) VALUES ('" + x + "','" + y + "');";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "Update Equipment SET unitNum  = '" + this.tbUnitNum.Text + "' , model  = '" + this.tbModel.Text + "', serialNum  = '" 
                    + this.tbSerialNum.Text + "', service = '" + this.tbService.Text + "', ignitionTiming = '" + this.tbIgnitionTiming.Text + "', stackFlow = '" 
                    + this.tbStackFlow.Text + "', stackTemp = '" + this.tbStackTemp.Text + "', intakeMPL = '" + this.tbIntakeMPL.Text + "', intakeMPR = '" 
                    + this.tbIntakeMPR.Text + "', intakeMTL = '" + this.tbIntakeMTL.Text + "', intakeMTR = '" + this.tbIntakeMTR.Text + "', stackHeightFT = '" 
                    + this.tbStackHeightFT.Text + "', stackHeightIN = '" + this.tbStackHeightIN.Text + "', fuelSG = '" + this.tbFuelSG.Text + "', RPM = '" 
                    + this.tbRPM.Text + "', AFControllerMake = '" + this.AFControllerMake.Text + "', AFControllerModel = '" + this.AFControllerModel.Text + "', catalyticConverterMake = '" 
                    + this.tbCatalyticConverterMake.Text + "', catalyticConverterModeL = '" + this.tbCatalyticConverterModel.Text
                    + "'  WHERE equipment = '"+this.equipBox.SelectedText+"';";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "UPDATE Sites SET Area =  '" + this.textBox1.Text + "', Facility ='" 
                    + this.textBox2.Text + "' Where site = '"+this.siteBox.Text.ToString()+"' ;";
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
                equipBox.SelectedItem = 1;
                sqlite_cmd = new SQLiteCommand("SELECT Sites.area, Sites.facility, Equipment.equipment FROM Sites INNER JOIN Equipment ON Sites.site"
                    + " = Equipment.owner WHERE Site = '" + this.siteBox.Text.ToString() + "';", sqlite_conn);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personal Data: " + ex.Message);
            }
        }
    }
}
