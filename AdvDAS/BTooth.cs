using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using InTheHand;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Ports;
using InTheHand.Net.Sockets;



namespace BTooth_tutorial
{
    public partial class BTooth : Form
    {
        List<string> items;
        BluetoothDeviceInfo deviceInfo;
        BluetoothDeviceInfo[] devices;
        string myPin = "1234";
        bool ready = false;
        byte [] message;
        public BTooth()
        {
            InitializeComponent();
            items = new List<string>();
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            if (serverStarted)
            {
                updateUI("Server already started");
                return;
            }
            if (rbClient.Checked)
            {
                
                startScan();
            }
            else
            {
                connectAsServer();
            }
        }

        private void startScan()
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            items.Clear();
            Thread bluetoothScanThread = new Thread(new ThreadStart(scan));
            bluetoothScanThread.Start();
        }

        private void scan()
        {            
            updateUI("Starting Scan...");
            BluetoothClient client = new BluetoothClient();
            devices = client.DiscoverDevicesInRange();
            updateUI("Scan complete");
            updateUI(devices.Length.ToString() + " devices discovered");
            foreach(BluetoothDeviceInfo d in devices)
            {
                items.Add(d.DeviceName);
            }

            updateDeviceList();
        }
        private void connectAsServer()
        {
            Thread bluetoothServerThread = new Thread(new ThreadStart(ServerConnectThread));
            bluetoothServerThread.Start();
        }

        private void connectAsClient()
        {
            throw new NotImplementedException();
        }
        Guid mUUID = new Guid("00001101-0000-1000-8000-00805F9B34F8");
        bool serverStarted = false;
        public void ServerConnectThread()
        {
            serverStarted = true;
            updateUI("Server started, waiting for clients");
            BluetoothListener blueListener = new BluetoothListener(mUUID);
            blueListener.Start();
            BluetoothClient conn = blueListener.AcceptBluetoothClient();
            updateUI("Client has connected");

            Stream mStream = conn.GetStream();
            while(true)
            {
                try
                {
                    //handle server connection
                    byte[] received = new byte[1024];
                    mStream.Read(received, 0, received.Length);
                    updateUI("Received " + Encoding.ASCII.GetString(received));
                    byte[] sent = Encoding.ASCII.GetBytes("Hello World");
                    mStream.Write(sent, 0, sent.Length);
                } catch(Exception ex){
                    updateUI("Client has disconnected!!!~!!!"+System.Environment.NewLine + ex);
                }

            }
        }

        private void updateUI(string message)
        {
            Func<int> del = delegate()
            {
                tbOutput.AppendText(message + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }

        private void updateDeviceList()
        {
            Func<int> del = delegate()
            {
                listBox1.DataSource = items;
                return 0;
            };
            Invoke(del);
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            deviceInfo = devices.ElementAt(listBox1.SelectedIndex);
            updateUI(deviceInfo.DeviceName + " was selected, attempting connect. \nAddress = "+ deviceInfo.DeviceAddress);
            if (pairDevice())
            {
                updateUI("device paired...");
                updateUI("start connecting thread");
                Thread bluetoothClientThread = new Thread(new ThreadStart(ClientConnectThread));
                bluetoothClientThread.Start();
            }
            else
            {
                updateUI("Pair Failed");
            }
        }
        private void ClientConnectThread()
        {
            BluetoothClient client = new BluetoothClient();
            updateUI("attempting connect");
            client.BeginConnect(deviceInfo.DeviceAddress, mUUID,this.BluetoothClientConnectCallback,client);
        }
        void BluetoothClientConnectCallback(IAsyncResult result)
        {
            try
            {
                BluetoothClient client = (BluetoothClient)result.AsyncState;
                client.EndConnect(result);

                Stream stream = client.GetStream();
                stream.ReadTimeout = 1000;

                while (true)
                {
                    while (!ready) ;
                    stream.Write(message, 0, message.Length);
                }
            }
            catch (Exception ex)
            {
                updateUI(ex.ToString());
            }
        }
        
        private bool pairDevice()
        {
            if (!deviceInfo.Authenticated)
            {
                if (!BluetoothSecurity.PairRequest(deviceInfo.DeviceAddress, myPin))
                {
                    return false;
                }
            }
            return true;
        }

        private void tbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                message = Encoding.ASCII.GetBytes(tbText.Text);
                ready=true;
                tbText.Clear();
            }
        }
    }
}
