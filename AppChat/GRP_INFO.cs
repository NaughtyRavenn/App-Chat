﻿using System;
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
    public partial class frmGroupinfo : Form
    {
        public frmGroupinfo()
        {
            InitializeComponent();
        }

        private void btnAddtogroup_Click(object sender, EventArgs e)
        {
            frmAddtogroup frm = new frmAddtogroup();
            frm.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}