using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        delegate string StringOperation(string s);

        public static string CroppingLastSymdol(string s)
        {
            int i = s.Length - 1;
            s = s.Remove(i);
            Console.WriteLine($"Строка без поледней буквы {s}");
            return s;
        }
        public static string UpperString(string s)
        {
            s = s.ToUpper();
            Console.WriteLine($"Смена регистра букв на прописные {s}") ;
            return s;
        }
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
