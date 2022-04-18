using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        static void SwapNumber()
        {
            int c = 1234;

            int a = c / 1000;
            int b = c / 100 % 10;
            int n = c / 10 % 10;
            int d = c % 10;

            var rez = a * 100 + b * 1000 + n + d * 10;
            Console.WriteLine(rez);

        }
        static void Main(string[] args)
        {
            Task t = new Task(SwapNumber);
            t.Start();
            t.Wait();

            Task t1 = Task.Factory.StartNew(SwapNumber);


            Task t2 = Task.Run(SwapNumber);
        }
    }
}
