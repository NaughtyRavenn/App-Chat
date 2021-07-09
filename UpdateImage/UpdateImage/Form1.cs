using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte[] bytes = FromFile(getLinkFromDialog());
            string sqlQuery = "UPDATE GROUPCHAT SET Avatar = @a ";
            DataProvider.Instance.ExcuteQuery(sqlQuery, new object[] { bytes });

            byte[] bytes1 = FromFile(getLinkFromDialog());
            string sqlQuery1 = "UPDATE GROUPCHAT SET Avatar = @a ";
            DataProvider.Instance.ExcuteQuery(sqlQuery1, new object[] { bytes1 });
        }

        static public string getLinkFromDialog()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select avatar";
            open.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (.jpg;.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (.png)|.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                return open.FileName;
            }
            else
            {
                return "";
            }
        }

        static public byte[] FromFile(string path)
        {
            if (path == "")
            {
                return null;
            }
            else
            {
                var bytes = File.ReadAllBytes(path);
                return bytes;
            }
        }
    }
}
