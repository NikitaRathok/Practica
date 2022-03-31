using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        public static void CalculationPunktA(double x)
        {
            try
            {
                double y = Math.Pow(Math.Sin(x), 3) / Math.Pow(x, 3);
                Console.WriteLine(y);
            }
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void CalculationPunktB(double x)
        {
            try
            {
                double y = (x) / (x-1) - 3 * x;
                Console.WriteLine(y);
            }
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите х");
                double x = Convert.ToDouble(Console.ReadLine());
                CalculationPunktA(x);
                CalculationPunktB(x);
            }
            
             catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
