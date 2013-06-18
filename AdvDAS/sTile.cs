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

namespace AdvDAS
{
    public partial class ScaleDisplay : Form
    {
        private MainMenu mainMenu;
        public ScaleDisplay(MainMenu mainMenu, int index)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.elementComboBox.SelectedIndex = index + 1;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ScaleDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void elementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (elementComboBox.SelectedIndex)
            {
                case 1:
                    this.mainMenu."O2",
           
                    break;
                case 2: "CO",
            
                    break;
                case 3:"CO2",
            
                    break;
                case 4:"NO",
            
                    break;
                case 5:"NO2",
            
                    break;
                case 6:"NOx",
           
                    break;
                case 7: "SO2",
            
                    break;
                case 8:"CxHy",
            
                    break;
                case 9:"T(gas)",
            
                    break;
                case 10:"T(amb)",
            
                    break;
                case 11:"Temp 1 ?",
           
                    break;
                case 12: "Temp 2 ?",
            
                    break;
                case 13:"T(cell)",
            
                    break;
                case 14:"Efficiency",
            
                    break;
                case 15:
                    "Flow",
            
                    break;
                case 16:
                    "NH3"
                    break;
                default:
                    MessageBox.Show("I'm not sure how to do that yet.");
                    break;
            }
        }

        private void ScaleDisplay_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }
    }
}
