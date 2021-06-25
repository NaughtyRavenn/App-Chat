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
    public partial class Form_AddFriend : Form
    {
        public Form_AddFriend()
        {
            InitializeComponent();
            Count = 0;
        }

        private void Form_AddFriend_Load(object sender, EventArgs e)
        {
            LoadStranger();
            LoadFriendRequest();
        }

        private void Button_Recent_Click(object sender, EventArgs e)
        {
            Notice1.Visible = true;
            Button_Recent.ForeColor = Color.FromArgb(218, 50, 207);
            Notice2.Visible = false;
            Button_ListFriend.ForeColor = Color.DimGray;
            Page_AddFriend.SetPage(TabPage_Recent);
        }

        private void Button_ListFriend_Click(object sender, EventArgs e)
        {
            Notice2.Visible = true;
            Button_ListFriend.ForeColor = Color.FromArgb(218, 50, 207);
            Notice1.Visible = false;
            Button_Recent.ForeColor = Color.DimGray;
            Page_AddFriend.SetPage(TabPage_ListFriend);
        }

        private void LoadStranger()
        {
            FlowLayoutPanel_Stranger.Controls.Clear();
            var ListStranger = DataProvider.Instance.LoadListStrangerID();
            foreach (var v in ListStranger)
            {
                FlowLayoutPanel_Stranger.Controls.Add(new UC_Stranger()
                {
                    Name1 = DataProvider.Instance.LoadInfoByID(v).Name,
                    ID = v
                });
            }
        }

        private void LoadFriendRequest()
        {
            FlowLayoutPanel_ListRequest.Controls.Clear();
            var ListFriendRequest = DataProvider.Instance.LoadListFriendRequest();
            foreach (var v in ListFriendRequest)
            {
                FlowLayoutPanel_ListRequest.Controls.Add(new UC_FriendRequest()
                {
                    Name1 = DataProvider.Instance.LoadInfoByID(v).Name,
                    ID = v
                });
                Count++;
            }
            Label_Count.Text = Count.ToString();
        }

        private int _count;

        public int Count { get => _count; set => _count = value; }
    }
}
