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
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_InteractSingle : Form
    {
        public Form_InteractSingle(UC_Friend PAR)
        {
            InitializeComponent();
            this.Par = PAR;

            CheckForIllegalCrossThreadCalls = false;
        }
 

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            Form_FriendInfomation frm = new Form_FriendInfomation(this);
            frm.ShowDialog();
            this.Hide();
        }

        private void Form_InteractSingle_Load(object sender, EventArgs e)
        {
            /*Connect();*/
        }

        private void Button_Chat_Click(object sender, EventArgs e)
        {
            Form_SingleChat frm = new Form_SingleChat(this);
            frm.Show();
            this.Hide();
        }

        private void Button_Unfriend_Click(object sender, EventArgs e)
        {
            Unfriend();
            this.Hide();
        }

        private void Unfriend()
        {
            string sqlQuery = "DELETE FROM CONTACT WHERE ( ID1 = @id1 AND ID2 = @id2 ) OR ( ID1 = @id3 AND ID2 = @id4 )";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Account.Instance.id, Par.ID, Par.ID, Account.Instance.id });
        }

        private void Button_AddGroup_Click(object sender, EventArgs e)
        {
            Form_GroupInfomation frm = new Form_GroupInfomation(this, 1);
            frm.ShowDialog();
        }

        //--------------------------------------------
        
        private UC_Friend _Par;
        /*IPEndPoint IP;
        Socket server;
        List<Client> clientList;
        public class Client
        {
            public Socket clientsocket;
            public Client()
            {
                clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
        }

        void Connect()
        {
            clientList = new List<Client>();
            IP = new IPEndPoint(IPAddress.Any, Par.Port);
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
                        Client client = new Client();
                        client.clientsocket = server.Accept();
                        clientList.Add(client);
                        ThreadPool.QueueUserWorkItem(Receive, client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, Par.Port);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
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

                    foreach (Client item in clientList)
                    {
                        if (item != null && item != client)
                            item.clientsocket.Send(data);
                    }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.clientsocket.Close();
            }
        }*/

        public UC_Friend Par { get => _Par; set => _Par = value; }
    }
}
