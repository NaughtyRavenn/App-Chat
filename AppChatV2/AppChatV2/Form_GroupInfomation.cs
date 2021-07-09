using System;
using System.IO;
using System.Windows.Forms;
using AppChatV2.Class;

namespace AppChatV2
{
    public partial class Form_GroupInfomation : Form
    {
        public UC_GroupChat Par;
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
            string sqlQuery;
            if (CheckName() && CheckAvatar())
            {
                sqlQuery = "UPDATE GROUPCHAT SET Name = @name , Avatar = @avatar WHERE ID = @id ";
                DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { TextBox_Name.Text, Avatar, ID });
            }
            else if (CheckName() && !CheckAvatar())
            {
                sqlQuery = "UPDATE GROUPCHAT SET Name = @name WHERE ID = @id ";
                DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { TextBox_Name.Text, ID });
            }
            else if (!CheckName() && CheckAvatar())
            {
                sqlQuery = "UPDATE GROUPCHAT SET Avatar = @avatar WHERE ID = @id ";
                DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { Avatar, ID });
            }
            MessageBox.Show("Successfully updated");
            this.Hide();
        }

        private bool CheckName()
        {
            if (!string.IsNullOrEmpty(TextBox_Name.Text))
                return true;
            return false;
        }

        private bool CheckAvatar()
        {
            if (PictureBox_Avatar.Image != null)
                return true;
            return false;
        }

        private void Button_AddMember_Click(object sender, EventArgs e)
        {
            Form_AddMember frm = new Form_AddMember(this);
            frm.ShowDialog();
        }


        private void Button_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select avatar";
            open.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (.jpg;.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (.png)|.png";
            try
            {
                string file = InteractImage.getLinkFromDialog();
                PictureBox_Avatar.Image = InteractImage.BytesToImage(InteractImage.FromFile(file));
                Avatar = File.ReadAllBytes(file);
            }
            catch
            {
                return;
            }
        }

        private byte[] _Avatar;
        private string _ID;
        
        public string ID { get => _ID; set => _ID = value; }
        public byte[] Avatar { get => _Avatar; set => _Avatar = value; }
    }
}
