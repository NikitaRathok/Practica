using Figurelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace num1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double p = 0;
            double s = 0;
            Treangle t = new Treangle(a, b, c);

            t.EnterSite();
            Console.WriteLine(t.IsCreat());
            Console.WriteLine(t.Perim(p));
            Console.WriteLine(t.S(s)); ;

            Rectangle r = new Rectangle(a, b);

            r.EnterSite();
            Console.WriteLine(r.Perim(p));
            Console.WriteLine(r.S(s));

        }
    }
}
