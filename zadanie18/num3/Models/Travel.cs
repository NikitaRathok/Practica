using System;

namespace num3
{
    internal partial class Program
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
    }
}
