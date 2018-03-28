namespace Project_Music.ErrorForms
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.NotfPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.OKButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BodyLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NotfPanel.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotfPanel
            // 
            this.NotfPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NotfPanel.BackgroundImage")));
            this.NotfPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NotfPanel.Controls.Add(this.OKButton);
            this.NotfPanel.Controls.Add(this.BodyLabel);
            this.NotfPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NotfPanel.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.NotfPanel.GradientBottomRight = System.Drawing.Color.SlateBlue;
            this.NotfPanel.GradientTopLeft = System.Drawing.Color.PowderBlue;
            this.NotfPanel.GradientTopRight = System.Drawing.Color.White;
            this.NotfPanel.Location = new System.Drawing.Point(0, 30);
            this.NotfPanel.Name = "NotfPanel";
            this.NotfPanel.Quality = 10;
            this.NotfPanel.Size = new System.Drawing.Size(392, 240);
            this.NotfPanel.TabIndex = 15;
            // 
            // OKButton
            // 
            this.OKButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(54)))), ((int)(((byte)(91)))));
            this.OKButton.BackColor = System.Drawing.Color.Crimson;
            this.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OKButton.BorderRadius = 0;
            this.OKButton.ButtonText = "Ok";
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.DisabledColor = System.Drawing.Color.Gray;
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Iconcolor = System.Drawing.Color.Transparent;
            this.OKButton.Iconimage = null;
            this.OKButton.Iconimage_right = null;
            this.OKButton.Iconimage_right_Selected = null;
            this.OKButton.Iconimage_Selected = null;
            this.OKButton.IconMarginLeft = 0;
            this.OKButton.IconMarginRight = 0;
            this.OKButton.IconRightVisible = true;
            this.OKButton.IconRightZoom = 0D;
            this.OKButton.IconVisible = true;
            this.OKButton.IconZoom = 0D;
            this.OKButton.IsTab = false;
            this.OKButton.Location = new System.Drawing.Point(0, 196);
            this.OKButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Normalcolor = System.Drawing.Color.Crimson;
            this.OKButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(31)))), ((int)(((byte)(72)))));
            this.OKButton.OnHoverTextColor = System.Drawing.Color.White;
            this.OKButton.selected = false;
            this.OKButton.Size = new System.Drawing.Size(392, 44);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "Ok";
            this.OKButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OKButton.Textcolor = System.Drawing.Color.White;
            this.OKButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BodyLabel
            // 
            this.BodyLabel.BackColor = System.Drawing.Color.Transparent;
            this.BodyLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyLabel.ForeColor = System.Drawing.Color.White;
            this.BodyLabel.Location = new System.Drawing.Point(3, 26);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(383, 166);
            this.BodyLabel.TabIndex = 7;
            this.BodyLabel.Text = "Error body";
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DragPanel.Controls.Add(this.TitleLabel);
            this.DragPanel.Controls.Add(this.CloseButton);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(392, 38);
            this.DragPanel.TabIndex = 16;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(8, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(269, 18);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Error title";
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
            this.CloseButton.Location = new System.Drawing.Point(347, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(39, 37);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 270);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.NotfPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Error";
            this.Text = "Error";
            this.NotfPanel.ResumeLayout(false);
            this.DragPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel NotfPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel BodyLabel;
        private System.Windows.Forms.Panel DragPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel TitleLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseButton;
        private Bunifu.Framework.UI.BunifuFlatButton OKButton;
    }
}