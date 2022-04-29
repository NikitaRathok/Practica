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
        
       
        Image ni;
        Rectangle rct;
        public Form1()
        {
            InitializeComponent();
             ni = Image.FromFile("baner.png");
            rct.X = 0;
            rct.Y = 0;
            rct.Width = ni.Width;
            rct.Height = ni.Height;
            timer1.Interval = 50;
            timer1.Enabled = true;
        }
       
           
            
     

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            rct.X -= 1;
            if (Math.Abs(rct.X) > rct.Width)
            {
                rct.X += rct.Width;

            }
            for (int i = 0; i <= Convert.ToInt32(this.ClientSize.Width / rct.Width) + 1; i++)
            {

               
            }
        }
         private void Form1_Paint(object sender, PaintEventArgs e)
          {
                    e.Graphics.DrawImage(ni, rct);
          }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < rct.Y + rct.Height) && (e.Y > rct.Y))
            {
                if (timer1.Enabled != false)
                {
                    timer1.Enabled = false;
                }
            }
            else
            {
                if (timer1.Enabled != true)
                {
                    timer1.Enabled = true;
                }
            }
        }

        
    }
}
