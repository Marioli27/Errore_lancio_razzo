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
            double Spazio_fallito = 0;
            double metri_sec = 0;
            double errore_tempo = 0;
            double tronc = 0.000000095;

            //inseriamo in input la velocità
            Console.WriteLine("inserire la velocità");
            metri_sec = Convert.ToDouble(Console.ReadLine());

            //calcolo errore di tempo
            errore_tempo = tronc * 100 * 60 * 60 * 10;
            Console.WriteLine($"Hanno sbagliato di {errore_tempo}s");

            //calcolo errore di spazio
            Spazio_fallito = metri_sec * errore_tempo;
            Console.WriteLine($"Hanno sbagliato di {Spazio_fallito}m");

            Console.ReadLine();
        }
    }
}
