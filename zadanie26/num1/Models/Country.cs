using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1.Models
{
    public class Country
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public double Population { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"--->Country is {Name}")
                .AppendLine($"\tarea is {Area}km2")
                .AppendLine($"\tpopulation is {Population} millions people")
                .ToString();
        }
    }
}
