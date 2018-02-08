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
    public partial class Culling_Setup : Form
    {
        public Culling_Setup()
        {
            InitializeComponent();
        }

        private void Culling_Setup_Load(object sender, EventArgs e)
        {
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2);
            this.Location = p;
        }
    }
}
