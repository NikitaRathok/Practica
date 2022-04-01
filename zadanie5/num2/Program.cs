using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        public static void RandomMas(int [] mas)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(100);
            }
        }
        public static void MinMax( int lastIndexOfMin,  int lastIndexOfMax)
        {
            var min = lastIndexOfMin < lastIndexOfMax ? lastIndexOfMin : lastIndexOfMax;
            var max = lastIndexOfMin > lastIndexOfMax ? lastIndexOfMin : lastIndexOfMax;
            lastIndexOfMin = min;
            lastIndexOfMax = max;
        }
        public static void Sort(int [] mas)
        {
            Array.Sort(mas);
            Array.Reverse(mas);
            foreach (var item in mas)
            {
                Console.Write(" " + item);
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());
            
            int[] mas = new int[100];
            RandomMas(mas);
            int h = 1;
            int  s = 0;
            
            var lastIndexOfMin = Array.LastIndexOf(mas, mas.Min());
            var lastIndexOfMax = Array.LastIndexOf(mas, mas.Max()); 
            for(int i = lastIndexOfMin;i <= lastIndexOfMax;i++)
            {
                MinMax(lastIndexOfMin, lastIndexOfMax);
                s += mas[i];
                h++;
            }

            int rez = s / h;
            Console.WriteLine("Результа = " + rez);
            Console.WriteLine("Сортированыый массив");
            Sort(mas);
            Console.WriteLine(Array.BinarySearch(mas,k));
        }
    }
}
