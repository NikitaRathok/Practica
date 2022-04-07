using System;

namespace num1.Models
{

    class Office : Building
    {
        public int n;


        public override void DisplayPrint()
        {
            Console.WriteLine($"Офис: {Name}, количество этажей: {n}, Высота {Height()}");
        }

        public virtual double Height()
        {
            return 0.05 * n;
        }
        public Office(int n, string name) : base(name)
        {
            this.n = n;
        }
    }

}
