using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Collections;

namespace AppChatV2.Class
{
    class DataProvider
    {
        private static DataProvider instance;

        internal static DataProvider Instance
        {
            get
            {
                if (DataProvider.instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }

        public object DataTable { get; private set; }

        public int x, y;
        public int Getx() { return x; }
        public void Setx(int x) { this.x = x; }
        public int Gety() { return y; }
        public void Sety(int y) { this.y = y; }


        private DataProvider() { }

        protected static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(GetConnectionString());
        private static string GetConnectionString()
        {
            return @"Data Source=LAPTOP-L3JT52S4;Initial Catalog=ChatApp;Integrated Security=True";
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        public DataTable ExcuteQuery(string query, object[] parameters = null)
        {
            DataTable DataProviderTable = new DataTable();
            int Out;
            if (InternetGetConnectedState(out Out, 0))
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    try
                    {
                        connection.Open();
                    }

                    catch
                    {
                        MessageBox.Show("Mất mạng!");
                        return null;
                    }

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameters != null)
                    {
                        string[] splitPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in splitPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(DataProviderTable);
                    connection.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Vui lòng khởi động lại chương trình", "Mất kết nối", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            return DataProviderTable;
        }

        public DataTable LoadInfoFromDB()
        {
            string sqlQuery = "SELECT * FROM ACCOUNT WHERE ID = @id ";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Account.Instance.id });
            return Data;
        }

        public Dictionary<string,int> LoadListFriendIDAndPort()
        {
            var v1 = new Dictionary<string, int>();
            string sqlQuery = "SELECT ID1 AS IDnew,Port FROM CONTACT WHERE ID2 = @id1 AND Type = 'Added' " +
                "UNION " +
                "SELECT ID2 AS IDnew,Port FROM CONTACT WHERE ID1 = @id2 AND Type = 'Added' ";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Account.Instance.id, Account.Instance.id });
            foreach (DataRow v2 in Data.Rows)
            {
                v1.Add(v2["IDnew"].ToString(), int.Parse(v2["Port"].ToString()));
            }
            return v1;
        }

        public List<string> LoadListStrangerID()
        {
            var v1 = new List<string>();
            string sqlQuery = "SELECT ID FROM ACCOUNT WHERE ID <> @id " +
                "EXCEPT " +
                "( " +
                "SELECT ID2 FROM CONTACT WHERE ID1= @id1 AND Type = 'Added'" +
                "UNION " +
                "SELECT ID1 FROM CONTACT WHERE ID2= @id2 AND Type = 'Added'" +
                "UNION " +
                "SELECT ID2 FROM CONTACT WHERE ID1= @id3 AND Type = 'Waiting'" +
                "UNION " +
                "SELECT ID1 FROM CONTACT WHERE ID2= @id4 AND Type = 'Waiting'" +
                ")";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Account.Instance.id, Account.Instance.id,
                Account.Instance.id, Account.Instance.id, Account.Instance.id });
            foreach (DataRow v2 in Data.Rows)
            {
                v1.Add(v2["ID"].ToString());
            }
            return v1;
        }

        public List<string> LoadListFriendRequest()
        {
            var v1 = new List<string>();
            string sqlQuery = "SELECT ID1 FROM CONTACT WHERE ID2 = @id AND Type= 'Waiting'";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Account.Instance.id });
            foreach (DataRow v2 in Data.Rows)
            {
                v1.Add(v2["ID1"].ToString());
            }
            return v1;
        }

        public Person LoadInfoByID(string id)
        {
            string sqlQuery = "SELECT * FROM ACCOUNT WHERE ID = @id ";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { id });
            return new Person()
            {
                Id = id,
                Username = Data.Rows[0]["Username"].ToString(),
                Password = Data.Rows[0]["Password"].ToString(),
                Name = Data.Rows[0]["Name"].ToString(),
                Email = Data.Rows[0]["Email"].ToString(),
                Phonenumber = Data.Rows[0]["Phonenumber"].ToString(),
                Sex = Data.Rows[0]["Sex"].ToString(),
                Birthday = DateTime.Parse(Data.Rows[0]["Birthday"].ToString()),
                Is_active = Data.Rows[0]["Is_active"].ToString()
            };
        }

        //--------------------------

        public List<int> LoadContactFromDB()
        {
            var v1 = new List<int>();
            string sqlQuery = "SELECT Port FROM CONTACT";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery);
            foreach (DataRow v in Data.Rows)
            {
                v1.Add(int.Parse(v["Port"].ToString()));
            }
            return v1;
        }
    }
}
