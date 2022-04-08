using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        public delegate double CalcFigure(double r);

        public static double GetLength(double r)
        {
            double d;
            d = 2 * Math.PI * r;
            Console.WriteLine($"Длина окружности = {Math.Round(d, 3)}");
            return d;

        }

        public static double GetArea(double r)
        {
            double s;
            s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга = {Math.Round(s, 3)}");
            return s;
        }

        public static double GetVolume(double r)
        {
            double v;
            v = (4/3) * Math.PI* Math.Pow(r, 3);
            Console.WriteLine($"Объём шара = {Math.Round(v, 3)}");
            return v;
        }
        
        public static void Write(CalcFigure c)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            c(r);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус ");
            double r = Convert.ToDouble(Console.ReadLine());
            CalcFigure cf = new CalcFigure(GetArea);

            cf += GetLength;
            cf += GetVolume;

            cf(r);
            Write(cf);
        }
    }
}
