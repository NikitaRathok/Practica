using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal static class Input
    {
        public static string String(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static int Int(string message)
        {
            var result = default(int);
            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(),out result));
            return result;
        }
    }
}
