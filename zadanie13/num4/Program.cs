using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4
{
    internal class Program
    {
        class MyInfo
        {
            string name = "Никита";
            public delegate void Info(string name);
            public event Info Changed;
            public void OnChanged(string n)
            {
                if (name != n)
                {
                    Changed(n);
                    name = n;
                }
            }
        }
        class Famaly
        {
            public void Message(string message)
            {
                Console.WriteLine($" {message}  не мой сын");
            }
            public void SomeMessage(string message)
            {
                Console.WriteLine($"{message} возможно имя изменено");
            }
        }
        class Friends
        {
            public void Message(string message)
            {
                Console.WriteLine($" {message}  не наш друг");
            }
        }

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
