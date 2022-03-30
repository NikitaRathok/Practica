using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        
            public static int Func(int x)
            {
                if (x % 5 == 0)
                {
                   return x = x - 5;
                   
                }
                else
                {
                    return x++;
                    
                }
            }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            int x = int.Parse(Console.ReadLine());
            var rez = Func(x);

            Console.WriteLine(rez);

        }
    }
}
