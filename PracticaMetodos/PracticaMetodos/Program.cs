using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodos
{
    class Program
    {
        static void mesajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el método mensajeEnPantalla");

        }
        static void Main(string[] args)
        {
            mesajeEnPantalla();
            mesajeEnPantalla();
            Console.WriteLine("Mensaje desde el Main");
        }
       
    }
}
