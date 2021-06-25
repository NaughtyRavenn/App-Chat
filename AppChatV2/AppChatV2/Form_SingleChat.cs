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
    public partial class Form_SingleChat : Form
    {
        public Form_SingleChat(Form_InteractSingle PAR)
        {
            InitializeComponent();
            this.Par = PAR;
        }

        private void btnGroupinfo_Click_1(object sender, EventArgs e)
        {
            Form_GroupInfomation frm = new Form_GroupInfomation();
            frm.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            /*richTextBox1.Height*/
        }

        private void Form_SingleChat_Load(object sender, EventArgs e)
        {

        }

        private Form_InteractSingle _Par;

        public Form_InteractSingle Par { get => _Par; set => _Par = value; }
    }
}
