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
            Console.WriteLine("5.Поиск по инлексу");

            int k = int.Parse(Console.ReadLine());
            
            bool n = true;
            if (k != 0 && k <= 5)
            {
                switch (k)
                {
                    case 1:
                        {
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
                            v.InfoTime();
                            goto M1;
                        }
                    case 4:
                        {
                            v.ShowEndPunct();
                            goto M1;
                        }
                    case 5:
                        {
                            v.ShowIndex();
                            goto M1;
                        }
                }
            }
            else goto M1;
        }
    }
} 
 
