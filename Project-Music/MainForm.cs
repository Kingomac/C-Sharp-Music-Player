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
            CheckConfigFile();
            SetLangAsync();
        }
        private async void SetLangAsync()
        {
            string[] w = await Language.GetTexts(await Language.ReadConfFile());
            #region Set
            TitleLabel.Text = w[0];
            PlaySingleButton.Text = w[1];
            PlayDirectoryButton.Text = w[2];
            //_randomtext = w[0, 3];
            MoreAbout.Text = w[4];
            SettingsButton.Text = w[5];
            PlayButton.ButtonText = w[6];
            StopButton.ButtonText = w[7];
            PauseButton.ButtonText = w[8];
            NextButton.ButtonText = w[9];
            PreviousButton.ButtonText = w[10];
            #endregion
        }
        private async void CheckConfigFile()
        {
            if (File.Exists("config.ini"))
            {
                StreamReader r = new StreamReader("config.ini");
                FadeLenght = Convert.ToInt32(await r.ReadLineAsync());
                timer.Interval = Convert.ToInt32(await r.ReadLineAsync());
                r.Close();
            }
            else { await ConfigFile.CreateDefault(); }
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
        bool IsPlaying { get; set; }
        int FadeLenght { get; set; }
        public static string FilePath { get; set; }
        int FileNum { get; set; }
        string[] Files { get; set; }
        int PlayingMeth { get; set; }
        WaveOutEvent waveOutDevice = new WaveOutEvent();
        FadeInOutSampleProvider fade;
        AudioFileReader audio = null;
        Timer timer = new Timer();
        Timer afterfade = new Timer();
        private bool _fadeMade;
        #endregion
        private void StopAudio()
        {
            RandomCheckBox.Visible = false;
            RandomLabel.Visible = false;
            RepeatCheckbox.Visible = false;
            RepeatLabel.Visible = false;
            try
            {
                timer.Stop();
                if (IsPlaying && !_fadeMade)
                {
                    fade.BeginFadeOut(FadeLenght);
                    _fadeMade = true;
                }
                waveOutDevice.Stop();
                TitleLabel.Text = "Let's listen your favourite songs!";
                TimeLabel.Text = "0:0:0 / 0:0:0";
                CoverPicture.Image = null;
                _position = 0;
            }
            catch {  }
        }
        private void PlayAudio()
        {
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
                catch { FilePath = null; }
        }

        private void Afterfade_Tick(object sender, EventArgs e)
        {
            audio.Dispose();
            waveOutDevice.Dispose();
            afterfade.Stop();
            afterfade.Dispose();
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
            if (audio.Position >= audio.Length && PlayingMeth == 2)
            {
                if (RepeatCheckbox.Checked) { PlayAudio(); }
                else { NextPrevPlay(true); }
            }
            if (audio.Position >= audio.Length && PlayingMeth == 1)
            {
                if (RepeatCheckbox.Checked) PlayAudio();
                StopAudio();
            }
        }
        private int _lastsong;
        private void NextPrevPlay(bool next/*true --> play next || false --> play previos*/)
        {
            StopAudio();
            if (!RandomCheckBox.Checked)
            {
                if (next) { FileNum++; }
                else { FileNum--; }
            }
            else
            {
                if (next)
                {
                    _lastsong = FileNum;
                    Random r = new Random();
                    FileNum = r.Next(0, Files.Length);
                }
                else FileNum = _lastsong;
            }
            PlayAudioDirectory(Files);
            RandomCheckBox.Visible = true;
            RandomLabel.Visible = true;
            RepeatCheckbox.Visible = true;
            RepeatLabel.Visible = true;
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
                _fadeMade = false;
                FilePath = path[FileNum];
            }
            catch
            {
                FileNum++;
                PlayAudioDirectory(Files);
            }
        }
        Timer timer2 = new Timer();
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopAudio();
            afterfade.Interval = FadeLenght;
            afterfade.Start();
            afterfade.Tick += Afterfade_Tick;
        }

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
                FileNum = 0;
                try { Files = Directory.GetFiles(fileStream); PlayAudioDirectory(Files); }
                catch { Files = null; }
            }
            #endregion 
            RandomCheckBox.Visible = true;
            RandomLabel.Visible = true;
            RepeatCheckbox.Visible = true;
            RepeatLabel.Visible = true;
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
                if (!_fadeMade)
                {
                    fade.BeginFadeOut(FadeLenght);
                    _fadeMade = true;
                }
                waveOutDevice.Stop();
                IsPlaying = false;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(PlayingMeth == 2) PlayAudioDirectory(Files);
            else if (PlayingMeth == 1)
            {
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
                catch { FilePath = null; }
            }
            audio.Position = _position;
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

        private void MainForm_Leave(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LyricsText.Text = TagControl.GetLyrics(FilePath);
        }
    }
}
