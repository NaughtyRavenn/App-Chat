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

        public string Name { get; set; }
        public string Is_admin { get; set; }
        public string Is_active { get; set; }

        public void LoadInfo()
        {
            var Data = DataProvider.Instance.LoadInfoFromDB();
            Name = Data.Rows[0]["Name"].ToString();
            Is_admin = Data.Rows[0]["Is_admin"].ToString();
            Is_active = Data.Rows[0]["Is_active"].ToString();
        }
    }
}
