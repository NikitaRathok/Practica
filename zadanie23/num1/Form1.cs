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
            listBox1.Items.Add("Hi my name is Saitama");
            listBox1.Items.Add("Happy New Year");
            listBox1.Items.Add("Nikita Rathok");


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str = listBox1.Text;
            string[] arr = str.Split(' ');
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length != 1)
                {
                    char ch1 = arr[i][0];
                    char ch2 = arr[i][arr[i].Length - 1];
                    arr[i] = ch2 + arr[i].Substring(1, arr[i].Length - 2) + ch1;
                }
                result += arr[i] + " ";
            }
           label1.Text = "Изменённые местами букв= " + result.ToString();


        }


    }
}
