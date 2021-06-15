using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppChatV2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            doLogin();
        }
        
        private void doLogin()
        {
            if(Account.Instance.Login(txtUsername.Text,txtPassword.Text))
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmSignup frm = new frmSignup();
            frm.ShowDialog();
        }
    }
}
