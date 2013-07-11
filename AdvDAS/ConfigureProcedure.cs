using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Finisar.SQLite;
using System.Drawing.Drawing2D;


namespace CRS
{
    public partial class ConfigureProcedure : Form
    {
        public DateTime rampUp;
        public DateTime testData;
        public DateTime purge;
        public DateTime totalCycle;
        public int sampleRate;
        public ConfigureProcedure()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked.Equals(true))
            {
                this.label6.Enabled = false;
                this.numericUpDown1.Enabled = false;
                MessageBox.Show("Once the function is initiated, the analyzer will cycle continuously until the user stops the measurement.");
                
            }else
            {
                this.label6.Enabled = true;
                this.numericUpDown1.Enabled = true;
            }

        }

        private void measurementOptions_CheckedChanged(object sender, EventArgs e)
        {
            totalCycle = new DateTime();
            if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(true)) 
            {
                this.label7.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.checkBox3.Enabled = false;
                this.label8.Enabled = false;
                this.dateTimePicker3.Enabled = false;
                this.checkBox5.Enabled = false;
                label4.Text = totalCycle.Add(TimeSpan.Parse(this.dateTimePicker2.Text)).ToString("HH:mm:ss");
            }
            else if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(false))
            {
                this.label7.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.checkBox3.Enabled = false;
                this.label8.Enabled = true;
                this.dateTimePicker3.Enabled = true;
                this.checkBox5.Enabled = true;
                label4.Text = totalCycle.Add(TimeSpan.Parse(this.dateTimePicker2.Text) + TimeSpan.Parse(this.dateTimePicker3.Text)).ToString("HH:mm:ss");
            }
            else if (checkBox2.Checked.Equals(false) && checkBox4.Checked.Equals(true))
            {
                this.label7.Enabled = true;
                this.dateTimePicker1.Enabled = true;
                this.checkBox3.Enabled = true;
                this.label8.Enabled = false;
                this.dateTimePicker3.Enabled = false;
                this.checkBox5.Enabled = false;
                label4.Text = totalCycle.Add(TimeSpan.Parse(this.dateTimePicker1.Text) + TimeSpan.Parse(this.dateTimePicker2.Text)).ToString("HH:mm:ss");
            }
            else
            {
                this.label7.Enabled = true;
                this.dateTimePicker1.Enabled = true;
                this.checkBox3.Enabled = true;
                this.label8.Enabled = true;
                this.dateTimePicker3.Enabled = true;
                this.checkBox5.Enabled = true;
                label4.Text = totalCycle.Add(TimeSpan.Parse(this.dateTimePicker1.Text) + TimeSpan.Parse(this.dateTimePicker2.Text) + TimeSpan.Parse(this.dateTimePicker3.Text)).ToString("HH:mm:ss");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rampUp = this.dateTimePicker1.Value;
            testData = this.dateTimePicker2.Value;
            purge = this.dateTimePicker3.Value;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            totalCycle = new DateTime();
            totalCycle.AddHours(1);
            rampUp = this.dateTimePicker1.Value;
            testData = this.dateTimePicker2.Value;
            purge = this.dateTimePicker3.Value;

            if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(true)) 
            {
                label4.Text += totalCycle.Add(TimeSpan.Parse(this.dateTimePicker2.Text)).ToString("HH:mm:ss");
            }
            else if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(false))
            {
                label4.Text += totalCycle.Add(TimeSpan.Parse(this.dateTimePicker2.Text) + TimeSpan.Parse(this.dateTimePicker3.Text)).ToString("HH:mm:ss");
            }
            else if (checkBox2.Checked.Equals(false) && checkBox4.Checked.Equals(true))
            {
                label4.Text += totalCycle.Add(TimeSpan.Parse(this.dateTimePicker1.Text) + TimeSpan.Parse(this.dateTimePicker2.Text)).ToString("HH:mm:ss");
            }
            else
            {
                label4.Text += totalCycle.Add(TimeSpan.Parse(this.dateTimePicker1.Text) + TimeSpan.Parse(this.dateTimePicker2.Text) + TimeSpan.Parse(this.dateTimePicker3.Text)).ToString("HH:mm:ss");
            }
        }
    }
}
