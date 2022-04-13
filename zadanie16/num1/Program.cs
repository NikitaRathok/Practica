using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace num1
{
    internal class Program
    {
        static void Record()
        {
            Random rand = new Random();
            int[] mas = new int[10];

            StreamWriter file = new StreamWriter("numbers.txt");

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(1, 10);
                file.WriteLine(mas[i]);
            }

            file.Close();
        }

        static int CalcModul()
        {
            string[] mas = File.ReadAllLines("numbers.txt");
            int sum = 0;
            int abs = 0;
            for(int i = 0; i < mas.Length;i++)
            {
                sum = sum + Convert.ToInt32(mas[i]);
                

            }
            abs = Math.Abs(sum);

            return abs;
        }
        static double CalcPow()
        {
            string[] mas = File.ReadAllLines("numbers.txt");
            double p = 1;
            double pow = 0;
            for(int i = 0;i< mas.Length;i++)
            {
                p = p * Convert.ToInt32(mas[i]);

            }
            pow = Math.Pow(p, 2);
            return pow;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Запись чисел в файл");
            Record();

            Console.Write("Модуль суммы ");
            Console.WriteLine(CalcModul());

            Console.Write("Квадрат произведения ");
            Console.WriteLine(CalcPow());
            
        }
    }
}
