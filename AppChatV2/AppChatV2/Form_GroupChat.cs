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

namespace AppChatV2
{
    public partial class Form_GroupChat : Form
    {
        public Form_GroupChat()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            
        }

        IPEndPoint IP;
        Socket client;

        //Gửi tin đi
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        //Kết nối tới server
        void Connect()
        {
            
         /*   IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();*/
        }

        //Đóng kết nối
        void Close()
        {
            /*client.Close();*/
        }

        //Gửi tin
        void Send()
        {
            /*if (txtMessage.Text != string.Empty)
                client.Send(Serialize(txtMessage.Text));
            AddMessage(txtMessage.Text);*/
        }

        //Nhận tin
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        //Add message vào khung chat
        void AddMessage(string s)
        {
           /* lstvMessage.Items.Add(new ListViewItem() { Text = s });
            txtMessage.Clear();*/
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

        //Đóng kết nối khi đóng form
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void frmSinglechat_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void Form_GroupChat_Load(object sender, EventArgs e)
        {

        }

        private void Button_GroupInfomation_Click(object sender, EventArgs e)
        {
            /*Form_GroupInfomation frm = new Form_GroupInfomation(this, 3);
            frm.ShowDialog();*/
        }
    }
}
