using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4
{
    delegate int MyDelegate(ref int[] Mas);
    class Program
    {
        public static int Counting(ref int[] Mas)
        {
            Random rnd = new Random();

            int count = 0;

            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rnd.Next(0, 10);
                count += Mas[i];
            }

            return count / Mas.Length;
        }
        static void Main(string[] args)
        {
            int[] MasArg = new int[5];

            MyDelegate myDelegate = delegate (ref int[] Mas)
            {
                return Counting(ref Mas);
            };

            Console.WriteLine(myDelegate(ref MasArg));
        }
}   }
