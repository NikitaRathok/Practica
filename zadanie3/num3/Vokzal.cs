using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
     class Vokzal:Poezd
    {
        private Poezd [] poezda;

        public Vokzal():base()
        {
            
            int len = 0;
            poezda = new Poezd[len];
        }
        

        public void Print()
        {
            for (int i = 0; i < poezda.Length; i++)
            {
                Console.WriteLine($"Индекс поезд: {poezda[i].Index}");
                Console.WriteLine($"Пункт назначения: { poezda[i].PunktNaz}");
                Console.WriteLine($"номер поезда: {poezda[i].NumberP}" );
                Console.WriteLine($"Время отправления: {poezda[i].Time}");
                
            }
        }
        public void Add()
        {
            Array.Resize(ref poezda, poezda.Length + 1);
            poezda[poezda.Length - 1] = new Poezd(Index,PunktNaz, NumberP,Time );
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
            return poezda.Where(p => p.Index == Index).ToArray();
        }

    }
}
