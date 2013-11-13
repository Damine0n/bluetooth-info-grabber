using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace CRS
{
    public class J2KNProtocol
    {
        public string vO2 = "0.0";
        public string vCO = "0.0";
        public string vNO = "0.0";
        public string vNO2 = "0.0";
        public string vNOx = "0.0";
        public string vSO2 = "0.0";
        public string vCxHy = "0.0";
        public string vDraft = "0.0";
        public string vTamb = "0.0";
        public string vTgas = "0.0";
        public string vTcell = "0.0";
        public string vIFlow = "0.0";
        public string vLosses = "0.0";
        public string vExcessAir = "0.0";
        public string vEfficiency = "0.0";
        public string vCO2 = "0.0";
        public string vCOBtu = "0.0";
        public string vNOxBtu = "0.0";
        public string vCOTPY = "0.0";
        public string vNOxTPY = "0.0";
        public string vCOHr = "0.0";
        public string vNOxHr = "0.0";
        public string vCOBhp = "0.0";
        public string vNOxBhp = "0.0";
        public string vCO_C = "0.0";
        public string vNO_C = "0.0";
        public string vNO2_C = "0.0";
        public string vNOx_C = "0.0";
        public string vSO2_C = "0.0";
        public string vCxHy_C = "0.0";
        public string vCOmass_C = "0.0";
        public string vNOxmass_C = "0.0";
        public string vAccu = "";
        public string vSerialNumber = "";
        public string vFirmware = "";
        public string ipAddress = "192.168.55.1";
        public IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
        public string tempvCO_C;
        public string tempvNO_C;
        public string tempvNO2_C;
        public string tempvNOx_C;
        public string tempvSO2_C;
        public string tempvCxHy_C;
        public int signalStrength = 0;
        public J2KNProtocol()
        {
        }
        public void disconnect()
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Disconnect(false);
        }
        public bool processProtocol()
        {
            byte[] sendPacket = new byte[256];
            string p = "$0802";
            string vbCr = "\r";
            byte[] receivedBytes = new byte[256];
            double iValue = 0;
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (!clientSocket.Connected)
            {
                try
                {
                    clientSocket.Connect(IPAddress.Parse(ipAddress), 4000);
                }
                catch
                {
                    return false;
                }
                try
                {
                    sendPacket = Encoding.UTF8.GetBytes(p + CalculateChecksum(p) + vbCr);
                    clientSocket.Send(sendPacket);
                    clientSocket.ReceiveTimeout = 4000;
                    clientSocket.Receive(receivedBytes);
                    string[] arr = Encoding.ASCII.GetString(receivedBytes).Split(';');

                    iValue = Convert.ToInt32(arr[3].Substring(2, arr[3].Length - 2), 16);
                    if (iValue >= 32767 || iValue == 0)
                        vO2 = "0.0";
                    else
                        vO2 = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[4].Substring(2, arr[4].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vCO = "0.0";
                    else
                        vCO = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[5].Substring(2, arr[5].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vNO = "0.0";
                    else
                        vNO = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[6].Substring(2, arr[6].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vNO2 = "0.0";
                    else
                        vNO2 = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[7].Substring(2, arr[7].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vSO2 = "0.0";
                    else
                        vSO2 = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[8].Substring(2, arr[8].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vCxHy = "0.0";
                    else
                        vCxHy = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[9].Substring(2, arr[9].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vDraft = "0.0";
                    else
                        vDraft = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[10].Substring(2, arr[10].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vTamb = "0.0";
                    else
                        vTamb = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[11].Substring(2, arr[11].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vTgas = "0.0";
                    else
                        vTgas = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[12].Substring(2, arr[12].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vTcell = "0.0";
                    else
                        vTcell = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[13].Substring(2, arr[13].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vExcessAir = "0.00";
                    else
                        vExcessAir = (iValue / 100).ToString("0.00");
                    iValue = (Convert.ToInt32(arr[14].Substring(2, arr[14].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vEfficiency = "0.0";
                    else
                        vEfficiency = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[15].Substring(2, arr[15].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vCO2 = "0.0";
                    else
                        vCO2 = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[16].Substring(2, arr[16].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vAccu = "0.0";
                    else
                        vAccu = (iValue / 10).ToString("0.0");
                    double num = Convert.ToDouble(vNO) + Convert.ToDouble(vNO2);
                    vNOx = num.ToString();
                    
                    clientSocket.Close();
                }
                catch
                {
                }
                return true;
            }
            return false;
        }
        public bool processProtocol(bool first)
        {
            byte[] sendPacket = new byte[256];
            string p = "$0802";
            string vbCr = "\r";
            byte[] receivedBytes = new byte[256];
            double iValue = 0;
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (!clientSocket.Connected)
            {
                try
                {
                    clientSocket.Connect(IPAddress.Parse(ipAddress), 4000);
                }
                catch
                {
                    return false;
                }

                sendPacket = Encoding.UTF8.GetBytes(p + CalculateChecksum(p) + vbCr);
                clientSocket.Send(sendPacket);
                clientSocket.ReceiveTimeout = 4000;
                clientSocket.Receive(receivedBytes);

                try
                {
                    string[] arr = Encoding.ASCII.GetString(receivedBytes).Split(';');
                    iValue = Convert.ToInt32(arr[3].Substring(2, arr[3].Length - 2), 16);
                    if (iValue >= 32767 || iValue == 0)
                        vO2 = "0.0";
                    else
                        vO2 = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[4].Substring(2, arr[4].Length - 2), 16));
                    if (iValue >= 32767)
                        vCO = "0.0";
                    else
                        vCO = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[5].Substring(2, arr[5].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vNO = "0.0";
                    else
                        vNO = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[6].Substring(2, arr[6].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vNO2 = "0.0";
                    else
                        vNO2 = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[7].Substring(2, arr[7].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vSO2 = "0.0";
                    else
                        vSO2 = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[8].Substring(2, arr[8].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vCxHy = "0.0";
                    else
                        vCxHy = (iValue).ToString();
                    iValue = (Convert.ToInt32(arr[9].Substring(2, arr[9].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vDraft = "0.0";
                    else
                        vDraft = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[10].Substring(2, arr[10].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vTamb = "0.0";
                    else
                        vTamb = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[11].Substring(2, arr[11].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vTgas = "0.0";
                    else
                        vTgas = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[12].Substring(2, arr[12].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vTcell = "0.0";
                    else
                        vTcell = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[13].Substring(2, arr[13].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vExcessAir = "0.00";
                    else
                        vExcessAir = (iValue / 100).ToString("0.00");
                    iValue = (Convert.ToInt32(arr[14].Substring(2, arr[14].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vEfficiency = "0.0";
                    else
                        vEfficiency = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[15].Substring(2, arr[15].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vCO2 = "0.0";
                    else
                        vCO2 = (iValue / 10).ToString("0.0");
                    iValue = (Convert.ToInt32(arr[16].Substring(2, arr[16].Length - 2), 16));
                    if (iValue >= 32767 || iValue == 0)
                        vAccu = "0.0";
                    else
                        vAccu = (iValue / 10).ToString("0.0");
                    double num = Convert.ToDouble(vNO) + Convert.ToDouble(vNO2);
                    vNOx = num.ToString();

                }
                catch
                {
                    MessageBox.Show("You must connect analyzer to computer with IP address in 'Set-Up Communication'.");
                }
                clientSocket.Close();
                return true;
            }
            return false;
        }
        public void populateCorrection(int index, double num)
        {
            double Emeas, O2meas = Convert.ToDouble(vO2);
            try
            {
                switch (index)
                {
                    case 1:
                        Emeas = Convert.ToDouble(vCO);
                        tempvCO_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();

                        if (tempvCO_C.Equals("Infinity") || tempvCO_C.Equals("NaN"))
                            tempvCO_C = "0.0";

                        break;
                    case 2:
                        Emeas = Convert.ToDouble(vNO);
                        tempvNO_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();
                        if (tempvNO_C.Equals("Infinity") || tempvNO_C.Equals("NaN"))
                            tempvNO_C = "0.0";
                        break;
                    case 3:
                        Emeas = Convert.ToDouble(vNO2);
                        tempvNO2_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();
                        if (tempvNO2_C.Equals("Infinity") || tempvNO2_C.Equals("NaN"))
                            tempvNO2_C = "0.0";
                        break;
                    case 4:
                        Emeas = Convert.ToDouble(vNOx);
                        tempvNOx_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();
                        if (tempvNOx_C.Equals("Infinity") || tempvNOx_C.Equals("NaN"))
                            tempvNOx_C = "0.0";
                        break;
                    case 5:
                        Emeas = Convert.ToDouble(vSO2);
                        tempvSO2_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();
                        if (tempvSO2_C.Equals("Infinity") || tempvSO2_C.Equals("NaN"))
                            tempvSO2_C = "0.0";
                        break;
                    case 6:
                        Emeas = Convert.ToDouble(vCxHy);
                        tempvCxHy_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();
                        if (tempvCxHy_C.Equals("Infinity") || tempvCxHy_C.Equals("NaN"))
                            tempvCxHy_C = "0.0";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void populateCorrection(double num)
        {
            double Emeas;
            double O2meas = Convert.ToDouble(vO2);

            Emeas = Convert.ToDouble(vCO);
            vCO_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();

            Emeas = Convert.ToDouble(vNO);
            vNO_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();

            Emeas = Convert.ToDouble(vNO2);
            vNO2_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();

            Emeas = Convert.ToDouble(vNOx);
            vNOx_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();

            Emeas = Convert.ToDouble(vSO2);
            vSO2_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();

            Emeas = Convert.ToDouble(vCxHy);
            vCxHy_C = Math.Round(Emeas * ((21 - num) / (21 - O2meas))).ToString();
            if (vNO_C.Equals("Infinity") || vNO_C.Equals("NaN"))
            {
                vNO_C = "0.0";
                vCO_C = "0.0";
                vNO2_C = "0.0";
                vNOx_C = "0.0";
                vSO2_C = "0.0";
                vCxHy_C = "0.0";
            }
        }
        public void massEmissions(int type)
        {
            processProtocol();
            double value;
            switch (type)
            {
                case 0:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 9190 * (20.9/(20.9-Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 9190 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
                case 1:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 9190 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 9190 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
                case 2:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 9190 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 9190 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
                case 3:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 8710 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 8710 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString("F");
                    break;
                case 4:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 8710 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 8710 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
                case 5:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 8710 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 8710 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
                case 6:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 10100 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 10100 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
                case 7:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 9780 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 9780 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
                case 8:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 9860 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 9860 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
                case 9:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 9240 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10,-7) * 9240 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
                case 10:
                    value = Convert.ToDouble(vCO) * 7.271 * Math.Pow(10,-8) * 9600 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vCOBtu = value.ToString();
                    value = Convert.ToDouble(vNOx) * 1.194 * Math.Pow(10, -7) * 9600 * (20.9 / (20.9 - Convert.ToDouble(vO2)));
                    vNOxBtu = value.ToString();
                    break;
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

        public void processProtocol(string p)
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            byte[] sendPacket = new byte[256];
            string vbCr = "\r";
            byte[] receivedBytes = new byte[256];
            double iValue = 0;

            if (!clientSocket.Connected)
                try
                {
                    clientSocket.Connect(IPAddress.Parse(ipAddress), 4000);
                }
                catch
                {
                    return;
                }
            try
            {
                sendPacket = Encoding.UTF8.GetBytes(p + CalculateChecksum(p) + vbCr);
                clientSocket.Send(sendPacket);
                clientSocket.ReceiveTimeout = 4000;
                clientSocket.Receive(receivedBytes);

                string[] arr = Encoding.ASCII.GetString(receivedBytes).Split(';');
                if (p.Equals("$0A0514"))
                    vSerialNumber = (Convert.ToInt32(arr[1].Substring(2, arr[1].Length - 2), 16)).ToString();
                if (p.Equals("$0A053D"))
                {
                    iValue = Convert.ToInt32(arr[1].Substring(2, arr[1].Length - 2), 16);
                    if (iValue >= 32767 || iValue == 0)
                        vLosses = "0.0";
                    else
                        vLosses = (iValue / 10).ToString("0.0");
                }
                else if (p.Equals("$0A0531"))
                {
                    iValue = Convert.ToInt32(arr[1].Substring(2, arr[1].Length - 2), 16);
                    vIFlow = (iValue / 100).ToString("0.00");
                }

                else if (p.Equals("$0A0512"))
                {
                    signalStrength = Convert.ToInt32(arr[1].Substring(2, arr[1].Length - 2), 16);
                }
                else if (p.Equals("$0A0515"))
                {
                    vFirmware = Convert.ToInt32(arr[1].Substring(2, arr[1].Length - 2), 16).ToString();
                }
                else if (p.Equals("$0f1006 0x20"))
                {
                    MessageBox.Show(Encoding.ASCII.GetString(receivedBytes));
                    MessageBox.Show(Convert.ToInt32(arr[1].Substring(2, arr[1].Length - 2), 16).ToString());
                }
            }
            catch
            {
            }
            clientSocket.Close();

        }
    }
}