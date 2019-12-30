using System;

namespace StructsYEnum
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Estaciones alergia = Estaciones.Primavera;
            Console.WriteLine(alergia);


        }
    }

    enum Estaciones { Primavera, Verano, Otoño, Invierno};

}
