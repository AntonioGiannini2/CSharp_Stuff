using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendita
{
    internal class Program
    {
       
        static void Saluta()
        {
            Console.WriteLine("Buongiorno!");
        }

        static Dictionary<string, int> PassaInventario()
        {
            Dictionary<string, int> Inventario = new Dictionary<string, int>();
            Inventario.Add("pane", 2);
            Inventario.Add("carne", 5);
            Inventario.Add("pesce", 7);
            Inventario.Add("formaggio", 3);
            Inventario.Add("pasta", 4);
            return Inventario;
        }

        static void MostraProdotti()
        {
            Dictionary<string, int> inventario = PassaInventario();
            Console.WriteLine("I prodotti disponili sono:");
            foreach (var prodotto in inventario)
            {
                Console.WriteLine($"{prodotto.Key}: {prodotto.Value}$");
            }
        }

        static List<int> CreaCarrello()
        {
            Dictionary<string, int> inventario = PassaInventario();
            Console.WriteLine("Quali prodotti vuoi acquistare? " +
                "(Inserisci il nome del prodotto che vuoi acquistare, inserisci exit quando non vuoi aggiungerne altri)");
            string ordineCliente = null;
            string quantità = null;
            bool controllo = false;
            int quantitàInt = 0;
            List<int> totale = new List<int>();
            while (ordineCliente != "exit")
            {
                ordineCliente = Console.ReadLine();
                if (inventario.ContainsKey(ordineCliente))
                {
                    Console.WriteLine($"Quanto/a {ordineCliente} vuoi acquistare?");
                    quantità = Console.ReadLine();
                    controllo = int.TryParse(quantità, out quantitàInt);
                    while (controllo == false)                         
                    {
                        Console.WriteLine("Errore: Inserisci un numero intero");
                        quantità = Console.ReadLine();
                        controllo = int.TryParse(quantità, out quantitàInt);
                    }
                    totale.Add(inventario[ordineCliente] * quantitàInt);
                    Console.WriteLine("Articolo aggiunto correttamente, inseriscine un altro o scrivi exit se non vuoi aggiungerne altri");
                }
                else if (ordineCliente != "exit")
                {
                    Console.WriteLine("Errore: articolo non esiste");
                }
                
            }
            return totale;
        }

        static string SommaProdotti(List<int> totale)
        {
            return $"Il totale da pagare è: {totale.Sum()}$";
        }

        static void MostraCostoERingrazia(List<int> totale)
        {
            Console.WriteLine(SommaProdotti(totale));
            Console.WriteLine("Grazie e arrivederci");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
           

            Saluta();
            MostraProdotti();
            //bool carrelloTerminato;
            int totale = 0;
            CreaCarrello(ref totale);
            /*while (!carrelloTerminato)
            {
                AggiungiProdotto(ref carrelloTerminato, ref totale);
            }*/


     
            MostraCostoERingrazia(totale);
        }
    }
}
