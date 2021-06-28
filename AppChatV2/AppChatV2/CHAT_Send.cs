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
    public partial class CHAT_Send : UserControl
    {
        public CHAT_Send(string v)
        {
            InitializeComponent();
            Label_Message.Text = v;
        }

 /*       private void CHAT_Send_Load(object sender, EventArgs e)
        {
            Label_Message.Text = Message;
        }*/

    }
}
