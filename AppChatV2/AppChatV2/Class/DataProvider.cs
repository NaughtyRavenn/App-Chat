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
using AppChatV2.Class;

namespace AppChatV2
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
            return @"Server = myseversql.database.windows.net; Database = AppChat; UID = nhatminh; Pwd = Ngaymai123";
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

        public List<string> LoadListFriendID()
        {
            var v1 = new List<string>();
            string sqlQuery = "SELECT * FROM CONTACT WHERE ID1 = @id OR ID2 = @id_1 ";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Account.Instance.id, Account.Instance.id });
            foreach (DataRow v2 in Data.Rows)
            {
                if (v2["ID1"].ToString()== Account.Instance.id)
                {
                    v1.Add(v2["ID2"].ToString());
                }
                else
                {
                    v1.Add(v2["ID1"].ToString());
                }
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
                Name = Data.Rows[0]["Name"].ToString()
            };
        }

        public void EditProfile1(Person p)
        {
            string sqlQuery = "UPDATE ACCOUNT SET Name = @Name , Birthday = @Birthday , Phonenumber = @Phonenumber , Sex = @Sex , Email = @Email";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { p.Name, p.Birthday, p.Phonenumber, p.Sex, p.Email });
        }
    }
}
