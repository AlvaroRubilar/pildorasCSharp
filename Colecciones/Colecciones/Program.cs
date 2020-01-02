using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();// Creación Lista
            Console.WriteLine("Introduce elementos en la colección(0 para salir)");
            int elem = 1;
            while (elem!=0)
            {
                elem = Int32.Parse(Console.ReadLine());
                numeros.Add(elem);
            }
            numeros.RemoveAt(numeros.Count - 1);
            Console.WriteLine("Elementos Itroducidos");
            foreach (int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }
            
          
        }
    }
}
