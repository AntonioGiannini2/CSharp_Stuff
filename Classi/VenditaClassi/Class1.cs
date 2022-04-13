using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaClassi
{
    public class Prodotto
    {
        public Prodotto(string nome, int prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
        }
       public string Nome { get; set; }
        public int Prezzo { get; set; }
    }
    public class Inventario
    {
        public Inventario()
        {
            Catalogo = new List<Prodotto>();
        }
        public List<Prodotto> Catalogo { get; set; }

        public void AggiungiProdotto(Prodotto prodotto)
        {
            Catalogo.Add(prodotto); 
        }

        public void RimuoviProdotto(Prodotto prodotto)
        {
            Catalogo.Remove(prodotto);
        }
    }

    public class Carrello
    {
        public List<Prodotto> Spesa { get; set; }

        public void AggiungiProdotto(Prodotto prodotto)
        {
            Spesa.Add(prodotto);
        }

        public void RimuoviProdotto(Prodotto prodotto)
        {
            Spesa.Remove(prodotto);
        }
    }
}
