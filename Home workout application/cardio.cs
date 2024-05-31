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
    public partial class cardio : Form
    {
        public cardio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Timex f2 = new Timex();
            this.Hide();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Timex f2 = new Timex();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timex f2 = new Timex();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timex f2 = new Timex();
            this.Hide();
            f2.Show();
        }
    }
}
