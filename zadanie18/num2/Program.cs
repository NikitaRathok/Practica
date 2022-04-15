using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader st = new StreamReader("1.txt");

            Queue<string> q1 = new Queue<string>();
            Queue<string> q2 = new Queue<string>();
            Queue<int> q3 = new Queue<int>();
            string f = st.ReadToEnd();

            string notNumbers = " ";
            string numbers = " ";

            foreach (var i in f)
            {
                if (!char.IsDigit(i))
                {
                    notNumbers += i;

                }
                else
                {
                    numbers += i;

                }

            }

            q1.Enqueue(notNumbers);
            q2.Enqueue(numbers);

            Console.WriteLine(String.Join(" ", q1));
            Console.WriteLine(String.Join(" ", q2));

        }
    }
}
