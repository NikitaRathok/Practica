using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        public delegate void Colors();

        static void PrintFirstColor()
        {
            Console.WriteLine("Красный");
        }
       static void PrintSecondColor()
        {
            Console.WriteLine("Оранжевый");
        }
      static  void PrintLastColor()
        {
            Console.WriteLine("Чёрный");
        }
        static void ColorsDeleg(Colors s)
        {
            s();
        }
        static void Main(string[] args)
        {
            Colors c = new Colors(PrintFirstColor);

            c += PrintSecondColor;
            c += PrintLastColor;

            c();

            ColorsDeleg(c);
        }
    }
}
