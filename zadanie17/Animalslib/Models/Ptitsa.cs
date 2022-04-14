using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalslib
{
    public class Ptitsa:Animals
    {
        public string name = "Гоша";

        public override void Sleep()
        {
            Console.WriteLine("Птица спит");
        }
        public override void Run()
        {
            Console.WriteLine("Птица не может бегать");
        }
        public override void Eat()
        {
            Console.WriteLine("Птица ест жуков и растения");
        }
        public override void Jump()
        {
            Console.WriteLine("Птица прыгает на 2 конечнастях");
        }
        public override void Fly()
        {
            Console.WriteLine("Птица умеет летать");
        }
    }
}
