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

namespace WindowsFormsApp1
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }
        
        string cs = @"Data Source=LAPTOP-L3JT52S4\SQLEXPRESS;Initial Catalog=test;Integrated Security=TrueData Source=LAPTOP-L3JT52S4\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";

        private void frmSignup_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateaccount_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (txtConfirmpassword.Text != string.Empty || txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_User where username=@username", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                SqlDataReader sdr = cmd.ExecuteReader();
                //check tên tài khoản
                if (sdr.Read())
                {
                    sdr.Close();
                    MessageBox.Show("Tên tài khoản đã được sử dụng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //check mật khẩu
                if (txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("Mật khẩu cần tối đa 8 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //check nhập lại mật khẩu
                if (txtPassword.Text != txtConfirmpassword.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu sai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //check ngày sinh
                string date = cboMonth.Text + "/" + cboDay.Text + "/" + cboYear.Text;
                if (!DateTime.TryParse(date, out DateTime temp))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //check số điện thoại
                if (!int.TryParse(txtPhonenumber.Text, out int nunmber) || txtPhonenumber.Text.Length < 10)
                {
                    MessageBox.Show("Nhập lại số điện thoại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //check giới tính
                if (rdoMale.Checked == false && rdoFemale.Checked == false)
                {
                    MessageBox.Show("Kiểm tra lại giới tính", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sdr.Close();
                cmd = new SqlCommand("insert into tbl_User values(@username,@password,@name,@email,@birthday,@phone,@sex,@is_admin)", con);
                cmd.Parameters.AddWithValue("username", txtUsername.Text);
                cmd.Parameters.AddWithValue("password", txtPassword.Text);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("birthday", date);
                cmd.Parameters.AddWithValue("phone", txtPhonenumber.Text);
                cmd.Parameters.AddWithValue("sex", rdoMale.Checked);
                cmd.Parameters.AddWithValue("is_admin", 0);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo tài khoản thành công", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
