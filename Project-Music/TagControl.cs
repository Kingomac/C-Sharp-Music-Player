using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using TagLib.Image;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
namespace Project_Music
{
    class TagControl
    {
        public static void GetCover(string path, PictureBox pictureBox)
        {
            TagLib.File file = TagLib.File.Create(path);
            if (file.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pictureBox.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(1000, 1000, null, IntPtr.Zero);
            }
        }
    }
}
