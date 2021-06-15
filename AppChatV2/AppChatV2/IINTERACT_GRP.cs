using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChatV2
{
    public partial class frmInteractgroup : Form
    {
        public frmInteractgroup()
        {
            InitializeComponent();
        }

        private void btnMessagesingle_Click(object sender, EventArgs e)
        {
            frmGroupchat frm = new frmGroupchat();
            frm.Show();
            this.Hide();
        }

        private void frmInteractgroup_Load(object sender, EventArgs e)
        {

        }
    }
}
