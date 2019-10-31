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

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad < 18)
                Console.WriteLine("No puedes conducir vehículos");
            else
            {
                Console.WriteLine("¿Tienes carnet?");
                string carnet = Console.ReadLine();
                int compara = String.Compare(carnet, "si", true);
                if(compara==0)
                    Console.WriteLine("Puedes conducir vehículos");
                else
                    Console.WriteLine("Lo siento mucho no puedes conducir");

            }
        }
    }
}
