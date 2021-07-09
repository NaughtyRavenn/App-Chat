using System;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_FriendInfomation : Form
    {
        public Form_FriendInfomation(Form_InteractSingle PAR)
        {
            InitializeComponent();
            this.Par = PAR;
        }

        private void Form_FriendInfomation_Load(object sender, EventArgs e)
        {
            PictureBox_Avatar.Image = DataProvider.Instance.GetSingleImage(Par.Par.ID);
            Label_Name.Text = Par.Par.Name1;
            Label_Birthday.Text = Par.Par.Birthday.ToString();
            Label_Email.Text = Par.Par.Email;
            Label_Phonenumber.Text = Par.Par.Phonenumber;
        }

        private Form_InteractSingle _Par;

        public Form_InteractSingle Par { get => _Par; set => _Par = value; }
    }
}
