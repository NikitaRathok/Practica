using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        static void CalcMul()
        {
            int c = 323;
            int b = c / 100 % 10;
            int n = c / 10 % 10;
            int d = c % 10;

            var rez = b * d;
            Console.WriteLine(rez);

        }
        static void Main(string[] args)
        {
            Task t = new Task(CalcMul);

            t.Start();
            t.Wait();

            Task t1 = new Task(CalcMul);
            t1.Start();

        }
    }
}
