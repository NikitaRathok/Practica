using Animalslib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Console.WriteLine($"Кличка кота {c.name}");
            c.Sleep();
            c.Run();
            c.Fly();
            c.Eat();
            c.Jump();

            Ptitsa p = new Ptitsa();
            Console.WriteLine($"Кличка птица {p.name}");
            p.Run();
            p.Fly();
            p.Sleep();
            p.Eat();
            p.Jump();
        }
    }
}
