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

        }
        static void ProcesaDatos(int[] datos)
        {
            foreach (var i in datos)
            {
                Console.WriteLine(i);
            }
        }

    }

}
