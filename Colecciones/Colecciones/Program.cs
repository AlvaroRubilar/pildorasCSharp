using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();// Creación Lista
            Console.WriteLine("¿Cuántos elemntos quieres introducir?");
            int elem = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < elem; i++)
            {
                Console.Write($"Ingresa el elemento {i}: ");
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Elementos Introducidos");
            for (int i = 0; i < elem; i++)
            {
                Console.WriteLine(numeros[i]);
            }
          
        }
    }
}
