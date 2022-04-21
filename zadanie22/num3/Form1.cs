using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-4";
            textBox2.Text = "-6,2";
            textBox3.Text = "-0,2";
            textBox4.Text = "0,1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);

            for(double i = x0;i>=xk;i +=dx)
            {
                double y = i + Math.Sqrt(Math.Abs(Math.Pow(i, 3) + a - a * Math.Pow(Math.E, i)));
                textBox5.Text += "x=" + Convert.ToString(i) + "; y=" + Convert.ToString(y) + Environment.NewLine;
            }
           
        }

        
    }
}
