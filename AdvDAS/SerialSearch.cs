using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace genericSerial
{
    public partial class SerialSearch : Form
    {
        public SerialSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = serialPort1.Read().ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                string text = textBox1.Text;
                serialPort1.WriteLine(text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            richTextBox1.Text += "The following serial ports were found:";

            // Display each port name to the console. 
            foreach (string port in ports)
            {
                listBox1.Items.Add(port);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = listBox1.SelectedItem.ToString();
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                richTextBox1.Text += "\nOpened";
            }
            else
            {


            }
        }
    }
}
