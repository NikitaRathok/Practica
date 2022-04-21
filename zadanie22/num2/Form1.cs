using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = Convert.ToDouble(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = Convert.ToDouble(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            double u ;
            double k ;
            double c ;
           

            if (radioButton1.Checked == true)
            {
                 u = ((Max(Math.Sin(x), y, z)) / (Min(Math.Pow(x, 2), y))) + 5;
                textBox4.Text += Environment.NewLine + "U = " + u.ToString();

            }
            else if (radioButton2.Checked == true)
            {
                 k = ((Max(Math.Pow(x, 2), y, z)) / (Min(Math.Pow(x, 2), y))) + 5;
                textBox4.Text += Environment.NewLine + "K = " + k.ToString();
            }
            else if(radioButton3.Checked == true)
            {
                c = ((Max(Math.Pow(Math.E, x), y, z)) / (Min(Math.Pow(x, 2), y))) + 5;
                textBox4.Text += Environment.NewLine + "C = " + c.ToString();
            }
            

        }

        private double Max(double x,double y ,double z)
        {
            
            if(x>y&&x>z)
            {

                return x;
            }
            else if(y>x&&y>z)
            {
                return y;
            }
            else
            {
                return z;
            }
            
        }
        private double Min(double x, double y)
        {

            if (x<y )
            {

                return x;
            }
            else 
            {
                return y;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }
    }
}
