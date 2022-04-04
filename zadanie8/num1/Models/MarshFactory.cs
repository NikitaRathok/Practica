using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1.Models
{
    internal class MarshFactory
    {
        public static Marsh Create(int number, string start,string end)
        {
            return new Marsh(nachalniyPunktMarshryta: start,konechniyPunktMarshryta: end,nomerMarshryta: number);
        }
    }
}
