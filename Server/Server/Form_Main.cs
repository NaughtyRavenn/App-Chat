using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ListServerPort = new List<ServerPort>();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void Button_Listen_Click(object sender, EventArgs e)
        {
            DoConnect();
            MessageBox.Show("Server is running");
        }

        private void DoConnect()
        {
            var Data = DataProvider.Instance.LoadPortFromDB();
            Data.Add(9000);
            foreach (var v in Data)
            {
                ThreadConnect(v);
            }
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        public void ThreadConnect(int i)
        {
            var v = i;
            var thread = new Thread(() => Connect(v));
            thread.Name = "Connect";
            thread.IsBackground = true;
            thread.Start();
        }

        public void ThreadWithParameters(Socket client, List<Socket> list)
        {
            var t = new Thread(() => Receive(client, list));
            t.Name = "Receive";
            t.IsBackground = true;
            t.Start();
        }

        private void Connect(int i)
        {
            int v = i;
            ServerPort serverPort = new ServerPort(v);
            ListServerPort.Add(serverPort);
            try
            {
                serverPort.Server.Bind(serverPort.IPep);
            }
            catch
            {
                return;
            }

            serverPort.Server.Listen(100);

            try
            {
                while (true)
                {
                    Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    client = serverPort.Server.Accept();
                    RichTextBox_Message.Text += "New client connected from: " + client.RemoteEndPoint + "\n";
                    serverPort.ClientList.Add(client);
                    ThreadWithParameters(client, serverPort.ClientList);
                }
            }
            catch
            {
                serverPort.IPep = new IPEndPoint(IPAddress.Any, v);
                serverPort.Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
        }

        void Receive(Socket client,List<Socket> ClientList)
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    if(message=="Reload")
                    {
                        DoConnect();
                    }
                    foreach (Socket item in ClientList)
                    {
                        if (item != null && item != client)
                            item.Send(Serialize(message));
                    }
                }
            }
            catch
            {
                try
                {
                    ClientList.Remove(client);
                    client.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi client");
                }
            }
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        void Close()
        {
            foreach(var v in ListServerPort)
                v.Server.Close();
        }
        
        private void RichTextBox_Message_TextChanged(object sender, EventArgs e)
        {
            if (RichTextBox_Message.TextLength > 1000)
                RichTextBox_Message.Clear();
        }

        private Socket _Server;
        private List<ServerPort> _ListServerPort;

        public Socket Server { get => _Server; set => _Server = value; }
        internal List<ServerPort> ListServerPort { get => _ListServerPort; set => _ListServerPort = value; }

    }
}
