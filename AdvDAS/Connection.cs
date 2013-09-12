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
        bool conn = false;
        public Connection(MainMenu main)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(protocol.ipHost.AddressList);
            comboBox1.SelectedText = protocol.ipAddress;
            this.main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            protocol.ipAddress = comboBox1.Text;
            if (!protocol.processProtocol().Equals(conn))
            {
                conn = true;
                main.dataGridTimer.Start();
                for (int i = 0; i < 10; i++)
                    main.scaleDisplays[i].timer1.Start();
                button1.Text = "Disconnect";
            }
            else
            {
                conn = false;
                main.dataGridTimer.Stop();
                for (int i = 0; i < 10; i++)
                    main.scaleDisplays[i].timer1.Stop();
                button1.Text = "Connect";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                comboBox1.Enabled = false;
            else
                comboBox1.Enabled = true;
        }
    }
}
