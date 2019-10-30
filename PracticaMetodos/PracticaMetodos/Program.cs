using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodos
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(Suma(7,5.3));
        }
        static int Suma(int operador1, int operador2) => operador1 + operador2;

        static double Suma(double operador1, double operador2) => operador1 + operador2;
        static int Suma(int numero1, int numero2, int numero3) => numero1 + numero2 + numero3;


        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2 + numero3 + numero4;

    }
}
