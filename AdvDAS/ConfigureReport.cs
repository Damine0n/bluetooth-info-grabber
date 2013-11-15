using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.IO;

namespace CRS
{
    public partial class SetUpReport : Form
    {
        public SetUpReport()
        {
            // TODO: Complete member initialization
            InitializeComponent();
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (checkCounter == 10)
            {
                foreach (Control gb in this.Controls)
                {
                    if (gb is GroupBox)
                    {
                        foreach (Control cb in gb.Controls)
                        {
                            if (cb is CheckBox)
                                MessageBox.Show(cb.Text);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select 10 variables or there will be errors in the Report.",
                    "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private int checkCounter = 10;
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                if (box.Equals(checkBox11))
                {
                    checkBox40.Enabled = true;
                }
                else if (box.Equals(checkBox18))
                {
                    checkBox38.Enabled = true;
                }
                else if (box.Equals(checkBox19))
                {
                    checkBox39.Enabled = true;
                }
                else if (box.Equals(checkBox20))
                {
                    checkBox37.Enabled = true;
                }
                else if (box.Equals(checkBox21))
                {
                    checkBox34.Enabled = true;
                }
                else if (box.Equals(checkBox22))
                {
                    checkBox33.Enabled = true;
                }
                checkCounter++;
            }
            else
            {
                if (box.Equals(checkBox11))
                {
                    checkBox40.Enabled = false;
                }
                else if (box.Equals(checkBox18))
                {
                    checkBox38.Enabled = false;
                }
                else if (box.Equals(checkBox19))
                {
                    checkBox39.Enabled = false;
                }
                else if (box.Equals(checkBox20))
                {
                    checkBox37.Enabled = false;
                }
                else if (box.Equals(checkBox21))
                {
                    checkBox34.Enabled = false;
                }
                else if (box.Equals(checkBox22))
                {
                    checkBox33.Enabled = false;
                }
                checkCounter--;
            }

            // prevent checking
            if (checkCounter > 10)
            {
                MessageBox.Show("You may only print 10 values.", "Error");
                box.Checked = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
