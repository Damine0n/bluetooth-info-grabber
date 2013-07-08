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

namespace AdvDAS
{
    public partial class EquipmentSite : Form
    {
        public EquipmentSite()
        {
            InitializeComponent();
            EquipmentSite_Load();
        }

        private void btnDeleteSite_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this site?", "Delete Site", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                return;
            else
                return;
        }

        private void btnDeleteEquip_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this equipment?", "Delete Equipment", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                return;
            else
                return;
        }
        private void btnCreateSite_Click(object sender, EventArgs e)
        {
            string x = Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the new site.", "New Site", "");
            MessageBox.Show(x);
        }

        private void btnCreateEquip_Click(object sender, EventArgs e)
        {
            string x = Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the new equipment.", "New Equipment", "");
            MessageBox.Show(x);
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
            
        }

    }
}
