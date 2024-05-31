using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Home_workout_application
{
    public partial class simple : Form
    {
        public simple()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {


            Timex f4 = new Timex();
            f4.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Timex f2 = new Timex();
            this.Hide();
            f2.Show();
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
    }
}
