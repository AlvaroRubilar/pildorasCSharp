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
            const double PI = 3.1416;
            Console.WriteLine("Introduce la medida del radio");
            double radio = double.Parse(Console.ReadLine());
            double area = radio * radio * PI;
            Console.WriteLine($"El área del circulo es {area}");


        }
    }
}
