using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class UC_Group : UserControl
    {
        public Form_Main Par;
        public UC_Group(Form_Main PAR)
        {
            InitializeComponent();
            this.Par = PAR;
        }

        private void UC_Group_Load(object sender, EventArgs e)
        {
            Label_Name.Text = Name1;
            PictureBox_Avatar.Image = DataProvider.Instance.GetGroupImage(ID);
        }

        public void NoticeMessage(bool a)
        {
            Notice_Message.Visible = a;
        }

        private void UC_Group_Click(object sender, EventArgs e)
        {
            Par.ChangeColorGroup();
            (sender as UC_Group).BackColor = Color.DimGray;
            Par.SwitchTab(Index);
            NoticeMessage(false);
        }

        public string ReturnBackColor()
        {
            return this.BackColor.ToString();
        }

        public void Reload()
        {
            Par.Reload();
        }


        private string _Name;
        private int _Port;
        private string _ID;
        private int _Index;
        private List<User> _ListMember;

        public string Name1 { get => _Name; set => _Name = value; }
        public int Port { get => _Port; set => _Port = value; }
        public string ID { get => _ID; set => _ID = value; }
        public int Index { get => _Index; set => _Index = value; }
        public List<User> ListMember { get => _ListMember; set => _ListMember = value; }

        private void Button_Option_Click(object sender, EventArgs e)
        {

        }
    }
}
