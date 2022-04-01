using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        static public void Swap(string s)
        {
            string[] split = s.Split(' ');
            string sSplit = split[split.Length - 1];
            for (int i = 1; i < split.Length - 1; i++)
            {
                sSplit += " " + split[i];
                sSplit += " " + split[0];
                Console.WriteLine(sSplit);
            }
        }
        static public string Glue(string s)
        {
            string[] split = s.Split(' ');
            string sSplit = split[split.Length -1];
            for (int i = 0;i< split.Length -1;i++)
            {
                sSplit = split[1] + split[2];
                
            }
            return sSplit;
        }
        static public string Print3SLovo(string s)
        {
            string[] split = s.Split(' ');
            string a = split[split.Length - 1];
            for (int i = 0;i< split.Length -1;i++)
            {
              a =  split[2];
            }
            return a;
            
        }
        static public string PrintFirstWord(string s)
        {
            string[] split = s.Split(' ');
            string firstWord = split[split.Length - 1];
            for (int i = 0; i < split.Length - 1; i++)
            {
                firstWord = split[0];
            }
            return firstWord;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            Console.WriteLine($"Склеяные строка 2 и 3 : {Glue(s)}");
            Console.WriteLine($"1 и послдеднее слова поменялись местами ");
            Swap(s);
            string rez = Print3SLovo(s);
            var reversString = new string(rez.Reverse().ToArray());
            string.Join("",rez.Reverse());

            Console.WriteLine($"Обратная строка {reversString}");
            var firstWord = PrintFirstWord(s);
            StringBuilder sb = new StringBuilder(firstWord);

            Console.WriteLine($"Первое слово без 2 первых букв {sb.Remove(0, 2)}");
        }
    }
}
