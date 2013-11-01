﻿using System;
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
        GasAnalysis gases = new GasAnalysis();
        string caliName;
        bool first = true;
        bool one = false;
        bool two = false;
        bool three = false;
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
                LCO.Text = (Math.Round(Convert.ToDouble(this.textBox1.Text) - (Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100)), 1)).ToString();
                RCO.Text = (Math.Round(Convert.ToDouble(this.textBox1.Text) + (Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100)), 1)).ToString();
                LNO.Text = (Math.Round(Convert.ToDouble(this.textBox2.Text) - (Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown2.Value) / 100)), 1)).ToString();
                RNO.Text = (Math.Round(Convert.ToDouble(this.textBox2.Text) + (Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown2.Value) / 100)), 1)).ToString();
                LNO2.Text = (Math.Round(Convert.ToDouble(this.textBox3.Text) - (Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown3.Value) / 100)), 1)).ToString();
                RNO2.Text = (Math.Round(Convert.ToDouble(this.textBox3.Text) + (Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown3.Value) / 100)), 1)).ToString();
                LO2.Text = (Math.Round(Convert.ToDouble(this.textBox4.Text) - (Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown4.Value) / 100)), 1)).ToString();
                RO2.Text = (Math.Round(Convert.ToDouble(this.textBox4.Text) + (Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown4.Value) / 100)), 1)).ToString();
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
            interv = Convert.ToInt32(numericUpDown9.Value) * 1000;
            timer2.Interval = interv;
        }
        ////////////////////CALIBRATION-TAB2\\\\\\\\\\\\\\\\\\\\\

        private void capZeroO2_Click(object sender, EventArgs e)
        {
            this.O2zeroResponse.Text = cO2lbl.Text;
            if (Convert.ToDouble(this.O2zeroResponse.Text) <= ((Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown8.Value) / 100))) &&
                Convert.ToDouble(this.O2zeroResponse.Text) >= (-(Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown8.Value) / 100))))
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
            if (Convert.ToDouble(this.COzeroResponse.Text) <= ((Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown5.Value) / 100))) &&
                Convert.ToDouble(this.COzeroResponse.Text) >= (-(Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown5.Value) / 100))))
            {
                this.COzeroResponse.ForeColor = Color.Green;

            }
            else
            {
                this.COzeroResponse.ForeColor = Color.Red;
            } calCO.Visible = true;
        }

        private void capZeroNO_Click(object sender, EventArgs e)
        {
            this.NOzeroResponse.Text = cNOlbl.Text;
            if (Convert.ToDouble(this.NOzeroResponse.Text) <= ((Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown6.Value) / 100))) &&
                Convert.ToDouble(this.NOzeroResponse.Text) >= (-(Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown6.Value) / 100))))
            {
                this.NOzeroResponse.ForeColor = Color.Green;

            }
            else
            {
                this.NOzeroResponse.ForeColor = Color.Red;
            } calNO.Visible = true;
        }

        private void capZeroNO2_Click(object sender, EventArgs e)
        {
            this.NO2zeroResponse.Text = cNO2lbl.Text;
            if (Convert.ToDouble(this.NO2zeroResponse.Text) <= ((Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown7.Value) / 100))) &&
                Convert.ToDouble(this.NO2zeroResponse.Text) >= (-(Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown7.Value) / 100))))
            {
                this.NO2zeroResponse.ForeColor = Color.Green;

            }
            else
            {
                this.NO2zeroResponse.ForeColor = Color.Red;
            } calNO2.Visible = true;

        }
        private void capCalCO_Click(object sender, EventArgs e)
        {
            this.COcalResponse.Text = cCOlbl.Text;
            if ((Convert.ToDouble(this.COcalResponse.Text) <= (Convert.ToDouble(this.textBox1.Text) + (Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100)))) &&
                (Convert.ToDouble(this.COcalResponse.Text) >= (Convert.ToDouble(this.textBox1.Text) - (Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(numericUpDown1.Value) / 100)))))
            {
                this.COcalResponse.ForeColor = Color.Green;
                one = true;
            }
            else
            {
                this.COcalResponse.ForeColor = Color.Red;
            }
            HocusPocus();
        }

       

        private void capCalNO_Click(object sender, EventArgs e)
        {
            this.NOcalResponse.Text = cNOlbl.Text;
            if (Convert.ToDouble(this.NOcalResponse.Text) <= (Convert.ToDouble(textBox2.Text) + (Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown2.Value) / 100))) &&
                Convert.ToDouble(this.NOcalResponse.Text) >= (Convert.ToDouble(textBox2.Text) - (Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(numericUpDown2.Value) / 100))))
            {
                this.NOcalResponse.ForeColor = Color.Green;
                two = true;
            }
            else
            {
                this.NOcalResponse.ForeColor = Color.Red;
            }
            HocusPocus();
        }

        private void capCalNO2_Click(object sender, EventArgs e)
        {
            this.NO2calResponse.Text = cNO2lbl.Text;
            if (Convert.ToDouble(this.NO2calResponse.Text) <= (Convert.ToDouble(textBox3.Text) + (Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown3.Value) / 100))) &&
                Convert.ToDouble(this.NO2calResponse.Text) >= (Convert.ToDouble(textBox3.Text) - (Convert.ToDouble(textBox3.Text) * (Convert.ToDouble(numericUpDown3.Value) / 100))))
            {
                this.NO2calResponse.ForeColor = Color.Green;
                three = true;
            }
            else
            {
                this.NO2calResponse.ForeColor = Color.Red;
            }
            HocusPocus();
        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                timer3.Start();
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
            if (first)
            {
                caliName = gases.Calibration(protocol);
                first = false;
            }
            else
                if (one && two && three)
                    timer2.Stop();
                else
                    gases.Calibration(protocol, caliName);

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (dateTimePicker5.Value <= new DateTime(2013, 9, 9, 5, 0, 0))
            {
                stopIt();
            }
            else
            {
                dateTimePicker5.Value = dateTimePicker5.Value.AddSeconds(-1);
            }
        }

        private void stopIt()
        {
            protocol.processProtocol("$0F1007Meas1");
            timer3.Stop();
            dateTimePicker5.Enabled = true;
            dateTimePicker5.Value = new DateTime(2013, 9, 9, 5, 0, 0);
            this.startTimerButton.Text = "Start";
            clicked = false;
        }

        private void Calibration_Load(object sender, EventArgs e)
        {
            this.Refresh();
            tabControl1.TabPages[0].Select();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!button7.Enabled)
            {
                MessageBox.Show("Must click okay on the 'Calibration Gas Info' tab to proceed.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            capZeroO2.Visible = true;
            capZeroCO.Visible = true;
            capZeroNO.Visible = true;
            capZeroNO2.Visible = true;
            dateTimePicker5.Enabled = true;
            startTimerButton.Enabled = true;
        }

        private void calCO_Click(object sender, EventArgs e)
        {
            capCalCO.Visible = true;
            //Disable Keypad
            protocol.processProtocol("$0F106100000");
            //Return To Normal Mode
            protocol.processProtocol("$0F1007Meas2");
            //Enter control Mode
            protocol.processProtocol("$0F1006 0x20");
            //Enter Cal CO Mode
            protocol.processProtocol("$0F1010 0x20");
            //CAL CO to II
            protocol.processProtocol("$0F1011" + Convert.ToDouble(textBox1.Text).ToString("00000"));
            //Enter Button
            protocol.processProtocol("$0F1004 0x20");
            //Enter control Mode
            protocol.processProtocol("$0F1006 0x20");
            //Enable Keypad
            protocol.processProtocol("$0F106100001");
        }

        private void calNO_Click(object sender, EventArgs e)
        {
            capCalNO.Visible = true;
            //Disable Keypad
            protocol.processProtocol("$0F106100000");
            //Return To Normal Mode
            protocol.processProtocol("$0F1007Meas2");
            //Enter control Mode
            protocol.processProtocol("$0F1006 0x20");
            //Enter Cal NO Mode
            protocol.processProtocol("$0F1014 0x20");
            //CAL NO to II
            protocol.processProtocol("$0F1015" + Convert.ToDouble(textBox2.Text).ToString("00000"));
            //Enter Button
            protocol.processProtocol("$0F1004 0x20");
            //Enter control Mode
            protocol.processProtocol("$0F1006 0x20");
            //Enable Keypad
            protocol.processProtocol("$0F106100001");
        }

        private void calNO2_Click(object sender, EventArgs e)
        {
            capCalNO2.Visible = true;
            //Disable Keypad
            protocol.processProtocol("$0F106100000");
            //Return To Normal Mode
            protocol.processProtocol("$0F1007Meas2");
            //Enter control Mode
            protocol.processProtocol("$0F1006 0x20");
            //Enter Cal NO2 Mode
            protocol.processProtocol("$0F1018 0x20");
            //CAL NO2 to II
            protocol.processProtocol("$0F1019" + Convert.ToDouble(textBox3.Text).ToString("00000"));
            //Enter Button
            protocol.processProtocol("$0F1004 0x20");
            //Enter control Mode
            protocol.processProtocol("$0F1006 0x20");
            //Enable Keypad
            protocol.processProtocol("$0F106100001");

        }

        private void capZeroO2_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.capture_zero_B;
        }

        private void capZeroO2_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.capture_zero_btnA;
        }

        private void capCalCO_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.capture_cal_response_B;
        }

        private void capCalCO_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.capture_cal_response_A;
        }

        private void calCO_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.CALIBRATE_CO_B;
        }

        private void calCO_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.CALIBRATE_CO_A;
        }

        private void calNO_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.CALIBRATE_NO_B;
        }

        private void calNO_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.CALIBRATE_NO_A;
        }

        private void calNO2_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.CALIBRATE_NO2_B;
        }

        private void calNO2_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.CALIBRATE_NO2_A;
        }

        private void Calibration_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("*Always check for air leaks prior to calibration."
               + "\n1. Apply cal gas and begin timer."
               + "\n2. Once timer stops, verify that the sensor response is within the cal error limit."
               + "\n    Click 'Capture Cal Response'."
               + "\n3. Click 'Calibrate Sensor'."
               + "\nTip: Begin calibration by applying NO gas balanced in N2. You can check for air leaks &"
               + " capture zero response of 02 sensor while calibrating the NO sensor (3 birds, 1 stone).");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            
        }
        private void HocusPocus()
        {
            if (one && two && three)
                button6.Visible = true;
        }



        //////////////////////DRIFT CHECK-TAB3\\\\\\\\\\\\\\\\\\\\\\\
        private void capZero02B_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.capture_zero_btnA;
        }

        private void capZero02B_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.capture_zero_B;
        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.capture_cal_response_A;
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Properties.Resources.capture_cal_response_B;
        }

        private void calCOB_Click(object sender, EventArgs e)
        {

        }

        private void calNOB_Click(object sender, EventArgs e)
        {

        }

        private void calNO2B_Click(object sender, EventArgs e)
        {

        }

        private void capZero02B_Click(object sender, EventArgs e)
        {
            this.O2zeroResponse.Text = dcO2lbl.Text;
            if (Convert.ToDouble(this.O2zeroResponse.Text) <= ((Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown8.Value) / 100))) &&
                Convert.ToDouble(this.O2zeroResponse.Text) >= (-(Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(numericUpDown8.Value) / 100))))
            {
                this.O2zeroResponse.ForeColor = Color.Green;
            }
            else
            {
                this.O2zeroResponse.ForeColor = Color.Red;
            }
        }

        private void capZeroCOB_Click(object sender, EventArgs e)
        {

        }

        private void capZeroNOB_Click(object sender, EventArgs e)
        {

        }

        private void capZeroNO2B_Click(object sender, EventArgs e)
        {

        }
        ////////////////////INTERFACE CHECK-TAB4\\\\\\\\\\\\\\\\\\\\\
    }
}
