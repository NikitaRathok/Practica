using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4
{
    internal class Program
    {
        static void Record()
        {
            string[] mas = new string[2];

            StreamWriter f = new StreamWriter("text.txt");

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"Строка: ");
                mas[i] = Console.ReadLine();

                f.WriteLine(mas[i]);
            }

            Console.WriteLine("Запись завершена");
            f.Close();
        }

        static string[] Write()
        {
            string[] mas = File.ReadAllLines("text.txt");

            foreach (string s in mas)
            {
                Console.WriteLine(s);
            }

            return mas;
        }

        static void Replace(string[] mas)
        {
            StreamWriter f1 = new StreamWriter("text1.txt");

            foreach (string s in mas)
            {
                for (var i = 0; i < s.Length; i++)
                {
                    f1.Write(Convert.ToChar(s[i]) == '1' ? '0' : Convert.ToChar(s[i]) == '0' ? '1' : Convert.ToChar(s[i]));
                }
            }
            f1.Close();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Запишите 2 строкм:");
            Record();

            string[] mas = Write();

            Console.WriteLine("Файл изменен");
            Replace(mas);
        }
    }
}
