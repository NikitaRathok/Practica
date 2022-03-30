using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Poezd p = new Poezd();
            Vokzal v = new Vokzal();
            M1:
            Console.WriteLine("Ввыбрать пункт:");
            Console.WriteLine();
            Console.WriteLine("1.Добавить поезд");
            Console.WriteLine("2.Вывод всех поездов");
            Console.WriteLine("3.Поиск по времени");
            Console.WriteLine("4.Поиск по пункту назначения");
            Console.WriteLine("5.Поиск по индексу");

            int k = int.Parse(Console.ReadLine());
            
            bool n = true;
            if (k != 0 && k <= 5)
            {
                switch (k)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите индекс");
                            v.Index = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите пункт назначения");
                            v.PunktNaz = Console.ReadLine();

                            Console.WriteLine("Введите номер поезда");
                            v.NumberP = Console.ReadLine();

                            Console.WriteLine("Введите время");
                            v.Time = Convert.ToDateTime(Console.ReadLine());
                            v.Add();
                            goto M1;
                        }
                    case 2:
                        {
                            v.Print();
                            goto M1;
                        }
                    case 3:
                        {
                            Console.Write("Введите время: ");
                            DateTime time = Convert.ToDateTime(Console.ReadLine());
                            v.InfoTime(time);
                            goto M1;
                        }
                    case 4:
                        {
                            Console.Write("Введите пункт назначения: ");
                            string punkt = Console.ReadLine();
                            v.ShowEndPunct(punkt);
                            goto M1;
                        }
                    case 5:
                        {
                            Console.Write("Введите индекс: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            v.ShowIndex(index);
                            
                            goto M1;
                        }
                }
            }
            else goto M1;
        }
    }
} 
 
