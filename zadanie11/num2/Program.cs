using num2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество зданий");
            int n = int.Parse(Console.ReadLine());
            
            Building[] buildings = new Building[n];
            
            for (int i = 0; i < buildings.Length; i++)
            {
                Console.WriteLine("Введите вес, название здания");
                buildings[i] = new Factory(int.Parse(Console.ReadLine()), Console.ReadLine());
            }

            foreach (Building building in buildings)
            {
                building.DisplayPrint();
            }
            
            var maxH = buildings.Max(b => b.Height());
            Console.WriteLine($"Максимальная высота {maxH}");
        }
    }
}
