using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace num2
{
    internal class Program
    {
        static void Sum()
        {
            
            Stopwatch sw = Stopwatch.StartNew();
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Сумма = { sum += i}" );
                Thread.Sleep(600);
                
            }
            sw.Stop();

            
            Console.WriteLine($"{Thread.CurrentThread.Name} {sw.ElapsedMilliseconds}");
        }
        static void Main(string[] args)
        {
            
            Thread t  = new Thread(Sum);
            t.Name = "Первый поток";
            Thread t1 = new Thread(Sum);
            t1.Name = "Второй поток";
            t.Start();
            
            t1.Start();
        }
    }
}
