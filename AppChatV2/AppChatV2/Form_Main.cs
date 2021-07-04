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
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Label_Name.Text = User.Instance.Name;
            /*Connect();*/
        }

        private void Button_Recent_Click(object sender, EventArgs e)
        {
            Notice1.Visible = true;
            Button_Recent.ForeColor = Color.FromArgb(218, 50, 207);
            Notice2.Visible = false;
            Button_ListFriend.ForeColor = Color.DimGray;
            Page_Main.SetPage(TabPage_Recent);
        }

        private void Button_ListFriend_Click(object sender, EventArgs e)
        {
            Notice2.Visible = true;
            Button_ListFriend.ForeColor = Color.FromArgb(218, 50, 207);
            Notice1.Visible = false;
            Button_Recent.ForeColor = Color.DimGray;
            Page_Main.SetPage(TabPage_ListFriend);
            LoadFriends();
        }

        private void LoadFriends()
        {
            FlowLayoutPanel_ListFriend.Controls.Clear();
            var Data = DataProvider.Instance.LoadListFriendIDAndPort();
            foreach (var v in Data)
            {
                var data = DataProvider.Instance.LoadInfoByID(v.Key);
                FlowLayoutPanel_ListFriend.Controls.Add(new UC_Friend()
                {
                    Name1 = data.Name,
                    ID = v.Key,
                    Is_active = data.Is_active,
                    Birthday = data.Birthday,
                    Phonenumber = data.Phonenumber,
                    Email = data.Email,
                    Port = v.Value
                });
            }
        }

        private void Button_EditProfile_Click(object sender, EventArgs e)
        {
            Form_EditProfile frm = new Form_EditProfile();
            frm.ShowDialog();
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button_SignOut_Click(object sender, EventArgs e)
        {
            Form_VerifySignout frm = new Form_VerifySignout(this);
            frm.ShowDialog();
        }

        private void Button_AddFriend_Click(object sender, EventArgs e)
        {
            Form_AddFriend frm = new Form_AddFriend();
            frm.ShowDialog();
        }


        //----------------------------------------------------------------


       /* IPEndPoint IP;
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
            foreach (var v in DataProvider.Instance.LoadContactFromDB())
            {
                clientList = new List<Client>();
                IP = new IPEndPoint(IPAddress.Any, 8001);
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
                        IP = new IPEndPoint(IPAddress.Any, 8001);
                        server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    }
                });
                listen.IsBackground = true;
                listen.Start();
            *//*}*//*
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
    }
}
