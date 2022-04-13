using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Animale
    {
        public Animale(int eta, int numeroZampe)
        {
            Eta = eta;
            _numeroZampe = numeroZampe;

        }

        public int Eta;
 
        private int _numeroZampe;

        public int NumeroZampe
        {
            get 
            { 
                return _numeroZampe;
            }
            set 
            { 
                _numeroZampe = value;
            }
        }
        public string Specie { get; set; } = "nessuna";
        public string Razza { get; set; }
        public TipoSesso Sesso { get; set; }

        public void Dorme()
        {
            Console.WriteLine("Ronf.........");
        }

        public void Mangia(string cibo)
        {
            Console.WriteLine($"Gnam Gnam! {cibo}!");
        }
    }
    public enum TipoSesso
    {
        Maschile,
        Femminile
    }
}
