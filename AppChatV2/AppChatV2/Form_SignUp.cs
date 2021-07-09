using System;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
            Flag = 1;
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            DoSignup();
        }

        private void CheckUsername()
        {
            string username = TextBox_Username.Text;
            string sqlQuery = "SELECT Username FROM ACCOUNT WHERE Username = @username ";
            DataTable Data = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { username });
            if (Data.Rows.Count != 0)
            {
                Label_Username.Text = "Username has already been used";
                Flag = 0;
            }
            else
            {
                Username = username;
                Label_Username.Text = string.Empty;
            }
        }

        private void CheckPassword()
        {
            string password = TextBox_Password.Text;
            //min 6 chars, max 12 chars
            if (password.Length < 6 || password.Length > 12)
            {
                Label_Password.Text = "Min 6 character, max 12 character";
                Flag = 0;
            }

            //No white space
            else if (password.Contains(" "))
            {
                Label_Password.Text = "No white space";
                Flag = 0;
            }

            //At least 1 upper case letter
            else if (!password.Any(char.IsUpper))
            {
                Label_Password.Text = "At least 1 upper case letter";
                Flag = 0;
            }

            //At least 1 lower case letter
            else if (!password.Any(char.IsLower))
            {
                Label_Password.Text = "At least 1 lower case letter";
                Flag = 0;
            }
            else
            {
                Password = password;
                Label_Password.Text = string.Empty;
            }
        }

        private void ConfirmPassword()
        {
            string confirmpass = TextBox_ConfirmPassword.Text;
            if (confirmpass != TextBox_Password.Text)
            {
                Label_ConfirmPassword.Text = "Confirm password incorect";
                Flag = 0;
            }
            else
            {
                Label_ConfirmPassword.Text = string.Empty;
            }
        }

        private void CheckName()
        {
            Name1 = TextBox_Name.Text;
        }

        private void CheckBirthday()
        {
            string birthday;
            DateTime date;
            if (!(int.Parse(ComboBox_Year.Text) > 1900 && int.Parse(ComboBox_Year.Text) < DateTime.Now.Year))
            {
                Label_Birthday.Text = "Invalid date of birth";
                Flag = 0;
            }
            else
            {
                birthday = ComboBox_Month.Text + "/" + ComboBox_Day.Text + "/" + ComboBox_Year.Text;
                if (!DateTime.TryParse(birthday, out date))
                {
                    Label_Birthday.Text = "Invalid date of birth";
                    Flag = 0;
                }
                else
                {
                    Birthday = DateTime.Parse(birthday);
                    Label_Birthday.Text = string.Empty;
                }
            }
        }

        private void CheckEmail()
        {
            string email = TextBox_Email.Text;
            try
            {
                MailAddress mail = new MailAddress(email);
                Label_Email.Text = string.Empty;
                Email = email;
            }
            catch
            {
                Label_Email.Text = ("Invalid email");
                Flag = 0;
            }
        }

        private void CheckPhonenumber()
        {
            string phonenumber = TextBox_Phonenumber.Text;
            if (phonenumber[0] == '0' && phonenumber[1] == '9' && (phonenumber.Length == 11 || phonenumber.Length == 10)
                && IsDigit(phonenumber))
            {
                Phonenumber = phonenumber;
                Label_Phonenumber.Text = string.Empty;
            }
            else
            {
                Label_Phonenumber.Text = "Invalid phone number";
                Flag = 0;
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

        private bool CheckAll()
        {
            if (string.IsNullOrEmpty(TextBox_Username.Text) || string.IsNullOrEmpty(TextBox_Password.Text) ||
                string.IsNullOrEmpty(TextBox_ConfirmPassword.Text) || string.IsNullOrEmpty(TextBox_Name.Text) ||
                string.IsNullOrEmpty(ComboBox_Day.Text) || string.IsNullOrEmpty(ComboBox_Month.Text) || string.IsNullOrEmpty(ComboBox_Year.Text) ||
                string.IsNullOrEmpty(TextBox_Phonenumber.Text) || string.IsNullOrEmpty(TextBox_Email.Text) ||
                RadioButton_Male.Checked == false && RadioButton_Female.Checked == false)
            {
                MessageBox.Show("Please enter all required information");
                return false;
            }
            CheckUsername();
            CheckPassword();
            ConfirmPassword();
            CheckBirthday();
            CheckPhonenumber();
            CheckEmail();
            CheckName();
            CheckSex();
            Invalidate();
            if (Flag == 1)
                return true;
            else
                return false;
        }

        private void DoSignup()
        {
            if (CheckAll())
            {
                string sqlQuery = "INSERT INTO ACCOUNT (Username,Password,Name,Is_active,Is_admin,Birthday,Email,Phonenumber,Sex,Avatar) " +
                    "VALUES ( @username , @password , @name , @is_active , @is_admin , @birthday , @email , @phonenumber , @sex , @avatar )";
                Avatar = InteractImage.FromFile(InteractImage.getLinkFromDialog());
                DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Username,Password,Name1,"false","false",Birthday,Email
            ,Phonenumber,Sex,Avatar});
                MessageBox.Show("Account successfully created");
                this.Hide();
            }
            else
                Flag = 1;
        }

        private string _Username;
        private string _Password;
        private string _ConfirmPassword;
        private string _Name;
        private DateTime _Birthday;
        private string _Phonenumber;
        private string _Email;
        private string _Sex;
        private int _Flag;
        private byte[] _Avatar;

        public string Username { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string ConfirmPassword1 { get => _ConfirmPassword; set => _ConfirmPassword = value; }
        public string Name1 { get => _Name; set => _Name = value; }
        public DateTime Birthday { get => _Birthday; set => _Birthday = value; }
        public string Phonenumber { get => _Phonenumber; set => _Phonenumber = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
        public int Flag { get => _Flag; set => _Flag = value; }
        public byte[] Avatar { get => _Avatar; set => _Avatar = value; }
    }
}
