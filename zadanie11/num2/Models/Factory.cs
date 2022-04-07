using System;

namespace num2.Models
{

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

}
