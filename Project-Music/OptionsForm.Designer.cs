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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.GeneralButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.DefaultSetButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TitleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.LangCombobox = new System.Windows.Forms.ComboBox();
            this.UpdateNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.UpdateSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.UpdateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FadeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.FadeSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.FadeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.LanguageLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.GeneralButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.bunifuSeparator2.LineThickness = 4;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 440);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(200, 10);
            this.bunifuSeparator2.TabIndex = 6;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            this.bunifuSeparator2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuSeparator2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // GeneralButton
            // 
            this.GeneralButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.GeneralButton.BackColor = System.Drawing.Color.Crimson;
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
            this.GeneralButton.Location = new System.Drawing.Point(0, 101);
            this.GeneralButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GeneralButton.Name = "GeneralButton";
            this.GeneralButton.Normalcolor = System.Drawing.Color.Crimson;
            this.GeneralButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(31)))), ((int)(((byte)(72)))));
            this.GeneralButton.OnHoverTextColor = System.Drawing.Color.White;
            this.GeneralButton.selected = false;
            this.GeneralButton.Size = new System.Drawing.Size(200, 55);
            this.GeneralButton.TabIndex = 2;
            this.GeneralButton.Text = "General";
            this.GeneralButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GeneralButton.Textcolor = System.Drawing.Color.White;
            this.GeneralButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralButton.Click += new System.EventHandler(this.PlaySingleButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 94);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("CL EvoluFont", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(1, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(196, 78);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "C#Music\r\n     Player";
            this.bunifuCustomLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuCustomLabel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DragPanel.Controls.Add(this.DefaultSetButton);
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
            // DefaultSetButton
            // 
            this.DefaultSetButton.ActiveBorderThickness = 1;
            this.DefaultSetButton.ActiveCornerRadius = 20;
            this.DefaultSetButton.ActiveFillColor = System.Drawing.Color.White;
            this.DefaultSetButton.ActiveForecolor = System.Drawing.Color.Crimson;
            this.DefaultSetButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.DefaultSetButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DefaultSetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DefaultSetButton.BackgroundImage")));
            this.DefaultSetButton.ButtonText = "Defualt values";
            this.DefaultSetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultSetButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultSetButton.ForeColor = System.Drawing.Color.White;
            this.DefaultSetButton.IdleBorderThickness = 1;
            this.DefaultSetButton.IdleCornerRadius = 20;
            this.DefaultSetButton.IdleFillColor = System.Drawing.Color.Crimson;
            this.DefaultSetButton.IdleForecolor = System.Drawing.Color.White;
            this.DefaultSetButton.IdleLineColor = System.Drawing.Color.White;
            this.DefaultSetButton.Location = new System.Drawing.Point(353, 0);
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
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(6, 9);
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
            // GeneralPanel
            // 
            this.GeneralPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GeneralPanel.Controls.Add(this.LanguageLabel);
            this.GeneralPanel.Controls.Add(this.LangCombobox);
            this.GeneralPanel.Controls.Add(this.UpdateNumUpDown);
            this.GeneralPanel.Controls.Add(this.UpdateSlider);
            this.GeneralPanel.Controls.Add(this.UpdateLabel);
            this.GeneralPanel.Controls.Add(this.FadeNumUpDown);
            this.GeneralPanel.Controls.Add(this.FadeSlider);
            this.GeneralPanel.Controls.Add(this.FadeLabel);
            this.GeneralPanel.Location = new System.Drawing.Point(221, 70);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(567, 161);
            this.GeneralPanel.TabIndex = 3;
            // 
            // LangCombobox
            // 
            this.LangCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LangCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangCombobox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LangCombobox.ForeColor = System.Drawing.Color.Crimson;
            this.LangCombobox.FormattingEnabled = true;
            this.LangCombobox.Items.AddRange(new object[] {
            "English",
            "Español"});
            this.LangCombobox.Location = new System.Drawing.Point(434, 95);
            this.LangCombobox.Name = "LangCombobox";
            this.LangCombobox.Size = new System.Drawing.Size(120, 25);
            this.LangCombobox.TabIndex = 13;
            // 
            // UpdateNumUpDown
            // 
            this.UpdateNumUpDown.BackColor = System.Drawing.Color.CadetBlue;
            this.UpdateNumUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpdateNumUpDown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateNumUpDown.ForeColor = System.Drawing.Color.Crimson;
            this.UpdateNumUpDown.Location = new System.Drawing.Point(434, 57);
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
            this.UpdateSlider.BackgroudColor = System.Drawing.Color.CadetBlue;
            this.UpdateSlider.BorderRadius = 0;
            this.UpdateSlider.IndicatorColor = System.Drawing.Color.Crimson;
            this.UpdateSlider.Location = new System.Drawing.Point(162, 56);
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
            this.UpdateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLabel.ForeColor = System.Drawing.Color.White;
            this.UpdateLabel.Location = new System.Drawing.Point(37, 56);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(98, 18);
            this.UpdateLabel.TabIndex = 10;
            this.UpdateLabel.Text = "Update time";
            // 
            // FadeNumUpDown
            // 
            this.FadeNumUpDown.BackColor = System.Drawing.Color.CadetBlue;
            this.FadeNumUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FadeNumUpDown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FadeNumUpDown.ForeColor = System.Drawing.Color.Crimson;
            this.FadeNumUpDown.Location = new System.Drawing.Point(434, 20);
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
            this.FadeSlider.BackgroudColor = System.Drawing.Color.CadetBlue;
            this.FadeSlider.BorderRadius = 0;
            this.FadeSlider.IndicatorColor = System.Drawing.Color.Crimson;
            this.FadeSlider.Location = new System.Drawing.Point(162, 19);
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
            this.FadeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FadeLabel.ForeColor = System.Drawing.Color.White;
            this.FadeLabel.Location = new System.Drawing.Point(14, 19);
            this.FadeLabel.Name = "FadeLabel";
            this.FadeLabel.Size = new System.Drawing.Size(142, 18);
            this.FadeLabel.TabIndex = 7;
            this.FadeLabel.Text = "Fade in/out length";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.bunifuSeparator3.LineThickness = 4;
            this.bunifuSeparator3.Location = new System.Drawing.Point(790, 38);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(10, 412);
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
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(200, 440);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(590, 10);
            this.bunifuSeparator1.TabIndex = 13;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.bunifuSeparator1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageLabel.ForeColor = System.Drawing.Color.White;
            this.LanguageLabel.Location = new System.Drawing.Point(295, 96);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(83, 18);
            this.LanguageLabel.TabIndex = 14;
            this.LanguageLabel.Text = "Language";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton GeneralButton;
        private System.Windows.Forms.Panel DragPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel TitleLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 MinimizeButton;
        private System.Windows.Forms.Panel GeneralPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel UpdateLabel;
        private System.Windows.Forms.NumericUpDown FadeNumUpDown;
        private Bunifu.Framework.UI.BunifuSlider FadeSlider;
        private Bunifu.Framework.UI.BunifuCustomLabel FadeLabel;
        private System.Windows.Forms.NumericUpDown UpdateNumUpDown;
        private Bunifu.Framework.UI.BunifuSlider UpdateSlider;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuThinButton2 DefaultSetButton;
        private System.Windows.Forms.ComboBox LangCombobox;
        private Bunifu.Framework.UI.BunifuCustomLabel LanguageLabel;
    }
}