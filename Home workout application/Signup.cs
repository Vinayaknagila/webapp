using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home_workout_application
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ENTER YOUR NAME");

            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("ENTER YOUR AGE");

            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("ENTER YOUR MAIL");

            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("ENTER YOUR NUMBER");

            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("ENTER YOUR PASSWORD");
            }

            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-HV3PEGM7;Initial Catalog=\"workout signup\";Integrated Security=True");
            SqlCommand cd = new SqlCommand("insert into Signup values (@name, @age, @mail, @number, @password)"); cd.Parameters.AddWithValue("@name", textBox1.Text); cd.Parameters.AddWithValue("@mail", textBox3.Text); cd.Parameters.AddWithValue("@age", textBox2.Text); cd.Parameters.AddWithValue("@password", textBox5.Text); cd.Parameters.AddWithValue("@number", textBox4.Text);
            cd.Connection = cn;
            try
            {


                cn.Open();
                cd.ExecuteNonQuery();
                label6.Text = "registratiion done";
                cn.Close();
            }

            catch (Exception ex)
            {
                label6.Text = ex.Message;
            }


            LOGIN f1 = new LOGIN(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
