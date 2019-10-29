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
            sumaNumeros(2, 4);
        }
        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los números es: {num1+num2}");
        }
    }
}
