using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using TagLib.WavPack;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.IO;

namespace Project_Music
{
    public partial class AboutTags : Form
    {
        public AboutTags()
        {
            InitializeComponent();
            TitleLabel.Text = $"More about: {TagControl.GetName(MainForm.FilePath)}";
            TagLib.File file = TagLib.File.Create(MainForm.FilePath);
            AuthorTextbox.Text = "";
            foreach(string i in file.Tag.Performers)
            {
                AuthorTextbox.Text += $"{i} ";
            }
            AlbumTextbox.Text = file.Tag.Album;
            YearTextbox.Text = file.Tag.Year.ToString();
            TrackTextbox.Text = file.Tag.Track.ToString();
            GenreTextbox.Text = "";
            foreach(string i in file.Tag.Genres)
            {
                GenreTextbox.Text += $"{i} ";
            }
            if(Path.GetExtension(MainForm.FilePath) == ".wav")
            {
                var wave = new WaveFileReader(MainForm.FilePath);
                LengthTextbox.Text = wave.TotalTime.ToString();
                FreqTextbox.Text = $"{wave.WaveFormat.SampleRate.ToString()} Hz";
                wave.Close();
            }
            else if(Path.GetExtension(MainForm.FilePath) == ".mp3")
            {
                var mp3 = new Mp3FileReader(MainForm.FilePath);
                LengthTextbox.Text = mp3.TotalTime.ToString();
                FreqTextbox.Text = $"{mp3.WaveFormat.SampleRate.ToString()} Hz";
                BitrateTextbox.Text = Convert.ToString(mp3.Mp3WaveFormat.AverageBytesPerSecond * 8 / 1024) + "Kbps (aprox.)";
                mp3.Close();
            }
            file.Dispose();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void SaveTagsButton_Click(object sender, EventArgs e)
        {
        }
    }
}
