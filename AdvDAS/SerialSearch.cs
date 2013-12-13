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
            string text = textBox1.Text;
            byte[] sendPacket = new byte[256];
            string vbCr = "\r";
            byte[] receivedBytes = new byte[256];
            if(serialPort1.IsOpen)
            {
                sendPacket = Encoding.UTF8.GetBytes(text + CalculateChecksum(text) + vbCr);

                serialPort1.WriteLine(text + CalculateChecksum(text) + vbCr);
                richTextBox1.Text+="/n"+ serialPort1.ReadLine();
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
        private static string CalculateChecksum(string dataToCalculate)
        {
            byte[] byteToCalculate = Encoding.ASCII.GetBytes(dataToCalculate);
            int checksum = 0;
            foreach (byte chData in byteToCalculate)
            {
                checksum += chData;
            }
            checksum &= 0xff;
            return checksum.ToString("X2");
        }
    }
}
