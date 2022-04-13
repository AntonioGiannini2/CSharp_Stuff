using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaClassi
{
    internal class Prodotto
    {
        public Prodotto(string nome, int prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;    
        }
        
        public string Nome { get; set; }
        public int Prezzo { get; set; }
        
    }
}
