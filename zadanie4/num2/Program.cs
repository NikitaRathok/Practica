using num2.Exceptions;
using System;

namespace num2
{
    internal class Program
    {
        public static void FuncCalcl(double x)
        {
            try
            {
                if (x > -2 && x <= 5)
                {
                    double f = (3 * x) / (x - 5);
                    Console.WriteLine(f);
                }
                else if (x > 5)
                {
                    double f = x - 1;
                    Console.WriteLine($"Функия  = {f} ");
                }
                else throw new OutOfDiapazonException("Erorr, Допустимый диапазо [-2..100]", "Comment");
            }
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfDiapazonException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x = ");
                double x = Convert.ToDouble(Console.ReadLine());
                FuncCalcl(x);
            }
            
             catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfDiapazonException ex)
            {
                Console.WriteLine(ex.Comment, ex.Message);
            }
            
        }
    }
}
