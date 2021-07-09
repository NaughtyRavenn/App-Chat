using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppChatV2.Class;

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
            PictureBox_Avatar.Image = DataProvider.Instance.GetSingleImage(ID);
        }

        private void Button_SendRequest_Click_1(object sender, EventArgs e)
        {
            SendRequestFriend();
        }

        private void SendRequestFriend()
        {
            string sqlQuery1 = "SELECT * FROM CONTACT WHERE ID1 = @id AND ID2 = @id1 ";
            int count1 = DataProvider.Instance.ExcuteQuery(sqlQuery1, new object[] { User.Instance.ID, ID }).Rows.Count;
            if (count1 > 0)
            {
                MessageBox.Show("Friend request has been sent before");
                return;
            }
            string sqlQuery3 = "INSERT INTO CONTACT (ID1, ID2, Type) VALUES ( @id , @id1 , 'Waiting')";
            DataProvider.Instance.ExcuteQuery(sqlQuery3, new object[] { User.Instance.ID, ID });
            MessageBox.Show("Sent friend request");
        }

        private string _Name;
        private string _ID;

        public string Name1 { get => _Name; set => _Name = value; }
        public string ID { get => _ID; set => _ID = value; }
    }
}
