using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num5
{
    internal class Program
    {
        static double Factorial(double n)
        {
            
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        static double Calculation(double n)
        {
            double f = 0;
            return f = 1 / Factorial(n + 3);
        }
        static void Main(string[] args)
        {
          Console.WriteLine("Введите число n ");
          double n = double.Parse(Console.ReadLine());
          Console.WriteLine(Calculation(n));
        }
    }
}
