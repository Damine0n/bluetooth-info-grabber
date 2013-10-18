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
        int interv = 1000;
        public Calibration()
        {
            InitializeComponent();
            if (protocol.processProtocol())
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
                PrintDocs.COspan = textBox1.Text;
                PrintDocs.NOspan = textBox2.Text;
                PrintDocs.NO2span = textBox3.Text;
                PrintDocs.calErr1 = numericUpDown1.Value.ToString();
                PrintDocs.calErr2 = numericUpDown2.Value.ToString();
                PrintDocs.calErr3 = numericUpDown3.Value.ToString();
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
            interv = Convert.ToInt32(numericUpDown9.Value)*1000;
            timer2.Interval = interv;
        }
        ////////////////////CALIBRATION-TAB2\\\\\\\\\\\\\\\\\\\\\

        private void capZeroO2_Click(object sender, EventArgs e)
        {
            this.O2zeroResponse.Text = cO2lbl.Text;
            if (Convert.ToDouble(this.O2zeroResponse.Text) <= ((Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) &&
                Convert.ToDouble(this.O2zeroResponse.Text) >= (-(Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                this.O2zeroResponse.ForeColor = Color.Green;
            }
            else
            {
                this.O2zeroResponse.ForeColor = Color.Red;
            }
        }

        private void capZeroCO_Click(object sender, EventArgs e)
        {
            this.COzeroResponse.Text = cCOlbl.Text;
            if (Convert.ToDouble(this.COzeroResponse.Text) <= ((Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) &&
                Convert.ToDouble(this.COzeroResponse.Text) >= (-(Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                this.COzeroResponse.ForeColor = Color.Green;
            }
            else
            {
                this.COzeroResponse.ForeColor = Color.Red;
            }
        }

        private void capZeroNO_Click(object sender, EventArgs e)
        {
            this.NOzeroResponse.Text = cNOlbl.Text;
            if (Convert.ToDouble(this.NOzeroResponse.Text) <= ((Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) &&
                Convert.ToDouble(this.NOzeroResponse.Text) >= (-(Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                this.NOzeroResponse.ForeColor = Color.Green;
            }
            else
            {
                this.NOzeroResponse.ForeColor = Color.Red;
            }
        }

        private void capZeroNO2_Click(object sender, EventArgs e)
        {
            this.NO2zeroResponse.Text = cNO2lbl.Text;
            if (Convert.ToDouble(this.NO2zeroResponse.Text) <= ((Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) &&
                Convert.ToDouble(this.NO2zeroResponse.Text) >= (-(Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                this.NO2zeroResponse.ForeColor = Color.Green;
            }
            else
            {
                this.NO2zeroResponse.ForeColor = Color.Red;
            }
        }
        private void capCalCO_Click(object sender, EventArgs e)
        {
            this.COcalResponse.Text = cCOlbl.Text;
            if ((Convert.ToDouble(this.COcalResponse.Text) >= (Convert.ToDouble(this.textBox1.Text) + (Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100)))) &&
                (Convert.ToDouble(this.COcalResponse.Text) <= (Convert.ToDouble(this.textBox1.Text) - (Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100)))))
            {
                this.COcalResponse.ForeColor = Color.Green;
            }
            else
            {
                this.COcalResponse.ForeColor = Color.Red;
            }
            calCO.Enabled = true;
        }

        private void capCalNO_Click(object sender, EventArgs e)
        {
            this.NOcalResponse.Text = cNOlbl.Text;
            if (Convert.ToDouble(this.NOcalResponse.Text) <= (Convert.ToDouble(textBox2.Text) + (Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) &&
                Convert.ToDouble(this.NOcalResponse.Text) >= (Convert.ToDouble(textBox2.Text) - (Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                this.NOcalResponse.ForeColor = Color.Green;
            }
            else
            {
                this.NOcalResponse.ForeColor = Color.Red;
            }
            calNO.Enabled = true;
        }

        private void capCalNO2_Click(object sender, EventArgs e)
        {
            this.NO2calResponse.Text = cNO2lbl.Text;
            if (Convert.ToDouble(this.NO2calResponse.Text) <= (Convert.ToDouble(textBox3.Text) + (Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))) &&
                Convert.ToDouble(this.NO2calResponse.Text) >= (Convert.ToDouble(textBox3.Text) - (Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100))))
            {
                this.NO2calResponse.ForeColor = Color.Green;
            }
            else
            {
                this.NO2calResponse.ForeColor = Color.Red;
            }
            calNO2.Enabled = true;
        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                protocol.processProtocol("$0F1006 0x20");
                protocol.processProtocol("$0F1004 0x20");
                timer2.Start();
                dateTimePicker5.Enabled = false;
                this.startTimerButton.Text = "Stop";
                clicked = true;
            }
            else
            {
                stopIt();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (dateTimePicker5.Value<=new DateTime(2013,9,9, 5,0,0))
                stopIt();
            else 
                dateTimePicker5.Value = dateTimePicker5.Value.AddSeconds(-(interv/1000));
        }

        private void stopIt()
        {
            protocol.processProtocol("$0F1007Meas1");
            timer2.Stop();
            dateTimePicker5.Enabled = true;
            dateTimePicker5.Value = new DateTime(2013, 9, 9, 5, 0, 0);
            this.startTimerButton.Text = "Start";
            clicked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Always check for air leaks prior to calibration."
                +"\n1. Apply cal gas and begin timer."
                +"\n2. Once timer stops, verify that the sensor response is within the cal error limit."
                +"\n    Click 'Capture Cal Response'."
                +"\n3. Click 'Calibrate Sensor'."
                + "\nTip: Begin calibration by applying NO gas balanced in N2. You can check for air leaks &"
                +" capture zero response of 02 sensor while calibrating the NO sensor (3 birds, 1 stone).");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void Calibration_Load(object sender, EventArgs e)
        {
            this.Refresh();
            tabControl1.TabPages[0].Select();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (OKbtn.)
        }
        ////////////////////DRIFT CHECK-TAB3\\\\\\\\\\\\\\\\\\\\\
        ////////////////////INTERFACE CHECK-TAB4\\\\\\\\\\\\\\\\\\\\\
    }
}
