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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoreAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlayDirectoryButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlaySingleButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DragPanel = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.MoreAbout);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.PlayDirectoryButton);
            this.panel1.Controls.Add(this.PlaySingleButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // MoreAbout
            // 
            this.MoreAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.MoreAbout.BackColor = System.Drawing.Color.Crimson;
            this.MoreAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoreAbout.BorderRadius = 0;
            this.MoreAbout.ButtonText = "More about this song";
            this.MoreAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoreAbout.DisabledColor = System.Drawing.Color.Gray;
            this.MoreAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.MoreAbout.Iconimage = null;
            this.MoreAbout.Iconimage_right = null;
            this.MoreAbout.Iconimage_right_Selected = null;
            this.MoreAbout.Iconimage_Selected = null;
            this.MoreAbout.IconMarginLeft = 0;
            this.MoreAbout.IconMarginRight = 0;
            this.MoreAbout.IconRightVisible = true;
            this.MoreAbout.IconRightZoom = 0D;
            this.MoreAbout.IconVisible = true;
            this.MoreAbout.IconZoom = 0D;
            this.MoreAbout.IsTab = false;
            this.MoreAbout.Location = new System.Drawing.Point(0, 227);
            this.MoreAbout.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MoreAbout.Name = "MoreAbout";
            this.MoreAbout.Normalcolor = System.Drawing.Color.Crimson;
            this.MoreAbout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(31)))), ((int)(((byte)(72)))));
            this.MoreAbout.OnHoverTextColor = System.Drawing.Color.White;
            this.MoreAbout.selected = false;
            this.MoreAbout.Size = new System.Drawing.Size(200, 55);
            this.MoreAbout.TabIndex = 5;
            this.MoreAbout.Text = "More about this song";
            this.MoreAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoreAbout.Textcolor = System.Drawing.Color.White;
            this.MoreAbout.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreAbout.Click += new System.EventHandler(this.MoreAbout_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.SettingsButton.BackColor = System.Drawing.Color.Crimson;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.BorderRadius = 0;
            this.SettingsButton.ButtonText = "Settings";
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.SettingsButton.Location = new System.Drawing.Point(0, 395);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Normalcolor = System.Drawing.Color.Crimson;
            this.SettingsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(31)))), ((int)(((byte)(72)))));
            this.SettingsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingsButton.selected = false;
            this.SettingsButton.Size = new System.Drawing.Size(200, 55);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Textcolor = System.Drawing.Color.White;
            this.SettingsButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PlayDirectoryButton
            // 
            this.PlayDirectoryButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.PlayDirectoryButton.BackColor = System.Drawing.Color.Crimson;
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
            this.PlayDirectoryButton.Location = new System.Drawing.Point(0, 164);
            this.PlayDirectoryButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PlayDirectoryButton.Name = "PlayDirectoryButton";
            this.PlayDirectoryButton.Normalcolor = System.Drawing.Color.Crimson;
            this.PlayDirectoryButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(31)))), ((int)(((byte)(72)))));
            this.PlayDirectoryButton.OnHoverTextColor = System.Drawing.Color.White;
            this.PlayDirectoryButton.selected = false;
            this.PlayDirectoryButton.Size = new System.Drawing.Size(200, 55);
            this.PlayDirectoryButton.TabIndex = 3;
            this.PlayDirectoryButton.Text = "Play directory";
            this.PlayDirectoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayDirectoryButton.Textcolor = System.Drawing.Color.White;
            this.PlayDirectoryButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayDirectoryButton.Click += new System.EventHandler(this.PlayDirectoryButton_Click);
            // 
            // PlaySingleButton
            // 
            this.PlaySingleButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.PlaySingleButton.BackColor = System.Drawing.Color.Crimson;
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
            this.PlaySingleButton.Normalcolor = System.Drawing.Color.Crimson;
            this.PlaySingleButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(31)))), ((int)(((byte)(72)))));
            this.PlaySingleButton.OnHoverTextColor = System.Drawing.Color.White;
            this.PlaySingleButton.selected = false;
            this.PlaySingleButton.Size = new System.Drawing.Size(200, 55);
            this.PlaySingleButton.TabIndex = 2;
            this.PlaySingleButton.Text = "Play single file";
            this.PlaySingleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlaySingleButton.Textcolor = System.Drawing.Color.White;
            this.PlaySingleButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaySingleButton.Click += new System.EventHandler(this.PlaySingleButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 94);
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
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DragPanel.Controls.Add(this.TimeLabel);
            this.DragPanel.Controls.Add(this.TitleLabel);
            this.DragPanel.Controls.Add(this.CloseButton);
            this.DragPanel.Controls.Add(this.MinimizeButton);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(200, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(600, 38);
            this.DragPanel.TabIndex = 1;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(397, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(87, 18);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "0:0:0 / 0:0:0";
            this.TimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.TimeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(8, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(367, 18);
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
            this.CloseButton.ActiveForecolor = System.Drawing.Color.Crimson;
            this.CloseButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.CloseButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.ButtonText = "X";
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.IdleBorderThickness = 1;
            this.CloseButton.IdleCornerRadius = 20;
            this.CloseButton.IdleFillColor = System.Drawing.Color.Crimson;
            this.CloseButton.IdleForecolor = System.Drawing.Color.White;
            this.CloseButton.IdleLineColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(551, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(39, 37);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.ActiveBorderThickness = 1;
            this.MinimizeButton.ActiveCornerRadius = 20;
            this.MinimizeButton.ActiveFillColor = System.Drawing.Color.White;
            this.MinimizeButton.ActiveForecolor = System.Drawing.Color.Crimson;
            this.MinimizeButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.ButtonText = "_";
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.IdleBorderThickness = 1;
            this.MinimizeButton.IdleCornerRadius = 20;
            this.MinimizeButton.IdleFillColor = System.Drawing.Color.Crimson;
            this.MinimizeButton.IdleForecolor = System.Drawing.Color.White;
            this.MinimizeButton.IdleLineColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(504, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(39, 37);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // VolumeTrackbar
            // 
            this.VolumeTrackbar.BackColor = System.Drawing.Color.Transparent;
            this.VolumeTrackbar.BackgroudColor = System.Drawing.Color.DarkSlateGray;
            this.VolumeTrackbar.BorderRadius = 0;
            this.VolumeTrackbar.IndicatorColor = System.Drawing.Color.Crimson;
            this.VolumeTrackbar.Location = new System.Drawing.Point(208, 44);
            this.VolumeTrackbar.MaximumValue = 100;
            this.VolumeTrackbar.Name = "VolumeTrackbar";
            this.VolumeTrackbar.Size = new System.Drawing.Size(30, 394);
            this.VolumeTrackbar.SliderRadius = 0;
            this.VolumeTrackbar.TabIndex = 4;
            this.VolumeTrackbar.Value = 50;
            this.VolumeTrackbar.ValueChanged += new System.EventHandler(this.VolumeTrackbar_ValueChanged);
            // 
            // TimeTrackbar
            // 
            this.TimeTrackbar.BackColor = System.Drawing.Color.Transparent;
            this.TimeTrackbar.BackgroudColor = System.Drawing.Color.DarkSlateGray;
            this.TimeTrackbar.BorderRadius = 0;
            this.TimeTrackbar.IndicatorColor = System.Drawing.Color.Crimson;
            this.TimeTrackbar.Location = new System.Drawing.Point(763, 44);
            this.TimeTrackbar.MaximumValue = 100;
            this.TimeTrackbar.Name = "TimeTrackbar";
            this.TimeTrackbar.Size = new System.Drawing.Size(30, 394);
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
            this.NextButton.ActiveForecolor = System.Drawing.Color.Crimson;
            this.NextButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.NextButton.BackColor = System.Drawing.Color.CadetBlue;
            this.NextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextButton.BackgroundImage")));
            this.NextButton.ButtonText = "Next";
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.IdleBorderThickness = 1;
            this.NextButton.IdleCornerRadius = 20;
            this.NextButton.IdleFillColor = System.Drawing.Color.Crimson;
            this.NextButton.IdleForecolor = System.Drawing.Color.White;
            this.NextButton.IdleLineColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(642, 406);
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
            this.PreviousButton.ActiveForecolor = System.Drawing.Color.Crimson;
            this.PreviousButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.PreviousButton.BackColor = System.Drawing.Color.CadetBlue;
            this.PreviousButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviousButton.BackgroundImage")));
            this.PreviousButton.ButtonText = "Previous";
            this.PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton.ForeColor = System.Drawing.Color.White;
            this.PreviousButton.IdleBorderThickness = 1;
            this.PreviousButton.IdleCornerRadius = 20;
            this.PreviousButton.IdleFillColor = System.Drawing.Color.Crimson;
            this.PreviousButton.IdleForecolor = System.Drawing.Color.White;
            this.PreviousButton.IdleLineColor = System.Drawing.Color.White;
            this.PreviousButton.Location = new System.Drawing.Point(551, 406);
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
            this.PauseButton.ActiveForecolor = System.Drawing.Color.Crimson;
            this.PauseButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.PauseButton.BackColor = System.Drawing.Color.CadetBlue;
            this.PauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseButton.BackgroundImage")));
            this.PauseButton.ButtonText = "Pause";
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.ForeColor = System.Drawing.Color.White;
            this.PauseButton.IdleBorderThickness = 1;
            this.PauseButton.IdleCornerRadius = 20;
            this.PauseButton.IdleFillColor = System.Drawing.Color.Crimson;
            this.PauseButton.IdleForecolor = System.Drawing.Color.White;
            this.PauseButton.IdleLineColor = System.Drawing.Color.White;
            this.PauseButton.Location = new System.Drawing.Point(460, 406);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(84, 37);
            this.PauseButton.TabIndex = 9;
            this.PauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.ActiveBorderThickness = 1;
            this.StopButton.ActiveCornerRadius = 20;
            this.StopButton.ActiveFillColor = System.Drawing.Color.White;
            this.StopButton.ActiveForecolor = System.Drawing.Color.Crimson;
            this.StopButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.StopButton.BackColor = System.Drawing.Color.CadetBlue;
            this.StopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopButton.BackgroundImage")));
            this.StopButton.ButtonText = "Stop";
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.IdleBorderThickness = 1;
            this.StopButton.IdleCornerRadius = 20;
            this.StopButton.IdleFillColor = System.Drawing.Color.Crimson;
            this.StopButton.IdleForecolor = System.Drawing.Color.White;
            this.StopButton.IdleLineColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(369, 406);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(84, 37);
            this.StopButton.TabIndex = 8;
            this.StopButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.ActiveBorderThickness = 1;
            this.PlayButton.ActiveCornerRadius = 20;
            this.PlayButton.ActiveFillColor = System.Drawing.Color.White;
            this.PlayButton.ActiveForecolor = System.Drawing.Color.Crimson;
            this.PlayButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.PlayButton.BackColor = System.Drawing.Color.CadetBlue;
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.ButtonText = "Play!";
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.IdleBorderThickness = 1;
            this.PlayButton.IdleCornerRadius = 20;
            this.PlayButton.IdleFillColor = System.Drawing.Color.Crimson;
            this.PlayButton.IdleForecolor = System.Drawing.Color.White;
            this.PlayButton.IdleLineColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(278, 406);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(84, 37);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // CoverPicture
            // 
            this.CoverPicture.Location = new System.Drawing.Point(322, 48);
            this.CoverPicture.Name = "CoverPicture";
            this.CoverPicture.Size = new System.Drawing.Size(350, 350);
            this.CoverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoverPicture.TabIndex = 2;
            this.CoverPicture.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(200, 440);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(600, 10);
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
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.bunifuSeparator3.LineThickness = 4;
            this.bunifuSeparator3.Location = new System.Drawing.Point(790, 38);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(10, 402);
            this.bunifuSeparator3.TabIndex = 13;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            this.bunifuSeparator3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuSeparator3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.TimeTrackbar);
            this.Controls.Add(this.VolumeTrackbar);
            this.Controls.Add(this.CoverPicture);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "C#MusicPlayer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DragPanel;
        private Bunifu.Framework.UI.BunifuFlatButton PlaySingleButton;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 MinimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsButton;
        private Bunifu.Framework.UI.BunifuFlatButton PlayDirectoryButton;
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
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton MoreAbout;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
    }
}