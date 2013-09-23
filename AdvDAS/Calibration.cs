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
        bool clicked = false;
        private double COcalError, COzeroError;
        private double NOcalError, NOzeroError;
        private double NO2calError, NO2zeroError;
        private double O2calError, O2zeroError;
        public Calibration()
        {
            InitializeComponent();
            timer1.Start();
            ((Control)this.tabPage2).Enabled = false;
            ((Control)this.tabPage3).Enabled = false;
            ((Control)this.tabPage4).Enabled = false;
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
            {
                MessageBox.Show("All Span Gas Values should be entered.");
                ((Control)this.tabPage2).Enabled = false;
                ((Control)this.tabPage3).Enabled = false;
                ((Control)this.tabPage4).Enabled = false;
            }
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

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            timer2.Interval = Convert.ToInt32(numericUpDown9.Value);
        }
        ////////////////////CALIBRATION-TAB2\\\\\\\\\\\\\\\\\\\\\

        private void capZeroO2_Click(object sender, EventArgs e)
        {
            textBox7.Text = cO2lbl.Text;
            if(Convert.ToDouble(this.textBox7.Text) > (Convert.ToDouble(textBox4.Text) + (Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) ||
                Convert.ToDouble(this.textBox7.Text) < (Convert.ToDouble(textBox4.Text) - (Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                textBox7.ForeColor = Color.Green;
            }else
            {
                textBox7.ForeColor = Color.Red;
            }
        }

        private void capZeroCO_Click(object sender, EventArgs e)
        {
            textBox8.Text = cCOlbl.Text;
            if (Convert.ToDouble(this.textBox8.Text) > (Convert.ToDouble(textBox1.Text) + (Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) ||
                Convert.ToDouble(this.textBox8.Text) < (Convert.ToDouble(textBox1.Text) - (Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                textBox8.ForeColor = Color.Green;
            }
            else
            {
                textBox8.ForeColor = Color.Red;
            }
        }

        private void capZeroNO_Click(object sender, EventArgs e)
        {
            textBox11.Text = cNOlbl.Text;
            if (Convert.ToDouble(this.textBox11.Text) > (Convert.ToDouble(textBox2.Text) + (Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) ||
                Convert.ToDouble(this.textBox11.Text) < (Convert.ToDouble(textBox2.Text) - (Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                textBox11.ForeColor = Color.Green;
            }
            else
            {
                textBox11.ForeColor = Color.Red;
            }
        }

        private void capZeroNO2_Click(object sender, EventArgs e)
        {
            textBox12.Text = cNO2lbl.Text;
            if (Convert.ToDouble(this.textBox12.Text) > (Convert.ToDouble(textBox3.Text) + (Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) ||
                Convert.ToDouble(this.textBox12.Text) < (Convert.ToDouble(textBox3.Text) - (Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                textBox12.ForeColor = Color.Green;
            }
            else
            {
                textBox12.ForeColor = Color.Red;
            }
        }
        private void capCalCO_Click(object sender, EventArgs e)
        {
            textBox13.Text = cCOlbl.Text;
            if (Convert.ToDouble(this.textBox13.Text) > (Convert.ToDouble(textBox13.Text) + (Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) ||
                Convert.ToDouble(this.textBox13.Text) < (Convert.ToDouble(textBox13.Text) - (Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                textBox13.ForeColor = Color.Green;
            }
            else
            {
                textBox13.ForeColor = Color.Red;
            }
            calCO.Enabled = true;
        }

        private void capCalNO_Click(object sender, EventArgs e)
        {
            textBox14.Text = cNOlbl.Text;
            if (Convert.ToDouble(this.textBox14.Text) > (Convert.ToDouble(textBox12.Text) + (Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) ||
                Convert.ToDouble(this.textBox14.Text) < (Convert.ToDouble(textBox12.Text) - (Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                textBox14.ForeColor = Color.Green;
            }
            else
            {
                textBox14.ForeColor = Color.Red;
            }
            calNO.Enabled = true;
        }

        private void capCalNO2_Click(object sender, EventArgs e)
        {
            textBox15.Text = cNO2lbl.Text;
            if (Convert.ToDouble(this.textBox15.Text) > (Convert.ToDouble(textBox12.Text) + (Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) ||
                Convert.ToDouble(this.textBox15.Text) < (Convert.ToDouble(textBox12.Text) - (Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                textBox15.ForeColor = Color.Green;
            }
            else
            {
                textBox15.ForeColor = Color.Red;
            }
            calNO2.Enabled = true;
        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                timer2.Start();
                dateTimePicker5.Enabled=false;
                this.startTimerButton.Text = "Stop";
                clicked = true;
            }
            else
            {
                timer2.Stop();
                dateTimePicker5.Enabled = true;
                this.startTimerButton.Text = "Start";
                clicked = false;
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dateTimePicker5.Value = dateTimePicker5.Value.AddSeconds(-1);
        }



        ////////////////////DRIFT CHECK-TAB3\\\\\\\\\\\\\\\\\\\\\
        ////////////////////INTERFACE CHECK-TAB4\\\\\\\\\\\\\\\\\\\\\
    }
}
