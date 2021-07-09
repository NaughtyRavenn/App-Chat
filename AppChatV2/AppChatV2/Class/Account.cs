
namespace AppChatV2.Class
{
    class Account
    {
        private static Account instance;

        internal static Account Instance
        {
            get
            {
                if (Account.instance == null)
                    instance = new Account();
                return Account.instance;
            }
            private set
            {
                Account.instance = value;
            }
        }

        public bool Login(string username, string password)
        {
            string sqlQuery = "SELECT * FROM ACCOUNT WHERE Username= @username AND Password= @password ";
            int count = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { username, password }).Rows.Count;
            if (count > 0)
            {
                string sqlQuery1 = "SELECT ID FROM ACCOUNT WHERE Username = @username ";
                ID = DataProvider.Instance.ExcuteQuery(sqlQuery1, new object[] { username }).Rows[0]["id"].ToString();
                Username = username;
                Password = password;
                IP = "192.168.0.104";
                string sqlQuery2 = "UPDATE ACCOUNT SET Is_active = 'true' WHERE ID = @id ";
                DataProvider.Instance.ExcuteQuery(sqlQuery2, new object[] { ID });
                return true;
            }
            return false;
        }

        public void Logout()
        {
            string sqlQuery = "UPDATE ACCOUNT SET Is_active = 'false' WHERE ID = @id ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { ID });
        }

        private string _IP;
        private string _Username;
        private string _ID;
        private string _Password;

        public string IP { get => _IP; set => _IP = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string ID { get => _ID; set => _ID = value; }
        public string Password { get => _Password; set => _Password = value; }
    }
}
