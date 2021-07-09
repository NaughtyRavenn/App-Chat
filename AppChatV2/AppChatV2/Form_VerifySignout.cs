using System;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_VerifySignout : Form
    {
        Form_Main par;
        public Form_VerifySignout(Form_Main par)
        {
            InitializeComponent();
            this.par = par;
        }

        private void frmVerilogout_Load(object sender, EventArgs e)
        {
            Account.Instance.Logout();
        }

        private void Button_Yes_Click(object sender, EventArgs e)
        {
            this.Hide();
            par.Hide();
            Account.Instance.Logout();
            Form_Login frm = new Form_Login();
            frm.Show();
        }

        private void Button_No_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
