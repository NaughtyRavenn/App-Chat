using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            LoadFriends();
            /*ListConnect = DataProvider.Instance.LoadMyContactFromDB();
            foreach (UC_Friend v in FlowLayoutPanel_ListFriend)
            {
                int i = v;
                ThreadConnect(i);
            }*/
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Label_Name.Text = User.Instance.Name;
            Button_ListFriend.ForeColor = Color.FromArgb(218, 50, 207);
            /*Connect();*/
        }

        //Xử lí các button
        private void Button_ListFriend_Click(object sender, EventArgs e)
        {
            Notice1.Visible = true;
            Button_ListFriend.ForeColor = Color.FromArgb(218, 50, 207);
            Notice2.Visible = false;
            Button_ListGroup.ForeColor = Color.DimGray;
            Page_Main.SetPage(TabPage_ListFriend);
/*            LoadFriends();*/
        }

        private void Button_ListGroup_Click(object sender, EventArgs e)
        {
            Notice2.Visible = true;
            Button_ListGroup.ForeColor = Color.FromArgb(218, 50, 207);
            Notice1.Visible = false;
            Button_ListFriend.ForeColor = Color.DimGray;
            Page_Main.SetPage(TabPage_ListGroup);
        }

        private void Button_EditProfile_Click(object sender, EventArgs e)
        {
            Form_EditProfile frm = new Form_EditProfile();
            frm.ShowDialog();
        }

        private void Button_SignOut_Click(object sender, EventArgs e)
        {
            Form_VerifySignout frm = new Form_VerifySignout(this);
            frm.ShowDialog();
        }

        private void Button_AddFriend_Click(object sender, EventArgs e)
        {
            Form_AddFriend frm = new Form_AddFriend();
            frm.ShowDialog();
        }
       
        //Load danh sách bạn bè
        private void LoadFriends()
        {
            FlowLayoutPanel_ListFriend.Controls.Clear();
            var Data = DataProvider.Instance.LoadListFriendIDAndPort();
            int i = 1;
            foreach (var v in Data)
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
                    Index = i,
                };
                FlowLayoutPanel_ListFriend.Controls.Add(Friend);
                AddTabBox(Friend);
                i++;
            }
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        public void AddTabBox(UC_Friend par)
        {
            TabPage tabpg = new TabPage(par.ID);
            Page_ChatBox.Controls.Add(tabpg);
            UC_SingleChat BoxChat = new UC_SingleChat(par,par.Port);
            tabpg.Controls.Add(BoxChat);
            tabpg.BackgroundImage = new Bitmap(AppChatV2.Properties.Resources._18ef4fc0d30f69f601411fdf251e82f5);
            BoxChat.Location = new Point(0, 50);
        }

        public void SwitchTab(int i)
        {
            Page_ChatBox.SelectTab(i);

        }



        private List<int> _BoxChat;
        private List<int> _ListConnect;

        public List<int> BoxChat { get => _BoxChat; set => _BoxChat = value; }
        public List<int> ListConnect { get => _ListConnect; set => _ListConnect = value; }
    }
}
