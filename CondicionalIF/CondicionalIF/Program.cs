using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 25;
            Console.WriteLine("vamos a evaluar si eres mayor de edad");
            if (edad >= 18)
            {
                Console.WriteLine("Adelante, puedes pasar porque eres mayor de edad");
            }

        }
    }
}
