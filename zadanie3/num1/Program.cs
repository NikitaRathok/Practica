using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        public class Calculation
        {
            public int x;
            public void Func(int x)
            {
                if (x % 5 == 0)
                {
                    x = x - 5;
                    Console.WriteLine(x);
                }
                else
                {
                    x++;
                    Console.WriteLine(x);
                }
            }
            public Calculation()
            {

            }
        }
        
        static void Main(string[] args)
        {
            Calculation f = new Calculation();
            Console.WriteLine("Введите переменную x");
            f.x = int.Parse(Console.ReadLine());
            f.Func(f.x);

        }
    }
}
