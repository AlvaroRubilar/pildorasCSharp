using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado de la suma es " + (num1 + num2));
        }
    }
}
