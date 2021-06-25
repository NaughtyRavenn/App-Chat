﻿using System;
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
    public partial class UC_Friend : System.Windows.Forms.UserControl
    {
        public UC_Friend()
        {
            InitializeComponent();
        }

        private void Form_UserControl_Load(object sender, EventArgs e)
        {
            Label_Name.Text = Name1;
        }

        private string _Name;
        private string _ID;
        public string Name1 { get => _Name; set => _Name = value; }
        public string ID { get => _ID; set => _ID = value; }
    }
}