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
    public partial class frmGroupchat : Form
    {
        public frmGroupchat()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void btnGroupinfo_Click_1(object sender, EventArgs e)
        {
            frmGroupinfo frm = new frmGroupinfo();
            frm.ShowDialog();
        }
    }
}
