using num1.Consts;
using num1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal partial class Program
    {
            static void Main(string[] args)
            {
                Marsh m = new Marsh();
                Marsh[] mas = m.MasCreat();

               

                m.SortNomer(mas);
                Console.WriteLine("Информация в базе:");
                Console.WriteLine();
                m.ShowInfo(mas);
                Console.WriteLine("введите название города");
                string name = Console.ReadLine();

                var createdMarshes = CreateMarshes(MarshConsts.MAX_COUNT_MARSHES);
                Spravoshnaya sp = new Spravoshnaya(createdMarshes.ToList());
            
                var marshes = sp.GetAllMarshes();
                Print(marshes);
            
                var sortedMarshes = sp.GetSortedByPunk(name);
                Print(sortedMarshes, $"Sorted marhesr by  {name}");
            }
        private static Marsh CreateMarsh()
        {
            Console.WriteLine("Enter номер");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter начальный пункт");
            var start=Console.ReadLine();
            Console.WriteLine("Enter конечный пункт");
            var end=Console.ReadLine();
            return MarshFactory.Create(number, start, end);
        }
        private static IEnumerable<Marsh> CreateMarshes(int count)
        {
            var marshes = new List<Marsh>();
            for (int i = 0; i < count; i++)
            {
                var marsh = CreateMarsh();
                marshes.Add(marsh);
            }
            return marshes;
        }
        private static void Print(IEnumerable<Marsh> marshes, string message="All marshes")
        {
            Console.WriteLine(message);
            foreach (var marsh in marshes)
            {
                Console.WriteLine(marsh);
            }
        }
    }
}
