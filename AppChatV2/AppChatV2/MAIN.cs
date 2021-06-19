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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditprofile_Click(object sender, EventArgs e)
        {
            Form_EditProfile frm = new Form_EditProfile();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmVerilogout frm = new frmVerilogout(this);
            frm.ShowDialog();
        }

        private void btnAddfriend_Click(object sender, EventArgs e)
        {
            frmAddfriend frm = new frmAddfriend();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblName.Text = User.Instance.Name;
            LoadFriends();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnInteractsingle_Click(object sender, EventArgs e)
        {
            frmInteractsingle frm = new frmInteractsingle();
            frm.ShowDialog();
        }

        private void btnInteractgroup_Click(object sender, EventArgs e)
        {
            frmInteractgroup frm = new frmInteractgroup();
            frm.ShowDialog();
        }

        private void LoadFriends()
        {
            flowLayoutPanel1.Controls.Clear();
            var listFriends = DataProvider.Instance.LoadListFriendID();
            foreach(var v in listFriends)
            {
                flowLayoutPanel1.Controls.Add(new UC_Friend()
                {
                    Name1 = DataProvider.Instance.LoadInfoByID(v).Name
                });
            }
        }
    }
}
