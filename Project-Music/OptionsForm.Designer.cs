namespace Project_Music
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.GeneralButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DefaultSetButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TitleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LanguageLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LangCombobox = new System.Windows.Forms.ComboBox();
            this.UpdateNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.UpdateSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.UpdateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FadeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.FadeSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.FadeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.GeneralPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeNumUpDown)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralButton
            // 
            this.GeneralButton.Activecolor = System.Drawing.Color.Magenta;
            this.GeneralButton.BackColor = System.Drawing.Color.Fuchsia;
            this.GeneralButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeneralButton.BorderRadius = 0;
            this.GeneralButton.ButtonText = "General";
            this.GeneralButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneralButton.DisabledColor = System.Drawing.Color.Gray;
            this.GeneralButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralButton.Iconcolor = System.Drawing.Color.Transparent;
            this.GeneralButton.Iconimage = null;
            this.GeneralButton.Iconimage_right = null;
            this.GeneralButton.Iconimage_right_Selected = null;
            this.GeneralButton.Iconimage_Selected = null;
            this.GeneralButton.IconMarginLeft = 0;
            this.GeneralButton.IconMarginRight = 0;
            this.GeneralButton.IconRightVisible = true;
            this.GeneralButton.IconRightZoom = 0D;
            this.GeneralButton.IconVisible = true;
            this.GeneralButton.IconZoom = 0D;
            this.GeneralButton.IsTab = false;
            this.GeneralButton.Location = new System.Drawing.Point(-4, 94);
            this.GeneralButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GeneralButton.Name = "GeneralButton";
            this.GeneralButton.Normalcolor = System.Drawing.Color.Fuchsia;
            this.GeneralButton.OnHovercolor = System.Drawing.Color.Magenta;
            this.GeneralButton.OnHoverTextColor = System.Drawing.Color.White;
            this.GeneralButton.selected = false;
            this.GeneralButton.Size = new System.Drawing.Size(204, 55);
            this.GeneralButton.TabIndex = 2;
            this.GeneralButton.Text = "General";
            this.GeneralButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GeneralButton.Textcolor = System.Drawing.Color.White;
            this.GeneralButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralButton.Click += new System.EventHandler(this.PlaySingleButton_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("CL EvoluFont", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(196, 78);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "C#Music\r\n     Player";
            this.bunifuCustomLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuCustomLabel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // DefaultSetButton
            // 
            this.DefaultSetButton.ActiveBorderThickness = 1;
            this.DefaultSetButton.ActiveCornerRadius = 20;
            this.DefaultSetButton.ActiveFillColor = System.Drawing.Color.White;
            this.DefaultSetButton.ActiveForecolor = System.Drawing.Color.Magenta;
            this.DefaultSetButton.ActiveLineColor = System.Drawing.Color.Magenta;
            this.DefaultSetButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DefaultSetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DefaultSetButton.BackgroundImage")));
            this.DefaultSetButton.ButtonText = "Defualt values";
            this.DefaultSetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultSetButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultSetButton.ForeColor = System.Drawing.Color.White;
            this.DefaultSetButton.IdleBorderThickness = 1;
            this.DefaultSetButton.IdleCornerRadius = 20;
            this.DefaultSetButton.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.DefaultSetButton.IdleForecolor = System.Drawing.Color.White;
            this.DefaultSetButton.IdleLineColor = System.Drawing.Color.White;
            this.DefaultSetButton.Location = new System.Drawing.Point(382, 0);
            this.DefaultSetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DefaultSetButton.Name = "DefaultSetButton";
            this.DefaultSetButton.Size = new System.Drawing.Size(143, 37);
            this.DefaultSetButton.TabIndex = 7;
            this.DefaultSetButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DefaultSetButton.Click += new System.EventHandler(this.DefaultSetButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.TitleLabel.Location = new System.Drawing.Point(29, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(241, 18);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Settings - Restart to see changes";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveBorderThickness = 1;
            this.CloseButton.ActiveCornerRadius = 20;
            this.CloseButton.ActiveFillColor = System.Drawing.Color.White;
            this.CloseButton.ActiveForecolor = System.Drawing.Color.Magenta;
            this.CloseButton.ActiveLineColor = System.Drawing.Color.Magenta;
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
            this.CloseButton.Location = new System.Drawing.Point(572, 1);
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
            this.MinimizeButton.ActiveForecolor = System.Drawing.Color.Magenta;
            this.MinimizeButton.ActiveLineColor = System.Drawing.Color.Magenta;
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
            this.MinimizeButton.Location = new System.Drawing.Point(533, 1);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(39, 37);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.BackColor = System.Drawing.Color.Transparent;
            this.LanguageLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.LanguageLabel.Location = new System.Drawing.Point(301, 90);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(83, 18);
            this.LanguageLabel.TabIndex = 14;
            this.LanguageLabel.Text = "Language";
            // 
            // LangCombobox
            // 
            this.LangCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LangCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangCombobox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LangCombobox.ForeColor = System.Drawing.Color.Fuchsia;
            this.LangCombobox.FormattingEnabled = true;
            this.LangCombobox.Items.AddRange(new object[] {
            "English",
            "Español"});
            this.LangCombobox.Location = new System.Drawing.Point(440, 89);
            this.LangCombobox.Name = "LangCombobox";
            this.LangCombobox.Size = new System.Drawing.Size(120, 25);
            this.LangCombobox.TabIndex = 13;
            // 
            // UpdateNumUpDown
            // 
            this.UpdateNumUpDown.BackColor = System.Drawing.Color.LightBlue;
            this.UpdateNumUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpdateNumUpDown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateNumUpDown.ForeColor = System.Drawing.Color.Fuchsia;
            this.UpdateNumUpDown.Location = new System.Drawing.Point(440, 51);
            this.UpdateNumUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpdateNumUpDown.Name = "UpdateNumUpDown";
            this.UpdateNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.UpdateNumUpDown.TabIndex = 12;
            this.UpdateNumUpDown.ValueChanged += new System.EventHandler(this.UpdateNumUpDown_ValueChanged);
            // 
            // UpdateSlider
            // 
            this.UpdateSlider.BackColor = System.Drawing.Color.Transparent;
            this.UpdateSlider.BackgroudColor = System.Drawing.Color.LightBlue;
            this.UpdateSlider.BorderRadius = 0;
            this.UpdateSlider.IndicatorColor = System.Drawing.Color.Fuchsia;
            this.UpdateSlider.Location = new System.Drawing.Point(168, 50);
            this.UpdateSlider.MaximumValue = 10000;
            this.UpdateSlider.Name = "UpdateSlider";
            this.UpdateSlider.Size = new System.Drawing.Size(255, 30);
            this.UpdateSlider.TabIndex = 11;
            this.UpdateSlider.Value = 0;
            this.UpdateSlider.ValueChanged += new System.EventHandler(this.UpdateSlider_ValueChanged);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.UpdateLabel.Location = new System.Drawing.Point(43, 50);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(98, 18);
            this.UpdateLabel.TabIndex = 10;
            this.UpdateLabel.Text = "Update time";
            // 
            // FadeNumUpDown
            // 
            this.FadeNumUpDown.BackColor = System.Drawing.Color.LightBlue;
            this.FadeNumUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FadeNumUpDown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FadeNumUpDown.ForeColor = System.Drawing.Color.Fuchsia;
            this.FadeNumUpDown.Location = new System.Drawing.Point(440, 14);
            this.FadeNumUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.FadeNumUpDown.Name = "FadeNumUpDown";
            this.FadeNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.FadeNumUpDown.TabIndex = 9;
            this.FadeNumUpDown.ValueChanged += new System.EventHandler(this.FadeNumUpDown_ValueChanged);
            // 
            // FadeSlider
            // 
            this.FadeSlider.BackColor = System.Drawing.Color.Transparent;
            this.FadeSlider.BackgroudColor = System.Drawing.Color.LightBlue;
            this.FadeSlider.BorderRadius = 0;
            this.FadeSlider.IndicatorColor = System.Drawing.Color.Fuchsia;
            this.FadeSlider.Location = new System.Drawing.Point(168, 13);
            this.FadeSlider.MaximumValue = 50000;
            this.FadeSlider.Name = "FadeSlider";
            this.FadeSlider.Size = new System.Drawing.Size(255, 30);
            this.FadeSlider.TabIndex = 8;
            this.FadeSlider.Value = 0;
            this.FadeSlider.ValueChanged += new System.EventHandler(this.FadeSlider_ValueChanged);
            // 
            // FadeLabel
            // 
            this.FadeLabel.AutoSize = true;
            this.FadeLabel.BackColor = System.Drawing.Color.Transparent;
            this.FadeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FadeLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.FadeLabel.Location = new System.Drawing.Point(20, 13);
            this.FadeLabel.Name = "FadeLabel";
            this.FadeLabel.Size = new System.Drawing.Size(142, 18);
            this.FadeLabel.TabIndex = 7;
            this.FadeLabel.Text = "Fade in/out length";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Fuchsia;
            this.bunifuSeparator3.LineThickness = 4;
            this.bunifuSeparator3.Location = new System.Drawing.Point(790, 0);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(10, 450);
            this.bunifuSeparator3.TabIndex = 6;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            this.bunifuSeparator3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuSeparator3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Fuchsia;
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 440);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(790, 10);
            this.bunifuSeparator1.TabIndex = 13;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuSeparator1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.TitleLabel);
            this.bunifuGradientPanel2.Controls.Add(this.DefaultSetButton);
            this.bunifuGradientPanel2.Controls.Add(this.CloseButton);
            this.bunifuGradientPanel2.Controls.Add(this.MinimizeButton);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.LightSkyBlue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Azure;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(189, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(617, 38);
            this.bunifuGradientPanel2.TabIndex = 39;
            this.bunifuGradientPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuGradientPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeneralPanel.BackgroundImage")));
            this.GeneralPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeneralPanel.Controls.Add(this.LanguageLabel);
            this.GeneralPanel.Controls.Add(this.UpdateSlider);
            this.GeneralPanel.Controls.Add(this.LangCombobox);
            this.GeneralPanel.Controls.Add(this.FadeLabel);
            this.GeneralPanel.Controls.Add(this.UpdateNumUpDown);
            this.GeneralPanel.Controls.Add(this.FadeSlider);
            this.GeneralPanel.Controls.Add(this.FadeNumUpDown);
            this.GeneralPanel.Controls.Add(this.UpdateLabel);
            this.GeneralPanel.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.GeneralPanel.GradientBottomRight = System.Drawing.Color.LightSkyBlue;
            this.GeneralPanel.GradientTopLeft = System.Drawing.Color.Azure;
            this.GeneralPanel.GradientTopRight = System.Drawing.Color.Fuchsia;
            this.GeneralPanel.Location = new System.Drawing.Point(212, 78);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Quality = 10;
            this.GeneralPanel.Size = new System.Drawing.Size(578, 143);
            this.GeneralPanel.TabIndex = 40;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel3.Controls.Add(this.GeneralButton);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.LightSkyBlue;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.Azure;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(200, 440);
            this.bunifuGradientPanel3.TabIndex = 40;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeNumUpDown)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton GeneralButton;
        private Bunifu.Framework.UI.BunifuCustomLabel TitleLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 MinimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel UpdateLabel;
        private System.Windows.Forms.NumericUpDown FadeNumUpDown;
        private Bunifu.Framework.UI.BunifuSlider FadeSlider;
        private Bunifu.Framework.UI.BunifuCustomLabel FadeLabel;
        private System.Windows.Forms.NumericUpDown UpdateNumUpDown;
        private Bunifu.Framework.UI.BunifuSlider UpdateSlider;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 DefaultSetButton;
        private System.Windows.Forms.ComboBox LangCombobox;
        private Bunifu.Framework.UI.BunifuCustomLabel LanguageLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel GeneralPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
    }
}