namespace Project_Music
{
    partial class AboutTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutTags));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.AuthorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AuthorTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AlbumTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.YearTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TrackTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GenreTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FreqTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LengthTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BitrateTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
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
            this.DragPanel.Controls.Add(this.bunifuThinButton21);
            this.DragPanel.Controls.Add(this.TitleLabel);
            this.DragPanel.Controls.Add(this.CloseButton);
            this.DragPanel.Controls.Add(this.MinimizeButton);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(200, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(600, 38);
            this.DragPanel.TabIndex = 2;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(8, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(463, 18);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "More about:";
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
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BitrateTextbox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuGradientPanel1.Controls.Add(this.FreqTextbox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuGradientPanel1.Controls.Add(this.LengthTextbox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel1.Controls.Add(this.GenreTextbox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.TrackTextbox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.YearTextbox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.AlbumTextbox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.AuthorTextbox);
            this.bunifuGradientPanel1.Controls.Add(this.AuthorLabel);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.PaleTurquoise;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Crimson;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkCyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(236, 60);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(530, 369);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.White;
            this.AuthorLabel.Location = new System.Drawing.Point(32, 15);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(79, 33);
            this.AuthorLabel.TabIndex = 7;
            this.AuthorLabel.Text = "Author: ";
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.AuthorTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AuthorTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.AuthorTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.AuthorTextbox.HintText = "";
            this.AuthorTextbox.isPassword = false;
            this.AuthorTextbox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.AuthorTextbox.LineIdleColor = System.Drawing.Color.White;
            this.AuthorTextbox.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.AuthorTextbox.LineThickness = 3;
            this.AuthorTextbox.Location = new System.Drawing.Point(97, 14);
            this.AuthorTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(379, 29);
            this.AuthorTextbox.TabIndex = 10;
            this.AuthorTextbox.Text = "Author";
            this.AuthorTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AlbumTextbox
            // 
            this.AlbumTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.AlbumTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AlbumTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.AlbumTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.AlbumTextbox.HintText = "";
            this.AlbumTextbox.isPassword = false;
            this.AlbumTextbox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.AlbumTextbox.LineIdleColor = System.Drawing.Color.White;
            this.AlbumTextbox.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.AlbumTextbox.LineThickness = 3;
            this.AlbumTextbox.Location = new System.Drawing.Point(97, 63);
            this.AlbumTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumTextbox.Name = "AlbumTextbox";
            this.AlbumTextbox.Size = new System.Drawing.Size(379, 29);
            this.AlbumTextbox.TabIndex = 12;
            this.AlbumTextbox.Text = "Album";
            this.AlbumTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 63);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "Album:";
            // 
            // YearTextbox
            // 
            this.YearTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.YearTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.YearTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.YearTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.YearTextbox.HintText = "";
            this.YearTextbox.isPassword = false;
            this.YearTextbox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.YearTextbox.LineIdleColor = System.Drawing.Color.White;
            this.YearTextbox.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.YearTextbox.LineThickness = 3;
            this.YearTextbox.Location = new System.Drawing.Point(97, 108);
            this.YearTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.YearTextbox.Name = "YearTextbox";
            this.YearTextbox.Size = new System.Drawing.Size(96, 29);
            this.YearTextbox.TabIndex = 14;
            this.YearTextbox.Text = "Year";
            this.YearTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(32, 107);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(69, 33);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Year:";
            // 
            // TrackTextbox
            // 
            this.TrackTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.TrackTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TrackTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.TrackTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.TrackTextbox.HintText = "";
            this.TrackTextbox.isPassword = false;
            this.TrackTextbox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.TrackTextbox.LineIdleColor = System.Drawing.Color.White;
            this.TrackTextbox.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.TrackTextbox.LineThickness = 3;
            this.TrackTextbox.Location = new System.Drawing.Point(380, 108);
            this.TrackTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.TrackTextbox.Name = "TrackTextbox";
            this.TrackTextbox.Size = new System.Drawing.Size(96, 29);
            this.TrackTextbox.TabIndex = 16;
            this.TrackTextbox.Text = "Number";
            this.TrackTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(304, 116);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 33);
            this.bunifuCustomLabel4.TabIndex = 15;
            this.bunifuCustomLabel4.Text = "Track:";
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.GenreTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GenreTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.GenreTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.GenreTextbox.HintText = "";
            this.GenreTextbox.isPassword = false;
            this.GenreTextbox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.GenreTextbox.LineIdleColor = System.Drawing.Color.White;
            this.GenreTextbox.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.GenreTextbox.LineThickness = 3;
            this.GenreTextbox.Location = new System.Drawing.Point(97, 153);
            this.GenreTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.Size = new System.Drawing.Size(379, 29);
            this.GenreTextbox.TabIndex = 18;
            this.GenreTextbox.Text = "Genre";
            this.GenreTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(32, 155);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel5.TabIndex = 17;
            this.bunifuCustomLabel5.Text = "Genre:";
            // 
            // FreqTextbox
            // 
            this.FreqTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.FreqTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FreqTextbox.Enabled = false;
            this.FreqTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreqTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.FreqTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.FreqTextbox.HintText = "";
            this.FreqTextbox.isPassword = false;
            this.FreqTextbox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.FreqTextbox.LineIdleColor = System.Drawing.Color.White;
            this.FreqTextbox.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.FreqTextbox.LineThickness = 3;
            this.FreqTextbox.Location = new System.Drawing.Point(97, 248);
            this.FreqTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.FreqTextbox.Name = "FreqTextbox";
            this.FreqTextbox.Size = new System.Drawing.Size(379, 29);
            this.FreqTextbox.TabIndex = 22;
            this.FreqTextbox.Text = "Frequency";
            this.FreqTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(32, 248);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel7.TabIndex = 21;
            this.bunifuCustomLabel7.Text = "Frequ:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(32, 200);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel6.TabIndex = 19;
            this.bunifuCustomLabel6.Text = "Length:";
            // 
            // LengthTextbox
            // 
            this.LengthTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.LengthTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LengthTextbox.Enabled = false;
            this.LengthTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.LengthTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.LengthTextbox.HintText = "";
            this.LengthTextbox.isPassword = false;
            this.LengthTextbox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.LengthTextbox.LineIdleColor = System.Drawing.Color.White;
            this.LengthTextbox.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.LengthTextbox.LineThickness = 3;
            this.LengthTextbox.Location = new System.Drawing.Point(97, 200);
            this.LengthTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthTextbox.Name = "LengthTextbox";
            this.LengthTextbox.Size = new System.Drawing.Size(379, 29);
            this.LengthTextbox.TabIndex = 20;
            this.LengthTextbox.Text = "Length";
            this.LengthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BitrateTextbox
            // 
            this.BitrateTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.BitrateTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BitrateTextbox.Enabled = false;
            this.BitrateTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitrateTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.BitrateTextbox.HintForeColor = System.Drawing.Color.Crimson;
            this.BitrateTextbox.HintText = "";
            this.BitrateTextbox.isPassword = false;
            this.BitrateTextbox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.BitrateTextbox.LineIdleColor = System.Drawing.Color.White;
            this.BitrateTextbox.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.BitrateTextbox.LineThickness = 3;
            this.BitrateTextbox.Location = new System.Drawing.Point(97, 295);
            this.BitrateTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.BitrateTextbox.Name = "BitrateTextbox";
            this.BitrateTextbox.Size = new System.Drawing.Size(379, 29);
            this.BitrateTextbox.TabIndex = 24;
            this.BitrateTextbox.Text = "Bitrate";
            this.BitrateTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(32, 295);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel8.TabIndex = 23;
            this.bunifuCustomLabel8.Text = "Bitrate:";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Save";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(432, 1);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(64, 37);
            this.bunifuThinButton21.TabIndex = 7;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutTags";
            this.Text = "AboutTags";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.DragPanel.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel DragPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel TitleLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 MinimizeButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel AuthorLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AuthorTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AlbumTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FreqTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox GenreTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TrackTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox YearTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LengthTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BitrateTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}