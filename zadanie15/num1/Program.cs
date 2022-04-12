using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            MyList<int> m = new MyList<int>();

            for (int i = 0; i < 10; i++)
            {
                m.Add(i);
                Console.WriteLine(m[i]);
            }

            Console.WriteLine(m.Count);

        }
    }
}
