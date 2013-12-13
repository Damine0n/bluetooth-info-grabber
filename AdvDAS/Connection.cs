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
        public static J2KNProtocolw protocol = new J2KNProtocolw();
        MainMenu main;
        bool conn = false;
        public Connection(MainMenu main)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(protocol.ipHost.AddressList);
            comboBox1.Items.Add("192.168.55.1");
            comboBox1.SelectedIndex = comboBox1.Items.Count-1;
            this.main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                protocol.ipAddress = comboBox1.Text;
                if (protocol.processProtocol())
                {
                    conn = true;
                    J2KNProtocolw.start = true;
                    main.dataGridTimer.Start();
                    for (int i = 0; i <= 11; i++)
                        main.scaleDisplays[i].timer1.Start();
                    button1.Text = "Disconnect";
                }
                else
                {
                    conn = false;
                    J2KNProtocolw.start = false;
                    main.dataGridTimer.Stop();
                    for (int i = 0; i < 10; i++)
                        main.scaleDisplays[i].timer1.Stop();
                    
                    button1.Text = "Connect";
                }
            }
            else 
            {
 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                comboBox1.Enabled = false;
                //MainMenu.pictureBox1.Image = Properties.Resources.wi_fi_btn;
            else
                comboBox1.Enabled = true;
        }
    }
}
