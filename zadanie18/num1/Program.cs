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
            string s = "abc#d##c";
            Stack<char> st = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '#' && st.Count > 0)
                {
                    st.Pop();
                }
                else
                {
                    st.Push(c);
                }

            }

            var stroka = new string(st.Reverse().ToArray());
            Console.WriteLine(stroka);
        }
    }
}
