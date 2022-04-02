using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\d{3}[ -]?\d{2}[ -]?\d{2}";
            Regex r = new Regex(pattern);

            MatchCollection m = r.Matches(text);
            foreach (Match m2 in m)
            {
                Console.WriteLine(m2);
            }
        }
    }
}
