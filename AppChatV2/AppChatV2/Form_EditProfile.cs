using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_EditProfile : Form
    {
        public Form_EditProfile()
        {
            InitializeComponent();
            Flag1 = 1;
            Flag2 = 1;
        }

        private void Form_EditProfile_Load(object sender, EventArgs e)
        {
            Button_PersonalInfo.ForeColor = Color.FromArgb(218, 50, 207);
        }

        private void Button_PersonalInfo_Click(object sender, EventArgs e)
        {
            Notice1.Visible = true;
            Button_PersonalInfo.ForeColor = Color.FromArgb(218, 50, 207);
            Notice2.Visible = false;
            Button_LoginInfo.ForeColor = Color.DimGray;
            Page_EditProfile.SetPage(TabPage_PersonalInfo);
        }

        private void Button_LoginInfo_Click(object sender, EventArgs e)
        {
            Notice2.Visible = true;
            Button_LoginInfo.ForeColor = Color.FromArgb(218, 50, 207);
            Notice1.Visible = false;
            Button_PersonalInfo.ForeColor = Color.DimGray;
            Page_EditProfile.SetPage(TabPage_LoginInfo);
        }

        Person p = DataProvider.Instance.LoadInfoByID(Account.Instance.id);

        private void CheckName()
        {
            p.Name = TextBox_Name.Text;
        }

        private void CheckBirthday()
        {
            string birthday;
            DateTime date;
            if (!(int.Parse(ComboBox_Year.Text) > 1900 && int.Parse(ComboBox_Year.Text) < DateTime.Now.Year))
            {
                Label_Birthday.Text = "Invalid date of birth";
                Flag1 = 0;
            }
            else
            {
                birthday = ComboBox_Month.Text + "/" + ComboBox_Day.Text + "/" + ComboBox_Year.Text;
                if (!DateTime.TryParse(birthday, out date))
                {
                    Label_Birthday.Text = "Invalid date of birth"; 
                    Flag1 = 0;
                }
                else
                {
                    p.Birthday = DateTime.Parse(birthday);
                    Label_Birthday.Text = string.Empty;
                }
            }
        }

        private void CheckPhonenumber()
        {
            string phonenumber = TextBox_Phonenumber.Text;
            if (phonenumber[0] == '0' && phonenumber[1] == '9' && (phonenumber.Length == 11 || phonenumber.Length == 10)
                && IsDigit(phonenumber))
            {
                p.Phonenumber = phonenumber;
                Label_Phonenumber.Text = string.Empty;
            }
            else
            {
                Label_Phonenumber.Text = "Invalid phone number";
                Flag1 = 0;
            }
        }

        private void CheckEmail()
        {
            string email = TextBox_Email.Text;
            try
            {
                MailAddress mail = new MailAddress(email);
                Label_Email.Text = string.Empty;
                p.Email = email;
            }
            catch
            {
                Label_Email.Text = ("Invalid email");
                Flag1 = 0;
            }
        }

        private void CheckSex()
        {
            if (RadioButton_Male.Checked == true)
                p.Sex = "Male";
            else
                p.Sex = "Female";
        }

        private bool IsDigit(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void CheckInfo1()
        {
            if (!string.IsNullOrEmpty(TextBox_Name.Text))
                CheckName();
            if (ComboBox_Month.Text != string.Empty && ComboBox_Day.Text != string.Empty && ComboBox_Year.Text != string.Empty)
                CheckBirthday();
            if (!string.IsNullOrEmpty(TextBox_Phonenumber.Text))
                CheckPhonenumber();
            if (!string.IsNullOrEmpty(TextBox_Email.Text))
                CheckEmail();
            if (RadioButton_Male.Checked == true || RadioButton_Female.Checked == true)
                CheckSex();
        }

        private void DoEdit1()
        {
            CheckInfo1();
            if (Flag1 == 1)
            {
                string sqlQuery = "UPDATE ACCOUNT SET Name = @Name , Birthday = @Birthday ," +
                    " Email = @Email , Phonenumber = @Phonenumber , Sex = @Sex WHERE ID = @id ";
                DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { p.Name, p.Birthday, p.Email, p.Phonenumber, p.Sex, p.Id });
                MessageBox.Show("Successfully updated");
            }
            else
            {
                Flag1 = 1;
                return;
            }
        }

        private void CheckCurrentPassword()
        {
            string currentpassword = TextBox_CurrentPassword.Text;
            string sqlQuery = "SELECT * FROM ACCOUNT WHERE Username = @Username AND Password = @Password ";
            if (DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { p.Username, currentpassword }).Rows.Count == 0)
            {
                Label_CurrentPassword.Text = "Current password is wrong";
                Flag2 = 0;
            }
            else
                Label_CurrentPassword.Text = string.Empty;
        }

        private void CheckNewPassword()
        {
            string password = TextBox_NewPassword.Text;
            //min 6 chars, max 12 chars
            if (password.Length < 6 || password.Length > 12)
            {
                Label_NewPassword.Text = "Min 6 character, max 12 character";
                Flag2 = 0;
            }

            //No white space
            else if (password.Contains(" "))
            {
                Label_NewPassword.Text = "No white space";
                Flag2 = 0;
            }

            //At least 1 upper case letter
            else if (!password.Any(char.IsUpper))
            {
                Label_NewPassword.Text = "At least 1 upper case letter";
                Flag2 = 0;
            }

            //At least 1 lower case letter
            else if (!password.Any(char.IsLower))
            {
                Label_NewPassword.Text = "At least 1 lower case letter";
                Flag2 = 0;
            }
            else
            {
                p.Password = password;
                Label_NewPassword.Text = string.Empty;
            }
        }

        private void ConfirmPassword()
        {
            string confirmpass = TextBox_ConfirmPassword.Text;
            if (confirmpass != TextBox_NewPassword.Text)
            {
                Label_ConfirmPassword.Text = "Confirm password incorect";
                Flag2 = 0;
            }
            else
                Label_ConfirmPassword.Text = string.Empty;
        }

        private bool CheckInfo2()
        {
            if (!(!string.IsNullOrEmpty(TextBox_CurrentPassword.Text) && !string.IsNullOrEmpty(TextBox_NewPassword.Text) &&
                !string.IsNullOrEmpty(TextBox_ConfirmPassword.Text)))
            {
                MessageBox.Show("Please enter all required information");
                return false;
            }
            CheckCurrentPassword();
            CheckNewPassword();
            ConfirmPassword();
            Invalidate();
            if (Flag2 == 1)
                return true;
            else
                return false;
        }

        private void DoEdit2()
        {
            if (CheckInfo2())
            {
                string sqlQuery = "UPDATE ACCOUNT SET Password = @Password WHERE Username = @Username ";
                DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { p.Password, p.Username });
                TextBox_ConfirmPassword.Text = TextBox_CurrentPassword.Text = TextBox_NewPassword.Text = string.Empty;
                MessageBox.Show("Successfully updated");
            }
            else
                Flag2 = 1;
        }

        private void Button_Confirm2_Click(object sender, EventArgs e)
        {
            DoEdit2();
        }

        private void Button_Confirm1_Click(object sender, EventArgs e)
        {
            DoEdit1();
            ComboBox_Month.Text = ComboBox_Day.Text = ComboBox_Year.Text = null;
            TextBox_Name.Text = TextBox_Email.Text = TextBox_Phonenumber.Text = string.Empty;
            RadioButton_Female.Checked = RadioButton_Male.Checked = false;
        }


        private int _Flag1;
        private int _Flag2;

        public int Flag1 { get => _Flag1; set => _Flag1 = value; }
        public int Flag2 { get => _Flag2; set => _Flag2 = value; }
    }
}
