﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows;

namespace AppChatV2
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

        public string userName = "";
        public string id = "";
        public string passWord = "";

        public bool Login(string username, string password)
        {
            string sqlQuery = "SELECT * FROM ACCOUNT WHERE Username= @username AND Password= @password ";
            int count = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { username, password }).Rows.Count;
            if (count > 0)
            {
                string sqlQuery1 = "SELECT ID FROM ACCOUNT WHERE Username = @username ";
                id = DataProvider.Instance.ExcuteQuery(sqlQuery1, new object[] { username }).Rows[0]["id"].ToString();
                userName = username;
                passWord = password;
                string sqlQuery2 = "UPDATE ACCOUNT SET Is_active = 'true' WHERE ID = @id ";
                DataProvider.Instance.ExcuteQuery(sqlQuery2, new object[] { id });
                return true;
            }
            //id = Data.Instance.ExcuteQuery(sqlQuery1).Rows[0]["id"].ToString();
            return false;
        }

        public void Logout()
        {
            string sqlQuery = "UPDATE ACCOUNT SET Is_active = 'false' WHERE ID = @id ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { id });
        }
    }
}