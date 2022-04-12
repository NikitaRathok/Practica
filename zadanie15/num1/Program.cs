using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        class MyList<T>
        {
            List<T> l = new List<T>();


            public T this[int index]
            {
                get { return l[index]; }
                set { l[index] = value; }
            }
            public void Add(T a)
            {

                l.Add(a);
            }

            public int Count
            {
                get { return l.Count; }
            }


        }
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
