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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        Point lastPoint;

        public object Form2 { get; private set; }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
        }
        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Minimize_Label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Label_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit AgriPig?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void MiniMaxi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            setup_click_panel.Show();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel3.Controls.Add(frm);
            frm.Visible = true;
        }
    }

}
