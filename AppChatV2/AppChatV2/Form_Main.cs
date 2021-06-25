using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Label_Name.Text = User.Instance.Name;
        }

        private void Button_Recent_Click(object sender, EventArgs e)
        {
            Notice1.Visible = true;
            Button_Recent.ForeColor = Color.FromArgb(218, 50, 207);
            Notice2.Visible = false;
            Button_ListFriend.ForeColor = Color.DimGray;
            Page_Main.SetPage(TabPage_Recent);
        }

        private void Button_ListFriend_Click(object sender, EventArgs e)
        {
            Notice2.Visible = true;
            Button_ListFriend.ForeColor = Color.FromArgb(218, 50, 207);
            Notice1.Visible = false;
            Button_Recent.ForeColor = Color.DimGray;
            Page_Main.SetPage(TabPage_ListFriend);
            LoadFriends();
        }

        private void LoadFriends()
        {
            FlowLayoutPanel_ListFriend.Controls.Clear();
            var listFriends = DataProvider.Instance.LoadListFriendID();
            foreach (var v in listFriends)
            {
                FlowLayoutPanel_ListFriend.Controls.Add(new UC_Friend()
                {
                    Name1 = DataProvider.Instance.LoadInfoByID(v).Name,
                    ID = v,
                    Is_active = DataProvider.Instance.LoadInfoByID(v).Is_active,
                    Birthday=DataProvider.Instance.LoadInfoByID(v).Birthday,
                    Phonenumber = DataProvider.Instance.LoadInfoByID(v).Phonenumber,
                    Email = DataProvider.Instance.LoadInfoByID(v).Email
                });
            }
        }

        private void Button_EditProfile_Click(object sender, EventArgs e)
        {
            Form_EditProfile frm = new Form_EditProfile();
            frm.ShowDialog();
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
