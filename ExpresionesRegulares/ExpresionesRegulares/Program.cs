using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi web es http://pildorasinformaticas.es";
            string patron = "https?://(www.)?pildorasinformaticas.es";
            Regex miRegex = new Regex(patron);
            MatchCollection elMatch = miRegex.Matches(frase);

            Console.WriteLine(elMatch.Count > 0? "Se ha encontrado web":"No se ha encontrado web");
        }
    }
}
