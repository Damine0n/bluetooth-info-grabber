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
            EquipmentSite_Load();
        }
        void Fillcombo()
        {
            

            // create a new SQL command:
           // sqlite_cmd = sqlite_conn.CreateCommand();

           

            // Now lets execute the SQL ;D
            //sqlite_cmd.ExecuteNonQuery();

            try
            {
                
                sqlite_cmd = new SQLiteCommand("SELECT * FROM Sites;", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                //bindingSource1.DataSource = ds.Tables[0];
                while (sqlite_datareader.Read())
                {
                    string sites = sqlite_datareader[0].ToString();
                    siteBox.Items.Add(sites);
                }
                
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
                }
            else
                return;
        }
        private void btnCreateSite_Click(object sender, EventArgs e)
        {
            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();



            // Now lets execute the SQL ;D
            //sqlite_cmd.ExecuteNonQuery();
            string x = Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the new site.", "New Site", "");
            sqlite_cmd.CommandText = "INSERT INTO Sites (Site) VALUES ('" + x + "');";

            // And execute this again ;D
            sqlite_cmd.ExecuteNonQuery();
            siteBox.Items.Clear();
            Fillcombo();
        }

        private void btnCreateEquip_Click(object sender, EventArgs e)
        {
            string x = Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the new equipment.", "New Equipment", "");
            sqlite_cmd.CommandText = "INSERT INTO Equipment (equipment) VALUES ('" + x + "');";

            // And execute this again ;D
            sqlite_cmd.ExecuteNonQuery();
            equipBox.Items.Clear();
            Fillcombo();
        }
        private void EquipmentSite_Load()
        {
            //CREATE TABLE EquipmentSite (owner TEXT, site TEXT, equipment TEXT, unitNum INTEGER, model TEXT, serialNum INTEGER,
            //service TEXT, ignitionTiming REAL, stackFlow REAL, stackTemp REAL, intakeMPL REAL, intakeMPR REAL, intakeMTL REAL,
            //intakeMTR REAL, stackHeightFT REAL, stackHeightIN REAL, fuelSG REAL, RPM REAL, AFControllerMake TEXT,
            //AFControllerModel TEXT, catalyticConverterMake TEXT, catalyticConverterModel TEXT, PRIMARY KEY (site, equipment),
            //FOREIGN KEY(owner) REFERENCES Customers(CustomerID) ON DELETE CASCADE);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "Update EquipmentSite SET unitNum  = '" + this.tbUnitNum.Text + "' , model  = '" + this.tbModel.Text + "', serialNum  = '" 
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
                sqlite_cmd.CommandText = "UPDATE Sites SET Area =  '" + this.textBox1.Text + "', Facility ='" + this.textBox2.Text + "' ;";
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
                var da = new SQLiteDataAdapter("SELECT * FROM Sites WHERE Site = '" + this.siteBox.SelectedItem.ToString() + "';", sqlite_conn);
                da.Fill(ds);
                bindingSource1.DataSource = ds.Tables[0];

                textBox1.DataBindings.Add("Text", bindingSource1, "Area");
                textBox2.DataBindings.Add("Text", bindingSource1, "Facility");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personal Data: " + ex.Message);
            }
        }
    }
}
