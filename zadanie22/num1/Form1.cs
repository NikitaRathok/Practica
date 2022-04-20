using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "6,51";
            textBox2.Text = "0,827";
            textBox3.Text = "25,001";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            

            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            double c = Math.Pow(2, Math.Pow(y, x)) + Math.Pow(3, Math.Pow(x, y)) - (y * (Math.Atan(z) - (Math.PI/6)))/(Math.Abs(x)+ (1/Math.Pow(y,2)+1));

            textBox4.Text += Environment.NewLine + "C = " + c.ToString();
        }

       
    }
}
