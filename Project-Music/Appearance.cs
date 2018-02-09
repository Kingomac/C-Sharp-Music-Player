using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Music
{
    class Appearance
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
}
