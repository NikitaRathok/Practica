using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            string pattern = @"[+]?\d{1}[- ]?\d{3}[- ]?\d{3}[- ]?\d{2}[- ]?\d{2}";
            Regex r = new Regex(pattern);

            MatchCollection mc = r.Matches(text);
            
            foreach (Match m in mc)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
