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
                pictureBox.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(2048, 2048, null, IntPtr.Zero);
            }
        }
        public static string GetName(string path)
        {
            TagLib.File file = TagLib.File.Create(path);
            if (file.Tag.IsEmpty)
            {
                return Path.GetFileNameWithoutExtension(path);
            }
            else return file.Tag.Title;
        }
    }
    class ConfigFile
    {
        public static async Task CreateDefault()
        {
            StreamWriter r = new StreamWriter("config.ini");
            await r.WriteAsync($"2500{Environment.NewLine}100");
            r.Close();
        }
        public static async Task<decimal[]> Read()
        {
            StreamReader r = new StreamReader("config.ini");
            decimal[] num = new decimal[1];
            num[0] = Convert.ToDecimal(await r.ReadLineAsync());
            num[1] = Convert.ToDecimal(await r.ReadLineAsync());
            r.Close();
            return num;
        }
        public static async Task Save(decimal FadeInOut = 2500, decimal UpdateTime = 100)
        {
            StreamWriter r = new StreamWriter("config.ini");
            await r.WriteLineAsync(FadeInOut.ToString());
            await r.WriteLineAsync(UpdateTime.ToString());
            r.Close();
        }
    }
}
