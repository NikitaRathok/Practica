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
            string s = Console.ReadLine();
            string[] sSplit = s.Split(' ');
            foreach (var item in sSplit)
            {
                if(item[0] == item.ToUpper()[0])
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
