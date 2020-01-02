using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();// Creación Lista
            int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };
            for (int i = 0; i < 5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
