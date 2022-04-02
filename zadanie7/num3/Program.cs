using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"https[://]{1,3}\w*[.]\w*[/]?|http[://]{1,3}\w*[.]\w*[/]?";
            Regex r = new Regex(pattern);

            Match m = r.Match(text);

            if(m.Success)
            {
                Console.WriteLine($"{m}-Да");
            }
            else
            {
                Console.WriteLine($"{m}-Нет");
            }
        }
    }
}
