using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvDAS
{
    public partial class EquipmentSite : Form
    {
        private MassEBC mass = new MassEBC();
        public EquipmentSite()
        {
            InitializeComponent();
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

        private void btnMassECB_Click(object sender, EventArgs e)
        {
            mass.ShowDialog();
        }
    }
}
