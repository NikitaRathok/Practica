using System;

namespace num1.Models
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

}
