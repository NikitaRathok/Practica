using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace num3
{
    internal class Program
    {
        
        static void Sum(int a,int n)
        {
            double sum = 0;
           for(int i = 0;i<=n;i++)
           {
                sum += Math.Pow(a, i);
                Console.WriteLine($"{Thread.CurrentThread.Name} {sum}");
                Thread.Sleep(500);
            }
        }
        static void Proizv(int a,int n)
        {
            
            double proizv = 1;
            for(int i = 1;i<=n;i++)
            {
                proizv *= Math.Pow(a, i);
                Console.WriteLine($"{Thread.CurrentThread.Name} {proizv}");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите a ");
            int a = Convert.ToInt32(Console.ReadLine());

            ThreadStart ts = new ThreadStart(delegate () {
                Sum(a, n);

            });

            Thread t = new Thread(ts);
             
            t.Name = "Первый поток";
           
            ThreadStart ts1 = new ThreadStart(delegate () {
                Sum(a, n);
                Proizv(a, n);
            });
            Thread t1 = new Thread(ts1);
            t1.Name = "Второй поток";
            t.Start();
            t.Join();
            t1.Start();
            
           
           
            
            


        }
    }
}
