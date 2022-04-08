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
            Console.WriteLine("Hello world!");
        }

        static string RichiediAddendo(string messaggio)
        {
            Console.WriteLine(messaggio);
            string addendo = Console.ReadLine();
            return addendo;
        }

        static int ConvertiStringaANumero(string addendo)
        {
            int addendoIntero;
            try
            {
                addendoIntero = Convert.ToInt32(addendo);
            }
            catch (Exception)
            {

                throw;
            }

            return addendoIntero;
        }
        static int TentaSomma(string addendo1, string addendo2)
        {

            int addendo1Intero = ConvertiStringaANumero(addendo1);
            int addendo2Intero = ConvertiStringaANumero(addendo2);

            return addendo1Intero + addendo2Intero;
        }

        static void StampaSomma(int somma)
        {
            Console.WriteLine("La somma è: " + somma);
        }
        static void Main(string[] args)
        {
            MandaSaluto();

            string addendo1 = RichiediAddendo("Inserisci il primo addendo:");
            string addendo2 = RichiediAddendo("Inserisci il secondo addendo:");

            try
            {
                int somma = TentaSomma(addendo1, addendo2);

                StampaSomma(somma);
            }
            catch (Exception)
            {
                Console.WriteLine("Attenzione! Si è verificato un errore. Il programma sta per terminare.");
            }

            Console.ReadLine();
        }
    }
}