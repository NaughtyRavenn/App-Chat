using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChatV2
{
    public class User
    {
        private static User instance;

        internal static User Instance
        {
            get
            {
                if (User.instance == null)
                    instance = new User();
                return User.instance;
            }
            private set
            {
                User.instance = value;
            }
        }
        
        public void LoadInfo()
        {
            var Data = DataProvider.Instance.LoadInfoFromDB();
            ID = Data.Rows[0][ID].ToString();
            Name = Data.Rows[0]["Name"].ToString();
            Is_admin = Data.Rows[0]["Is_admin"].ToString();
            Is_active = Data.Rows[0]["Is_active"].ToString();
            Birthday = Data.Rows[0]["Birthday"].ToString();
            Email = Data.Rows[0]["Email"].ToString();
            Phonenumber = Data.Rows[0]["Phonenumber"].ToString();
        }

        public string Name { get; set; }
        public string Is_admin { get; set; }
        public string Is_active { get; set; }
        public string Phonenumber { get => _Phonenumber; set => _Phonenumber = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Birthday { get => _Birthday; set => _Birthday = value; }
        public string ID { get => _ID; set => _ID = value; }
        public string Sex { get => _Sex; set => _Sex = value; }

        private string _Phonenumber;
        private string _Email;
        private string _Birthday;
        private string _ID;
        private string _Sex;
    }
}
