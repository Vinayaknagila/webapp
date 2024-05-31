using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_workout_application
{
    public partial class Timex : Form
    {
        public Timex()
        {
            InitializeComponent();
        }
        int timeCs; int timeSec;
        bool isActive;
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private int counter = 30;


        private void button1_Click(object sender, EventArgs e)
        {
            isActive = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (isActive)
            {


                timeCs++;

                if (timeCs >= 70)
                {
                    timeSec++;
                    timeCs = 0;
                }

            }
            DrawTime();

        }

        private void DrawTime()
        {
            label1.Text = String.Format("{0:00}", timeCs);
            label2.Text = String.Format("{0:00}", timeSec);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }

        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ResetTime();
            isActive = false;
        }

    }
}
