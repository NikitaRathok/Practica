using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.Models
{
    [Table(Name = "туристы")]
    public class Turst
    {
        [Column(Name = "Код", IsPrimaryKey = true, IsDbGenerated  = true)]
        public string Surname { get; set; }
        [Column(Name = "Фамилия")]
        public string OneName { get; set; }
        [Column(Name = "Имя")]
        public string FirstName { get; set; }
        [Column(Name = "Отчество")]
        public string LastName { get; set; }
    }
}
