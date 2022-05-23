using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvManagement
{
    public partial class completed : Form
    {
        public completed()
        {
            InitializeComponent();
        }
        private int ticks;
        private void completed_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if(ticks == 4)
            {
                this.Hide();
            }
        }
    }
}
