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
    public partial class hTile : Form
    {
        public Control source;
        private Label lbl1,lbl2,radioLbl;
        private string unit;
        private int index;
        public hTile(Tuple<Label, Label> tuple, string unit)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.lbl1 = tuple.Item1;
            this.lbl2 = tuple.Item2;
            //this.radioLbl = radioLbl;
            this.unit = unit;
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            lbl1.Text = elementComboBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            elementComboBox.SelectedIndex = index;
            this.DialogResult = DialogResult.Cancel;
        }
        
        private void ScaleDisplay_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton src = sender as RadioButton;
            foreach (var item in elementComboBox.Items)
            {
                if (item.Equals("NOx(mass)"))
                    MainMenu.nUnit = src.Text;
                else
                    MainMenu.cUnit = src.Text;
            }
            valLabel.Text = src.Text;
            aveLAbel.Text = src.Text;
            radioLbl.Text = src.Text;
        }
    }
}
