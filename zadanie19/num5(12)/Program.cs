using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num5_12_
{
    internal class Program
    {
        delegate string StringOperation(string s);

        /// <summary>
        /// Метод удаления последней пуквы
        /// </summary>
        /// <param name="s">Строка из которой удалится последняя буква</param>
        /// <returns>строка без последней буквы</returns>
        public static string CroppingLastSymdol(string s)
        {
            int i = s.Length - 1;
            s = s.Remove(i);
            Console.WriteLine($"Строка без поледней буквы {s}");
            return s;
        }
        /// <summary>
        /// Метод смены регистра букв на прописной
        /// </summary>
        /// <param name="s">строка</param>
        /// <returns>строка состоящая только из прописных букв</returns>
        public static string UpperString(string s)
        {
            s = s.ToUpper();
            Console.WriteLine($"Смена регистра букв на прописные {s}");
            return s;
        }
        /// <summary>
        /// Метод удаления части строки
        /// </summary>
        /// <param name="s">строка</param>
        /// <returns>обрезаная строка</returns>
        public static string DelletWordString(string s)
        {
            s = s.Substring(2);
            Console.WriteLine($"Удаление части строки {s}");
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();

            StringOperation so = new StringOperation(CroppingLastSymdol);

            so += UpperString;
            so += DelletWordString;
            so(s);
        }
    }
}
