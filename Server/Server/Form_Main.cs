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
            var Data = DataProvider.Instance.LoadContactFromDB();
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
            #region v1
            /*for (int i = 8000; i <= 8001; i++)
            {*/
            int v = i;
            /*Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPEndPoint IPep = new IPEndPoint(IPAddress.Any, v);
            List<Socket> ClientList = new List<Socket>();*/
            ServerPort serverPort = new ServerPort(v);
            ListServerPort.Add(serverPort);
            /*IP1 = TextBox_IP.Text;*/
            try
            {
                /*Server.Bind(IPep);*/
                serverPort.Server.Bind(serverPort.IPep);
            }
            catch
            {
                return;
            }
            /*Server.Listen(100);*/
            serverPort.Server.Listen(100);
            /*Thread listen = new Thread(() =>
            {*/
            try
            {
                while (true)
                {
                    Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    client = serverPort.Server.Accept();
                    RichTextBox_Message.Text += "New client connected from: " + client.RemoteEndPoint + "\n";
                    serverPort.ClientList.Add(client);
                    /*Thread recv = new Thread(Receive);
                    recv.IsBackground = true;
                    recv.Start(client);*/
                    /*Thread recv=*/ThreadWithParameters(client, serverPort.ClientList);
                    /*recv.Start();*/
                    /*ThreadWithParameters(client, ClientList);*/
                    /*Thread recv = new Thread(() =>
                      {
                          try
                          {
                              while (true)
                              {
                                  byte[] data = new byte[1024 * 5000];
                                  client.Receive(data);

                                  string message = (string)Deserialize(data);
                                  AddMessage(client.RemoteEndPoint + ": " + message);
                                  foreach (Socket item in ClientList)
                                  {
                                      if (item != null && item != client)
                                          item.Send(Serialize(message));
                                  }
                              }
                          }
                          catch
                          {
                              ClientList.Remove(client);
                              client.Close();
                          }
                      });
                    recv.Name = "Receive";
                    recv.IsBackground = true;
                    recv.Start();*/
                }
            }
            catch
            {
                serverPort.IPep = new IPEndPoint(IPAddress.Any, v);
                serverPort.Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
                /*});
                listen.Name = "Listen";
                listen.IsBackground = true;
                listen.Start();

            }*/
            #endregion
        }

        //Nhận dữ liệu từ khách
        void Receive(Socket client,List<Socket> ClientList)
        {
            #region

           /* List<Socket> ClientList = obj2 as List<Socket>;*/
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
                    /*AddMessage(client.RemoteEndPoint + ": " + message);*/
                    foreach (Socket item in ClientList)
                    {
                        if (item != null && item != client)
                            item.Send(Serialize(message));
                    }
                }
            }
            catch
            {
                ClientList.Remove(client);
                client.Close();
            }
            #endregion
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

        void AddMessage(string s)
        {
            RichTextBox_Message.Text+=s+"\n";
        }

        private Socket _Server;
        private List<ServerPort> _ListServerPort;

        public Socket Server { get => _Server; set => _Server = value; }
        internal List<ServerPort> ListServerPort { get => _ListServerPort; set => _ListServerPort = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tabpg = new TabPage("Tab");
            tabControl1.TabPages.Add(tabpg);
            RichTextBox RichTextBox_Chat = new RichTextBox();
            tabpg.Controls.Add(RichTextBox_Chat);
        }
    }
}
