using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Project_Music
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader("config.ini");
            FadeNumUpDown.Value = Convert.ToDecimal(reader.ReadLine());
            UpdateNumUpDown.Value = Convert.ToDecimal(reader.ReadLine());
            reader.Close();
        }

        private void FadeSlider_ValueChanged(object sender, EventArgs e)
        {
            FadeNumUpDown.Value = FadeSlider.Value;
        }

        private void FadeNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            FadeSlider.Value = Convert.ToInt32(FadeNumUpDown.Value);
        }

        private void UpdateSlider_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumUpDown.Value = UpdateSlider.Value;
        }

        private void UpdateNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateSlider.Value = Convert.ToInt32(UpdateNumUpDown.Value);
        }
        Point LastPoint;
        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - LastPoint.X; this.Top += e.Y - LastPoint.Y; }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("config.ini");
            writer.WriteLine(FadeNumUpDown.Value);
            writer.WriteLine(UpdateNumUpDown.Value);
            writer.Close();
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PlaySingleButton_Click(object sender, EventArgs e)
        {
            GeneralPanel.Visible = !GeneralPanel.Visible;
        }
    }
}
