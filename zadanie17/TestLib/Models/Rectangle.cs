using System;
namespace Figurelib
{
   public class Rectangle : Figure
    {
        public double a;
        public double b;

        public Rectangle(double a, double b) : base()
        {
            this.a = a;
            this.b = b;
        }
        public override void EnterSite()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }
        public override double Perim(double p)
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