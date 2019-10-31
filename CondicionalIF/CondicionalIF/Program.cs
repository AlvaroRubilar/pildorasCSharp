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
            int edad = 15;
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");
            bool carnet = false;
            if (carnet)
                Console.WriteLine("Puedes conducir vehículos");
            else
                Console.WriteLine("Lo siento pero no puedes conducir vehículos");
        }
    }
}
