using System;

namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Deseas entrar en un bucle while? si/no");
            string respuesta = Console.ReadLine();
            while (respuesta != "no")
            {
                Console.WriteLine("Estas ejecutando el interior del bucle while");
                Console.WriteLine("Introduce tu nombre, por favor");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Saldras del bucle {nombre} cuando respondas no a la pregunta" );
                Console.WriteLine("¿Deseas repetir otra vez? si/no ");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Has salido del bucle");
        }
    }
}
