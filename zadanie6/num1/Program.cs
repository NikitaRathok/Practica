using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string textUpper = text.ToUpper();
            if(textUpper == text)
            {
                Console.WriteLine(text);
            }
        }
    }
}
