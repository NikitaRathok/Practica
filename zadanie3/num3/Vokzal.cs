using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
     class Vokzal:Poezd
    {
        private Poezd [] poezd;

        public Vokzal():base()
        {
            
            int len = 0;
            poezd = new Poezd[len];
        }
        

        public void Print()
        {
            for (int i = 0; i < poezd.Length; i++)
            {
                Console.WriteLine($"Индекс поезд: {poezd[i].Index}");
                Console.WriteLine($"Пункт назначения: { poezd[i].PunktNaz}");
                Console.WriteLine($"номер поезда: {poezd[i].NumberP}" );
                Console.WriteLine($"Время отправления: {poezd[i].Time}");
                
            }
        }
        public void Add()
        {
            Console.WriteLine("Введите индекс");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите пункт назначения"); 
            string n = Console.ReadLine();

            Console.WriteLine("Введите номер поезда");
            string a = Console.ReadLine();

            Console.WriteLine("Введите время");
            double y = Convert.ToDouble(Console.ReadLine());
            
            Array.Resize(ref poezd, poezd.Length + 1);
            poezd[poezd.Length - 1] = new Poezd(f,n, a, y);
        }
        public void InfoTime()
        {
            Console.Write("Введите время: ");
            double time = Convert.ToDouble(Console.ReadLine());
            int num = 0;
            for (int i = 0; i < poezd.Length; i++)
            {
                if (poezd[i].Time < time)
                {
                    Console.WriteLine($"Индекс поезд: {poezd[i].Index}");
                    Console.WriteLine($"Пункт назначения: { poezd[i].PunktNaz}");
                    Console.WriteLine($"номер поезда: {poezd[i].NumberP}");
                    Console.WriteLine($"Время отправления: {poezd[i].Time}");
                    num++;
                }
            }
            if (num == 0)
                Console.WriteLine("После введённого времени поездов нет");

        }
        public void ShowEndPunct() 
        {
            Console.Write("Введите пункт назначения: ");
            string punkt = Console.ReadLine();
            int num = 0;
            for (int i = 0; i < poezd.Length; i++)
            {
                if (poezd[i].PunktNaz == punkt)
                {
                    Console.WriteLine($"Индекс поезд: {poezd[i].Index}");
                    Console.WriteLine($"Пункт назначения: { poezd[i].PunktNaz}");
                    Console.WriteLine($"номер поезда: {poezd[i].NumberP}");
                    Console.WriteLine($"Время отправления: {poezd[i].Time}");
                    num++;
                }
            }
            if (num == 0)
                Console.WriteLine("В заданный пункт назначения поезда не ходят!");
        }
        public void ShowIndex()
        {
            Console.Write("Введите время: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            for (int i = 0; i < poezd.Length; i++)
            {
                if (poezd[i].Index == index)
                {
                    Console.WriteLine($"Индекс поезд: {poezd[i].Index}");
                    Console.WriteLine($"Пункт назначения: { poezd[i].PunktNaz}");
                    Console.WriteLine($"номер поезда: {poezd[i].NumberP}");
                    Console.WriteLine($"Время отправления: {poezd[i].Time}");
                    num++;

                }
            }
            if (num == 0)
                Console.WriteLine("Такого индекса нет");
        }

    }
}
