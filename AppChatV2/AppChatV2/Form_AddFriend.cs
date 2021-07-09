using System;
using System.Drawing;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_AddFriend : Form
    {
        Form_Main Par;
        public Form_AddFriend(Form_Main PAR)
        {
            InitializeComponent();
            this.Par = PAR;
            Count = 0;
        }

        private void Form_AddFriend_Load(object sender, EventArgs e)
        {
            Button_Stranger.ForeColor = Color.FromArgb(218, 50, 207);
            LoadStranger();
            LoadFriendRequest();
            NoticeRequest();
        }

        private void Button_ListStranger_Click(object sender, EventArgs e)
        {
            Notice1.Visible = true;
            Button_Stranger.ForeColor = Color.FromArgb(218, 50, 207);
            Notice2.Visible = false;
            Button_Request.ForeColor = Color.DimGray;
            Page_AddFriend.SetPage(TabPage_Recent);
        }


        private void Button_Request_Click(object sender, EventArgs e)
        {
            Notice2.Visible = true;
            Button_Request.ForeColor = Color.FromArgb(218, 50, 207);
            Notice1.Visible = false;
            Button_Stranger.ForeColor = Color.DimGray;
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

        private void NoticeRequest()
        {
            Invoke(new Action(() =>
            {
                if (Count != 0)
                {
                    Notice_Request.Visible = true;
                }
                else
                    Notice_Request.Visible = false;
            }));
        }

        private int _count;

        public int Count { get => _count; set => _count = value; }
    }
}
