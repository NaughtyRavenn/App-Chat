using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_InteractSingle : Form
    {
        public Form_InteractSingle(UC_Friend PAR)
        {
            InitializeComponent();
            this.Par = PAR;

            CheckForIllegalCrossThreadCalls = false;
/*
            if (Check_BoxChat(Par.ID))
            {
                Button_Chat.Enabled = false;
            }
            else
            {
                Button_Chat.Enabled = true;
            }*/
        }


        private void Button_Profile_Click(object sender, EventArgs e)
        {
            Form_FriendInfomation frm = new Form_FriendInfomation(this);
            frm.ShowDialog();
            this.Hide();
        }

        private void Form_InteractSingle_Load(object sender, EventArgs e)
        {

        }

        private void Button_Chat_Click(object sender, EventArgs e)
        {
            Form_SingleChat frm = new Form_SingleChat(this);
            frm.Show();
            this.Hide();
        }

      /*  private bool Check_BoxChat(string i)
        {
            *//*foreach (var v in Par.Par.BoxChat)
                if (i == v.ToString())
                    return true;
            return false;*//*
        }*/

        private void Button_Unfriend_Click(object sender, EventArgs e)
        {
            Unfriend();
            this.Hide();
        }

        private void Unfriend()
        {
            string sqlQuery = "DELETE FROM CONTACT WHERE ( ID1 = @id1 AND ID2 = @id2 ) OR ( ID1 = @id3 AND ID2 = @id4 )";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Account.Instance.id, Par.ID, Par.ID, Account.Instance.id });
        }

        private void Button_AddGroup_Click(object sender, EventArgs e)
        {
            Form_GroupInfomation frm = new Form_GroupInfomation(this, 1);
            frm.ShowDialog();
        }

        //--------------------------------------------
        
        private UC_Friend _Par;
        
        public UC_Friend Par { get => _Par; set => _Par = value; }
    }
}
