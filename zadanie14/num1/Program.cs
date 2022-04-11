using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace num1
{
    internal class Program
    {
        public delegate void ThreadStart();

       static void PrintFirstThread()
        {
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine($"Первый поток: {i}");
                Thread.Sleep(400);
            }
        }
        static void PrintSecondThread()
        {
            for(int i = 10;i<=19;i++)
            {
                Console.WriteLine($"Второй поток: {i}");
                Thread.Sleep(400);
            }
        }
        static void PrintThirdThread()
        {
            for (int i = 20; i <= 29; i++)
            {
                Console.WriteLine($"Третий поток: {i}");
                Thread.Sleep(400);
            }
        }
        static void Main(string[] args)
        {
            
            Thread t = new Thread(PrintFirstThread);

            Thread t1 = new Thread(PrintSecondThread);

            Thread t2 = new Thread(PrintThirdThread);
            t.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.BelowNormal;
            t2.Priority = ThreadPriority.Lowest;
            
            t.Start();
            t.Join(100);
            t1.Start();
            t.Join(100);
            t2.Start();
            
           
           
            




        }


    }
}
