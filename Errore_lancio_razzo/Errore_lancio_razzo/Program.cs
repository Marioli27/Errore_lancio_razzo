using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errore_lancio_razzo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Spazio = 0;
            double metri_sec_scud = 1676;
            double errore_tempo = 0;
            double tronc = 0.000000095;

            //calcolo errore di tempo
            errore_tempo = tronc * 100 * 60 * 60 * 10;
            Console.WriteLine($"Hanno sbagliato di {errore_tempo}s");

            //calcolo errore di spazio
            Spazio = metri_sec_scud * errore_tempo;
            Console.WriteLine($"Hanno sbagliato di {Spazio}m");

            Console.ReadLine();
        }
    }
}
