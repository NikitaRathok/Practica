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
            bool c = true;
            while (c )
            {
                Console.WriteLine("Ввыбрать пункт:");
                Console.WriteLine();
                Console.WriteLine("1.Добавить поезд");
                Console.WriteLine("2.Вывод всех поездов");
                Console.WriteLine("3.Поиск по времени");
                Console.WriteLine("4.Поиск по пункту назначения");
                Console.WriteLine("5.Поиск по индексу");
                Console.WriteLine("6.Выход");

                int k = int.Parse(Console.ReadLine());



                switch (k)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("Введите индекс");
                            var index = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите пункт назначения");
                            var punktNaz = Console.ReadLine();

                            Console.WriteLine("Введите номер поезда");
                            var numberP = Console.ReadLine();

                            Console.WriteLine("Введите время");
                            var time = Convert.ToDateTime(Console.ReadLine());
                            var poezd = new Poezd(index, punktNaz, numberP, time);
                            v.Add(poezd);

                            break;
                        }
                    case 2:
                        {
                            Info(v.GetAllPoezda());
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Введите время: ");
                            DateTime time = Convert.ToDateTime(Console.ReadLine());
                            Info(v.InfoTime(time));
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Введите пункт назначения: ");
                            string punkt = Console.ReadLine();
                            Info(v.ShowEndPunct(punkt));
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Введите индекс: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            
                            Info(v.ShowIndex(index));
                            break;
                        }
                    case 6:
                        {
                            c = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого пункта нет");
                            break;
                        }
                }
            }
            
            
            
        }
        private static void Info(Poezd[] poezda)
        {
            foreach (var poezd in poezda)
            {
                Console.WriteLine(poezd.Info());
            }
        }
    }
} 
 
