using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        class Travel
        {
            public string strana;
            public int stoim;
            public Travel(string strana, int stoim)
            {
                this.strana = strana;
                this.stoim = stoim;
            }
            virtual public void PrintTravel()
            {
                Console.WriteLine($"Путешествие в {strana} стоит: {stoim}");
            }
        }
        class Gorod:Travel
        {
            public string g;

            public Gorod(string g, int stoim, string strana):base(strana,stoim)
            {
                this.g = g;
            }
            public override void PrintTravel()
            {
                Console.WriteLine($"Путешествие в {strana}, город {g} стоит: {stoim}");
            }
        }
        class InfoObj
        {
            public static void Info<tip>(tip obj) where tip: Travel
            {
                obj.PrintTravel();
            }
        }
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


        static void Main(string[] args)
        {
            Gorod gd = new Gorod("город", 32, "страна");
            InfoObj.Info<Gorod>(gd);
            Console.WriteLine("====================");
            Trev TrevList = new Trev();
            Dictionary<int, string> c = new Dictionary<int, string>(3);
            for(int i = 0;i<3;i++)
            {
                Console.WriteLine("Введите страну");
                string strana = null;
                strana = Console.ReadLine();
                Console.WriteLine("Введите стоимость");
                int stoim = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите город");
                string gorod = Console.ReadLine();
                TrevList.Add(new Gorod(gorod, stoim, strana));
                c[i + 1] = gorod;

            }
            Console.WriteLine("=========================");

            foreach(KeyValuePair<int,string> keyValue in c)
            {
                Console.WriteLine(keyValue.Key + "-"+keyValue.Value);
            }
            Console.WriteLine("==============");
            foreach (Gorod x in TrevList)
                x.PrintTravel();
            TrevList.RemoveAt(1);
            Console.WriteLine("-=====================-");
            Trev cl = (Trev)TrevList.Clone();
            foreach(Gorod x in cl)
            {
                x.PrintTravel();
            }
        }
    }
}
