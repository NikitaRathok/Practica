using num1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Country country);
        void Delete(string name);
        Country FindBy(string name);
        List<Country> GetAll();
    }
}
