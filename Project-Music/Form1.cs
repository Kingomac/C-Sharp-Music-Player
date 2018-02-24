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
using System.Windows.Input;


namespace Project_Music
{
    public partial class Form1 : Form
    {
        public bool isPlaying = false;
        public double fadeLenght;
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("config.ini"))
            {
                ConfigFile.ClearAll();
            }
            StreamReader reader = new StreamReader("config.ini");
            fadeLenght = Convert.ToDouble(reader.ReadLine());
            string color = reader.ReadLine();
            reader.Close();
            if(color == "Dark")
            {
                //Paneles
                panel1.BackColor = Color.FromArgb(28, 28, 28);
                panel2.BackColor = Color.FromArgb(28, 28, 28);
                panel4.BackColor = Color.FromArgb(28, 28, 28);
                panel5.BackColor = Color.FromArgb(28, 28, 28);
                panel3.BackColor = Color.FromArgb(28, 28, 28);
                //Pictures background
                pictureBox11.BackColor = Color.FromArgb(28, 28, 28);
                pictureBox10.BackColor = Color.FromArgb(28, 28, 28);
                //Form backcolor
                this.BackColor = Color.FromArgb(37, 37, 38);
                //Textbox
                textBox1.BackColor = Color.FromArgb(63, 63, 70);
                textBox2.BackColor = Color.FromArgb(63, 63, 70);
                //Buttons backcolor
                button1.BackColor = Color.FromArgb(45, 45, 48);
                button3.BackColor = Color.FromArgb(45, 45, 48);
                button4.BackColor = Color.FromArgb(45, 45, 48);
                button5.BackColor = Color.FromArgb(45, 45, 48);
                button6.BackColor = Color.FromArgb(45, 45, 48);
                button7.BackColor = Color.FromArgb(45, 45, 48);
                button9.BackColor = Color.FromArgb(45, 45, 48);
                button10.BackColor = Color.FromArgb(45, 45, 48);
                //Buttons forecolor
                button1.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                button5.ForeColor = Color.White;
                button6.ForeColor = Color.White;
                button7.ForeColor = Color.White;
                button9.ForeColor = Color.White;
                button10.ForeColor = Color.White;
            }
            else if(color == "Blue")
            {
                //Paneles
                panel1.BackColor = Color.FromArgb(16, 71, 166);
                panel2.BackColor = Color.FromArgb(16, 71, 166);
                panel4.BackColor = Color.FromArgb(16, 71, 166);
                panel5.BackColor = Color.FromArgb(16, 71, 166);
                panel3.BackColor = Color.FromArgb(16, 71, 166);
                //Pictures background
                pictureBox11.BackColor = Color.FromArgb(16, 71, 166);
                pictureBox10.BackColor = Color.FromArgb(16, 71, 166);
                //Form backcolor
                this.BackColor = Color.WhiteSmoke;
                //Textbox
                ///backcolor
                textBox1.BackColor = Color.WhiteSmoke;
                textBox2.BackColor = Color.WhiteSmoke;
                ///forecolor
                textBox1.ForeColor = Color.FromArgb(16, 71, 166);
                textBox2.ForeColor = Color.FromArgb(16, 71, 166);
                //Buttons backcolor
                button1.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
                button10.BackColor = Color.WhiteSmoke;
                //Buttons forecolor
                button1.ForeColor = Color.FromArgb(16, 71, 166);
                button3.ForeColor = Color.FromArgb(16, 71, 166);
                button4.ForeColor = Color.FromArgb(16, 71, 166);
                button5.ForeColor = Color.FromArgb(16, 71, 166);
                button6.ForeColor = Color.FromArgb(16, 71, 166);
                button7.ForeColor = Color.FromArgb(16, 71, 166);
                button9.ForeColor = Color.FromArgb(16, 71, 166);
                button10.ForeColor = Color.FromArgb(16, 71, 166);
            }
            else if (color == "Orange")
            {
                //Paneles
                panel1.BackColor = Color.FromArgb(252, 143, 0);
                panel2.BackColor = Color.FromArgb(252, 143, 0);
                panel4.BackColor = Color.FromArgb(252, 143, 0);
                panel5.BackColor = Color.FromArgb(252, 143, 0);
                panel3.BackColor = Color.FromArgb(252, 143, 0);
                //Pictures background
                pictureBox11.BackColor = Color.FromArgb(252, 143, 0);
                pictureBox10.BackColor = Color.FromArgb(252, 143, 0);
                //Form backcolor
                this.BackColor = Color.FromArgb(255, 179, 81);
                //Textbox
                ///backcolor
                textBox1.BackColor = Color.FromArgb(255, 179, 81);
                textBox2.BackColor = Color.FromArgb(255, 179, 81);
                ///forecolor
                textBox1.ForeColor = Color.WhiteSmoke;
                textBox2.ForeColor = Color.WhiteSmoke;
                //Buttons backcolor
                button1.BackColor = Color.FromArgb(255, 179, 81);
                button3.BackColor = Color.FromArgb(255, 179, 81);
                button4.BackColor = Color.FromArgb(255, 179, 81);
                button5.BackColor = Color.FromArgb(255, 179, 81);
                button6.BackColor = Color.FromArgb(255, 179, 81);
                button7.BackColor = Color.FromArgb(255, 179, 81);
                button9.BackColor = Color.FromArgb(255, 179, 81);
                button10.BackColor = Color.FromArgb(255, 179, 81);
                //Buttons forecolor
                button1.ForeColor = Color.WhiteSmoke;
                button3.ForeColor = Color.WhiteSmoke;
                button4.ForeColor = Color.WhiteSmoke;
                button5.ForeColor = Color.WhiteSmoke;
                button6.ForeColor = Color.WhiteSmoke;
                button7.ForeColor = Color.WhiteSmoke;
                button9.ForeColor = Color.WhiteSmoke;
                button10.ForeColor = Color.WhiteSmoke;
            }

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
            PlayAudioDirectory(files);
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
        Timer timer = new Timer();
        private void PlayAudio(String path)
        {
            if ((Path.GetExtension(path) == ".mp3") || (Path.GetExtension(path) == ".wav" ))
            {
            audio = new AudioFileReader(path); 
            fade = new FadeInOutSampleProvider(audio, true);
            fade.BeginFadeIn(fadeLenght);
            var waveOutDevice = new WaveOutEvent();
           waveOutDevice.Init(fade);
           waveOutDevice.Play();
            if (audio.Position >= audio.Length)
                {
                    fade.BeginFadeOut(fadeLenght);
                    waveOutDevice.Stop();
                }
            }
            else
            {
                ErrorForms.Error error = new ErrorForms.Error(1);
                error.Show();
            }
            isPlaying = true;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            trackBar1.Maximum = Convert.ToInt32(audio.Length / 1000);
        }
        private void PlayAudioDirectory(String[] path)
        {
            audio = new AudioFileReader(path[fileNum]);
            fade = new FadeInOutSampleProvider(audio, true);
            fade.BeginFadeIn(fadeLenght);
            var waveOutDevice = new WaveOutEvent();
            waveOutDevice.Init(fade);
            waveOutDevice.Play();
            isPlaying = true;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            trackBar1.Maximum = Convert.ToInt32(audio.Length / 1000);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(audio.Position / 1000);
            if(isPlaying)   label3.Text = $"{audio.CurrentTime.Hours.ToString()}:{audio.CurrentTime.Minutes.ToString()}:{audio.CurrentTime.Seconds.ToString()} / {audio.TotalTime.Hours}:{audio.TotalTime.Minutes}:{audio.TotalTime.Seconds}";

        }
        private void PlayNext()
        {
            StopAudio();
            fileNum++;
            if (File.Exists(files[fileNum])) PlayAudio(files[fileNum]);
            label1.Text = Path.GetFileNameWithoutExtension(files[fileNum]);
        }
        Timer reloj = new Timer();
        private void StopAudio()
        {
            timer.Stop();
            fade.BeginFadeOut(fadeLenght);
            waveOutDevice.Stop();
            label1.Text = "Let's listen something!";
            label3.Text = "0:0:0 / 0:0:0";
            reloj.Interval = 10;
            reloj.Tick += new EventHandler(Reloj_Tick);
            reloj.Start();
        }
        private void PauseAudio()
        {
            position = audio.Position;
            timer.Stop();
            fade.BeginFadeOut(fadeLenght);
            waveOutDevice.Stop();
            //label1.Text = "Let's listen something!";
            //label3.Text = "0:0:0 / 0:0:0";
            //reloj.Interval = 10;
            //reloj.Tick += new EventHandler(Reloj_Tick);
            //reloj.Start();
        }
        private void Reloj_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value - 100 >= 100) trackBar1.Value -= 100;
            else reloj.Stop();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {
                PlayAudio(textBox1.Text);
                audio.Volume = 0.5f;
                trackBar1.Value = 50;
                label1.Text = Path.GetFileNameWithoutExtension(textBox1.Text);
            }
            else
            {
                ErrorForms.Error error = new ErrorForms.Error(0);
                error.Show();
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                audio.Position = 1000 * trackBar1.Value;
            }
        }
        public long position = 0;
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (isPlaying) PauseAudio();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            PlayAudio(textBox1.Text);
            audio.Position = position;
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                audio.Volume = VolumeTrackBar.Value / 100f;
            }
        }
    }
}