using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        public class Circle:Tochka
        {
            public double Radius{ get; private set;}
            public double x;
            public double y;

            public Circle(double radius):base()
            {
                Radius = radius;
            }

            public Circle()
            {
            }

            public void Creat()
            {
                Console.WriteLine("Введите радиус");

                Radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите точку х");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите точку у");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Круг создан");
            }
            public double S()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
            public double P()
            {
                return 2 * Math.PI * Radius; 
            }
            public void ProverkaPopadnia()
            {
                if(Math.Pow(a - x, 2) + Math.Pow(a - b, 2) < Math.Pow(Radius, 2) || Math.Pow(a - x, 2) + Math.Pow(a - b, 2) == Math.Pow(Radius, 2))
                {
                    Console.WriteLine("Точка попала в круг");
                }
                else
                {
                    Console.WriteLine("Точка не попала");
                }
            }

        }
        public class Tochka
        {
            public double a;
            public double b;

            public void Creat()
            {
                Console.WriteLine("Введите точку а");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Точку b");
                b = Convert.ToDouble(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
            Circle c = new Circle();
            Tochka t = new Tochka();

            Console.WriteLine("Создание круга");
            c.Creat();
            Console.WriteLine(" ");
            Console.WriteLine("Создние точки");
            t.Creat();

            Console.WriteLine("Выберите действие: 1-Подсчёт площади.  2- Подсчёт длинны. 3- Проверка на то попала ли точка в круг");
            int k = int.Parse(Console.ReadLine());
            switch(k)
            {
                case 1:
                    {
                        Console.WriteLine($"Площадь = {c.S()}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Длинна = {c.P()}");
                        break;
                    }
                case 3:
                    {
                        c.ProverkaPopadnia();
                        break;
                    }
            }
            
        }
    }
}
