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
    public partial class Form_InteractGroup : Form
    {
        public Form_InteractGroup()
        {
            InitializeComponent();
        }

        private void Form_InteractGroup_Load(object sender, EventArgs e)
        {

        }

        private void Button_GroupInfomation_Click(object sender, EventArgs e)
        {
            Form_GroupInfomation frm = new Form_GroupInfomation(this, 2);
            frm.ShowDialog();
        }
    }
}
