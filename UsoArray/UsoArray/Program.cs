using System;

namespace UsoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;
            ProcesaDatos(numeros);
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

        }
        static void ProcesaDatos(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }
        }


    }

}
