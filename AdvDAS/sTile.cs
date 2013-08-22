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
        public Control source;
        private Label lbl1,lbl2;
        private int index;

        public ScaleDisplay(Tuple<Label, Label> tuple)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.lbl1 = tuple.Item1;
            this.lbl2 = tuple.Item2;
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.lbl1.Text = elementComboBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            elementComboBox.SelectedIndex = index;
            this.DialogResult = DialogResult.Cancel;
        }
        
        private void elementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (elementComboBox.SelectedIndex)
            {
                case 0:
                    valLabel.Text = "%";
                    aveLabel.Text = "%";
                    break;
                case 1:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 2:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 3:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 4: 
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 5:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 6:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 7:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 8:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 9:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 10:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 11:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 12:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 13:
                    valLabel.Text = "ppm";
                    aveLabel.Text = "ppm";
                    break;
                case 14:
                    valLabel.Text = "°F";
                    aveLabel.Text = "°F";
                    break;
                case 15:
                    valLabel.Text = "°F";
                    aveLabel.Text = "°F";
                    break;
                case 16:
                    valLabel.Text = "°F";
                    aveLabel.Text = "°F";
                    break;
                case 17:
                    valLabel.Text = "%";
                    aveLabel.Text = "%";
                    break;
                case 18:
                    valLabel.Text = "L/Min";
                    aveLabel.Text = "L/Min";
                    break;
                case 19:
                    valLabel.Text = "i.w.g.";
                    aveLabel.Text = "i.w.g.";
                    break;
                case 20:
                    valLabel.Text = "%";
                    aveLabel.Text = "%";
                    break;
                case 21:
                    valLabel.Text = "";
                    aveLabel.Text = "";
                    break;
            }
        }
    }
}
