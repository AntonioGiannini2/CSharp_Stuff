using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaClassi
{
    internal class Inventario
    {
        public Inventario()
        {
            Catalogo = new List<Prodotto>();
        }
        public List<Prodotto> Catalogo { get; set; }

    }
}
