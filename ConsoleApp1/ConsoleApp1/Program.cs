using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void MandaSaluto()
        {
            Console.WriteLine("Ciao!");
        }

        static void Ringrazia()
        {
            Console.WriteLine("Grazie!");
            Console.ReadLine();
        }

        static string ChiediEtà()
        {
            Console.WriteLine("Quanti anni hai?");
            return Console.ReadLine();
        }

        static int ProvaAConvertireEtà(string età)
        {
            int etàInt;
            try
            {
                etàInt = Convert.ToInt32(età);
            }
            catch (Exception)
            {
                Console.WriteLine("Errore: Inserisci un numero intero. Ritenta");
                età = Console.ReadLine();
                try
                {
                    etàInt = Convert.ToInt32(età);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return etàInt;
        }

        static string ScegliMessaggioEtà(int età)
        {
            if (età > 50)
            {
                return "Ti stai appropinquando alla vecchiaia (a grandi passi)";
            }
            else if (età > 44 && età <= 50)
            {
                return "Stai trapassando...";
            }
            else
            {
                return "Godi la vita che sei giovane (ancora...)";
            }
        }

        static void Main(string[] args)
        {
            MandaSaluto();

            string età = ChiediEtà();

            try
            {
                int etàInt = ProvaAConvertireEtà(età);
                string messaggio = ScegliMessaggioEtà(etàInt);

                Console.WriteLine(messaggio);
                Ringrazia();
            }
            catch (Exception)
            {
                Console.WriteLine("Errore: Il programma ora terminerà.");
                Console.ReadLine();
            }
         
        }
    }
}
