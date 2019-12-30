using System;

namespace StructsYEnum
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Estaciones alergia = Estaciones.Primavera;
            string laAlergia = alergia.ToString();
            Console.WriteLine(laAlergia);


        }
    }

    enum Estaciones { Primavera, Verano, Otoño, Invierno};

}
