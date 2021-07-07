using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_CreateGroup : Form
    {
        public Form_CreateGroup()
        {
            InitializeComponent();
        }

        private void Form_CreateGroup_Load(object sender, EventArgs e)
        {

        }

        private bool CheckInfo()
        {
            if (string.IsNullOrEmpty(TextBox_Name.Text))
                return false;
            return true;
        }

        private void CreateGroup()
        {
            string sqlQuery = "INSERT INTO GROUPCHAT (Name,Port) VALUES ( @name , @port )";
            int Port = DataProvider.Instance.ProvideGroupPort();
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { TextBox_Name.Text, Port });
            string sqlQuery3 = "SELECT ID FROM GROUPCHAT WHERE Name = @name1 ";
            var Data = DataProvider.Instance.ExcuteQuery(sqlQuery3, new object[] { TextBox_Name.Text });
            int groupid = int.Parse(Data.Rows[0]["ID"].ToString());
            string sqlQuery2 = "INSERT INTO GROUPINFO (GROUP_ID,ACCOUNT_ID) VALUES ( @groupid , @accountid )";
            DataProvider.Instance.ExcuteQuery(sqlQuery2, new object[] { groupid, Account.Instance.id });
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                CreateGroup();
                MessageBox.Show("Group successfully created");
                this.Hide();
            }
            else
            {
                Label_Name.Text = "Invalid name";
                return;
            }
        }
    }
}
