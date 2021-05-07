using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmInteractgroup : Form
    {
        public frmInteractgroup()
        {
            InitializeComponent();
        }

        private void btnMessagegroup_Click(object sender, EventArgs e)
        {
            frmGroupchat frm = new frmGroupchat();
            frm.Show();
            this.Hide();
        }
    }
}
