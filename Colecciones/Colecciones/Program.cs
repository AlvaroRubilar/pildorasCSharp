using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();
            // rellenando o agregando elementos a la cola

            foreach (int num in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Enqueue(num);
            }
            //recorriendo la cola

            Console.WriteLine("Recorriendo el Queue");

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
