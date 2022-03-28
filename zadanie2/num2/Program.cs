using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        public class Automobile:Transport
        {
            string marka;
            string model;

            public Automobile():base()
            {
                
            }
            public void Input()
            {
                Console.WriteLine("Марка авто");
                marka = Console.ReadLine();

                Console.WriteLine("Модель авто");
                model = Console.ReadLine();
            }
            public override string Output()
            {
                return base.Output()+ $"Марка {marka}" + "||" + $"Модель-{model} ";
            }
        }
       
        public class Poezd:Express
        {
            int numberOfWagons;
            int number;

            public Poezd():base()
            {

            }
            public void Vvod()
            {
                Console.WriteLine("Колво вогонов");
                numberOfWagons = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите номер вагона");
                number = int.Parse(Console.ReadLine());
            }
            public override string Vivod()
            {
                return base.Vivod() + $"Всего вагонов {numberOfWagons}"+"||"+$"Номер вагона {number}";
            }
        }
       
        public class Transport
        {
            public string type;
            public Transport()
            {
                
            }
           public  void Write()
            {
                Console.WriteLine("Введите тип авто");
                type = Console.ReadLine(); 
            }

           public virtual string Output()
            {
                return $"Тип авто -  {type}"+"||";
            }
        }

        public class Express
        {
            string way;
            public Express()
            {
                
            }
            public void Read()
            {
                Console.WriteLine("Куда едет поезд");
                way = Console.ReadLine();  
            }

            public virtual string Vivod()
            {
                return $"Поезд едет в {way}"+"||";
            }
        }

        static void Main(string[] args)
        {
            Automobile auto = new Automobile();
            auto.Write();
            auto.Input();
            Console.WriteLine(auto.Output());

            Poezd poezd = new Poezd();
            poezd.Read();
            poezd.Vvod();
            Console.WriteLine(poezd.Vivod());
        }
    }
}
