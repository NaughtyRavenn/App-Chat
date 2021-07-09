using System;
using System.Drawing;
using System.Windows.Forms;
using AppChatV2.Class;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace AppChatV2
{
    public partial class UC_Friend : UserControl
    {
        Form_Main Par;
        public UC_Friend(Form_Main PAR)
        {
            InitializeComponent();
            this.Par = PAR;
        }

        private void UC_Friend_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void UC_Friend_Load(object sender, EventArgs e)
        {
            Label_Name.Text = Name1;
            if (Is_active == "true")
            {
                Button_Status.FillColor = Color.Green;
            }
            else
            {
                Button_Status.FillColor = Color.Gray;
            }
            PictureBox_Avatar.Image = DataProvider.Instance.GetSingleImage(ID);
        }

        public void NoticeMessage(bool a)
        {
            Notice_Message.Visible = a;
        }

        public string ReturnBackColor()
        {
            return this.BackColor.ToString();
        }

        private void Button_Option_Click(object sender, EventArgs e)
        {
            Form_InteractSingle frm = new Form_InteractSingle(this);
            frm.ShowDialog();
        }

        private void UC_Friend_Click(object sender, EventArgs e)
        {
            Par.ChangeColorFriend();
            (sender as UC_Friend).BackColor = Color.DimGray;
            Par.SwitchTab(Index);
            NoticeMessage(false);
        }

        private string _Name;
        private string _ID;
        private string _Is_active;
        private DateTime _Birthday;
        private string _Email;
        private string _Phonenumber;
        private int _Port;
        private UC_SingleChat _ChatBox;
        private Socket _Client;
        private IPEndPoint _IP;
        private int _Index;
        private List<string> listMessage;
        private byte[] _Avatar;

        public string Name1 { get => _Name; set => _Name = value; }
        public string Is_active { get => _Is_active; set => _Is_active = value; }
        public DateTime Birthday { get => _Birthday; set => _Birthday = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Phonenumber { get => _Phonenumber; set => _Phonenumber = value; }
        public int Port { get => _Port; set => _Port = value; }
        public UC_SingleChat ChatBox { get => _ChatBox; set => _ChatBox = value; }
        public Socket Client { get => _Client; set => _Client = value; }
        public IPEndPoint IP { get => _IP; set => _IP = value; }
        public string ID { get => _ID; set => _ID = value; }
        public int Index { get => _Index; set => _Index = value; }
        public List<string> ListMessage { get => listMessage; set => listMessage = value; }
        public byte[] Avatar { get => _Avatar; set => _Avatar = value; }
    }
}
