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
        
       
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter A");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter B");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter C");
                double c = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter D");
                double d = Double.Parse(Console.ReadLine());

                MinMax(ref a, ref b);
                MinMax(ref c, ref d);
                MinMax(ref a, ref c);
                MinMax(ref b, ref d);
                Console.WriteLine($"Min {a}, Max {d}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
