using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChatV2.Class
{
    public class Person
    {
        private string _id;
        private string _Name;
        public string Id { get => _id; set => _id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Phonenumber { get => _Phonenumber; set => _Phonenumber = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
        public DateTime Birthday { get => _Birthday; set => _Birthday = value; }
        public string Username { get => _Username; set => _Username = value; }

        private string _Phonenumber;
        private string _Email;
        private  DateTime _Birthday;
        private string _Password;
        private string _Sex;
        private string _Username;
    }
}
