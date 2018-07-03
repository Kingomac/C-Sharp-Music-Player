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
        public static string GetLyrics(string path)
        {
            try
            {
                TagLib.File file = TagLib.File.Create(path);
                return file.Tag.Lyrics;
            }
            catch
            {
                return null;
            }
        }
    }
    class ConfigFile
    {
        public static async Task CreateDefault()
        {
            StreamWriter r = new StreamWriter("config.ini");
            await r.WriteAsync($"2500{Environment.NewLine}100{Environment.NewLine}eng");
            r.Close();
        }
        public static async Task<decimal[]> ReadDecimals()
        {
            StreamReader r = new StreamReader("config.ini");
            decimal[] num = new decimal[2];
            num[0] = Convert.ToDecimal(await r.ReadLineAsync());
            num[1] = Convert.ToDecimal(await r.ReadLineAsync());
            r.Close();
            return num;
        }
        public static async Task<string> ReadLanguage()
        {
            StreamReader r = new StreamReader("config.ini");
            await r.ReadLineAsync();
            await r.ReadLineAsync();
            string i = await r.ReadLineAsync();
            r.Close();
            if (i == "spa" || i == "eng") return i;
            else throw new InvalidDataException("Error with language, check if it's all right in config file");
        }
        public static async Task Save(decimal FadeInOut = 2500, decimal UpdateTime = 100, string Language = "eng")
        {
            StreamWriter r = new StreamWriter("config.ini");
            await r.WriteLineAsync(FadeInOut.ToString());
            await r.WriteLineAsync(UpdateTime.ToString());
            await r.WriteLineAsync(Language);
            r.Close();
        }
    }
}
