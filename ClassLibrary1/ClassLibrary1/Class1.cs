using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FunzioniVarie
    {
        static int ConvertiStringAInt(string valore)
        {
            int valoreInt = 0;
            bool controlloValore = int.TryParse(valore, out valoreInt);
            while (controlloValore == false)
            {
                Console.WriteLine("Errore: Inserisci un numero intero");
                valore = Console.ReadLine();
                controlloValore = int.TryParse(valore, out valoreInt);
            }
            return valoreInt;
        }

    }
}
