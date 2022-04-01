using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4
{
    internal class Program
    {
        static string GetAplhabet()
        {
            var str = new StringBuilder();
            for (char i = 'а'; i <= 'я'; i++)
            {
                str.Append(i.ToString());
            }
            return str.ToString();
        }
        public static string Alphabet = GetAplhabet();

        public static int[] GetNumberAlpha(string text)
        {
            int[] array = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = Alphabet.IndexOf(text[i]) + 1;
            }
            return array;
        }
        public static int SumDigits(int Number)
        {
            int Sum = 0;
            while (Number > 0)
            {
                Sum += Number % 10;
                Number /= 10;
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            string textWrite = "Рачёк Никита Дмитриевич";
            string text = "Рачёк Никита Дмитриевич".Replace(" ", "").ToLower();
            int[] mas = GetNumberAlpha(text);
            int Sum = mas.Sum();
            while (Sum > 9)
            {
                Sum = SumDigits(Sum);
            }
            Console.WriteLine(textWrite);
            Console.WriteLine(Sum);
        }
    }
}
