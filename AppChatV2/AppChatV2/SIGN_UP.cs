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
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            doSignup();
            MessageBox.Show("Account successfully created");
            this.Hide();
        }

        private void CheckUsername()
        {
            string username = TextBox_Username.Text;
            string sqlQuery = "SELECT Username FROM ACCOUNT WHERE Username = @username ";
            DataTable Data = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { username });
            if (Data.Rows.Count == 1)
            {
                LabelBox_Username.Text = "Username has already been used";
            }
            else
            {
                Username = username;
                LabelBox_Username.Text = string.Empty;
            }
        }

        private void CheckPassword()
        {
            string password = TextBox_Password.Text;
            //min 6 chars, max 12 chars
            if (password.Length < 6 || password.Length > 12)
            {
                LabelBox_Password.Text = "Min 6 character, max 12 character";
            }
           
            //No white space
            else if (password.Contains(" "))
            {
                LabelBox_Password.Text = "No white space";
            }

            //At least 1 upper case letter
            else if (!password.Any(char.IsUpper))
            {
                LabelBox_Password.Text = "At least 1 upper case letter";
            }

            //At least 1 lower case letter
            else if (!password.Any(char.IsLower))
            {
                LabelBox_Password.Text = "At least 1 lower case letter";
            }
            else
            {
                Password = password;
                LabelBox_Password.Text = string.Empty;
            }
        }

        private void ConfirmPassword()
        {
            string confirmpass = TextBox_ConfirmPassword.Text;
            if (confirmpass != TextBox_Password.Text)
            {
                LabelBox_ConfirmPassword.Text = "Confirm password incorect";
            }
            else
                LabelBox_ConfirmPassword.Text = string.Empty;
        }

        private void CheckName()
        {
            Name1 = TextBox_Name.Text;
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
                Birthday = DateTime.Parse(birthday);
                LabelBox_Birthday.Text = string.Empty;
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
                    Email = email;
                    LabelBox_Email.Text = string.Empty;
                }
            }
            catch
            {
                LabelBox_Email.Text = ("Invalid email");
            }
        }

        private void CheckPhonenumber()
        {
            string phonenumber = TextBox_Phonenumber.Text;
            if (phonenumber[0] == '0' && phonenumber[1] == '9' && (phonenumber.Length == 11 || phonenumber.Length == 10) 
                && IsDigit(phonenumber))
            {
                Phonenumber = phonenumber;
                LabelBox_Phonenumber.Text = string.Empty;
            }
            else
            {
                LabelBox_Phonenumber.Text = "Invalid phone number";
            }
        }

        private void CheckSex()
        {
            if (RadioButton_Male.Checked == true)
                Sex = "Male";
            else
                Sex = "Female";
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

        private void CheckAll()
        {
            if(string.IsNullOrEmpty(TextBox_Username.Text)|| string.IsNullOrEmpty(TextBox_Password.Text)||
                string.IsNullOrEmpty(TextBox_ConfirmPassword.Text)|| string.IsNullOrEmpty(TextBox_Name.Text)||
                string.IsNullOrEmpty(ComboBox_Day.Text) ||string.IsNullOrEmpty(ComboBox_Month.Text) ||string.IsNullOrEmpty(ComboBox_Year.Text)||
                string.IsNullOrEmpty(TextBox_Phonenumber.Text)|| string.IsNullOrEmpty(TextBox_Email.Text)||
                RadioButton_Male.Checked == false && RadioButton_Female.Checked == false)
            {
                MessageBox.Show("Please enter all required information");
                return;
            }
            CheckUsername();
            CheckPassword();
            ConfirmPassword();
            CheckName();
            CheckBirthday();
            CheckPhonenumber();
            CheckEmail();
            CheckSex();
        }
        private void doSignup()
        {
            CheckAll();
            string sqlQuery = "INSERT INTO ACCOUNT (Username,Password,Name,Is_active,Is_admin,Birthday,Email,Phonenumber,Sex) " +
                "VALUES ( @username , @password , @name , @is_active , @is_admin , @birthday , @email , @phonenumber , @sex )";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Username,Password,Name1,"false","false",Birthday,Email
            ,Phonenumber,Sex});
        }

        private string _Username;
        private string _Password;
        private string _ConfirmPassword;
        private string _Name;
        private DateTime _Birthday;
        private string _Phonenumber;
        private string _Email;
        private string _Sex;
        public string Username { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string ConfirmPassword1 { get => _ConfirmPassword; set => _ConfirmPassword = value; }
        public string Name1 { get => _Name; set => _Name = value; }
        public DateTime Birthday { get => _Birthday; set => _Birthday = value; }
        public string Phonenumber { get => _Phonenumber; set => _Phonenumber = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
    }
}
