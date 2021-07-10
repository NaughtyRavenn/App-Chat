using System;
using System.Windows.Forms;
using AppChatV2.Class;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;

namespace AppChatV2
{
    public partial class UC_GroupChat : UserControl
    {
        public UC_Group Par;
        public UC_GroupChat(UC_Group PAR,int i)
        {
            InitializeComponent();
            this.Par = PAR;
            ID = Par.ID;
            Thread connect = new Thread(() => Connect(i));
            connect.Name = "Connect";
            connect.IsBackground = true;
            connect.Start();
        }

        private void Button_GroupInfo_Click(object sender, EventArgs e)
        {
            Form_GroupInfomation frm = new Form_GroupInfomation(this);
            frm.ShowDialog();
        }

        private void Button_Leave_Click(object sender, EventArgs e)
        {
            string sqlQuery = "DELETE FROM GROUPINFO WHERE ACCOUNT_ID = @id AND GROUP_ID = @id2 ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Account.Instance.ID, ID });
            Par.Reload();
        }

        private void UC_GroupChat_Load(object sender, EventArgs e)
        {
            LabelBox_Name.Text = Name1;
            PictureBox_Avatar.Image = DataProvider.Instance.GetGroupImage(ID);
            Button_Send.Enabled = false;
        }

        private void RichTextBox_Message_TextChanged(object sender, EventArgs e)
        {
            if (RichTextBox_Message.Text == string.Empty)
                Button_Send.Enabled = false;
            else
                Button_Send.Enabled = true;
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
                        if (Par.ReturnBackColor() == "Color [DimGray]")
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
