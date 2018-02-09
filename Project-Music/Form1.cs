using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using NAudio;
using NAudio.Codecs;
using NAudio.Wave;
using NAudio.Wave.Asio;
using NAudio.Mixer;
using NAudio.MediaFoundation;
using NAudio.Utils;
using NAudio.Dsp;
using NAudio.CoreAudioApi;
using NAudio.Wave.SampleProviders;


namespace Project_Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            panel2.Enabled = !panel2.Enabled;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Your favorite songs (*.mp3)|*.mp3|(*.wav)|*.wav|All files (*.*)|*.*",
                FilterIndex = 1,

                Multiselect = false
            };
            // Call the ShowDialog method to show the dialog box.
            bool? userClickedOK = Convert.ToBoolean(openFileDialog1.ShowDialog());
            if (userClickedOK == true)
            {
                // Open the selected file to read.
                string fileStream = openFileDialog1.FileName;

                textBox1.Text = fileStream;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog()
            {
                Description = "Your favorite music's directory",
                ShowNewFolderButton = false
            };
            // Call the ShowDialog method to show the dialog box.
            bool? userClickedOK = Convert.ToBoolean(folderBrowser.ShowDialog());
            if (userClickedOK == true)
            {
                // Open the selected file to read.
                string fileStream = folderBrowser.SelectedPath;

                textBox2.Text = fileStream;
            }
        }
        public string[] files;
        public int fileNum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            files = Directory.GetFiles(textBox2.Text);
            PlayAudio(files[fileNum]);
            label1.Text = Path.GetFileNameWithoutExtension(files[fileNum]);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            StopAudio();
            fileNum++;
            if (File.Exists(files[fileNum])) PlayAudio(files[fileNum]);
            label1.Text = Path.GetFileNameWithoutExtension(files[fileNum]);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            StopAudio();
            fileNum--;
            if (File.Exists(files[fileNum])) PlayAudio(files[fileNum]);
            label1.Text = Path.GetFileNameWithoutExtension(files[fileNum]);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel5.Enabled = !panel5.Enabled;
            panel5.Visible = !panel5.Visible;
        }

        public void pictureBox13_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point lastPoint2;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.panel2.Left += e.X - lastPoint2.X; this.panel2.Top += e.Y - lastPoint2.Y; }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }
        Point lastPoint3;
        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.panel5.Left += e.X - lastPoint3.X; this.panel5.Top += e.Y - lastPoint3.Y; }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint3 = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        }

        WaveOutEvent waveOutDevice = new WaveOutEvent();
        FadeInOutSampleProvider fade;
        AudioFileReader audio;

        private void PlayAudio(String path)
        {
            audio = new AudioFileReader(path);
            fade = new FadeInOutSampleProvider(audio, true);
            fade.BeginFadeIn(2000);
            //var waveOutDevice = new WaveOutEvent();
            waveOutDevice.Init(fade);
            waveOutDevice.Play();
            if (audio.Position >= audio.Length)
            {
                fade.BeginFadeOut(2000);
                waveOutDevice.Stop();
            }
        }
        private void StopAudio()
        {
            fade.BeginFadeOut(2000);
            waveOutDevice.Stop();
            label1.Text = "Let's listen something!";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            PlayAudio(textBox1.Text);
            label1.Text = Path.GetFileNameWithoutExtension(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StopAudio();
        }
        private void button5_Click(object sender, EventArgs e) => StopAudio();

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}