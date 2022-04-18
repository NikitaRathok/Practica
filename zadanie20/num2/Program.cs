using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        static void CalcFirstFunc()
        {
            int m = 20;
            int n = 30;
            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
            Console.WriteLine(z1);
        }
        static void CalsSecondFunc()
        {
            int m = 10;
            int n = 100;
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine(z2);
        }
        static void Main(string[] args)
        {
            Task[] t = new Task[2]
            {
                    new Task(CalcFirstFunc),
                    new Task(CalsSecondFunc),
            };

            foreach (var st in t)
            {
                st.Start();
                Thread.Sleep(500);
            }
        }
    }
}
