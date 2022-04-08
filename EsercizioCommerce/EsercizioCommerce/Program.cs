using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti articoli vuoi acquistare?");
            string num = Console.ReadLine();
            int intNum = 0;
            int tot = 0;
            bool numCheck = int.TryParse(num, out intNum);
            if (numCheck == true)
            {
                tot = intNum * 10;
                Console.WriteLine("Il totale da pagare è: " + tot + ". Inserisci la tua età:");
                string età = Console.ReadLine();
                int intEtà = 0;
                bool etàCheck = int.TryParse(età, out intEtà);
                if (etàCheck == true)
                {
                    if (intEtà < 25)
                    {
                        tot = tot / 2;
                        Console.WriteLine("Sconto! Il nuovo totale da pagare è: " + tot + "!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Il totale da pagare è: " + tot);
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Errore: L'età deve essere un numero intero.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Errore: La quantità da acquistare deve essere un numero intero.");
                Console.ReadLine();
            }
        }
    }
}
