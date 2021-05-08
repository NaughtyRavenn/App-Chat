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
    public partial class frmInteractsingle : Form
    {
        public frmInteractsingle()
        {
            InitializeComponent();
        }

        private void btnMessagegroup_Click(object sender, EventArgs e)
        {
            frmSinglechat frm = new frmSinglechat();
            frm.Show();
            this.Hide();
        }
    }
}
