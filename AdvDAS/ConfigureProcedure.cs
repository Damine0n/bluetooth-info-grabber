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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked.Equals(true))
            {
                this.label6.Enabled = false;
                this.textBox1.Enabled = false;
                MessageBox.Show("Once the function is initiated, the analyzer will cycle continuously until the user stops the measurement.");
                
            }else
            {
                this.label6.Enabled = true;
                this.textBox1.Enabled = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked.Equals(true))
            {
                this.label7.Enabled = false;
                this.textBox2.Enabled = false;
                this.checkBox3.Enabled = false;       
            }else
            {
                this.label7.Enabled = true;
                this.textBox2.Enabled = true;
                this.checkBox3.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked.Equals(true))
            {
                this.label8.Enabled = false;
                this.textBox4.Enabled = false;
                this.checkBox5.Enabled = false;
            }else
            {
                this.label8.Enabled = true;
                this.textBox4.Enabled = true;
                this.checkBox5.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rampUp = Convert.ToDateTime(textBox2.Text);
            testData = Convert.ToDateTime(textBox6.Text);
            purge = Convert.ToDateTime(textBox4.Text);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            rampUp = Convert.ToDateTime(textBox2.Text);
            testData = Convert.ToDateTime(textBox6.Text);
            purge = Convert.ToDateTime(textBox4.Text);
            totalCycle = rampUp.Add(testData.Add(purge.Date);

        }
    }
}
