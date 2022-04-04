using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{

    class Program
    {
            static void Main(string[] args)
            {
                Accauntat a = new Accauntat();
                Console.WriteLine(a.AskForBonus(Post.Postman, 350));
            }
    }
}
