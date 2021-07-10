using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Server
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

        public List<int> LoadPortFromDB()
        {
            var v1 = new List<int>();
            string sqlQuery = "SELECT Port AS PORT FROM CONTACT WHERE Type='Added'" +
                "UNION " +
                "SELECT Port AS PORT FROM GROUPCHAT";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery);
            foreach (DataRow v in Data.Rows)
            {
                v1.Add(int.Parse(v["PORT"].ToString()));
            }
            return v1;
        }
    }
}
