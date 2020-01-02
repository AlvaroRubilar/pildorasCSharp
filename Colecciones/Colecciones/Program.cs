using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();// Creación Lista
            numeros.Add(5);
            numeros.Add(7);
            numeros.Add(9);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
