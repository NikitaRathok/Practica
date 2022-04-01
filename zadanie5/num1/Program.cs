using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int k = 0;
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int [] m = new int [n];

            for (int i = 0; i < n; i++)
            {
               m[i] = rand.Next(20);
                Console.WriteLine("Изначальный массив " + m[i]);
                
            }
            for(int i = 0; i < n;i++)
            {

                
                if(m[i]>0)
                {
                    k++;
                    Console.WriteLine("Положиьельные элементы "+m[i]);
                    
                }
                
            }
            Console.WriteLine("колличество " + k);
        }
    }
}
