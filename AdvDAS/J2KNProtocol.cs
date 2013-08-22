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
            if (!clientSocket.Connected)
                clientSocket.Connect(IPAddress.Parse("192.168.55.1"), 4000);
            sendPacket = Encoding.UTF8.GetBytes("$0802" + CalculateChecksum(sendString) + vbCr);
            int i = clientSocket.Send(sendPacket);

            clientSocket.ReceiveTimeout = 4000;

            i = clientSocket.Receive(receivedBytes);
            string[] arr = Encoding.ASCII.GetString(receivedBytes).Split(';');

            vO2 = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vCO = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vCO2 = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vNO = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vNO2 = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vSO2 = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vCxHy = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vDraft = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vTamb = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vTgas = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vTcell = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vAccu = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vExcessAir = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            vEfficiency = (Convert.ToInt32(arr[3].Substring(2, 4), 16) / 10).ToString();
            for (int j = 2; j < arr.Length - 4; j++)
            {
                Convert.ToInt32(arr[j].Substring(2, 4), 16).ToString("000").Insert(2, ".");
            }

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
