using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace num4
{
    internal class Program
    {
        private static void Calc(int a)
        {
            try
            {
                a = -7;
                int b = 5;
                double rez = 1;
                for (int i = a; i <= b; i++)
                {

                    rez = Math.Sin(1 / i);
                    Console.WriteLine(rez);
                    Thread.Sleep(1000);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            ParallelLoopResult rez = Parallel.For(-7, 5, Calc);

            Console.ReadLine();
        }
    }
}
