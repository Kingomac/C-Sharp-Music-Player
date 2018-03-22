using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Project_Music
{
    class ColorSetting
    {
        public static void PanelColor(Color BackColor, Color ForeColor, Panel panel)
        {
            panel.BackColor = BackColor;
            panel.ForeColor = ForeColor;
        }
        public static void ButtonColor(Color BackColor, Color ForeColor, Button button)
        {
            button.BackColor = BackColor;
            button.ForeColor = ForeColor;
        }
    }
    class ConfigFile
    {
        public static void Write(string text)
        {
            StreamWriter writer = new StreamWriter("config.ini");
            writer.Write(text);
            writer.Close();
        }
        public static void WriteLine(bool append, string text)
        {
            StreamWriter writer = new StreamWriter("config.ini", append: append);
            writer.WriteLine(text);
            writer.Close();
        }
        public static void ClearAll()
        {
            StreamWriter writer = new StreamWriter("config.ini");
            writer.Write("");
            writer.Close();
        }
        public static string ReadLine()
        {
            StreamReader reader = new StreamReader("config.ini");
            string value = reader.ReadLine();
            reader.Close();
            return value;
        }
    }
}
