using num1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static num1.Program;

namespace num1
{
    internal static class MarshExtentions
    {
        public static IEnumerable<Marsh> Where(this Marsh[] marshs, Func<Marsh,bool> predicate)
        {
           foreach (var marsh in marshs)
            {
                if (predicate(marsh))
                {
                    yield return marsh;
                }
            }
            
        }
    }
}
