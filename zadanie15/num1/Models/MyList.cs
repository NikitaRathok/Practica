using System.Collections.Generic;

namespace num1
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
}
