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
            works_panel.Hide();
            reports_panel.Hide();
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
            works_panel.Hide();
            reports_panel.Hide();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
            works_panel.Hide();
            reports_panel.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
            works_panel.Hide();
            reports_panel.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
            works_panel.Show();
            reports_panel.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
            works_panel.Hide();
            reports_panel.Show();
        }

    }

}
