using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChatV2
{
    public partial class UC_Stranger : UserControl
    {
        public UC_Stranger()
        {
            InitializeComponent();
        }

        private void UC_Stranger_Load(object sender, EventArgs e)
        {
            Label_Name.Text = Name1;
        }

        private void Button_AddFriend_Click(object sender, EventArgs e)
        {
            SendRequestFriend();
            MessageBox.Show("Sent friend request");
        }

        private void SendRequestFriend()
        {
            string sqlQuery1 = "SELECT FROM CONTACT WHERE ID1 = @id AND ID2 = @id1 ";
            int count = DataProvider.Instance.ExcuteQuery(sqlQuery1, new object[] { User.Instance.ID, ID }).Rows.Count;
            if (count > 0)
            {
                MessageBox.Show("Friend request has been sent before");
                return;
            }
            string sqlQuery2 = "INSERT INTO CONTACT (ID1, ID2, Type) VALUES ( @id , @id1 , 'Waiting')";
            DataProvider.Instance.ExcuteQuery(sqlQuery2, new object[] { User.Instance.ID, ID });
        }

        private string _Name;
        private string _ID;

        public string Name1 { get => _Name; set => _Name = value; }
        public string ID { get => _ID; set => _ID = value; }
    }
}
