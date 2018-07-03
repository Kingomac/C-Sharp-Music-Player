namespace Project_Music
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TimeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TitleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.VolumeTrackbar = new Bunifu.Framework.UI.BunifuVTrackbar();
            this.TimeTrackbar = new Bunifu.Framework.UI.BunifuVTrackbar();
            this.NextButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PreviousButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PauseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.StopButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PlayButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CoverPicture = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.RandomCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.RandomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.ImageTab = new MetroFramework.Controls.MetroTabPage();
            this.OptionsTab = new MetroFramework.Controls.MetroTabPage();
            this.RepeatCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.RepeatLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MoreAboutTab = new MetroFramework.Controls.MetroTabPage();
            this.GeneralPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TrackTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.YearTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TitleTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BitrateTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.FreqTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.LengthTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.GenreTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.AlbumTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.AuthorTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AuthorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LyricsTab = new MetroFramework.Controls.MetroTabPage();
            this.LyricsRighText = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PlaySingleButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlayDirectoryButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PathTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).BeginInit();
            this.TabControl.SuspendLayout();
            this.ImageTab.SuspendLayout();
            this.OptionsTab.SuspendLayout();
            this.MoreAboutTab.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.LyricsTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.TimeLabel.Location = new System.Drawing.Point(5, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(87, 18);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "0:0:0 / 0:0:0";
            this.TimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.TimeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.TitleLabel.Location = new System.Drawing.Point(113, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(378, 18);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Let\'s listen your favourite songs!";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveBorderThickness = 1;
            this.CloseButton.ActiveCornerRadius = 20;
            this.CloseButton.ActiveFillColor = System.Drawing.Color.White;
            this.CloseButton.ActiveForecolor = System.Drawing.Color.Fuchsia;
            this.CloseButton.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.CloseButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.ButtonText = "X";
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.IdleBorderThickness = 1;
            this.CloseButton.IdleCornerRadius = 20;
            this.CloseButton.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.CloseButton.IdleForecolor = System.Drawing.Color.White;
            this.CloseButton.IdleLineColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(552, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 37);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.ActiveBorderThickness = 1;
            this.MinimizeButton.ActiveCornerRadius = 20;
            this.MinimizeButton.ActiveFillColor = System.Drawing.Color.White;
            this.MinimizeButton.ActiveForecolor = System.Drawing.Color.Fuchsia;
            this.MinimizeButton.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.MinimizeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.ButtonText = "_";
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.IdleBorderThickness = 1;
            this.MinimizeButton.IdleCornerRadius = 20;
            this.MinimizeButton.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.MinimizeButton.IdleForecolor = System.Drawing.Color.White;
            this.MinimizeButton.IdleLineColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(504, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(48, 37);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // VolumeTrackbar
            // 
            this.VolumeTrackbar.BackColor = System.Drawing.Color.Transparent;
            this.VolumeTrackbar.BackgroudColor = System.Drawing.Color.LightBlue;
            this.VolumeTrackbar.BorderRadius = 0;
            this.VolumeTrackbar.IndicatorColor = System.Drawing.Color.Fuchsia;
            this.VolumeTrackbar.Location = new System.Drawing.Point(208, 44);
            this.VolumeTrackbar.MaximumValue = 100;
            this.VolumeTrackbar.Name = "VolumeTrackbar";
            this.VolumeTrackbar.Size = new System.Drawing.Size(30, 482);
            this.VolumeTrackbar.SliderRadius = 0;
            this.VolumeTrackbar.TabIndex = 4;
            this.VolumeTrackbar.Value = 50;
            this.VolumeTrackbar.ValueChanged += new System.EventHandler(this.VolumeTrackbar_ValueChanged);
            // 
            // TimeTrackbar
            // 
            this.TimeTrackbar.BackColor = System.Drawing.Color.Transparent;
            this.TimeTrackbar.BackgroudColor = System.Drawing.Color.LightBlue;
            this.TimeTrackbar.BorderRadius = 0;
            this.TimeTrackbar.IndicatorColor = System.Drawing.Color.Fuchsia;
            this.TimeTrackbar.Location = new System.Drawing.Point(763, 44);
            this.TimeTrackbar.MaximumValue = 100;
            this.TimeTrackbar.Name = "TimeTrackbar";
            this.TimeTrackbar.Size = new System.Drawing.Size(30, 482);
            this.TimeTrackbar.SliderRadius = 0;
            this.TimeTrackbar.TabIndex = 5;
            this.TimeTrackbar.Value = 0;
            this.TimeTrackbar.ValueChanged += new System.EventHandler(this.TimeTrackbar_ValueChanged);
            // 
            // NextButton
            // 
            this.NextButton.ActiveBorderThickness = 1;
            this.NextButton.ActiveCornerRadius = 20;
            this.NextButton.ActiveFillColor = System.Drawing.Color.White;
            this.NextButton.ActiveForecolor = System.Drawing.Color.Fuchsia;
            this.NextButton.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.NextButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextButton.BackgroundImage")));
            this.NextButton.ButtonText = "Next";
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.IdleBorderThickness = 1;
            this.NextButton.IdleCornerRadius = 20;
            this.NextButton.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.NextButton.IdleForecolor = System.Drawing.Color.White;
            this.NextButton.IdleLineColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(681, 456);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(84, 37);
            this.NextButton.TabIndex = 11;
            this.NextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.ActiveBorderThickness = 1;
            this.PreviousButton.ActiveCornerRadius = 20;
            this.PreviousButton.ActiveFillColor = System.Drawing.Color.White;
            this.PreviousButton.ActiveForecolor = System.Drawing.Color.Fuchsia;
            this.PreviousButton.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.PreviousButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PreviousButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviousButton.BackgroundImage")));
            this.PreviousButton.ButtonText = "Previous";
            this.PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton.ForeColor = System.Drawing.Color.White;
            this.PreviousButton.IdleBorderThickness = 1;
            this.PreviousButton.IdleCornerRadius = 20;
            this.PreviousButton.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.PreviousButton.IdleForecolor = System.Drawing.Color.White;
            this.PreviousButton.IdleLineColor = System.Drawing.Color.White;
            this.PreviousButton.Location = new System.Drawing.Point(589, 456);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(84, 37);
            this.PreviousButton.TabIndex = 10;
            this.PreviousButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.ActiveBorderThickness = 1;
            this.PauseButton.ActiveCornerRadius = 20;
            this.PauseButton.ActiveFillColor = System.Drawing.Color.White;
            this.PauseButton.ActiveForecolor = System.Drawing.Color.Fuchsia;
            this.PauseButton.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.PauseButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseButton.BackgroundImage")));
            this.PauseButton.ButtonText = "Pause";
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.ForeColor = System.Drawing.Color.White;
            this.PauseButton.IdleBorderThickness = 1;
            this.PauseButton.IdleCornerRadius = 20;
            this.PauseButton.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.PauseButton.IdleForecolor = System.Drawing.Color.White;
            this.PauseButton.IdleLineColor = System.Drawing.Color.White;
            this.PauseButton.Location = new System.Drawing.Point(472, 456);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(109, 37);
            this.PauseButton.TabIndex = 9;
            this.PauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.ActiveBorderThickness = 1;
            this.StopButton.ActiveCornerRadius = 20;
            this.StopButton.ActiveFillColor = System.Drawing.Color.White;
            this.StopButton.ActiveForecolor = System.Drawing.Color.Fuchsia;
            this.StopButton.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.StopButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopButton.BackgroundImage")));
            this.StopButton.ButtonText = "Stop";
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.IdleBorderThickness = 1;
            this.StopButton.IdleCornerRadius = 20;
            this.StopButton.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.StopButton.IdleForecolor = System.Drawing.Color.White;
            this.StopButton.IdleLineColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(355, 456);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(109, 37);
            this.StopButton.TabIndex = 8;
            this.StopButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.ActiveBorderThickness = 1;
            this.PlayButton.ActiveCornerRadius = 20;
            this.PlayButton.ActiveFillColor = System.Drawing.Color.White;
            this.PlayButton.ActiveForecolor = System.Drawing.Color.Fuchsia;
            this.PlayButton.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.PlayButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.ButtonText = "Play!";
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.IdleBorderThickness = 1;
            this.PlayButton.IdleCornerRadius = 20;
            this.PlayButton.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.PlayButton.IdleForecolor = System.Drawing.Color.White;
            this.PlayButton.IdleLineColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(238, 456);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(109, 37);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // CoverPicture
            // 
            this.CoverPicture.Location = new System.Drawing.Point(50, 0);
            this.CoverPicture.Name = "CoverPicture";
            this.CoverPicture.Size = new System.Drawing.Size(370, 370);
            this.CoverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoverPicture.TabIndex = 2;
            this.CoverPicture.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(200, 532);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(593, 10);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuSeparator1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.bunifuSeparator3.LineThickness = 4;
            this.bunifuSeparator3.Location = new System.Drawing.Point(790, 0);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(10, 542);
            this.bunifuSeparator3.TabIndex = 13;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            this.bunifuSeparator3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuSeparator3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // RandomCheckBox
            // 
            this.RandomCheckBox.BackColor = System.Drawing.Color.Fuchsia;
            this.RandomCheckBox.ChechedOffColor = System.Drawing.Color.LightCyan;
            this.RandomCheckBox.Checked = true;
            this.RandomCheckBox.CheckedOnColor = System.Drawing.Color.Fuchsia;
            this.RandomCheckBox.ForeColor = System.Drawing.Color.White;
            this.RandomCheckBox.Location = new System.Drawing.Point(12, 46);
            this.RandomCheckBox.Name = "RandomCheckBox";
            this.RandomCheckBox.Size = new System.Drawing.Size(20, 20);
            this.RandomCheckBox.TabIndex = 14;
            this.RandomCheckBox.Visible = false;
            // 
            // RandomLabel
            // 
            this.RandomLabel.AutoSize = true;
            this.RandomLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.RandomLabel.Location = new System.Drawing.Point(38, 46);
            this.RandomLabel.Name = "RandomLabel";
            this.RandomLabel.Size = new System.Drawing.Size(115, 20);
            this.RandomLabel.TabIndex = 15;
            this.RandomLabel.Text = "Random songs";
            this.RandomLabel.Visible = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ImageTab);
            this.TabControl.Controls.Add(this.OptionsTab);
            this.TabControl.Controls.Add(this.MoreAboutTab);
            this.TabControl.Controls.Add(this.LyricsTab);
            this.TabControl.Location = new System.Drawing.Point(244, 45);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(499, 413);
            this.TabControl.TabIndex = 17;
            this.TabControl.UseCustomBackColor = true;
            this.TabControl.UseCustomForeColor = true;
            this.TabControl.UseSelectable = true;
            this.TabControl.UseStyleColors = true;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // ImageTab
            // 
            this.ImageTab.BackColor = System.Drawing.Color.LightBlue;
            this.ImageTab.Controls.Add(this.CoverPicture);
            this.ImageTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageTab.ForeColor = System.Drawing.Color.Crimson;
            this.ImageTab.HorizontalScrollbarBarColor = true;
            this.ImageTab.HorizontalScrollbarHighlightOnWheel = true;
            this.ImageTab.HorizontalScrollbarSize = 10;
            this.ImageTab.Location = new System.Drawing.Point(4, 38);
            this.ImageTab.Name = "ImageTab";
            this.ImageTab.Size = new System.Drawing.Size(491, 371);
            this.ImageTab.TabIndex = 0;
            this.ImageTab.Text = "Art Cover";
            this.ImageTab.UseCustomBackColor = true;
            this.ImageTab.UseCustomForeColor = true;
            this.ImageTab.UseStyleColors = true;
            this.ImageTab.VerticalScrollbar = true;
            this.ImageTab.VerticalScrollbarBarColor = true;
            this.ImageTab.VerticalScrollbarHighlightOnWheel = true;
            this.ImageTab.VerticalScrollbarSize = 10;
            // 
            // OptionsTab
            // 
            this.OptionsTab.BackColor = System.Drawing.Color.LightBlue;
            this.OptionsTab.Controls.Add(this.RepeatCheckbox);
            this.OptionsTab.Controls.Add(this.RepeatLabel);
            this.OptionsTab.Controls.Add(this.RandomCheckBox);
            this.OptionsTab.Controls.Add(this.RandomLabel);
            this.OptionsTab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OptionsTab.HorizontalScrollbarBarColor = true;
            this.OptionsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.OptionsTab.HorizontalScrollbarSize = 10;
            this.OptionsTab.Location = new System.Drawing.Point(4, 38);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Size = new System.Drawing.Size(491, 371);
            this.OptionsTab.TabIndex = 1;
            this.OptionsTab.Text = "Options";
            this.OptionsTab.UseCustomBackColor = true;
            this.OptionsTab.UseCustomForeColor = true;
            this.OptionsTab.UseStyleColors = true;
            this.OptionsTab.UseVisualStyleBackColor = true;
            this.OptionsTab.VerticalScrollbarBarColor = true;
            this.OptionsTab.VerticalScrollbarHighlightOnWheel = true;
            this.OptionsTab.VerticalScrollbarSize = 10;
            // 
            // RepeatCheckbox
            // 
            this.RepeatCheckbox.BackColor = System.Drawing.Color.Fuchsia;
            this.RepeatCheckbox.ChechedOffColor = System.Drawing.Color.LightCyan;
            this.RepeatCheckbox.Checked = true;
            this.RepeatCheckbox.CheckedOnColor = System.Drawing.Color.Fuchsia;
            this.RepeatCheckbox.ForeColor = System.Drawing.Color.White;
            this.RepeatCheckbox.Location = new System.Drawing.Point(12, 18);
            this.RepeatCheckbox.Name = "RepeatCheckbox";
            this.RepeatCheckbox.Size = new System.Drawing.Size(20, 20);
            this.RepeatCheckbox.TabIndex = 16;
            // 
            // RepeatLabel
            // 
            this.RepeatLabel.AutoSize = true;
            this.RepeatLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.RepeatLabel.Location = new System.Drawing.Point(38, 18);
            this.RepeatLabel.Name = "RepeatLabel";
            this.RepeatLabel.Size = new System.Drawing.Size(102, 20);
            this.RepeatLabel.TabIndex = 17;
            this.RepeatLabel.Text = "Repeat song";
            // 
            // MoreAboutTab
            // 
            this.MoreAboutTab.BackColor = System.Drawing.Color.LightBlue;
            this.MoreAboutTab.Controls.Add(this.GeneralPanel);
            this.MoreAboutTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreAboutTab.ForeColor = System.Drawing.Color.Fuchsia;
            this.MoreAboutTab.HorizontalScrollbarBarColor = true;
            this.MoreAboutTab.HorizontalScrollbarHighlightOnWheel = false;
            this.MoreAboutTab.HorizontalScrollbarSize = 10;
            this.MoreAboutTab.Location = new System.Drawing.Point(4, 38);
            this.MoreAboutTab.Name = "MoreAboutTab";
            this.MoreAboutTab.Size = new System.Drawing.Size(491, 371);
            this.MoreAboutTab.TabIndex = 2;
            this.MoreAboutTab.Text = "More About this song";
            this.MoreAboutTab.VerticalScrollbarBarColor = true;
            this.MoreAboutTab.VerticalScrollbarHighlightOnWheel = false;
            this.MoreAboutTab.VerticalScrollbarSize = 10;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeneralPanel.BackgroundImage")));
            this.GeneralPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeneralPanel.Controls.Add(this.TrackTextbox);
            this.GeneralPanel.Controls.Add(this.YearTextbox);
            this.GeneralPanel.Controls.Add(this.TitleTextbox);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel9);
            this.GeneralPanel.Controls.Add(this.BitrateTextbox);
            this.GeneralPanel.Controls.Add(this.FreqTextbox);
            this.GeneralPanel.Controls.Add(this.LengthTextbox);
            this.GeneralPanel.Controls.Add(this.GenreTextbox);
            this.GeneralPanel.Controls.Add(this.AlbumTextbox);
            this.GeneralPanel.Controls.Add(this.AuthorTextbox);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel8);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel7);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel6);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel5);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel4);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel3);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel2);
            this.GeneralPanel.Controls.Add(this.AuthorLabel);
            this.GeneralPanel.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.GeneralPanel.GradientBottomRight = System.Drawing.Color.LightSkyBlue;
            this.GeneralPanel.GradientTopLeft = System.Drawing.Color.Azure;
            this.GeneralPanel.GradientTopRight = System.Drawing.Color.Fuchsia;
            this.GeneralPanel.Location = new System.Drawing.Point(3, 0);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Quality = 10;
            this.GeneralPanel.Size = new System.Drawing.Size(488, 370);
            this.GeneralPanel.TabIndex = 4;
            // 
            // TrackTextbox
            // 
            this.TrackTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.TrackTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.TrackTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.TrackTextbox.Location = new System.Drawing.Point(345, 142);
            this.TrackTextbox.Name = "TrackTextbox";
            this.TrackTextbox.ReadOnly = true;
            this.TrackTextbox.Size = new System.Drawing.Size(113, 22);
            this.TrackTextbox.TabIndex = 36;
            this.TrackTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YearTextbox
            // 
            this.YearTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.YearTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.YearTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.YearTextbox.Location = new System.Drawing.Point(79, 145);
            this.YearTextbox.Name = "YearTextbox";
            this.YearTextbox.ReadOnly = true;
            this.YearTextbox.Size = new System.Drawing.Size(113, 22);
            this.YearTextbox.TabIndex = 35;
            this.YearTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.TitleTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.TitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.TitleTextbox.Location = new System.Drawing.Point(79, 6);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.ReadOnly = true;
            this.TitleTextbox.Size = new System.Drawing.Size(379, 22);
            this.TitleTextbox.TabIndex = 30;
            this.TitleTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(14, 6);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel9.TabIndex = 34;
            this.bunifuCustomLabel9.Text = "Title:";
            // 
            // BitrateTextbox
            // 
            this.BitrateTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.BitrateTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.BitrateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitrateTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.BitrateTextbox.Location = new System.Drawing.Point(79, 330);
            this.BitrateTextbox.Name = "BitrateTextbox";
            this.BitrateTextbox.ReadOnly = true;
            this.BitrateTextbox.Size = new System.Drawing.Size(379, 22);
            this.BitrateTextbox.TabIndex = 33;
            this.BitrateTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FreqTextbox
            // 
            this.FreqTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.FreqTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.FreqTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreqTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.FreqTextbox.Location = new System.Drawing.Point(79, 283);
            this.FreqTextbox.Name = "FreqTextbox";
            this.FreqTextbox.ReadOnly = true;
            this.FreqTextbox.Size = new System.Drawing.Size(379, 22);
            this.FreqTextbox.TabIndex = 32;
            this.FreqTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LengthTextbox
            // 
            this.LengthTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.LengthTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.LengthTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.LengthTextbox.Location = new System.Drawing.Point(79, 235);
            this.LengthTextbox.Name = "LengthTextbox";
            this.LengthTextbox.ReadOnly = true;
            this.LengthTextbox.Size = new System.Drawing.Size(379, 22);
            this.LengthTextbox.TabIndex = 31;
            this.LengthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.GenreTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.GenreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.GenreTextbox.Location = new System.Drawing.Point(79, 190);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.ReadOnly = true;
            this.GenreTextbox.Size = new System.Drawing.Size(379, 22);
            this.GenreTextbox.TabIndex = 29;
            this.GenreTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AlbumTextbox
            // 
            this.AlbumTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.AlbumTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.AlbumTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.AlbumTextbox.Location = new System.Drawing.Point(79, 98);
            this.AlbumTextbox.Name = "AlbumTextbox";
            this.AlbumTextbox.ReadOnly = true;
            this.AlbumTextbox.Size = new System.Drawing.Size(379, 22);
            this.AlbumTextbox.TabIndex = 28;
            this.AlbumTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.AuthorTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.AuthorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.AuthorTextbox.Location = new System.Drawing.Point(79, 50);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.ReadOnly = true;
            this.AuthorTextbox.Size = new System.Drawing.Size(379, 22);
            this.AuthorTextbox.TabIndex = 27;
            this.AuthorTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(14, 330);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel8.TabIndex = 23;
            this.bunifuCustomLabel8.Text = "Bitrate:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(14, 283);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel7.TabIndex = 21;
            this.bunifuCustomLabel7.Text = "Frequ:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(14, 235);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel6.TabIndex = 19;
            this.bunifuCustomLabel6.Text = "Length:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(14, 190);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel5.TabIndex = 17;
            this.bunifuCustomLabel5.Text = "Genre:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(268, 142);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 33);
            this.bunifuCustomLabel4.TabIndex = 15;
            this.bunifuCustomLabel4.Text = "Track:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(14, 142);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(69, 33);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Year:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(14, 98);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "Album:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.AuthorLabel.Location = new System.Drawing.Point(14, 50);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(79, 33);
            this.AuthorLabel.TabIndex = 7;
            this.AuthorLabel.Text = "Author: ";
            // 
            // LyricsTab
            // 
            this.LyricsTab.Controls.Add(this.LyricsRighText);
            this.LyricsTab.HorizontalScrollbarBarColor = true;
            this.LyricsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.LyricsTab.HorizontalScrollbarSize = 10;
            this.LyricsTab.Location = new System.Drawing.Point(4, 38);
            this.LyricsTab.Name = "LyricsTab";
            this.LyricsTab.Size = new System.Drawing.Size(491, 371);
            this.LyricsTab.TabIndex = 3;
            this.LyricsTab.Text = "Lyrics";
            this.LyricsTab.VerticalScrollbarBarColor = true;
            this.LyricsTab.VerticalScrollbarHighlightOnWheel = false;
            this.LyricsTab.VerticalScrollbarSize = 10;
            // 
            // LyricsRighText
            // 
            this.LyricsRighText.BackColor = System.Drawing.Color.LightBlue;
            this.LyricsRighText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LyricsRighText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LyricsRighText.ForeColor = System.Drawing.Color.Fuchsia;
            this.LyricsRighText.Location = new System.Drawing.Point(3, 3);
            this.LyricsRighText.Name = "LyricsRighText";
            this.LyricsRighText.Size = new System.Drawing.Size(485, 365);
            this.LyricsRighText.TabIndex = 2;
            this.LyricsRighText.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 94);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("CL EvoluFont", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(196, 78);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "C#Music\r\n     Player";
            this.bunifuCustomLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuCustomLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.PlaySingleButton);
            this.bunifuGradientPanel1.Controls.Add(this.SettingsButton);
            this.bunifuGradientPanel1.Controls.Add(this.PlayDirectoryButton);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightSkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Azure;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(202, 542);
            this.bunifuGradientPanel1.TabIndex = 37;
            // 
            // PlaySingleButton
            // 
            this.PlaySingleButton.Activecolor = System.Drawing.Color.Fuchsia;
            this.PlaySingleButton.BackColor = System.Drawing.Color.Fuchsia;
            this.PlaySingleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaySingleButton.BorderRadius = 0;
            this.PlaySingleButton.ButtonText = "Play single file";
            this.PlaySingleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlaySingleButton.DisabledColor = System.Drawing.Color.Gray;
            this.PlaySingleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaySingleButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PlaySingleButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("PlaySingleButton.Iconimage")));
            this.PlaySingleButton.Iconimage_right = null;
            this.PlaySingleButton.Iconimage_right_Selected = null;
            this.PlaySingleButton.Iconimage_Selected = null;
            this.PlaySingleButton.IconMarginLeft = 0;
            this.PlaySingleButton.IconMarginRight = 0;
            this.PlaySingleButton.IconRightVisible = true;
            this.PlaySingleButton.IconRightZoom = 0D;
            this.PlaySingleButton.IconVisible = true;
            this.PlaySingleButton.IconZoom = 88D;
            this.PlaySingleButton.IsTab = false;
            this.PlaySingleButton.Location = new System.Drawing.Point(0, 101);
            this.PlaySingleButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PlaySingleButton.Name = "PlaySingleButton";
            this.PlaySingleButton.Normalcolor = System.Drawing.Color.Fuchsia;
            this.PlaySingleButton.OnHovercolor = System.Drawing.Color.Magenta;
            this.PlaySingleButton.OnHoverTextColor = System.Drawing.Color.White;
            this.PlaySingleButton.selected = false;
            this.PlaySingleButton.Size = new System.Drawing.Size(203, 55);
            this.PlaySingleButton.TabIndex = 2;
            this.PlaySingleButton.Text = "Play single file";
            this.PlaySingleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlaySingleButton.Textcolor = System.Drawing.Color.White;
            this.PlaySingleButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaySingleButton.Click += new System.EventHandler(this.PlaySingleButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Activecolor = System.Drawing.Color.Fuchsia;
            this.SettingsButton.BackColor = System.Drawing.Color.Fuchsia;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.BorderRadius = 0;
            this.SettingsButton.ButtonText = "Settings";
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SettingsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Iconimage")));
            this.SettingsButton.Iconimage_right = null;
            this.SettingsButton.Iconimage_right_Selected = null;
            this.SettingsButton.Iconimage_Selected = null;
            this.SettingsButton.IconMarginLeft = 0;
            this.SettingsButton.IconMarginRight = 0;
            this.SettingsButton.IconRightVisible = true;
            this.SettingsButton.IconRightZoom = 0D;
            this.SettingsButton.IconVisible = true;
            this.SettingsButton.IconZoom = 85D;
            this.SettingsButton.IsTab = false;
            this.SettingsButton.Location = new System.Drawing.Point(0, 487);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Normalcolor = System.Drawing.Color.Fuchsia;
            this.SettingsButton.OnHovercolor = System.Drawing.Color.Magenta;
            this.SettingsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingsButton.selected = false;
            this.SettingsButton.Size = new System.Drawing.Size(203, 55);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Textcolor = System.Drawing.Color.White;
            this.SettingsButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PlayDirectoryButton
            // 
            this.PlayDirectoryButton.Activecolor = System.Drawing.Color.Fuchsia;
            this.PlayDirectoryButton.BackColor = System.Drawing.Color.Fuchsia;
            this.PlayDirectoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayDirectoryButton.BorderRadius = 0;
            this.PlayDirectoryButton.ButtonText = "Play directory";
            this.PlayDirectoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayDirectoryButton.DisabledColor = System.Drawing.Color.Gray;
            this.PlayDirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayDirectoryButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PlayDirectoryButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("PlayDirectoryButton.Iconimage")));
            this.PlayDirectoryButton.Iconimage_right = null;
            this.PlayDirectoryButton.Iconimage_right_Selected = null;
            this.PlayDirectoryButton.Iconimage_Selected = null;
            this.PlayDirectoryButton.IconMarginLeft = 0;
            this.PlayDirectoryButton.IconMarginRight = 0;
            this.PlayDirectoryButton.IconRightVisible = true;
            this.PlayDirectoryButton.IconRightZoom = 0D;
            this.PlayDirectoryButton.IconVisible = true;
            this.PlayDirectoryButton.IconZoom = 87D;
            this.PlayDirectoryButton.IsTab = false;
            this.PlayDirectoryButton.Location = new System.Drawing.Point(0, 159);
            this.PlayDirectoryButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PlayDirectoryButton.Name = "PlayDirectoryButton";
            this.PlayDirectoryButton.Normalcolor = System.Drawing.Color.Fuchsia;
            this.PlayDirectoryButton.OnHovercolor = System.Drawing.Color.Magenta;
            this.PlayDirectoryButton.OnHoverTextColor = System.Drawing.Color.White;
            this.PlayDirectoryButton.selected = false;
            this.PlayDirectoryButton.Size = new System.Drawing.Size(203, 55);
            this.PlayDirectoryButton.TabIndex = 3;
            this.PlayDirectoryButton.Text = "Play directory";
            this.PlayDirectoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayDirectoryButton.Textcolor = System.Drawing.Color.White;
            this.PlayDirectoryButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayDirectoryButton.Click += new System.EventHandler(this.PlayDirectoryButton_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.TimeLabel);
            this.bunifuGradientPanel2.Controls.Add(this.TitleLabel);
            this.bunifuGradientPanel2.Controls.Add(this.CloseButton);
            this.bunifuGradientPanel2.Controls.Add(this.MinimizeButton);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.LightSkyBlue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Azure;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(200, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(600, 38);
            this.bunifuGradientPanel2.TabIndex = 38;
            // 
            // PathTextbox
            // 
            this.PathTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.PathTextbox.BorderColor = System.Drawing.Color.Fuchsia;
            this.PathTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTextbox.ForeColor = System.Drawing.Color.Fuchsia;
            this.PathTextbox.Location = new System.Drawing.Point(238, 504);
            this.PathTextbox.Name = "PathTextbox";
            this.PathTextbox.ReadOnly = true;
            this.PathTextbox.Size = new System.Drawing.Size(527, 22);
            this.PathTextbox.TabIndex = 37;
            this.PathTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.PathTextbox);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.TimeTrackbar);
            this.Controls.Add(this.VolumeTrackbar);
            this.Controls.Add(this.bunifuSeparator1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "C#MusicPlayer";
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ImageTab.ResumeLayout(false);
            this.OptionsTab.ResumeLayout(false);
            this.OptionsTab.PerformLayout();
            this.MoreAboutTab.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.LyricsTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 MinimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel TitleLabel;
        private System.Windows.Forms.PictureBox CoverPicture;
        private Bunifu.Framework.UI.BunifuVTrackbar VolumeTrackbar;
        private Bunifu.Framework.UI.BunifuVTrackbar TimeTrackbar;
        private Bunifu.Framework.UI.BunifuThinButton2 PlayButton;
        private Bunifu.Framework.UI.BunifuThinButton2 StopButton;
        private Bunifu.Framework.UI.BunifuThinButton2 PauseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 PreviousButton;
        private Bunifu.Framework.UI.BunifuThinButton2 NextButton;
        private Bunifu.Framework.UI.BunifuCustomLabel TimeLabel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuCheckbox RandomCheckBox;
        private Bunifu.Framework.UI.BunifuCustomLabel RandomLabel;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage ImageTab;
        private MetroFramework.Controls.MetroTabPage OptionsTab;
        private Bunifu.Framework.UI.BunifuCheckbox RepeatCheckbox;
        private Bunifu.Framework.UI.BunifuCustomLabel RepeatLabel;
        private MetroFramework.Controls.MetroTabPage MoreAboutTab;
        private MetroFramework.Controls.MetroTabPage LyricsTab;
        private System.Windows.Forms.RichTextBox LyricsRighText;
        private Bunifu.Framework.UI.BunifuGradientPanel GeneralPanel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TrackTextbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox YearTextbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TitleTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox BitrateTextbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox FreqTextbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox LengthTextbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox GenreTextbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox AlbumTextbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox AuthorTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel AuthorLabel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton PlaySingleButton;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsButton;
        private Bunifu.Framework.UI.BunifuFlatButton PlayDirectoryButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox PathTextbox;
    }
}