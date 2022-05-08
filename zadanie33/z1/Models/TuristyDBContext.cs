using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.Models
{
    public class TuristyDBContext : DataContext
    {
        public TuristyDBContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection) {}

        public Table<Turst> Turists { get; set; }
    }
}
