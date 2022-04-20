using System;
namespace Figurelib
{
    public class Treangle : Figure
    {
        public double a;
        public double b;
        public double c;

        public Treangle(double a, double b, double c) : base()
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override void EnterSite()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
        }
        public bool IsCreat()
        {
            if (a == 0 || b == 0 || c == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override double Perim(double p)
        {
            p = a + b + c;
            return p;
        }
        public override double S(double s)
        {
            s = 0.5 * a * b;
            return s;
        }
        public void TypeOfTreangle()
        {
            if (a == b)
            {
                Console.WriteLine("Равнобедренный");
            }
            else if (a == b && a == c && b == c)
            {
                Console.WriteLine("Равносторонний");
            }
            else
            {
                Console.WriteLine("Прямоугольный");
            }
        }

    }

}