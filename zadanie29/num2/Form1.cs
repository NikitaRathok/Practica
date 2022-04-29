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
        Bitmap b;
        Graphics g;
        
        Rectangle rct;
        public Form1()
        {
            InitializeComponent();
            b = new Bitmap("baner.png");
            g = Graphics.FromImage(b);
           
            rct.X = 0;
            rct.Y = 0;
            rct.Width = b.Width;
            rct.Height = b.Height;
            timer1.Interval = 50;
            timer1.Enabled = true;
        }
       
       
           
            
     

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = 50; 
            int count = 0;
            int max = 100;
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);


            timer1.Tick += new EventHandler((o, ev) =>
            {
                rct.X -= 1;

                g.Clear(Color.White);
                for (int i = 0; i <= Convert.ToInt32(this.ClientSize.Width / rct.Width) + 1; i++)
                {


                    g.DrawImage(b, rct.X + i * rct.Width, rct.Y);
                }
                count++;

                if (count == max)
                {
                    Timer t = o as Timer; 
                    t.Stop();
                }
            });
            timer1.Start(); 
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
