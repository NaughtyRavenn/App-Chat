using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_CreateGroup : Form
    {
        public Form_CreateGroup()
        {
            InitializeComponent();
        }

        private void Form_CreateGroup_Load(object sender, EventArgs e)
        {

        }

        private bool CheckInfo()
        {
            if (string.IsNullOrEmpty(TextBox_Name.Text))
                return false;
            else if (PictureBox_Avatar.Image == null)
                return false;
            return true;
        }

        private void CreateGroup()
        {
            string sqlQuery = "INSERT INTO GROUPCHAT (Name,Port,Avatar) VALUES ( @name , @port , @avatar )";
            int Port = DataProvider.Instance.ProvideGroupPort();
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { TextBox_Name.Text, Port, Avatar });
            string sqlQuery3 = "SELECT ID FROM GROUPCHAT WHERE Name = @name1 ";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery3, new object[] { TextBox_Name.Text });
            int groupid = int.Parse(Data.Rows[0]["ID"].ToString());
            string sqlQuery2 = "INSERT INTO GROUPINFO (GROUP_ID,ACCOUNT_ID) VALUES ( @groupid , @accountid )";
            DataProvider.Instance.ExcuteQuery(sqlQuery2, new object[] { groupid, Account.Instance.ID });
            ChangeData();
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                CreateGroup();
                MessageBox.Show("Group successfully created");
                this.Hide();
            }
            else
            {
                Label_Name.Text = "Invalid name or avatar";
                return;
            }
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

        private void Button_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select avatar";
            open.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (.jpg;.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (.png)|.png";
            try
            {
                string file = InteractImage.getLinkFromDialog();
                PictureBox_Avatar.Image = InteractImage.BytesToImage(InteractImage.FromFile(file));
                Avatar = File.ReadAllBytes(file);
            }
            catch
            {
                return;
            }
        }

        private IPEndPoint _IP;
        private Socket _Client;
        private byte[] _Avatar;

        public IPEndPoint IP { get => _IP; set => _IP = value; }
        public Socket Client { get => _Client; set => _Client = value; }
        public byte[] Avatar { get => _Avatar; set => _Avatar = value; }


    }
}
