using System;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_InteractSingle : Form
    {
        public Form_InteractSingle(UC_Friend PAR)
        {
            InitializeComponent();
            this.Par = PAR;
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            Form_FriendInfomation frm = new Form_FriendInfomation(this);
            frm.ShowDialog();
            this.Hide();
        }

        private void Form_InteractSingle_Load(object sender, EventArgs e)
        {

        }

        private void Button_Unfriend_Click(object sender, EventArgs e)
        {
            Unfriend();
            this.Hide();
        }

        private void Unfriend()
        {
            string sqlQuery = "DELETE FROM CONTACT WHERE ( ID1 = @id1 AND ID2 = @id2 ) OR ( ID1 = @id3 AND ID2 = @id4 )";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Account.Instance.ID, Par.ID, Par.ID, Account.Instance.ID });
        }
        
        private UC_Friend _Par;
        
        public UC_Friend Par { get => _Par; set => _Par = value; }
    }
}
