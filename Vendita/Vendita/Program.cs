using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendita
{
    internal class Program
    {
        static Dictionary<string, int> GeneraInventario()
        {
            Dictionary<string, int> inventario = new Dictionary<string, int>();
            inventario.Add("pane", 2);
            inventario.Add("carne", 5);
            inventario.Add("pesce", 7);
            inventario.Add("formaggio", 3);
            inventario.Add("pasta", 4);
            return inventario;
        }
        static void SalutaEMostraProdotti(Dictionary<string, int> inventario)
        {
            Console.WriteLine("Buongiorno!\n");
            Console.WriteLine("I prodotti disponibili sono:\n");
            foreach (var prodotto in inventario)
            {
                Console.WriteLine($"{prodotto.Key}: {prodotto.Value}$");
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

        static void RiempiCarrello(Dictionary<string, int> inventario, ref int totale)
        {
            string ordineCliente = null;
            string quantità;
            int quantitàInt;
            List<int> listaDaPagare = new List<int>();

            Console.WriteLine("Quali prodotti vuoi acquistare? " +
                "(Inserisci il nome del prodotto che vuoi acquistare, inserisci exit quando non vuoi aggiungerne altri)\n");

            while (ordineCliente != "exit")
            {
                ordineCliente = Console.ReadLine();
                if (inventario.ContainsKey(ordineCliente))
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

        static void MostraCostoERingrazia(int totale)
        {
            Console.WriteLine($"\nIl totale da pagare è: {totale}$\n");
            Console.WriteLine("Grazie e arrivederci");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> inventario = GeneraInventario();
            int totale = 0;

            SalutaEMostraProdotti(inventario);
            
            RiempiCarrello(inventario, ref totale);

            MostraCostoERingrazia(totale);
        }
    }
}
