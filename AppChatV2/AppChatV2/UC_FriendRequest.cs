using System;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class UC_FriendRequest : UserControl
    {
        Form_AddFriend Par;
        public UC_FriendRequest(Form_AddFriend PAR)
        {
            InitializeComponent();
            this.Par = PAR;
        }

        private void UC_FriendRequest_Load(object sender, EventArgs e)
        {
            Label_Name.Text = Name1;
            PictureBox_Avatar.Image = DataProvider.Instance.GetSingleImage(ID);
        }

        private void Button_Option_Click(object sender, EventArgs e)
        {
            Form_ResponeOption frm = new Form_ResponeOption(this);
            frm.ShowDialog();
        }

        public void Reload()
        {
            Par.Reload();
        }

        private string _Name;
        private string _ID;

        public string Name1 { get => _Name; set => _Name = value; }
        public string ID { get => _ID; set => _ID = value; }
    }
}
