using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaClassi
{
    internal class ItemOrdine
    {
        public ItemOrdine(Prodotto prodotto, int quantita)
        {
            Prodotto = prodotto;
            Quantita = quantita;           
        }
        public Prodotto Prodotto { get; set; }
        public int Quantita { get; set; }
    }
}
