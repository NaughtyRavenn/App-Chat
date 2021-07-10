using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_AddMember : Form
    {
        public Form_GroupInfomation Par;
        public Form_AddMember(Form_GroupInfomation PAR)
        {
            InitializeComponent();
            this.Par = PAR;
            ID = Par.ID;
        }

        private void Form_AddFriendToGroup_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadFriends();
        }

        private void LoadFriends()
        {
            FlowLayoutPanel_ListFriend.Controls.Clear();
            var Data = DataProvider.Instance.LoadListFriendsToAdd(ID);
            foreach (var v in Data)
            {
                var data = DataProvider.Instance.LoadInfoByID(v);
                UC_AddMember Friend = new UC_AddMember(this)
                {
                    Name1 = data.Name,
                    FriendID = data.Id,
                    GroupID = ID,
                };
                FlowLayoutPanel_ListFriend.Controls.Add(Friend);
            }
        }

        private void LoadMembers()
        {
            FlowLayoutPanel_ListMember.Controls.Clear();
            List<string> v1 = new List<string>();
            string sqlQuery = "SELECT ACCOUNT_ID AS ID FROM GROUPINFO WHERE GROUP_ID = @groupid ";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { ID });
            foreach(DataRow v2 in Data.Rows)
            {
                v1.Add(v2["ID"].ToString());
            }
            foreach(var v in v1)
            {
                var data = DataProvider.Instance.LoadInfoByID(v);
                UC_AddMember Friend = new UC_AddMember(this)
                {
                    Name1 = data.Name,
                    FriendID=data.Id,
                };
                Friend.VisibleButton();
                FlowLayoutPanel_ListMember.Controls.Add(Friend);
            }
        }


        private string _ID;

        public string ID { get => _ID; set => _ID = value; }
    }
}
