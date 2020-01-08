using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es juan y mi n° de tfno es (+34)123-45-67 y mi código postal es 29679";
            string patron = @"\(\+\d{2}\)\d{3}-\d{2}-\d{2}";
            Regex miRegex = new Regex(patron);
            MatchCollection elMatch = miRegex.Matches(frase);

            Console.WriteLine(elMatch.Count > 0? "Se ha encotrado número de teléfono":"No se ha encontrado número de teléfono");
        }
    }
}
