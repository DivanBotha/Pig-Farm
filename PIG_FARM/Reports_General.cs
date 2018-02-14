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
        bool p1E = false;
        bool p2E = false;
        public Reports_General()
        {
            InitializeComponent();
        }

        private void Reports_General_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2);
            this.Location = p;
            Reports_General_1_Info.Height = 0;
            Reports_General_2_Info.Height = 0;
            Reports_Genral_2_Head.Top = Reports_General_1_Info.Top;
        }

        private void Reports_Head_1_Label_Click(object sender, EventArgs e)
        {
            if(!p1E)
            {
                Reports_General_1_Info.Height = 119;
                Reports_Genral_2_Head.Top = Reports_General_1_Info.Top + Reports_General_1_Info.Height;
            }
            else
            {
                Reports_General_1_Info.Height = 0;
                Reports_Genral_2_Head.Top = Reports_General_1_Info.Top;
            }
            p1E = !p1E;
        }

        private void Reports_Head_2_Label_Click(object sender, EventArgs e)
        {
            if (!p2E)
            {
                Reports_General_2_Info.Height = 119;
                Reports_General_2_Info.Top = Reports_Genral_2_Head.Top + 30;
            }
            else
            {
                Reports_General_2_Info.Height = 0;

            }
            p2E = !p2E;
        }
    }
}
