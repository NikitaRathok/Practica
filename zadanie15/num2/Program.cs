using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            d.Add(1, 2);
            d.Add(2, 3);
            Console.WriteLine(d.Count);
            foreach (var i in d)
            {
                Console.WriteLine(i);
            }
        }
    }
}
