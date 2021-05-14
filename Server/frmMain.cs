using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        IPEndPoint IP;
        Socket server, client;
        List<Socket> clientList;
        string name;

        void Connect()
        {
            clientList = new List<Socket>();

            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                server.Bind(IP);
            }
            catch
            {
                return;
            }
            server.Listen(100);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Socket client = server.Accept();
                        name = Dns.GetHostName();
                        IPHostEntry ipHost = Dns.GetHostByName(name);
                        foreach (IPAddress ip in ipHost.AddressList)
                        {
                            lstvOnline.Items.Add(name + " from " + ip + " joined!");
                        }
                        clientList.Add(client);
                        ThreadPool.QueueUserWorkItem(Receive, client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        //Nhận dữ liệu từ khách
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                            item.Send(Serialize(message));
                    }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
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

        private void btnOpenserver_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}
    