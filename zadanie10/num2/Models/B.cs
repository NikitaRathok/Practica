using System;

namespace num2
{
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
}


