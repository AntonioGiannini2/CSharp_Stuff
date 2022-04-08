using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static string[] Resize(string[] array, int newSize)
        {
            string[] result = new string[newSize];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            return result;
        }

        static void Sostituisci(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;
            Sostituisci(ref x,ref y);

            List<string> miaLista = new List<string>();
            miaLista.Add("Ciao");
            miaLista.Add("a");
            miaLista.Add("tutti");
            miaLista.RemoveAt(1);

            Dictionary<string, string> mioDictionary = new Dictionary<string, string>();
            mioDictionary.Add("gelato", "cosa che si mangia ed è dolce.");
            mioDictionary.Add("palla", "cosa tonda con cui giocano le persone");

            string palla = mioDictionary["palla"];
        }
    }
}
