using System;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            if (string.IsNullOrEmpty(TextBox_Username.Text) || string.IsNullOrEmpty(TextBox_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (Account.Instance.Login(TextBox_Username.Text, TextBox_Password.Text))
            {
                User.Instance.LoadInfo();
                this.Hide();
                Form_Main frm = new Form_Main();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoLogin();
        }

        private void Button_Signup_Click(object sender, EventArgs e)
        {
            Form_SignUp frm = new Form_SignUp();
            frm.ShowDialog();
        }
    }
}
