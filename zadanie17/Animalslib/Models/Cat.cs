using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalslib
{
    public class Cat:Animals
    {
        public string name = "Барсик";
        public override void Eat()
        {
            Console.WriteLine("Кот ест");
        }
        public override void Fly()
        {
            Console.WriteLine("Кот не умеет летать");
        }
        public override void Jump()
        {
            Console.WriteLine("Кот прыгает с 4 конечностей");
        }
        public override void Run()
        {
            Console.WriteLine("Кот бегает на 4 конечностях");
        }
        public override void Sleep()
        {
            Console.WriteLine("Кот спит");
        }
    }
}
