using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura = 34.7;
            int temperaturaMadrid;
            // conversión explícita
            //casting
            temperaturaMadrid = (int) temperatura;
            // trunca
            Console.WriteLine(temperaturaMadrid);
        }
    }
}
