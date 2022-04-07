using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        class Building
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

        }

        class Office : Building
        {
            public int n;

            
            public override void DisplayPrint()
            {
                Console.WriteLine($"Офис: {Name}, количество этажей: {n}, Высота {Height()}" );
            }

            public virtual double Height()
            {
                return 0.05 * n;
            }
            public Office(int n,string name):base(name)
            {
                this.n = n;
            }
        }

        class Factory : Building
        {
            public double g;

            public Factory(double g,string name):base(name)
            {
                this.g = g;
                
            }
            public override void DisplayPrint()
            {
                Console.WriteLine($"Завод: { Name}, вес: {g} , Высота {Height()}" );
            }

            public virtual double Height()
            {
                return 0.000005 * g;
            }
            
        }

        static void Main(string[] args)
        {
           
            
            Building[] buildings =new Building[] {
                new Factory(10000,"Метал"), 
                new Office(10,"Епам")
            };

            foreach(Building building in buildings)
            {
                building.DisplayPrint();
            }

        }
    }
}
