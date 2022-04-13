using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaClassi
{
    internal class Carrello
    {
        public Carrello()
        {
            ItemsOrdine = new List<ItemOrdine>();
        }
        public List<ItemOrdine> ItemsOrdine { get; set; }
    }
}
