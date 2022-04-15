using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal partial class Program
    {
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
