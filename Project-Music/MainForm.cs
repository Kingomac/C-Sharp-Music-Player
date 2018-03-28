using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.IO;
using System.Diagnostics;

namespace Project_Music
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader("config.ini");
            FadeLenght = Convert.ToInt32(reader.ReadLine());
            timer.Interval = Convert.ToInt32(reader.ReadLine());
            reader.Close();
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
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #region Properties and vars
        bool IsPlaying { get => _isPlaying; set => _isPlaying = value; }
        int FadeLenght { get; set; }
        public static string FilePath { get; set; }
        int FileNum { get; set; }
        string[] Files { get; set; }
        int PlayingMeth { get; set; }
        WaveOutEvent waveOutDevice = new WaveOutEvent();
        FadeInOutSampleProvider fade;
        AudioFileReader audio;
        Timer timer = new Timer();
        private bool _isPlaying;
        #endregion
        private void StopAudio()
        {
            //if (IsPlaying)
            try
            {
                timer.Stop();
                fade.BeginFadeOut(FadeLenght);
                waveOutDevice.Stop();
                TitleLabel.Text = "Let's listen your favourite songs!";
                TimeLabel.Text = "0:0:0 / 0:0:0";
                CoverPicture.Image = null;
                _position = 0;
            }
            catch { }
        }

        private void PlaySingleButton_Click(object sender, EventArgs e)
        {
            #region Select file
            // Create an instance of the open file dialog box.
            OpenFileDialog w = new OpenFileDialog
            {
                Filter = "Your favorite songs (*.mp3)|*.mp3|(*.wav)|*.wav|All files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = false
            };
            // Call the ShowDialog method to show the dialog box.
            bool? userClickedOK = Convert.ToBoolean(w.ShowDialog());
            if (userClickedOK == true)
            {
                // Open the selected file to read.
                string fileStream = w.FileName;

                FilePath = fileStream;
            }
            #endregion
            #region Play File
            if (IsPlaying) StopAudio();
            try
            {
                audio = new AudioFileReader(FilePath);
                fade = new FadeInOutSampleProvider(audio, true);
                fade.BeginFadeIn(FadeLenght);
                var waveOutDevice = new WaveOutEvent();
                waveOutDevice.Init(fade);
                waveOutDevice.Play();
                IsPlaying = true;
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Start();
                TimeTrackbar.MaximumValue = Convert.ToInt32(audio.Length / 1000);
                TagControl.GetCover(FilePath, CoverPicture);
                TitleLabel.Text = TagControl.GetName(FilePath);
                audio.Volume = 0.5f;
                VolumeTrackbar.Value = 50;
                PlayingMeth = 1;
            }
            catch{ FilePath = null;}
            #endregion
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeTrackbar.Value = Convert.ToInt32(audio.Position / 1000);
            if (IsPlaying) TimeLabel.Text = $"{audio.CurrentTime.Hours.ToString()}:{audio.CurrentTime.Minutes.ToString()}:{audio.CurrentTime.Seconds.ToString()} / {audio.TotalTime.Hours}:{audio.TotalTime.Minutes}:{audio.TotalTime.Seconds}";
            if (audio.Position >= audio.Length && PlayingMeth == 2) NextPrevPlay(true);
            else if (audio.Position > audio.Length && PlayingMeth == 1) StopAudio();
        }
        private void NextPrevPlay(bool next/*true --> play next || false --> play previos*/)
        {
            StopAudio();
            FileNum++;
            if (File.Exists(Files[FileNum])) PlayAudioDirectory(Files);
        }
        private void PlayAudioDirectory(string[] path)
        {
            if (IsPlaying) StopAudio();
            //if (Path.GetExtension(path[FileNum]) == ".mp3" || Path.GetExtension(path[FileNum]) == ".wav")
            try
            {
                audio = new AudioFileReader(path[FileNum]);
                fade = new FadeInOutSampleProvider(audio, true);
                fade.BeginFadeIn(FadeLenght);
                var waveOutDevice = new WaveOutEvent();
                waveOutDevice.Init(fade);
                waveOutDevice.Play();
                IsPlaying = true;
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Start();
                TimeTrackbar.MaximumValue = Convert.ToInt32(audio.Length / 1000);
                TagControl.GetCover(path[FileNum], CoverPicture);
                TitleLabel.Text = TagControl.GetName(path[FileNum]);
                audio.Volume = 0.5f;
                VolumeTrackbar.Value = 50;
                PlayingMeth = 2;
            }
            catch
            {
                FileNum++;
                PlayAudioDirectory(Files);
            }
        }

        private void StopButton_Click(object sender, EventArgs e) => StopAudio();

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (PlayingMeth == 2) NextPrevPlay(true);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (PlayingMeth == 2) NextPrevPlay(false);
        }

        private void PlayDirectoryButton_Click(object sender, EventArgs e)
        {
            #region Select folder
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

                Files = Directory.GetFiles(fileStream);
            }
            #endregion
            PlayAudioDirectory(Files);
        }

        private void TimeTrackbar_ValueChanged(object sender, EventArgs e)
        {
            if (IsPlaying) audio.Position = TimeTrackbar.Value * 1000;
        }

        private void VolumeTrackbar_ValueChanged(object sender, EventArgs e)
        {
            if (IsPlaying)
            {
                audio.Volume = (100 - VolumeTrackbar.Value) / 100f;
                if (VolumeTrackbar.Value == 0) audio.Volume = 1f;
                else if (VolumeTrackbar.Value == 100) audio.Volume = 0f;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            OptionsForm o = new OptionsForm();
            o.Show();
        }
        private long _position;
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (IsPlaying)
            {
                _position = audio.Position;
                timer.Stop();
                fade.BeginFadeOut(FadeLenght);
                waveOutDevice.Stop();
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            //if ((Path.GetExtension(FilePath) == ".mp3") || (Path.GetExtension(FilePath) == ".wav") && !IsPlaying)
            try
            {
                audio = new AudioFileReader(FilePath);
                fade = new FadeInOutSampleProvider(audio, true);
                fade.BeginFadeIn(FadeLenght);
                var waveOutDevice = new WaveOutEvent();
                waveOutDevice.Init(fade);
                waveOutDevice.Play();
                IsPlaying = true;
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Start();
                TimeTrackbar.MaximumValue = Convert.ToInt32(audio.Length / 1000);
                TagControl.GetCover(FilePath, CoverPicture);
                TitleLabel.Text = TagControl.GetName(FilePath);
                audio.Volume = 0.5f;
                VolumeTrackbar.Value = 50;
                PlayingMeth = 1;
                audio.Position = _position;
            }
            catch
            {
                ErrorForms.Error x = new ErrorForms.Error("You aren't playing anything", "First select a file a pause it. If it's a bug, please make the developers know it.");
                x.ShowDialog();
            }
        }

        private void MoreAbout_Click(object sender, EventArgs e)
        {
            //if(FilePath != null)
            try
            {
                AboutTags w = new AboutTags();
                w.Show();
            }
            catch
            {
                ErrorForms.Error x = new ErrorForms.Error("You're playing any file", "When you're playing a file and after stop it you can see its tags");
                x.ShowDialog();
            }
        }
    }
}
