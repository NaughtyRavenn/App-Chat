using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChatV2
{
    public partial class UC_GroupChat : UserControl
    {
        UC_Group Par;
        public UC_GroupChat(UC_Group PAR,int i)
        {
            InitializeComponent();
            this.Par = PAR;
            ID = Par.ID;
        }

        private void Button_GroupInfo_Click(object sender, EventArgs e)
        {
            Form_GroupInfomation frm = new Form_GroupInfomation(this);
            frm.ShowDialog();
        }

        private void UC_GroupChat_Load(object sender, EventArgs e)
        {

        }

        private string _ID;

        public string ID { get => _ID; set => _ID = value; }
    }
}
