using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void Run_Server()
        {
            foreach (var v in DataProvider.Instance.LoadContactFromDB())
            {
                var i = v;
                Thread t = new Thread(() =>
                {
                    Connect(i);
                });
                t.IsBackground = true;
                t.Start();
            }
        }


        void Connect(int v)
        {

            ClientList = new List<Client>();
            IP = new IPEndPoint(IPAddress.Any, v);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                Server.Bind(IP);
            }
            catch
            {
                return;
            }
            Server.Listen(10);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Client client = new Client();
                        client.clientsocket = Server.Accept();
                        ClientList.Add(client);
                        ThreadPool.QueueUserWorkItem(Receive, client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, v);
                    Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        void Receive(object obj)
        {
            Client client = obj as Client;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.clientsocket.Receive(data);
                    /*string message = (string)Deserialize(data);*/
                    foreach (Client item in ClientList)
                    {
                        if (item != null && item != client)
                            item.clientsocket.Send(data);
                    }
                }
            }
            catch
            {
                ClientList.Remove(client);
                client.clientsocket.Close();
            }
        }


        public class Client
        {
            public Socket clientsocket;
            public Client()
            {
                clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
        }

        private IPEndPoint _IP;
        private Socket _Server;
        private List<Client> _ClientList;

        public IPEndPoint IP { get => _IP; set => _IP = value; }
        public Socket Server { get => _Server; set => _Server = value; }
        public List<Client> ClientList { get => _ClientList; set => _ClientList = value; }

        private void Button_Reload_Click(object sender, EventArgs e)
        {
            Run_Server();
            MessageBox.Show("Server ran");
        }
    }
}
