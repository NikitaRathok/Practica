using System.Collections;

namespace num3
{
    internal partial class Program
    {
        class Trev : IEnumerable
        {
            private ArrayList list;

            public Trev()
            {
                list = new ArrayList();
            }
            public Trev(ArrayList a)
            {
                list = a;
            }
            public void Add(Gorod gr)
            {
                list.Add(gr);
            }
            public Trev Clone()
            {
                return new Trev(list);
            }
            public void RemoveAt(int i)
            {
                list.RemoveAt(i);
            }
            public void Clear()
            {
                list.Clear();
            }
            public IEnumerator GetEnumerator()
            {
                return list.GetEnumerator();    
            }
        }
    }
}
