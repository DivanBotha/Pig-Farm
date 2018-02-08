using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIG_FARM
{
    public partial class Feeding_Setup : Form
    {
        public Feeding_Setup()
        {
            InitializeComponent();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Century Gothic", 10);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke);
            e.Graphics.TranslateTransform(30, 90);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Fatty Acids", myfont, mybrush, 0, 0);
        }

        private void label2_paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Century Gothic", 10);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke);
            e.Graphics.TranslateTransform(30, 90);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Minerals", myfont, mybrush, 0, 0);
        }

        private void label3_paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Century Gothic", 10);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke);
            e.Graphics.TranslateTransform(30, 90);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Vitamins", myfont, mybrush, 0, 0);
        }

        private void label4_paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Century Gothic", 10);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke);
            e.Graphics.TranslateTransform(30, 90);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Proteins", myfont, mybrush, 0, 0);
        }

        private void label5_paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Century Gothic", 10);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke);
            e.Graphics.TranslateTransform(30, 90);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Other", myfont, mybrush, 0, 0);
        }

        private void label6_paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Century Gothic", 10);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke);
            e.Graphics.TranslateTransform(30, 90);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString("Energy", myfont, mybrush, 0, 0);
        }

        private void Feeding_Setup_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2);
            this.Location = p;
        }
    }
}
