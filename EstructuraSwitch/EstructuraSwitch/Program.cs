using System;

namespace EstructuraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Elige medio de transporte (coche, tren, avión)");
            string medioTransporte = Console.ReadLine();
            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad media: 100 km/hr");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad media: 250 km/hr");
                    break;
                case "avión":
                    Console.WriteLine("Velocidad media: 800 km/hr");
                    break;
            }
        }
    }
}
