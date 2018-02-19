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
    public partial class Reports_General : Form
    {
        public Reports_General()
        {
            InitializeComponent();
        }

        private void Reports_General_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2);
            this.Location = p;
            Reports_General_1_Info.Height = 30;
            Reports_General_2_Info.Height = 30;
            Reports_General_3_Info.Height = 30;
            Reports_General_4_Info.Height = 30;
            Reports_General_5_Info.Height = 30;
            Reports_General_6_Info.Height = 30;
            Reports_General_7_Info.Height = 30;
        }

        private void Reports_Head_1_Label_Click(object sender, EventArgs e)
        {
            if (Reports_General_1_Info.Height == 30)
            {
                Reports_General_1_Info.Height = 285;
            }
            else
            {
                Reports_General_1_Info.Height = 30;
            }
        }

        private void Reports_General_Head_2_Click(object sender, EventArgs e)
        {
            if (Reports_General_2_Info.Height == 30)
            {
                Reports_General_2_Info.Height = 140;
            }
            else
            {
                Reports_General_2_Info.Height = 30;
            }
        }

        private void Reports_General_Head_3_Click(object sender, EventArgs e)
        {
            if (Reports_General_3_Info.Height == 30)
            {
                Reports_General_3_Info.Height = 140;
            }
            else
            {
                Reports_General_3_Info.Height = 30;
            }
        }

        private void Reports_General_Head_4_Click(object sender, EventArgs e)
        {
            if (Reports_General_4_Info.Height == 30)
            {
                Reports_General_4_Info.Height = 135;
            }
            else
            {
                Reports_General_4_Info.Height = 30;
            }
        }

        private void Reports_General_Head_5_Click(object sender, EventArgs e)
        {
            if (Reports_General_5_Info.Height == 30)
            {
                Reports_General_5_Info.Height = 135;
            }
            else
            {
                Reports_General_5_Info.Height = 30;
            }
        }

        private void Reports_General_Head_6_Click(object sender, EventArgs e)
        {
            if (Reports_General_6_Info.Height == 30)
            {
                Reports_General_6_Info.Height = 114;
            }
            else
            {
                Reports_General_6_Info.Height = 30;
            }
        }

        private void Reports_General_Head_7_Click(object sender, EventArgs e)
        {
            if (Reports_General_7_Info.Height == 30)
            {
                Reports_General_7_Info.Height = 110;
            }
            else
            {
                Reports_General_7_Info.Height = 30;
            }
        }
    }
}
