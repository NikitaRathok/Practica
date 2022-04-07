using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        abstract class Building
        {
            public string Name { get; }

            public virtual void DisplayPrint()
            {
                Console.WriteLine($"Здание:{Name} ");
            }
            public Building(string name)
            {
                Name = name;
            }
            public abstract double Height();

            public static bool operator >(Building b1, Building b2)
            {

                for (int i = 0; i < b1.Height(); i++)
                {
                    if (b1 > b2)
                    {
                        return true;
                    }
                }
                return false;
            }
            public static bool operator <(Building b1, Building b2)
            {

                for (int i = 0; i < b1.Height(); i++)
                {
                    if (b1 < b2)
                    {
                        return true;
                    }
                }
                return false;
            }
            


        }

        class Office : Building
        {
            public int n;

            public override void DisplayPrint()
            {
                Console.WriteLine($"Офис: {Name}, количество этажей: {n}, Высота {Height()}");
            }

            public override double Height()
            {
                return 0.05 * n;
            }
            public Office(int n, string name) : base(name)
            {
                this.n = n;
            }
        }

        class Factory : Building
        {
            public double g;

            public Factory(double g, string name) : base(name)
            {
                this.g = g;

            }
            public override void DisplayPrint()
            {
                Console.WriteLine($"Завод: { Name}, вес: {g} , Высота {Height()}");
            }

            public override double Height()
            {
                return 0.000005 * g;
            }


        }

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
