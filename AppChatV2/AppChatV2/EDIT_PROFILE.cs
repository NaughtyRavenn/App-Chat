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
        }

        

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            /*TextBox_Birthday.Text = TextBox_Email.Text = TextBox_Name.Text = TextBox_Phonenumber.Text = null;*/
        }

        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            txtNewpassword.Text = txtCurrentpassword.Text = txtConfirmpassword.Text = null;
        }

        private void doConfirm1()
        {
            Person p = DataProvider.Instance.LoadInfoByID(Account.Instance.id);
            
        }

        private void Form_EditProfile_Load(object sender, EventArgs e)
        {

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

        private bool IsDigit(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private string _Name;
        private DateTime _Birthday;
        private string _Email;
        private string _Phonenumber;
        private string _Sex;
        public string Name1 { get => _Name; set => _Name = value; }
        public DateTime Birthday { get => _Birthday; set => _Birthday = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Phonenumber { get => _Phonenumber; set => _Phonenumber = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
    }
}
