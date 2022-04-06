using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    class A
    {
        protected float a;

        protected float b;

        public float C
        {

            get { return a / b; }
        }
        public A(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
    }
    class B : A
    {
        public float d;


        public float C2
        {

            get
            {
                if (d == 0)
                {

                    Console.WriteLine("Число d не должно быть равно 0");
                    Console.WriteLine("Введите число большее 0");
                    d = Convert.ToInt32(Console.ReadLine());
                }

                return a + b + d;

            }
        }
        public B(float a, float b) : base(a, b)
        {
            this.a = a;
            this.b = b;
        }
        public B(float a, float b, float d) : this(a, b)
        {
            this.a = a;
            this.b = b;
            this.d = d;
        }



    }
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


