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
        public ScaleDisplay(int index)
        {
            InitializeComponent();
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
                case 0:
                    //sTile0;
                    break;
            }
        }

        private void ScaleDisplay_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }
    }
}
