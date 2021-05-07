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
    public partial class frmAddfriend : Form
    {
        public frmAddfriend()
        {
            InitializeComponent();
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {

        }

        private void FORM_ADD_FR_Load(object sender, EventArgs e)
        {

        }

        private void btnInvitefriend_Click(object sender, EventArgs e)
        {
            frmVerifriend frm = new frmVerifriend();
            frm.ShowDialog();
        }
    }
}
