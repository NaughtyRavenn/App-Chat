using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_SingleChat : Form
    {
        public Form_SingleChat(Form_InteractSingle PAR)
        {
            InitializeComponent();
            this.Par = PAR;
            Label_Name.Text = Par.Par.Name1;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form_SingleChat_Load(object sender, EventArgs e)
        {
            Connect();
        }

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("192.168.0.104"), Par.Par.Port);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                Client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TextBox_Port.Text = Par.Par.Port.ToString();
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Close()
        {
            Client.Close();
        }

        void Send()
        {
            string name=Account.Instance.userName;
            if (RichTextBox_Message.Text != string.Empty)
                Client.Send(Serialize(name + " sent | " + RichTextBox_Message.Text + " | to " + Par.Par.Name1));
            AddMessage(RichTextBox_Message.Text);
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 999];
                    Client.Receive(data);

                    string message = (string)Deserialize(data);

                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        private void AddMessage(string mess)
        {
            /*lstvMessage.Items.Add(new ListViewItem()
            {
                Text = mess
            });*/
            mess += "\n";
            richTextBox1.Text += mess;
            RichTextBox_Message.Clear();
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


        private void Button_Send_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void Form_SingleChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private Socket _Client;
        private Form_InteractSingle _Par;
        private IPEndPoint _IP;
        private List<string> _listChat;

        public Form_InteractSingle Par { get => _Par; set => _Par = value; }
        public IPEndPoint IP { get => _IP; set => _IP = value; }
        public List<string> ListChat { get => _listChat; set => _listChat = value; }
        public Socket Client { get => _Client; set => _Client = value; }
    }
}
