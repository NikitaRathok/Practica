using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace num6_16_
{
    internal class Program
    {
        /// <summary>
        /// Запись файла 
        /// </summary>
        static void Recorder()
        {
            string[] mas = new string[5];

            StreamWriter file = new StreamWriter("sometext.txt");

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"Строка: {i}: ");
                mas[i] = Console.ReadLine();

                file.WriteLine(mas[i]);
            }

            Console.WriteLine("Строки записаны");
            file.Close();
        }
        /// <summary>
        /// Вывод данных файла на экран
        /// </summary>
        /// <returns>массив данных файла</returns>
        static string[] Print()
        {
            string[] mas = File.ReadAllLines("sometext.txt");

            foreach (string s in mas)
            {
                Console.WriteLine(s);
            }

            return mas;
        }
        /// <summary>
        /// Подсчёт колличества строк в файле
        /// </summary>
        /// <returns>колличество строк</returns>
        static int StrSum()
        {
            int count = System.IO.File.ReadAllLines("sometext.txt").Length;

            return count;
        }
        /// <summary>
        /// Вывод на экран строк файла записанных в массив
        /// </summary>
        /// <param name="mas">массив</param>
        static void SumS(string[] mas)
        {
            int i = 0;
            foreach (string s in mas)
            {
                Console.WriteLine($"Строка: {i}, символов: {s.Length}");
                i++;
            }
        }
        /// <summary>
        /// Удаление строк из 1 первого файла и запись их в нойвый файл
        /// </summary>
        /// <param name="mas">массив данных файла</param>
        static void DeleteStr(string[] mas)
        {
            string[] writeText = new string[mas.Length - 1];
            Array.Copy(mas, 0, writeText, 0, mas.Length - 1);
            File.WriteAllLines("sometext2.txt", writeText);
        }

        /// <summary>
        /// НАхождение максимальной длины строки
        /// </summary>
        /// <param name="mas">массив данных файла</param>
        static void StrLength(string[] mas)
        {
            int maxS = 0;
            foreach (string s in mas)
            {
                maxS = Math.Max(maxS, s.Length);
            }

            Console.WriteLine(maxS);
        }
        /// <summary>
        /// Вывод больших букв из строки
        /// </summary>
        /// <param name="letter">большие буквы</param>
        /// <param name="mas">массив строк из файла</param>
        static void PrintLetter(string letter, string[] mas)
        {
            foreach (string s in mas)
            {
                for (int i = 0; i < letter.Length; i++)
                {
                    if (s[0] == letter[i])
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
        /// <summary>
        /// Вывод 1 и 2 строки файла
        /// </summary>
        /// <param name="mas">массив строк</param>
        static void PrintsStr(string[] mas)
        {
            string h1 = null;
            string h2 = null;
            for (int i = 0; i < mas.Length; i++)
            {
                h1 = mas[1];
                h2 = mas[2];
            }
            Console.WriteLine(h1);
            Console.WriteLine(h2);
        }
        /// <summary>
        /// Запис строк в обратном порядке
        /// </summary>
        /// <param name="mas">массив строк</param>
        static void StrRewrite(string[] mas)
        {
            StreamWriter sw = new StreamWriter(new FileStream("sometext3.txt", FileMode.Create, FileAccess.Write));

            for (int i = mas.Length; i > 0; i--)
            {
                sw.WriteLine(mas[i - 1]);
            }

            sw.Close();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 строк:");
            Recorder();

            Console.WriteLine("Вывод всего файла:");
            string[] mas = Print();

            Console.Write($"Кол-во строк: {StrSum()} ");

            Console.WriteLine("Кол-во символов: ");
            SumS(mas);

            Console.WriteLine("Последняя строка удалена и перезаписана в другой файл ");
            DeleteStr(mas);

            Console.WriteLine("Длина самой длинной строки: ");
            StrLength(mas);

            Console.WriteLine("Вывод строк начинающихся на заданную букву:");
            Console.Write("Введите букву: ");
            string letter = Console.ReadLine();
            PrintLetter(letter, mas);

            Console.WriteLine("Вывод s1 s2");
            PrintsStr(mas);

            Console.WriteLine("Перевёрнутые строки");
            StrRewrite(mas);
        }
    }
}
