using System;

namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            
            int intentos = 0;
            int adivina = 0;
            while (adivina != numeroAleatorio)
            {
                
                Console.WriteLine("Ingresa un número:");
                adivina = int.Parse(Console.ReadLine());
                
                Console.WriteLine(adivina<numeroAleatorio?"Más alto":
                    (adivina>numeroAleatorio?"Más bajo":$"Has acertado en {++intentos} intentos"));
                intentos++;
            }
        }
    }
}
