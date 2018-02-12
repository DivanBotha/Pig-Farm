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
            Works_Panel.Hide();
            Reports_Panel.Hide();
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
            Works_Panel.Hide();
            Reports_Panel.Hide();
            Animals_Search_Panel.Hide();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
            Works_Panel.Hide();
            Reports_Panel.Hide();
            Animals_Search_Panel.Hide();
            Container.Controls.Clear();
            Home_Form frm = new Home_Form()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
            Works_Panel.Hide();
            Reports_Panel.Hide();
            Animals_Search_Panel.Show();
            Container.Controls.Clear();
            Animals_Form frm = new Animals_Form()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
            Works_Panel.Show();
            Reports_Panel.Hide();
            Animals_Search_Panel.Hide();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            setup_click_panel.Hide();
            Works_Panel.Hide();
            Reports_Panel.Show();
            Animals_Search_Panel.Hide();
        }

        private void BunifuFlatButton21_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Program_parameters_form frm = new Program_parameters_form()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void BunifuFlatButton20_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Setup_AniClass_Breeds frm = new Setup_AniClass_Breeds()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void BunifuFlatButton19_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Housing_Setup_Form frm = new Housing_Setup_Form()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void BunifuFlatButton18_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Herd_Setup_Form frm = new Herd_Setup_Form()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void BunifuFlatButton17_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Medical_Setup_Form frm = new Medical_Setup_Form()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void BunifuFlatButton16_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Feeding_Setup frm = new Feeding_Setup()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void BunifuFlatButton15_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Culling_Setup frm = new Culling_Setup()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void Marketing_Button_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Marketing_Setup_Form frm = new Marketing_Setup_Form()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void bunifuFlatButton27_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Works_Services frm = new Works_Services()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }

        private void bunifuFlatButton26_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Works_Farrowing frm = new Works_Farrowing()
            {
                TopLevel = false
            };
            Container.Controls.Add(frm);
            frm.Show();
        }
    }

}
        