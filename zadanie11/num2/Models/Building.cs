using System;

namespace num2.Models
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

}
