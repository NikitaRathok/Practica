using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace num4
{
    public partial class Form1 : Form
    {
        private AirPlane plane;


        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            plane = new AirPlane() { Radius = 100, Image = Image.FromFile("plane.bmp") };
            plane.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            Application.Idle += delegate { Invalidate(); };
        }
    


        class AirPlane
        {
            public float Radius;
            public float Angle;
            public Image Image;

            public void Update(float dt)
            {
                Angle += dt;
            }

            public void Draw(Graphics gr)
            {
                gr.RotateTransform(Angle);
                gr.DrawImage(Image, Radius, 0);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            plane.Update(0.1f);
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            plane.Draw(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image i = Image.FromFile("sky.bmp");
            this.BackgroundImage = i;

        }
    }
}

