using System;

namespace num1
{
    internal partial class Program
    {
        class TestClass :Iz, Ix, Iy
        {

           public int w;
          

            public TestClass()
            {
                w = 10;
            }
            public TestClass(int key)
            {
                w = key;
            }

            public void IxF0(int key)
            {
                w = key * 10;
                Console.WriteLine($"IxF0 = {w}");
            }
            public void IxF1()
            {
                w = w * 10;
                Console.WriteLine($"IxF1 = {w}");
            }

             void  Iz.F0(int key)
             {
                w = key / 10;
                Console.WriteLine($"Iz.F0 = {w}");
            }
            void Iz.F1()
            {
                w = w / 10;
                Console.WriteLine($"Iz.F1 = {w}");
            }
            public void F0(int key)
            {
                w = key - 10;
                Console.WriteLine($"IyF0 = {w}");
            }
            public void F1()
            {
                w = w - 10;
                Console.WriteLine($"IyF1 = {w}");
            }
        }
    }
}
