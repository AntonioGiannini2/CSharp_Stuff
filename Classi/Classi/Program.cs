using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animale cane = new Animale(4, 4);
            cane.Specie = "canina";
            cane.Razza = "Carlino";
            cane.Sesso = TipoSesso.Maschile;
            cane.Eta = 5;

            Console.WriteLine($"La razza del cane è {cane.Razza}");
            cane.Mangia("insalata");
            cane.Dorme();
            Console.ReadLine();
        }
    }
}
