using System;

namespace num3
{
    internal partial class Program
    {
        class Gorod :Travel
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
    }
}
