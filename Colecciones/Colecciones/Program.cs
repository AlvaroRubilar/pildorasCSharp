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
            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}
            //numeros.Remove(6);
            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);
            numeros.AddFirst(nodoImportante);
            for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }
        }
    }
}
