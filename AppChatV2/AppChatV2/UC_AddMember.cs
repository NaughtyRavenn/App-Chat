using System;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class UC_AddMember : UserControl
    {
        Form_AddMember Par;
        public UC_AddMember(Form_AddMember PAR)
        {
            InitializeComponent();
            this.Par = PAR;
        }

        private void UC_AddMember_Load(object sender, EventArgs e)
        {
            Label_Name.Text = Name1;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            AddMember();
            MessageBox.Show("Friend successfully added");
            Par.Par.Par.Par.Par.Reload();
        }
        
        private void AddMember()
        {
            string sqlQuery = "INSERT INTO GROUPINFO (Group_ID,Account_ID) VALUES ( @groupid , @accoutid )";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { GroupID, FriendID });
        }

        public void VisibleButton()
        {
            Button_Add.Visible = false;
        }

        private string _Name;
        private string _GroupID;
        private string _FriendID;

        public string Name1 { get => _Name; set => _Name = value; }
        public string GroupID { get => _GroupID; set => _GroupID = value; }
        public string FriendID { get => _FriendID; set => _FriendID = value; }
    }
}
