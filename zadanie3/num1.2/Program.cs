using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1._2
{
    internal class Program
    {
            static void f(double x, out double y)
            {
                y = 0;
           
                Console.WriteLine($"f({x}) = {f(x)} ");
            }
            static double f(double x)
            {
                double y;
                if (x <= 5) y = Math.Pow(x, 2) + 5;
                else if(x>5&&x<20)  y = 0;
                else  y = 1;

                return y;
            }
        
            static void Main(string[] args)
            {
                double y = 0;
                Console.Write("a=");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("b=");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("h=");
                double h = Convert.ToDouble(Console.ReadLine());

                for(double i = a;i<=b;i+=h)
                {
                    Console.WriteLine($"f({i}) = {f(i)}");
                 
                }

                for (double i = a; i <= b; i += h)
                {
                    Console.WriteLine("============");
                    f(i,out y);

                }
            }
    }
}
