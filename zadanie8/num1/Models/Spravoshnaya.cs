using System.Collections.Generic;
using System.Linq;

namespace num1.Models
{
    internal class Spravoshnaya
    {
        private List<Marsh> _marshes;

        public Spravoshnaya(List<Marsh> marshes)
        {
            _marshes = marshes;
        }
        public Spravoshnaya()
        {
            _marshes = new List<Marsh>();
        }
        public IEnumerable<Marsh> GetAllMarshes()
        {
            return _marshes;
        }
        public IEnumerable<Marsh> GetSortedByPunk(string name)
        {
            return _marshes.OrderBy(m => m.StartPunkt==name || m.EndPunkt==name );
        }
        
        public void Add(Marsh marsh)
        {
            _marshes.Add(marsh);
        }
    }
}
