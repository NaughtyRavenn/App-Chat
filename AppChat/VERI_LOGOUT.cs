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
    public partial class frmVerilogout : Form
    {
        frmMain par;
        public frmVerilogout(frmMain par)
        {
            InitializeComponent();
            this.par = par;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            par.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();

        }

        private void frmVerilogout_Load(object sender, EventArgs e)
        {

        }
    }
}
