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
        public Error(int type)
        {
            InitializeComponent();
            if(type == 0)
            {
                label1.Text = "File is missing";
                label2.Text = "File didn't found.";
            }
            else if (type == 1)
            {
                label1.Text = "Have you selected music?";
                label2.Text = "The program can't read the file you've selected";
            }

            StreamReader reader = new StreamReader("config.ini");
            reader.ReadLine();
            string color = reader.ReadLine();
            reader.Close();

            if(color == "Dark")
            {
                panel1.BackColor = Color.FromArgb(28, 28, 28);
                button1.BackColor = Color.FromArgb(45, 45, 48);
                this.BackColor = Color.FromArgb(37, 37, 38);
                pictureBox3.BackColor = Color.FromArgb(28, 28, 28);
            }
            else if(color == "Blue")
            {
                panel1.BackColor = Color.FromArgb(16, 71, 166);
                button1.BackColor = Color.FromArgb(16, 71, 166);
                this.BackColor = Color.WhiteSmoke;
                pictureBox3.BackColor = Color.FromArgb(16, 71, 166);
                label2.ForeColor = Color.FromArgb(16, 71, 166);
            }
            else if(color == "Orange")
            {
                panel1.BackColor = Color.FromArgb(252, 143, 0);
                button1.BackColor = Color.FromArgb(252, 143, 0);
                this.BackColor = Color.WhiteSmoke;
                pictureBox3.BackColor = Color.FromArgb(252, 143, 0);
                label2.ForeColor = Color.FromArgb(252, 143, 0);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }
        }
    }
}
