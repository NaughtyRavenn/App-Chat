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
    public partial class frmEditprofile : Form
    {
        public frmEditprofile()
        {
            InitializeComponent();
        }

        private void frmEditprofile_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            txtBirthday.Text = txtEmail.Text = txtName.Text = txtPhone.Text = null;
        }

        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            txtNewpassword.Text = txtCurrentpassword.Text = txtConfirmpassword.Text = null;
        }
    }
}
