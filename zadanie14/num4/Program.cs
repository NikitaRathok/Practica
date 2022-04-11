using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace num4
{
    internal class Program
    {
        static int[] C = new int[10];
        
        static void ThreadFunc(int param, out int res, int n)
        {
            int  nt, beg, h, end;
            nt = param;
            res = 0;
            h = 1000 / n;
            beg = h * nt;
            res = beg;
            end = beg + h;
        }
        static void Sum()
        {
            int sum = 0;
            for(int i = 0;i<10;i++)
            {
                if (C[i] % 2 == 0)
                {
                    sum += i;
                    Console.WriteLine("Сумма = " + sum);
                }
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите количество потоков");

           int n = Convert.ToInt32(Console.ReadLine());

            
            Thread[] thead = new Thread[n];
            int[] sl = new int[n];
           
            int[] x = new int[n];
            for (int i = 0; i < 10; i++)
                C[i] = i;
            
           
            for (int i = 0; i < n; i++)
            {
                x[i] = i;
                thead[i] = new Thread(() => ThreadFunc(x[i], out sl[i],n));
                thead[i] = new Thread(Sum);
                thead[i].Start();
                thead[i].Join();
            }
           
        }
    }
}

