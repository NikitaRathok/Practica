using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        public static void RandomMas(int [,] mas,int a ,int b,int n)
        {

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rnd.Next(a, b);
                }
            }
        }
        public static void PrintMas(int[,] mas,  int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" "+mas[i,j]);
                }
                Console.WriteLine();
            }
        }
        public static int SearchMaxItemInColums(int [,] mas,int k)
        {
            var m = mas[0, k];
            for (int i = 0; i < mas.GetLength(1); i++)
            {

                if (mas[i, k] > m)
                {
                    m = mas[i, k];
                }

            }
            return m;
        }
        public static int Sum(int k,int l,int [,] mas,int s)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = k; j < mas.GetLength(1); j++)
                {
                    if (mas[i,j]>= k && mas[i,j]<l)
                    {
                        s = s += mas[i, j];
                    }
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, n];
            Console.WriteLine("Введите а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите l");
            int l = int.Parse(Console.ReadLine());
            var s = 0;
            RandomMas(mas, a, b, n);
            PrintMas(mas, n);
            var maxItem = SearchMaxItemInColums(mas, k);
            Console.WriteLine($"max = {maxItem}");
            var sum =  Sum(k, l, mas, s);
            Console.WriteLine($"suma = {sum}");
        }
    }
}
