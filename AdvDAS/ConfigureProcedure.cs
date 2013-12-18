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
//using System.Data.SQLite;
using Finisar.SQLite;
using System.Drawing.Drawing2D;


namespace CRS
{
    public partial class SetUpProcedure : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + "\\database1.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        DataTable ds = new DataTable();
        private DateTime rampUp;
        private DateTime testData;
        private DateTime purge;
        private DateTime totalCycle;
        private DateTime cycle;
        private int sampleRate;
        private string numOfCycles;
        public SetUpProcedure()
        {
            InitializeComponent();
            try
            {
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            this.cycle = Convert.ToDateTime(cycle.Add(TimeSpan.Parse(rampUp.ToString("HH:mm:ss")) + TimeSpan.Parse(testData.ToString("HH:mm:ss")) + TimeSpan.Parse(purge.ToString("HH:mm:ss"))).ToString("HH:mm:ss"));
            if (numOfCycles.Equals("-1"))
            {
                this.numericUpDown1.Value = 1;
                checkBox1.CheckState = CheckState.Checked;
            }
            else
                this.numOfCycles = numOfCycles;

        }

        private void populate()
        {
            sqlite_conn.Open();

            try
            {
                sqlite_cmd = new SQLiteCommand("SELECT * FROM Configurations WHERE NUM = 0 ;", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    numOfCycles = sqlite_datareader[1].ToString();
                    if (!numOfCycles.Equals("-1"))
                        numericUpDown1.Value = Convert.ToInt32(numOfCycles);

                    sampleRate = Convert.ToInt32(sqlite_datareader[2].ToString());
                    numericUpDown2.Value = sampleRate;

                    rampUp = Convert.ToDateTime(sqlite_datareader[3].ToString());
                    dateTimePicker1.Value = rampUp;

                    testData = Convert.ToDateTime(sqlite_datareader[4].ToString());
                    dateTimePicker2.Value = testData;

                    purge = Convert.ToDateTime(sqlite_datareader[5].ToString());
                    dateTimePicker3.Value = purge;

                }
                sqlite_datareader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Configure Procedure Error: " + ex.Message + ex.StackTrace);
            }




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked.Equals(true))
            {
                this.label6.Enabled = false;
                this.numericUpDown1.Value = 1;
                this.numericUpDown1.Enabled = false;
                MessageBox.Show("Once the function is initiated, the analyzer will cycle continuously until the user stops the measurement.");
                this.numOfCycles = "-1";
            }
            else
            {
                this.label6.Enabled = true;
                this.numericUpDown1.Enabled = true;
            }
        }

        private void measurementOptions_CheckedChanged(object sender, EventArgs e)
        {
            cycle = new DateTime();
            if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(true))
            {
                this.label7.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.checkBox3.Enabled = false;
                this.label8.Enabled = false;
                this.dateTimePicker3.Enabled = false;
                this.checkBox5.Enabled = false;
                label4.Text = cycle.Add(TimeSpan.Parse(this.dateTimePicker2.Text)).ToString("HH:mm:ss");
                if (!checkBox1.Checked)
                    Cycles(Convert.ToInt32(numOfCycles), Convert.ToDateTime(label4.Text));
                else
                    Cycles(Convert.ToInt32(1), Convert.ToDateTime(label4.Text));
            }
            else if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(false))
            {
                this.label7.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.checkBox3.Enabled = false;
                this.label8.Enabled = true;
                this.dateTimePicker3.Enabled = true;
                this.checkBox5.Enabled = true;
                label4.Text = cycle.Add(TimeSpan.Parse(this.dateTimePicker2.Text) + TimeSpan.Parse(this.dateTimePicker3.Text)).ToString("HH:mm:ss");
                if (!checkBox1.Checked)
                    Cycles(Convert.ToInt32(numOfCycles), Convert.ToDateTime(label4.Text));
                else
                    Cycles(Convert.ToInt32(1), Convert.ToDateTime(label4.Text));
            }
            else if (checkBox2.Checked.Equals(false) && checkBox4.Checked.Equals(true))
            {
                this.label7.Enabled = true;
                this.dateTimePicker1.Enabled = true;
                this.checkBox3.Enabled = true;
                this.label8.Enabled = false;
                this.dateTimePicker3.Enabled = false;
                this.checkBox5.Enabled = false;
                label4.Text = cycle.Add(TimeSpan.Parse(this.dateTimePicker1.Text) + TimeSpan.Parse(this.dateTimePicker2.Text)).ToString("HH:mm:ss");
                if (!checkBox1.Checked)
                    Cycles(Convert.ToInt32(numOfCycles), Convert.ToDateTime(label4.Text));
                else
                    Cycles(Convert.ToInt32(1), Convert.ToDateTime(label4.Text));
            }
            else
            {
                this.label7.Enabled = true;
                this.dateTimePicker1.Enabled = true;
                this.checkBox3.Enabled = true;
                this.label8.Enabled = true;
                this.dateTimePicker3.Enabled = true;
                this.checkBox5.Enabled = true;
                label4.Text = cycle.Add(TimeSpan.Parse(this.dateTimePicker1.Text) + TimeSpan.Parse(this.dateTimePicker2.Text) + TimeSpan.Parse(this.dateTimePicker3.Text)).ToString("HH:mm:ss");
                if (!checkBox1.Checked)
                    Cycles(Convert.ToInt32(numOfCycles), Convert.ToDateTime(label4.Text));
                else
                    Cycles(Convert.ToInt32(1), Convert.ToDateTime(label4.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(true))
            {
                MainMenu.testData = this.dateTimePicker2.Value;
            }
            else if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(false))
            {
                MainMenu.testData = this.dateTimePicker2.Value;
                MainMenu.purge = this.dateTimePicker3.Value;
            }
            else if (checkBox2.Checked.Equals(false) && checkBox4.Checked.Equals(true))
            {
                MainMenu.rampUp = this.dateTimePicker1.Value;
                MainMenu.testData = this.dateTimePicker2.Value;
            }
            else
            {
                MainMenu.rampUp = this.dateTimePicker1.Value;
                MainMenu.testData = this.dateTimePicker2.Value;
                MainMenu.purge = this.dateTimePicker3.Value;
            }
            if (numOfCycles == "-1")
            {
                MainMenu.testTime = this.cycle;
            }
            else
            {
                MainMenu.testTime = this.totalCycle;
            }
            MainMenu.numOfCycles = this.numOfCycles;
            MainMenu.dgInterval = sampleRate * 1000;

            ////////////////////////////////Database Upload///////////////////////////
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                // Lets insert something into our new table:
                sqlite_cmd.CommandText = "UPDATE Configurations SET NOC = " + numOfCycles + ", SPS = " + sampleRate
                        + ", Ramp = '" + dateTimePicker1.Text + "', Measurement = '" + dateTimePicker2.Text + "', Purge = '" + dateTimePicker3.Text + "', TTT = '" + this.totalCycle + "';";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            MainMenu.recordA = checkBox3.Checked;
            MainMenu.recordB = checkBox3.Checked;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            cycle = new DateTime();
            rampUp = this.dateTimePicker1.Value;
            testData = this.dateTimePicker2.Value;
            purge = this.dateTimePicker3.Value;
            if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(true))
            {
                cycle = Convert.ToDateTime(cycle.Add(TimeSpan.Parse(this.testData.ToString("HH:mm:ss"))).ToString("HH:mm:ss"));
                label4.Text = cycle.ToString("HH:mm:ss");
            }
            else if (checkBox2.Checked.Equals(true) && checkBox4.Checked.Equals(false))
            {
                cycle = Convert.ToDateTime(cycle.Add(TimeSpan.Parse(this.testData.ToString("HH:mm:ss")) + TimeSpan.Parse(this.purge.ToString("HH:mm:ss"))).ToString("HH:mm:ss"));
                label4.Text = cycle.ToString("HH:mm:ss");
            }
            else if (checkBox2.Checked.Equals(false) && checkBox4.Checked.Equals(true))
            {
                cycle = Convert.ToDateTime(cycle.Add(TimeSpan.Parse(this.rampUp.ToString("HH:mm:ss")) + TimeSpan.Parse(this.testData.ToString("HH:mm:ss"))).ToString("HH:mm:ss"));
                label4.Text = cycle.ToString("HH:mm:ss");
            }
            else
            {
                cycle = Convert.ToDateTime(cycle.Add(TimeSpan.Parse(this.rampUp.ToString("HH:mm:ss")) + TimeSpan.Parse(this.testData.ToString("HH:mm:ss")) + TimeSpan.Parse(this.purge.ToString("HH:mm:ss"))).ToString("HH:mm:ss"));
                label4.Text = cycle.ToString("HH:mm:ss");
            }
            if (!checkBox1.Checked)
                Cycles(Convert.ToInt32(numOfCycles), cycle);
            else
                Cycles(Convert.ToInt32(1), Convert.ToDateTime(label4.Text));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            sampleRate = (int)numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numOfCycles = "" + numericUpDown1.Value;
            Cycles(Convert.ToInt32(numOfCycles), cycle);
        }
        private void Cycles(int x, DateTime newCycle)
        {
            DateTime newTotal = new DateTime();
            for (int i = 0; i < x; i++)
            {
                newTotal = Convert.ToDateTime(newTotal.Add(TimeSpan.Parse(newCycle.ToString("HH:mm:ss"))).ToString("HH:mm:ss"));
            }
            this.totalCycle = newTotal;
            //label4.Text = totalCycle.ToString("HH:mm:ss");
        }
    }
}
