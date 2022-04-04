using System;
using System.Linq;

namespace num1.Models
{
        public struct Marsh
        {
            
            private readonly string nachalniyPunktMarshryta;
            private readonly string konechniyPunktMarshryta;
             int nomerMarshryta;

        public Marsh(string nachalniyPunktMarshryta, string konechniyPunktMarshryta, int nomerMarshryta)
        {
            this.nachalniyPunktMarshryta = nachalniyPunktMarshryta;
            this.konechniyPunktMarshryta = konechniyPunktMarshryta;
            this.nomerMarshryta = nomerMarshryta;
        }

        public string StartPunkt => nachalniyPunktMarshryta;
        public string EndPunkt => konechniyPunktMarshryta;

        public override string ToString()
            {
                return (string.Format($"Начальный пункт : {nachalniyPunktMarshryta} Конечный пункт : {konechniyPunktMarshryta}  Номер маршрута: {nomerMarshryta}"));
            }

            public Marsh[] MasCreat()
            {
                Marsh[] mas = new Marsh[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Начальный пункт маршрута:");
                    mas[i].nachalniyPunktMarshryta = Console.ReadLine();
                    Console.WriteLine("Конечный пункт маршрута:");
                    mas[i].konechniyPunktMarshryta = Console.ReadLine();
                    Console.WriteLine("Номер маршрута:");
                    mas[i].nomerMarshryta = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                return mas;
            }
            public void ShowInfo(Marsh[] mas, string message="All marshruts")
            {
                Console.WriteLine(message);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mas[i]);
                }     
            }
            public void SortNomer(Marsh[] mas)
            {
                for (int i = 0; i < n ; i++)
                {
                    for (int j = i+1; j < n; j++)
                    {
                        if (mas[i].nomerMarshryta > mas[j].nomerMarshryta)
                        {
                            Marsh x = mas[i];
                            mas[i] = mas[j];
                            mas[j] = x;
                        }
                    }
                }
                
            }
            public Marsh[] ShowInfoMarshrut(Marsh[] mas,string name)
            {
                return mas.Where(p => p.nachalniyPunktMarshryta == name|| p.konechniyPunktMarshryta == name).ToArray();
            }
            
        }
        
        
    
}
