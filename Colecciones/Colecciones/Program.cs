using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            // rellenando o agregando elementos la pila

            foreach (int num in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Push(num);
            }
            //recorriendo pila

            Console.WriteLine("Recorriendo el Stack");
            numeros.Pop();
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
