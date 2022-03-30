using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
     class Vokzal
    {
        private Poezd [] poezda;

        public Vokzal()
        {
            
            
        }
        

        public Poezd[] GetAllPoezda()
        {
            return poezda;
        }
        public void Add(Poezd poezd)
        {
            if(poezda == null)
            {
                poezda = new Poezd[1];
            }
            else
            {
              Array.Resize(ref poezda, poezda.Length + 1);
            }
           
            poezda[poezda.Length - 1] = poezd;
        }
        public Poezd[] InfoTime(DateTime time)
        {
           //LINQ
           return poezda.Where(p=>p.Time ==time).ToArray();
            
        }
        public Poezd[] ShowEndPunct(string punkt) 
        {
            return poezda.Where(p => p.PunktNaz == punkt).ToArray();
        }
        public Poezd[] ShowIndex(int index)
        {
            return poezda.Where(p => p.Index == index).ToArray();
        }

    }
}
