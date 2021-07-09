using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class UC_SingleChat : UserControl
    {
        UC_Friend Par;
        public UC_SingleChat(UC_Friend PAR,int i)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Par = PAR;
            Thread connect = new Thread(() => Connect(i));
            connect.Name = "Connect";
            connect.IsBackground = true;
            connect.Start();
        }

        private void RichTextBox_Message_TextChanged(object sender, EventArgs e)
        {
            if (RichTextBox_Message.Text == string.Empty)
                Button_Send.Enabled = false;
            else
                Button_Send.Enabled = true;
        }

        private void UC_SingleChat_Load(object sender, System.EventArgs e)
        {
            LabelBox_Name.Text = Name1;
            PictureBox_Avatar.Image = DataProvider.Instance.GetSingleImage(ID);
            Button_Send.Enabled = false;
        }

        private void Button_Send_Click(object sender, System.EventArgs e)
        {
            string name = User.Instance.Name;
            string ID = Account.Instance.ID;
            if (RichTextBox_Message.Text != string.Empty)
                Client.Send(Serialize(name + ": " + RichTextBox_Message.Text));
            AddMessage(name + ": " + RichTextBox_Message.Text);
        }

        private void AddMessage(string mess)
        {
            mess += "\n";
            RichTextBox_Display.Text += mess;
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

        public void Connect(int i)
        {
            IP = new IPEndPoint(IPAddress.Parse(Account.Instance.IP), i);
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

            Thread listen = new Thread(Receive);
            listen.Name = "Receive";
            listen.IsBackground = true;
            listen.Start();
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 999];
                    Client.Receive(data);
                    Invoke(new Action(() =>
                    {
                        if (Par.ReturnBackColor()=="Color [DimGray]")
                        {
                            Par.NoticeMessage(false);
                        }
                        else
                            Par.NoticeMessage(true);
                    }));
                    string message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private string _Name;
        private Socket _Client;
        private IPEndPoint _IP;
        private string _ID;

        public string Name1 { get => _Name; set => _Name = value; }
        public Socket Client { get => _Client; set => _Client = value; }
        public IPEndPoint IP { get => _IP; set => _IP = value; }
        public string ID { get => _ID; set => _ID = value; }
    }
}
