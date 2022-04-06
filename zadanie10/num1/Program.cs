using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using num1.Models;

namespace num1.Models
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону а");
            Square sq = new Square(int.Parse(Console.ReadLine()));

            Rectangle rec = new Rectangle(sq.a);
            rec.raznStaron = int.Parse(Console.ReadLine());

            var rez =rec.CalculatS();
            Console.WriteLine($"Площадь прямаугольника: {rez}");
            var rez1 = sq.CalculatS();
            Console.WriteLine($"Площадь квадрадата {rez1}");

        }
    }
}
