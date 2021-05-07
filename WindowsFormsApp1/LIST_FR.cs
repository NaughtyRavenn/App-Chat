using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FORM_LIST_FR : Form
    {
        public FORM_LIST_FR()
        {
            InitializeComponent();
        }

        private void Tìm_Click(object sender, EventArgs e)
        {

        }

        private void btnAddfriend_Click(object sender, EventArgs e)
        {
            frmAddfriend frm = new frmAddfriend();
            frm.Show();
        }

        private void btnCreategroup_Click(object sender, EventArgs e)
        {
            frmAddtogroup frm = new frmAddtogroup();
            frm.Show();
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

        private void btnEditprofile_Click(object sender, EventArgs e)
        {
            frmEditprofile frm = new frmEditprofile();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmVerilogout frm = new frmVerilogout();
            frm.ShowDialog();
        }
    }
}
