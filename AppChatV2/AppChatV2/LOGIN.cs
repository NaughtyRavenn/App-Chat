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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            doLogin();
        }
        
        private void doLogin()
        {
            if(string.IsNullOrEmpty(Textbox_Username.Text)||string.IsNullOrEmpty(Textbox_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            
            if(Account.Instance.Login(Textbox_Username.Text,Textbox_Password.Text))
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

        private void Linklabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_SignUp frm = new Form_SignUp();
            frm.ShowDialog();
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void Textbox_Username_Enter(object sender, EventArgs e)
        {
            if (Textbox_Username.Text=="Username")
            {
                Textbox_Username.Text = "";
                Textbox_Username.ForeColor = Color.Black;
            }
        }

        private void Textbox_Username_Leave(object sender, EventArgs e)
        {
            if(Textbox_Username.Text.Trim()=="")
            {
                Textbox_Username.Text = "Username";
                Textbox_Username.ForeColor = Color.DarkGray;
            }
        }

        private void Textbox_Password_Leave(object sender, EventArgs e)
        {
            if (Textbox_Password.Text.Trim() == "")
            {
                Textbox_Password.Text = "Password";
                Textbox_Password.ForeColor = Color.DarkGray;
            }
        }

        private void Textbox_Password_Enter(object sender, EventArgs e)
        {
            if (Textbox_Password.Text == "Password")
            {
                Textbox_Password.Text = "";
                Textbox_Password.ForeColor = Color.Black;
            }
        }

        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                doLogin();
        }
    }
}
