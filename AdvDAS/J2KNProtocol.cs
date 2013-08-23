﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace CRS
{
    class J2KNProtocol
    {
        public string vO2="";
        public string vCO="";
        public string vNO="";
        public string vNO2="";
        public string vNOx="";
        public string vSO2="";
        public string vCxHy="";
        public string vDraft="";
        public string vTamb="";
        public string vTgas="";
        public string vTcell="";
        public string vIFlow="";
        public string vLosses="";
        public string vExcessAir="";
        public string vEfficiency="";
        public string vCO2="";
        public string vCOmass="";
        public string vNOxmass="";
        public string vAccu="";
        public J2KNProtocol()
        {
            processProtocol();
        }

        private void processProtocol() 
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            byte[] sendPacket = new byte[256];
            string vbCr = "\r";
            string sendString = "$0802";
            byte[] receivedBytes = new byte[256];
            double iValue;

            if (!clientSocket.Connected)
                clientSocket.Connect(IPAddress.Parse("192.168.55.1"), 4000);
            sendPacket = Encoding.UTF8.GetBytes("$0802" + CalculateChecksum(sendString) + vbCr);
            int i = clientSocket.Send(sendPacket);

            clientSocket.ReceiveTimeout = 4000;

            i = clientSocket.Receive(receivedBytes);
            string[] arr = Encoding.ASCII.GetString(receivedBytes).Split(';');
            iValue = (Convert.ToInt32(arr[3].Substring(2, arr[3].Length - 2), 16));
            if (iValue >= 32767)
                vO2 = "0.0";
            else
                vO2 = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[4].Substring(2, arr[4].Length - 2), 16));
            if (iValue >= 32767)
                vCO = "0.0";
            else
                vCO = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[5].Substring(2, arr[5].Length - 2), 16));
            if (iValue >= 32767)
                vNO = "0.0";
            else
                vNO = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[6].Substring(2, arr[6].Length - 2), 16));
            if (iValue >= 32767)
                vNO2 = "0.0";
            else
                vNO2 = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[7].Substring(2, arr[7].Length - 2), 16));
            if (iValue >= 32767)
                vSO2 = "0.0";
            else
                vSO2 = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[8].Substring(2, arr[8].Length - 2), 16));
            if (iValue >= 32767)
                vCxHy = "0.0";
            else
                vCxHy = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[9].Substring(2, arr[9].Length - 2), 16));
            if (iValue >= 32767)
                vDraft = "0.0";
            else
                vDraft = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[10].Substring(2, arr[10].Length - 2), 16));
            if (iValue >= 32767)
                vTamb = "0.0";
            else
                vTamb = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[11].Substring(2, arr[11].Length - 2), 16));
            if (iValue >= 32767)
                vTgas = "0.0";
            else
                vTgas = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[12].Substring(2, arr[12].Length - 2), 16));
            if (iValue >= 32767)
                vTcell = "0.0";
            else
                vTcell = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[13].Substring(2, arr[13].Length - 2), 16));
            if (iValue >= 32767)
                vExcessAir = "0.0";
            else
                vExcessAir = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[14].Substring(2, 4), 16));
            if (iValue >= 32767)
                vEfficiency = "0.0";
            else
                vEfficiency = (iValue / 10).ToString();

            iValue = (Convert.ToInt32(arr[15].Substring(2, 4), 16));
            if (iValue >= 32767)
                vCO2 = "0.0";
            else
                vCO2 = (iValue / 10).ToString();
            iValue = (Convert.ToInt32(arr[16].Substring(2, arr[16].Length - 2), 16));
            if (iValue >= 32767)
                vAccu = "0.0";
            else
                vAccu = (iValue / 10).ToString();
            clientSocket.Disconnect(true);
            clientSocket.Close();
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
