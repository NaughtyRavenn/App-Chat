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
    public partial class Form_ResponeOption : Form
    {
        UC_FriendRequest par;
        public Form_ResponeOption(UC_FriendRequest PAR)
        {
            InitializeComponent();
            this.par = PAR;
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            string sqlQuery = "UPDATE CONTACT SET Type = 'Added' WHERE ID1 = @id1 AND ID2 = @id2 ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { par.ID, User.Instance.ID });
            this.Hide();
        }

        private void Form_ResponeOption_Load(object sender, EventArgs e)
        {

        }

        private void Button_Decline_Click(object sender, EventArgs e)
        {
            string sqlQuery = "DELETE FROM CONTACT WHERE ID1 = @id1 AND ID2 = @id2 ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { par.ID, User.Instance.ID });
            this.Hide();
        }
    }
}
