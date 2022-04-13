using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunzioniVarie;

namespace VenditaClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = GeneraInventario();
            int totale = 0;

            SalutaEMostraProdotti(inventario);

            RiempiCarrello(inventario, ref totale);

            MostraCostoERingrazia(totale);
        }
        public static Inventario GeneraInventario()
        {
            Prodotto pane = new Prodotto("pane", 2);
            Prodotto carne = new Prodotto("carne", 5);
            Prodotto pesce = new Prodotto("pesce", 7);
            Prodotto formaggio = new Prodotto("formaggio", 3);
            Prodotto pasta = new Prodotto("pasta", 4);

            Inventario inventario = new Inventario();

            inventario.Catalogo.Add(pane);
            inventario.Catalogo.Add(carne);
            inventario.Catalogo.Add(pesce);
            inventario.Catalogo.Add(formaggio);
            inventario.Catalogo.Add(pasta);
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

        static void RiempiCarrello(Inventario inventario, ref int totale)
        {
            string inputCliente = null;
            string quantità = null;
            ItemOrdine item;
            Carrello carrello = new Carrello();

            Console.WriteLine("Quali prodotti vuoi acquistare? " +
                "(Inserisci il nome del prodotto che vuoi acquistare, inserisci exit quando non vuoi aggiungerne altri)\n");

            while (inputCliente != "exit")
            {
                inputCliente = Console.ReadLine();
                if (inventario.Catalogo.Any(prodotto=>prodotto.Nome == inputCliente))
                {
                        Console.WriteLine($"\nQuanto/a {inputCliente} vuoi acquistare?\n");
                        quantità = Console.ReadLine();
                        item = new ItemOrdine(inventario.Catalogo.Find(prodotto=>prodotto.Nome == inputCliente), Conversione.ConvertiStringAInt(quantità));
                        carrello.ItemsOrdine.Add(item);
                        Console.WriteLine("\nArticolo aggiunto correttamente, inseriscine un altro o inserisci exit se non vuoi aggiungerne altri\n");
                }
                else if (inputCliente != "exit")
                {
                    Console.WriteLine("\nErrore: articolo non esiste\n");
                }
                else
                {
                    Console.WriteLine("\nOrdine chiuso correttamente\n");
                }
            }
            totale = CalcolaTotaleOrdine(carrello);
        }

        static int CalcolaTotaleOrdine(Carrello carrello)
        {
            int totale = 0;
            foreach (var item in carrello.ItemsOrdine)
            {
                totale = totale + (item.Prodotto.Prezzo * item.Quantita);
            }
            return totale;
        }
        static void MostraCostoERingrazia(int totale)
        {
            Console.WriteLine($"\nIl totale da pagare è: {totale}$\n");
            Console.WriteLine("Grazie e arrivederci");
            Console.ReadLine();
        }
    }
}
