using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunzioniVarie
{
    public class Conversione
    {
        public static int ConvertiStringAInt(string stringa)
        {
            int numero = 0;

            while (int.TryParse(stringa, out numero) == false)
            {
                Console.WriteLine("\nErrore: Inserisci un numero intero\n");
                stringa = Console.ReadLine();
            }
            return numero;
        }

    }
}
