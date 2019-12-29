using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.mostrarAviso();
            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provicial Madrid",
                "Sanción de velocidad: $300", "02-05-2019");
            Console.WriteLine(av2.getFecha());
            av2.mostrarAviso();
        }
    }
}
