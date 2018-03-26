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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PlaySingleButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TitleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FadeSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.FadeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.UpdateSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.UpdateNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FadeNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.PlaySingleButton);
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
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 94);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.DarkSlateGray;
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
            // PlaySingleButton
            // 
            this.PlaySingleButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.PlaySingleButton.BackColor = System.Drawing.Color.Crimson;
            this.PlaySingleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaySingleButton.BorderRadius = 0;
            this.PlaySingleButton.ButtonText = "General";
            this.PlaySingleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlaySingleButton.DisabledColor = System.Drawing.Color.Gray;
            this.PlaySingleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaySingleButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PlaySingleButton.Iconimage = null;
            this.PlaySingleButton.Iconimage_right = null;
            this.PlaySingleButton.Iconimage_right_Selected = null;
            this.PlaySingleButton.Iconimage_Selected = null;
            this.PlaySingleButton.IconMarginLeft = 0;
            this.PlaySingleButton.IconMarginRight = 0;
            this.PlaySingleButton.IconRightVisible = true;
            this.PlaySingleButton.IconRightZoom = 0D;
            this.PlaySingleButton.IconVisible = true;
            this.PlaySingleButton.IconZoom = 0D;
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
            this.PlaySingleButton.Text = "General";
            this.PlaySingleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlaySingleButton.Textcolor = System.Drawing.Color.White;
            this.PlaySingleButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaySingleButton.Click += new System.EventHandler(this.PlaySingleButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(18, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(241, 18);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Settings - Restart to see changes";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GeneralPanel.Controls.Add(this.UpdateNumUpDown);
            this.GeneralPanel.Controls.Add(this.UpdateSlider);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel2);
            this.GeneralPanel.Controls.Add(this.FadeNumUpDown);
            this.GeneralPanel.Controls.Add(this.FadeSlider);
            this.GeneralPanel.Controls.Add(this.bunifuCustomLabel1);
            this.GeneralPanel.Location = new System.Drawing.Point(221, 70);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(567, 100);
            this.GeneralPanel.TabIndex = 3;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(14, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(142, 18);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Fade in/out length";
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
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(37, 56);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(98, 18);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Update time";
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
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.panel1.ResumeLayout(false);
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FadeNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton PlaySingleButton;
        private System.Windows.Forms.Panel DragPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel TitleLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 MinimizeButton;
        private System.Windows.Forms.Panel GeneralPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.NumericUpDown FadeNumUpDown;
        private Bunifu.Framework.UI.BunifuSlider FadeSlider;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.NumericUpDown UpdateNumUpDown;
        private Bunifu.Framework.UI.BunifuSlider UpdateSlider;
    }
}