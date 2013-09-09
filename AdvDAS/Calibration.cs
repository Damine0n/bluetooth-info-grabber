using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRS
{
    public partial class Calibration : Form
    {
        J2KNProtocol protocol = new J2KNProtocol();
        public Calibration()
        {
            InitializeComponent();
            timer1.Start();
            ((Control)this.tabPage2).Enabled = false;
            ((Control)this.tabPage3).Enabled = false;
            ((Control)this.tabPage4).Enabled = false;
        }

       

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            protocol.processProtocol();
            protocol.processProtocol("$0A0531");
            cO2lbl.Text = protocol.vO2;
            cCOlbl.Text = protocol.vCO;
            cNOlbl.Text = protocol.vNO;
            cNO2lbl.Text = protocol.vNO2;
            cIFlowlbl.Text = protocol.vIFlow;
            dcO2lbl.Text = protocol.vO2;
            dcCOlbl.Text = protocol.vCO;
            dcNOlbl.Text = protocol.vNO;
            dcNO2lbl.Text = protocol.vNO2;
            dcIFlowlbl.Text = protocol.vIFlow;
        }
        ////////////////////CALIBRATION GAS INFO-TAB1\\\\\\\\\\\\\\\\\\\\\
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Word files (*.doc)|*.doc|pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opf.FilterIndex = 3;
            opf.RestoreDirectory = true;
            if (opf.ShowDialog() == DialogResult.OK)
                textBox10.Text = opf.FileName;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Word files (*.doc)|*.doc|pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opf.FilterIndex = 3;
            opf.RestoreDirectory = true;
            if (opf.ShowDialog() == DialogResult.OK)
                textBox9.Text = opf.FileName;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Word files (*.doc)|*.doc|pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opf.FilterIndex = 3;
            opf.RestoreDirectory = true;
            if (opf.ShowDialog() == DialogResult.OK)
                textBox5.Text = opf.FileName;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Word files (*.doc)|*.doc|pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            opf.FilterIndex = 3;
            opf.RestoreDirectory = true;
            if (opf.ShowDialog() == DialogResult.OK)
                textBox6.Text = opf.FileName;
        }
        private void OKbtn_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals(""))
            {
                ((Control)this.tabPage2).Enabled = true;
                ((Control)this.tabPage3).Enabled = true;
                ((Control)this.tabPage4).Enabled = true;
            }
            else
                MessageBox.Show("All Span Gas Values should be entered.");
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        ////////////////////CALIBRATION-TAB2\\\\\\\\\\\\\\\\\\\\\

        private void button9_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button14.Enabled = true;
        }

        ////////////////////DRIFT CHECK-TAB3\\\\\\\\\\\\\\\\\\\\\
        ////////////////////INTERFACE CHECK-TAB4\\\\\\\\\\\\\\\\\\\\\
    }
}
