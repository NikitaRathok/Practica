using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        public static void MinMax(ref double x,ref double y)
        {
            var min = x < y ? x : y;
            var max = x > y ? x : y;
            x= min;
            y= max;

            
        }
        public static void Print( ref double x , ref double y)
        {
            Console.WriteLine(MinMax(ref x, ref y));
            
        }
        static void Main(string[] args)
        {
            double a = Double.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            MinMax(ref a, ref b);

           
           


           


        }
    }
}
