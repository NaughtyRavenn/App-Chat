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
    public partial class Form_GroupInfomation : Form
    {
        UC_GroupChat Par;
        public Form_GroupInfomation(UC_GroupChat PAR)
        {
            InitializeComponent();
            this.Par = PAR;
            ID = Par.ID;
        }
       
        private void Form_GroupInfomation_Load(object sender, EventArgs e)
        {

        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                string sqlQuery = "UPDATE GROUPCHAT SET Name = @name WHERE ID = @id ";
                DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { TextBox_Name.Text,ID});
                MessageBox.Show("Successfully updated");
                this.Hide();
            }
            else
            {
                Label_Name.Text = "Invalid name";
                return;
            }
        }

        private bool CheckInfo()
        {
            if (string.IsNullOrEmpty(TextBox_Name.Text))
                return false;
            return true;
        }

        private void Button_AddMember_Click(object sender, EventArgs e)
        {
            Form_AddMember frm = new Form_AddMember(this);
            frm.ShowDialog();
        }

        private string _ID;

        public string ID { get => _ID; set => _ID = value; }

    }
}
