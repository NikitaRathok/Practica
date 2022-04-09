using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            MyInfo inf = new MyInfo();
            Famaly f = new Famaly();
            Friends fr = new Friends();

            inf.Changed += f.Message;
            inf.Changed += f.SomeMessage;
            inf.Changed += fr.Message;

            Console.WriteLine("Введите имя");
            var name = Console.ReadLine();
            inf.OnChanged(name);

           
            Console.WriteLine("После отписки");
            Console.WriteLine("Введите имя");
            var n = Console.ReadLine();
            inf.Changed -= f.SomeMessage;
            inf.OnChanged(n);

        }
    }
}
