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
        static public void Glue(string s)
        {
            string[] split = s.Split(' ');
            string sSplit = split[split.Length -1];
            for (int i = 0;i< split.Length -1;i++)
            {
                sSplit = split[1] + split[2];
                
            }
            Console.WriteLine(sSplit);
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
        static public void Cut(string s)
        {
            string[] spit = s.Split(' ');

        }
        static void Main(string[] args)
        {
           
            string s = Console.ReadLine();
            string rez = Print3SLovo(s);
            Console.WriteLine(rez.Reverse());

            Console.WriteLine();
        }
    }
}
