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
    public partial class UC_Friend : UserControl
    {
        public UC_Friend()
        {
            InitializeComponent();
        }

        private void UC_Friend_Load(object sender, EventArgs e)
        {
            Label_Name.Text = Name1;
            if (Is_active == "true")
                Button_Status.FillColor = Color.Green;
            else
                Button_Status.FillColor = Color.Gray;
        }

        private void Button_Option_Click(object sender, EventArgs e)
        {
            Form_InteractSingle frm = new Form_InteractSingle(this);
            frm.ShowDialog();
        }

        private string _Name;
        private string _ID;
        private string _Is_active;
        private DateTime _Birthday;
        private string _Email;
        private string _Phonenumber;
        private int _Port;
        public string Name1 { get => _Name; set => _Name = value; }
        public string ID { get => _ID; set => _ID = value; }
        public string Is_active { get => _Is_active; set => _Is_active = value; }
        public DateTime Birthday { get => _Birthday; set => _Birthday = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Phonenumber { get => _Phonenumber; set => _Phonenumber = value; }
        public int Port { get => _Port; set => _Port = value; }
    }
}
