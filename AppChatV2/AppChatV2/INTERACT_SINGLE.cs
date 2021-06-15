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

namespace AppChatV2
{
    public partial class frmInteractsingle : Form
    {
        public frmInteractsingle()
        {
            InitializeComponent();
        }
 
        private void btnMessagesingle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSinglechat frm = new frmSinglechat();
            frm.Show();
        }

        private void btnCreategroup_Click(object sender, EventArgs e)
        {
            frmGroupinfo frm = new frmGroupinfo();
            frm.ShowDialog();
        }

        private void frmInteractsingle_Load(object sender, EventArgs e)
        {

        }
    }
}
