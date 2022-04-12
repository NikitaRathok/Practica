using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        class MyDictionary<TKey, TValue> : IEnumerable
        {
            private int count;
            private TKey[] masKeys;
            private TValue[] masValues;
            public int Counter
            {
                get { return count; }
            }

            public void Add(TKey key, TValue val)
            {
                this.count++;

                Array.Resize(ref masKeys, count);
                masKeys[count - 1] = key;

                Array.Resize(ref masValues, count);
                masValues[count - 1] = val;
            }
            public TValue this[TKey key]
            {
                get
                {
                    int index = 0;
                    for (int i = 0; i < masKeys.Length; i++)
                    {
                        if (key.Equals(masKeys[i]))
                            index = i;
                    }
                    return masValues[index];
                }
            }
            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            {
                for (int i = 0; i < masKeys.Length; i++)
                    yield return new KeyValuePair<TKey, TValue>(masKeys[i], masValues[i]);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

        }
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
