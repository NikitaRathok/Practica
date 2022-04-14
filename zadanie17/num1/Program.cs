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
            int a = 0;
            int b = 0;
            int c = 0;
            int p = 0;
            int s = 0;
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
