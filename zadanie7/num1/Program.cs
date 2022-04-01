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
            string text = " ";
            string pattern = @"(2|3){3}-[0-9]{3}-\d{4}";
            Regex r = new Regex(pattern);

            MatchCollection mc = r.Matches(pattern);
            foreach (Match m in mc)
            {

            }
        }
    }
}
