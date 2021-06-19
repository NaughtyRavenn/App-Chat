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
    public partial class Form_EditProfile : Form
    {
        public Form_EditProfile()
        {
            InitializeComponent();
            Flag = 1;
        }

        Person p = DataProvider.Instance.LoadInfoByID(Account.Instance.id);

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            doEdit1();
            TextBox_Name.Text = TextBox_Email.Text = TextBox_Phonenumber.Text = string.Empty;
            ComboBox_Day.Text = "Ngày";
            ComboBox_Month.Text = "Tháng";
            ComboBox_Year.Text = "Năm";
            MessageBox.Show("Successfully updated");
        }

        private void Form_EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void CheckName()
        {
            p.Name = TextBox_Name.Text;
        }

        private void CheckBirthday()
        {
            string birthday;
            DateTime date;
            birthday = ComboBox_Month.Text + "/" + ComboBox_Day.Text + "/" + ComboBox_Year.Text;
            if (!DateTime.TryParse(birthday, out date))
            {
                LabelBox_Birthday.Text = "Invalid date of birth";
            }
            else
            {
                p.Birthday = DateTime.Parse(birthday);
                LabelBox_Birthday.Text = string.Empty;
            }
        }

        private void CheckPhonenumber()
        {
            string phonenumber = TextBox_Phonenumber.Text;
            if (phonenumber[0] == '0' && phonenumber[1] == '9' && (phonenumber.Length == 11 || phonenumber.Length == 10)
                && IsDigit(phonenumber))
            {
                p.Phonenumber = phonenumber;
                LabelBox_Phonenumber.Text = string.Empty;
            }
            else
            {
                LabelBox_Phonenumber.Text = "Invalid phone number";
            }
        }

        private void CheckEmail()
        {
            string email = TextBox_Email.Text;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    LabelBox_Email.Text = ("Invalid email");
                }
                else
                {
                    p.Email = email;
                    LabelBox_Email.Text = string.Empty;
                }
            }
            catch
            {
                LabelBox_Email.Text = ("Invalid email");
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
            if (ComboBox_Day.Text != "Ngày" && ComboBox_Month.Text != "Tháng" && ComboBox_Year.Text != "Năm")
                CheckBirthday();
            if (!string.IsNullOrEmpty(TextBox_Phonenumber.Text))
                CheckPhonenumber();
            if (!string.IsNullOrEmpty(TextBox_Email.Text))
                CheckEmail();
            if (RadioButton_Male.Checked == true || RadioButton_Female.Checked == true)
                CheckSex();
        }

        private void doEdit1()
        {
            CheckInfo1();
            string sqlQuery = "UPDATE ACCOUNT SET Name = @Name , Birthday = @Birthday ," +
                " Email = @Email , Phonenumber = @Phonenumber , Sex = @Sex WHERE ID = @id ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { p.Name, p.Birthday, p.Email, p.Phonenumber, p.Sex, p.Id });
            
        }

        private void CheckCurrentPassword()
        {
            string currentpassword = TextBox_CurrentPassword.Text;
            string sqlQuery = "SELECT * FROM ACCOUNT WHERE Username = @Username AND Password = @Password ";
            if (DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { p.Username, currentpassword }).Rows.Count == 0)
            {
                LabelBox_CurrentPassword.Text = "Current password is wrong";
                Flag = 0;
            }
            else
                LabelBox_CurrentPassword.Text = string.Empty;
        }

        private void CheckNewPassword()
        {
            string password = TextBox_NewPassword.Text;
            //min 6 chars, max 12 chars
            if (password.Length < 6 || password.Length > 12)
            {
                LabelBox_NewPassword.Text = "Min 6 character, max 12 character";
                Flag = 0;
            }

            //No white space
            else if (password.Contains(" "))
            {
                LabelBox_NewPassword.Text = "No white space";
                Flag = 0;
            }

            //At least 1 upper case letter
            else if (!password.Any(char.IsUpper))
            {
                LabelBox_NewPassword.Text = "At least 1 upper case letter";
                Flag = 0;
            }

            //At least 1 lower case letter
            else if (!password.Any(char.IsLower))
            {
                LabelBox_NewPassword.Text = "At least 1 lower case letter";
                Flag = 0;
            }
            else
            {
                p.Password = password;
                LabelBox_NewPassword.Text = string.Empty;
            }
        }

        private void ConfirmPassword()
        {
            string confirmpass = TextBox_ConfirmPassword.Text;
            if (confirmpass != TextBox_NewPassword.Text)
            {
                LabelBox_ConfirmPassword.Text = "Confirm password incorect";
                Flag = 0;
            }
            else
                LabelBox_ConfirmPassword.Text = string.Empty;
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
            if (Flag == 1)
                return true;
            else
                return false;
        }

        private void doEdit2()
        {
            if (CheckInfo2())
            {
                string sqlQuery = "UPDATE ACCOUNT SET Password = @Password WHERE Username = @Username ";
                DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { p.Password,p.Username });
                TextBox_ConfirmPassword.Text = TextBox_CurrentPassword.Text = TextBox_NewPassword.Text = string.Empty;
                MessageBox.Show("Successfully updated");
            }
            else
                Flag = 1;
        }

        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            doEdit2();
        }

        private int _Flag;

        public int Flag { get => _Flag; set => _Flag = value; }
    }
}
