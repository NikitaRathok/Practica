using System;
namespace Figurelib
{
   public class Rectangle : Figure
    {
        public int a;
        public int b;

        public Rectangle(int a, int b) : base()
        {
            this.a = a;
            this.b = b;
        }
        public override void EnterSite()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }
        public override int Perim(int p)
        {
            p = (a + b) * 2;
            return p;
        }

        public override double S(double s)
        {
            s = a * b;
            return s;
        }

    }

}