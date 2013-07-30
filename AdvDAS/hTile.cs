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
        private Label lbl;
        private int index;
        public hTile(Label lbl)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.lbl = lbl;
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            lbl.Text = elementComboBox.Text;
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

    }
}
