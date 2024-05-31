using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_workout_application
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\india\pack\gym icons and images\Name-48-50px\img3.jpg");
          
            
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\india\pack\gym icons and images\Name-48-50px\img2.jpg");
            }
        }

        private void simpleBodyWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simple c = new simple();
            c.Show();
        }

        private void workoutWithDumbellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dumbell d1 = new dumbell();
            d1.Show();
        }

        private void resistanceBandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resis r1 = new resis();
                r1.Show();
        }

        private void cardioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cardio c1 = new cardio();   
                c1.Show();
        }
    }
}