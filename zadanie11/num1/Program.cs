using num1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Building[] buildings =new Building[] {
                new Factory(10000,"Метал"), 
                new Office(10,"Епам")
            };

            foreach(Building building in buildings)
            {
                building.DisplayPrint();
            }

        }
    }
}
