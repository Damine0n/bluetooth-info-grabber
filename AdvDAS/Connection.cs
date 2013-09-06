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
    public partial class Connection : Form
    {
        public static J2KNProtocol protocol = new J2KNProtocol();
        MainMenu main;
        public Connection(MainMenu main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            protocol.ipAddress = textBox1.Text;
            main.dataGridTimer.Start();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox1.Enabled = false;
            else
                textBox1.Enabled = true;
        }
    }
}
