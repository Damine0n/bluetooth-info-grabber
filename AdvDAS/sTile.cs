using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CRS
{
    public partial class ScaleDisplay : Form
    {
        private Label lbl;
        public Control source;

        public ScaleDisplay(Label lbl)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.lbl = lbl;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void elementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)this.Owner;
            switch (elementComboBox.SelectedIndex)
            {
                case 1:
                    lbl.Text = "O2";
                    break;
                case 2:
                    lbl.Text = "CO";
                    break;
                case 3:
                    lbl.Text = "CO2";
                    break;
                case 4:
                    lbl.Text = "NO";
                    break;
                case 5:
                    lbl.Text = "NO2";
                    break;
                case 6:
                    lbl.Text = "NOx";
                    break;
                case 7:
                    lbl.Text = "SO2";
                    break;
                case 8:
                    lbl.Text = "CxHy";
                    break;
                case 9:
                    lbl.Text = "T(gas)";
                    break;
                case 10:
                    lbl.Text = "T(amb)";
                    break;
                case 11:
                    lbl.Text = "Temp 1 ?";
                    break;
                case 12:
                    lbl.Text = "Temp 2 ?";
                    break;
                case 13:
                    lbl.Text = "T(cell)";
                    break;
                case 14:
                    lbl.Text = "Efficiency";
                    break;
                case 15:
                    lbl.Text = "Flow";
                    break;
                case 16:
                    lbl.Text = "NH3";
                    break;
                default:
                    source.Hide();
                    this.Close();
                    break;
            }
        }

        private void ScaleDisplay_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }
    }
}
