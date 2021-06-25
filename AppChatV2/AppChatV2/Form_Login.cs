using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Textbox_Username_Enter(object sender, EventArgs e)
        {
            if (TextBox_Username.Text == "Username")
            {
                TextBox_Username.Text = "";
                TextBox_Username.ForeColor = Color.Black;
            }
        }

        private void Textbox_Username_Leave(object sender, EventArgs e)
        {
            if (TextBox_Username.Text.Trim() == "")
            {
                TextBox_Username.Text = "Username";
                TextBox_Username.ForeColor = Color.DarkGray;
            }
        }

        private void Textbox_Password_Leave(object sender, EventArgs e)
        {
            if (TextBox_Password.Text.Trim() == "")
            {
                TextBox_Password.Text = "Password";
                TextBox_Password.ForeColor = Color.DarkGray;
            }
        }

        private void Textbox_Password_Enter(object sender, EventArgs e)
        {
            if (TextBox_Password.Text == "Password")
            {
                TextBox_Password.Text = "";
                TextBox_Password.ForeColor = Color.Black;
            }
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
