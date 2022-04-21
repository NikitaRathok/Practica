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
        Point[] points = new Point[50];
        Pen p = new Pen(Color.Black, 2);
        private void Form1_print(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            g.DrawEllipse(p, 300, 220, 500, 400);
            g.FillEllipse(new SolidBrush(Color.Black), 120, 220, 250, 150);
            g.FillEllipse(new SolidBrush(Color.Black), 720, 220, 250, 150);
            g.FillEllipse(new SolidBrush(Color.Black), 400, 320, 50, 100);
            g.FillEllipse(new SolidBrush(Color.Black), 600, 320, 50, 100);

            g.FillEllipse(new SolidBrush(Color.Black), 500, 420, 50, 50);


        }
      
        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
    } }
