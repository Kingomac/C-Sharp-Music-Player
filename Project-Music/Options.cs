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

namespace Project_Music
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader("config.ini");
            numericUpDown1.Value = Convert.ToDecimal(reader.ReadLine());
            comboBox1.SelectedItem = reader.ReadLine();
            numericUpDown2.Value = Convert.ToDecimal(reader.ReadLine());
            reader.Close();
            if(comboBox1.SelectedItem.ToString() == "Dark")
            {
                //Paneles
                panel1.BackColor = Color.FromArgb(28, 28, 28);
                panel2.BackColor = Color.FromArgb(28, 28, 28);
                panel3.BackColor = Color.FromArgb(28, 28, 28);
                panel4.BackColor = Color.FromArgb(28, 28, 28);
                //Form backcolor
                this.BackColor = Color.FromArgb(37, 37, 38);
                //Other's color
                numericUpDown1.BackColor = Color.FromArgb(37, 37, 38);
                comboBox1.BackColor = Color.FromArgb(37, 37, 38);
                numericUpDown1.ForeColor = Color.White;
                comboBox1.ForeColor = Color.White;
            }
            else if (comboBox1.SelectedItem.ToString() == "Blue")
            {
                //Paneles
                panel1.BackColor = Color.FromArgb(16, 71, 166);
                panel2.BackColor = Color.FromArgb(16, 71, 166);
                panel3.BackColor = Color.FromArgb(16, 71, 166);
                panel4.BackColor = Color.FromArgb(16, 71, 166);
                //Form backcolor
                this.BackColor = Color.WhiteSmoke;
                //Other's color
                numericUpDown1.BackColor = Color.WhiteSmoke;
                comboBox1.BackColor = Color.WhiteSmoke;
                numericUpDown1.ForeColor = Color.FromArgb(16, 71, 166);
                comboBox1.ForeColor = Color.FromArgb(16, 71, 166);
            }
            else if (comboBox1.SelectedItem.ToString() == "Orange")
            {
                //Paneles
                panel1.BackColor = Color.FromArgb(252, 143, 0);
                panel2.BackColor = Color.FromArgb(252, 143, 0);
                panel3.BackColor = Color.FromArgb(252, 143, 0);
                panel4.BackColor = Color.FromArgb(252, 143, 0);
                //Form backcolor
                this.BackColor = Color.FromArgb(255, 179, 81);
                //Other's color
                numericUpDown1.BackColor = Color.FromArgb(255, 179, 81);
                comboBox1.BackColor = Color.FromArgb(255, 179, 81);
                numericUpDown1.ForeColor = Color.WhiteSmoke;
                comboBox1.ForeColor = Color.WhiteSmoke;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel4.Enabled = !panel4.Enabled;
            panel4.Visible = !panel4.Visible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            ConfigFile.ClearAll();
            ConfigFile.WriteLine(true, Convert.ToString(numericUpDown1.Value));
            ConfigFile.WriteLine(true, Convert.ToString(comboBox1.SelectedItem));
            ConfigFile.WriteLine(true, Convert.ToString(numericUpDown2.Value));
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }
    }
}
