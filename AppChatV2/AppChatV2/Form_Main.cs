using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            Page_Main.SetPage(TabPage_ListFriend);
        }

        #region Xử lí form

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Label_Name.Text = DataProvider.Instance.LoadInfoByID(User.Instance.ID).Name;
            LoadFriendsAndGroups();
            PictureBox_Avatar.Image = DataProvider.Instance.GetSingleImage(User.Instance.ID);
            Button_ListFriend.ForeColor = Color.FromArgb(218, 50, 207);
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Account.Instance.Logout();
        }

        #endregion

        #region Xử lí button 

        private void Button_ListFriend_Click(object sender, EventArgs e)
        {
            Button_ListGroup.ForeColor = Color.DimGray;
            Button_ListFriend.ForeColor = Color.FromArgb(218, 50, 207);
            Notice1.Visible = true;
            Notice2.Visible = false;
            Page_Main.SetPage(TabPage_ListFriend);
            LoadFriendsAndGroups();
            //Invoke(new Action(() => LoadFriends()));
        }

        private void Button_ListGroup_Click(object sender, EventArgs e)
        {
            Button_ListFriend.ForeColor = Color.DimGray;
            Button_ListGroup.ForeColor = Color.FromArgb(218, 50, 207);
            Notice2.Visible = true;
            Notice1.Visible = false;
            Page_Main.SetPage(TabPage_ListGroup);
            LoadFriendsAndGroups();
            //Invoke(new Action(() => LoadGroups()));
        }

        private void Button_EditProfile_Click(object sender, EventArgs e)
        {
            Form_EditProfile frm = new Form_EditProfile(this);
            frm.ShowDialog();
        }

        private void Button_SignOut_Click(object sender, EventArgs e)
        {
            Form_VerifySignout frm = new Form_VerifySignout(this);
            frm.ShowDialog();
        }

        private void Button_AddFriend_Click(object sender, EventArgs e)
        {
            Form_AddFriend frm = new Form_AddFriend(this);
            frm.ShowDialog();
        }

        private void Button_CreateGroup_Click(object sender, EventArgs e)
        {
            Form_CreateGroup frm = new Form_CreateGroup();
            frm.ShowDialog();
        }

        #endregion

        //Load danh sách bạn bè

        private void LoadFriendsAndGroups()
        {
            Index = 1;
            FlowLayoutPanel_ListFriend.Controls.Clear();
            Page_ChatBox.Controls.Clear();
            TabPage tabpg = new TabPage("Init");
            Page_ChatBox.Controls.Add(tabpg);
            tabpg.BackgroundImage = new Bitmap(AppChatV2.Properties.Resources._18ef4fc0d30f69f601411fdf251e82f5);
            Page_ChatBox.SelectTab(0);
            ListFriend = new List<UC_Friend>();
            ListGroup = new List<UC_Group>();
            
            //Hiển thị danh sách bạn
            var Data1 = DataProvider.Instance.LoadListFriendIDAndPort();
            foreach (var v in Data1)
            {
                var data = DataProvider.Instance.LoadInfoByID(v.Key);
                UC_Friend Friend = new UC_Friend(this)
                {
                    Name1 = data.Name,
                    ID = v.Key,
                    Is_active = data.Is_active,
                    Birthday = data.Birthday,
                    Phonenumber = data.Phonenumber,
                    Email = data.Email,
                    Port = v.Value,
                    Index = Index,
                };
                FlowLayoutPanel_ListFriend.Controls.Add(Friend);
                ListFriend.Add(Friend);
                AddSingleBox(Friend);
                Index++;
            }

            FlowLayoutPanel_ListGroup.Controls.Clear();

            //Hiển thị danh sách group
            var Data2 = DataProvider.Instance.LoadListGroupIDAndPort();
            foreach (var v in Data2)
            {
                var data = DataProvider.Instance.LoadGroupInfoByID(v.Key);
                UC_Group Group = new UC_Group(this)
                {
                    Name1 = data.Name,
                    ID = v.Key,
                    Port = v.Value,
                    Index = Index,
                };
                FlowLayoutPanel_ListGroup.Controls.Add(Group);
                ListGroup.Add(Group);
                AddGroupBox(Group);
                Index++;
            }
        }

        public void ChangeColorFriend()
        {
            foreach (var v in ListFriend)
                v.BackColor = Color.White;
        }

        public void ChangeColorGroup()
        {
            foreach (var v in ListGroup)
                v.BackColor = Color.White;
        }

        public void AddSingleBox(UC_Friend par)
        {
            TabPage tabpg = new TabPage(par.Name1+"-"+Index);
            Page_ChatBox.Controls.Add(tabpg);
            UC_SingleChat BoxChat = new UC_SingleChat(par, par.Port)
            {
                Name1 = par.Name1,
                ID = par.ID,
            };
            tabpg.Controls.Add(BoxChat);
            tabpg.BackgroundImage = new Bitmap(AppChatV2.Properties.Resources._18ef4fc0d30f69f601411fdf251e82f5);
            BoxChat.Location = new Point(-2, 0);
        }

        public void AddGroupBox(UC_Group par)
        {
            TabPage tabpg = new TabPage(par.Name1+"-"+Index);
            Page_ChatBox.Controls.Add(tabpg);
            UC_GroupChat BoxChat = new UC_GroupChat(par, par.Port)
            {
                Name1 = par.Name1,
                ID = par.ID,
            };
            tabpg.Controls.Add(BoxChat);
            tabpg.BackgroundImage = new Bitmap(AppChatV2.Properties.Resources._18ef4fc0d30f69f601411fdf251e82f5);
            BoxChat.Location = new Point(-2, 0);
        }

        public void SwitchTab(int i)
        {
            Page_ChatBox.SelectTab(i);
        }

        public void Reload()
        {
            Form_Main_Load(null, EventArgs.Empty);
        }

        //Các thuộc tính
        private List<int> _BoxChat;
        private List<int> _ListConnect;
        private int _Index;
        private List<UC_Friend> _ListFriend;
        private List<UC_Group> _ListGroup;

        public List<int> BoxChat { get => _BoxChat; set => _BoxChat = value; }
        public List<int> ListConnect { get => _ListConnect; set => _ListConnect = value; }
        public int Index { get => _Index; set => _Index = value; }
        public List<UC_Friend> ListFriend { get => _ListFriend; set => _ListFriend = value; }
        public List<UC_Group> ListGroup { get => _ListGroup; set => _ListGroup = value; }
    }
}
