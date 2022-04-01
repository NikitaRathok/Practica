using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            string[] sSplit = s.Split();
           
            foreach (string letter in sSplit)
            {
                for (int i = 0; i < letter.Length-1; i++)
                {
                    if (letter[i] == letter[i + 1])
                    {
                        Console.WriteLine(letter);
                    }
                        
                }    
            }
        }
    }
}
