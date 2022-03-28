using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        public class A
        {
            public int a ;
            public int b ;

            public double FuncCalc(int a, int b)
            {
                return (3 * b - (2 / (Math.Pow(a, 2)))) / 4;
            }
            public double Kub(double x)
            {
                return Math.Pow(x, 3);
            }
           
            public  A(int a,int b)
            {
                this.a = a;
                this.b = b;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите а и b");
            A a = new A(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Подсчёт функции { a.FuncCalc(a.a, a.b)}");
            Console.WriteLine($"Число а в кубе {a.Kub(a.a)}"+  
                $"\nЧисло b в кубе {a.Kub(a.b)}") ;
        }
    }
}
