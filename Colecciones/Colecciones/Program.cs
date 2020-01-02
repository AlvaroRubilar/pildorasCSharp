using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach(int num in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros.AddLast(num);
            }
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
          
        }
    }
}
