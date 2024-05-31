using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_workout_application
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage f2 = new Homepage(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f3 = new Signup();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-HV3PEGM7;Initial Catalog=\"workout signup\";Integrated Security=True");
           
          
            
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Signup where name='" + textBox1.Text + "'" + "and password='" + textBox2.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Homepage f2 = new Homepage();
               this.Hide() ;
                f2.Show();
            }
            else
            {

                label4.Text = "Invalid Username or Password";
                label4.Visible = true;
            }
            cn.Close();




            cn.Close();
           
        }

       
    }
}
