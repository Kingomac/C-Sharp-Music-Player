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
            LoadConfig();
        }
        private async void LoadConfig()
        {
            StreamReader r = new StreamReader("config.ini");
            decimal[] num = new decimal[1];
            FadeNumUpDown.Value = Convert.ToDecimal(await r.ReadLineAsync());
            UpdateNumUpDown.Value = Convert.ToDecimal(await r.ReadLineAsync());
            r.Close();
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

        private async void CloseButton_Click(object sender, EventArgs e)
        {
            await ConfigFile.Save(FadeNumUpDown.Value,UpdateNumUpDown.Value);
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

        private async void DefaultSetButton_Click(object sender, EventArgs e)
        {
            File.Delete("config.ini");
            await ConfigFile.CreateDefault();
            var i = new OptionsForm();
            i.Show();
            this.Close();
        }
    }
}
