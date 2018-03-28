using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Music.ErrorForms
{
    public partial class Error : Form
    {
        public Error(string title, string body)
        {
            InitializeComponent();
            TitleLabel.Text = title;
            BodyLabel.Text = body;
        }
        Point LastPoint;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - LastPoint.X; this.Top += e.Y - LastPoint.Y; }
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
