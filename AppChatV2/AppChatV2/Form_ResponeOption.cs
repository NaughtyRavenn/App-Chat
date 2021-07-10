using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_ResponeOption : Form
    {
        UC_FriendRequest Par;
        public Form_ResponeOption(UC_FriendRequest PAR)
        {
            InitializeComponent();
            this.Par = PAR;
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            int Port = DataProvider.Instance.ProvideSinglePort();
            string sqlQuery = "UPDATE CONTACT SET Type = 'Added',Port = @port WHERE ID1 = @id1 AND ID2 = @id2 ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Port,Par.ID, User.Instance.ID});
            ChangeData();
            Par.Reload();
            this.Hide();
        }

        public void ChangeData()
        {
            IP = new IPEndPoint(IPAddress.Parse(Account.Instance.IP), 9000);
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
            string mess = "Reload";
            Client.Send(Serialize(mess));
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        private void Form_ResponeOption_Load(object sender, EventArgs e)
        {

        }

        private void Button_Decline_Click(object sender, EventArgs e)
        {
            string sqlQuery = "DELETE FROM CONTACT WHERE ID1 = @id1 AND ID2 = @id2 ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Par.ID, User.Instance.ID });
            this.Hide();
        }

        private IPEndPoint _IP;
        private Socket _Client;

        public IPEndPoint IP { get => _IP; set => _IP = value; }
        public Socket Client { get => _Client; set => _Client = value; }
    }
}
