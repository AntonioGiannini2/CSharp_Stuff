using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaClassi
{
    internal class Program
    {
        static Inventario PopolaInventario()
        {
            Inventario inventario = new Inventario();
            Prodotto pane = new Prodotto("pane", 2);
            Prodotto carne = new Prodotto("carne", 5);
            Prodotto pesce = new Prodotto("pesce", 7);
            Prodotto pasta = new Prodotto("pasta", 4);
            Prodotto formaggio = new Prodotto("formaggio", 3);
            List<Prodotto> catalogo = new List<Prodotto>();
            inventario.AggiungiProdotto(pane);
            inventario.AggiungiProdotto(carne);
            inventario.AggiungiProdotto(pesce);
            inventario.AggiungiProdotto(pasta);
            inventario.AggiungiProdotto(formaggio);

            return inventario;
        }

        static void SalutaEMostraProdotti(Inventario inventario)
        {
            
            Console.WriteLine("Buongiorno!\n");
            Console.WriteLine("I prodotti disponibili sono:\n");
            foreach (var prodotto in inventario.Catalogo)
            {
                Console.WriteLine($"{prodotto.Nome}: {prodotto.Prezzo}$");
            }
            Console.WriteLine("\n");
        }

        static int ConvertiStringAInt(string valore)
        {
            int valoreInt = 0;
            bool controlloValore = int.TryParse(valore, out valoreInt);
            while (controlloValore == false)
            {
                Console.WriteLine("\nErrore: Inserisci un numero intero\n");
                valore = Console.ReadLine();
                controlloValore = int.TryParse(valore, out valoreInt);
            }
            return valoreInt;
        }

        static void PrendiProdotti(Inventario inventario, ref int totale)
        {
            string ordineCliente = null;
            string quantità;
            int quantitàInt;
            List<int> listaDaPagare = new List<int>();
            bool 

            Console.WriteLine("Quali prodotti vuoi acquistare? " +
                "(Inserisci il nome del prodotto che vuoi acquistare, inserisci exit quando non vuoi aggiungerne altri)\n");

            while (ordineCliente != "exit")
            {
                ordineCliente = Console.ReadLine();
                foreach (var prodotto in inventario.Catalogo)
                {

                }
                if (inventario.Catalogo.Contains(ordineCliente)
                {
                    Console.WriteLine($"\nQuanto/a {ordineCliente} vuoi acquistare?\n");
                    quantità = Console.ReadLine();
                    quantitàInt = ConvertiStringAInt(quantità);
                    listaDaPagare.Add(inventario[ordineCliente] * quantitàInt);
                    Console.WriteLine("\nArticolo aggiunto correttamente, inseriscine un altro o inserisci exit se non vuoi aggiungerne altri\n");
                }
                else if (ordineCliente != "exit")
                {
                    Console.WriteLine("\nErrore: articolo non esiste\n");
                }
                else
                {
                    Console.WriteLine("\nOrdine chiuso correttamente\n");
                }
            }

            totale = listaDaPagare.Sum();
        }
        static void Main(string[] args)
        {   
            Inventario inventario=PopolaInventario();

            SalutaEMostraProdotti(inventario);
            Console.ReadLine();
        }
    }
}
