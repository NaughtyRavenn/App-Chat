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
        }
    }
}
