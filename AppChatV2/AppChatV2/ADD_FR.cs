using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChatV2
{
    public partial class frmAddfriend : Form
    {
        public frmAddfriend()
        {
            InitializeComponent();
        }

        private void FORM_ADD_FR_Load(object sender, EventArgs e)
        {
            LoadStranger();
            LoadFriendRequest();
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
            }
        }
    }
}
