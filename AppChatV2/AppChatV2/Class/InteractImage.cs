using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppChatV2.Class
{
    class InteractImage
    {

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

        static public Image BytesToImage(byte[] bytes)
        {
            try
            {
                var ms = new MemoryStream(bytes);
                var img = Image.FromStream(ms);
                return img;
            }
            catch
            {
                return null;
            }
        }
    }
}
