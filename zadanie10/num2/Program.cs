using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2.Models
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a b ");
            A classA = new A(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            B classB = new B(2, 2);

            Console.WriteLine("Введите число D");
            classB.d = float.Parse(Console.ReadLine());

            Console.WriteLine(classA.C);
            Console.WriteLine(classB.C2);
        }
    }
}


