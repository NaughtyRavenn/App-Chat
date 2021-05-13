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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void btnAddfriend_Click(object sender, EventArgs e)
        {
            frmAddfriend frm = new frmAddfriend();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton11_Click(object sender, EventArgs e)
        {
            frmInteractsingle frm = new frmInteractsingle();
            frm.ShowDialog();
        }

        private void xuiButton10_Click(object sender, EventArgs e)
        {
            frmInteractsingle frm = new frmInteractsingle();
            frm.ShowDialog();
        }

        private void xuiButton9_Click(object sender, EventArgs e)
        {
            frmInteractsingle frm = new frmInteractsingle();
            frm.ShowDialog();
        }

        private void xuiButton4_Click(object sender, EventArgs e)
        {
            frmInteractsingle frm = new frmInteractsingle();
            frm.ShowDialog();
        }
    }
}
