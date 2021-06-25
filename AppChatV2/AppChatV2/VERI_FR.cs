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
    public partial class Form_VerifyFriend : Form
    {
        UC_FriendRequest par;
        public Form_VerifyFriend(UC_FriendRequest PAR)
        {
            InitializeComponent();
            this.par = PAR;
        }

        private void frmVerifriend_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string sqlQuery = "UPDATE CONTACT SET Type = 'Added' WHERE ID1 = @id1 AND ID2 = @id2 ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { par.ID, User.Instance.ID });
            this.Hide();
        }
    }
}
