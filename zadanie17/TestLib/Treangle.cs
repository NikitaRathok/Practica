using System;
namespace Figurelib
{
    public class Treangle : Figure
    {
        public int a;
        public int b;
        public int c;

        public Treangle(int a, int b, int c) : base()
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
        public override int Perim(int p)
        {
            p = a + b + c;
            return p;
        }
        public override double S(double s)
        {
            s = 1 / 2 * a * b;
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