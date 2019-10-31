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
            string carnet="no";
            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes carnet? si/no");
                carnet = Console.ReadLine();
            }
            if(edad>=18 && carnet=="si")
                Console.WriteLine("Puedes conducir vehículos");
            else
                Console.WriteLine("No puedes conduir vehículos");

        }
    }
}
