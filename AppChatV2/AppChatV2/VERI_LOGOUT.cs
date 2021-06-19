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
    public partial class frmVerilogout : Form
    {
        Form_Main par;
        public frmVerilogout(Form_Main par)
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
            Account.Instance.Logout();
            this.Hide();
            par.Hide();
            Form_Login frm = new Form_Login();
            frm.Show();
        
        }

        private void frmVerilogout_Load(object sender, EventArgs e)
        {

        }
    }
}
