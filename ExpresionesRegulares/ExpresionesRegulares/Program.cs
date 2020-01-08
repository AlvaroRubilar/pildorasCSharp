using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "cursos@@pildorasinformaticases";

            string re1 = ".*?";
            string re2 = "(@)";
            string re3 = ".*?";
            string re4 = "(\\.)";

            Regex r = new Regex(re1 + re2 + re3 + re4, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);
            Console.WriteLine(m.Success?"Email correcto":"Email no correcto");
        }
    }
}
