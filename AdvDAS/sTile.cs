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
        private int index;
        public ScaleDisplay(int index)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.index = index;
            //this.elementComboBox.SelectedItem = index;
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
                    mainMenu.label1.Text = "Daymen";
                    mainMenu.lblList[0].Text.ToString();
                    break;
                case 2:
                    MessageBox.Show(mainMenu.lblList[2].Text);// = "CO";
                    break;
                case 3:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "CO2";
                    break;
                case 4:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "NO";
                    break;
                case 5:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "NO2";
                    break;
                case 6:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "NOx";
                    break;
                case 7: 
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "SO2";
                    break;
                case 8:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "CxHy";
                    break;
                case 9:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "T(gas)";
                    break;
                case 10:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "T(amb)";
                    break;
                case 11:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "Temp 1 ?";
                    break;
                case 12: 
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "Temp 2 ?";
                    break;
                case 13:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "T(cell)";
                    break;
                case 14:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "Efficiency";
                    break;
                case 15:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "Flow";
                    break;
                case 16:
                    MessageBox.Show(mainMenu.lblList[this.index].Text);// = "NH3";
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
