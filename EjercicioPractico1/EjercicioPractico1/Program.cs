using System;

namespace EjercicioPractico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avión");
            Avion miAvion = new Avion();
            miAvion.ArrancaMotor("Tracatatractar");
            miAvion.Despegar();
            miAvion.Conducir();
            miAvion.Aterrizar();
            miAvion.PararMotor("Ploooof");
            Console.WriteLine();
            Console.WriteLine("Probando el coche");
            Coche miCoche = new Coche();
            miCoche.ArrancaMotor("grrrum grrruuummm");
            miCoche.Acelerar();
            miCoche.Conducir();
            miCoche.PararMotor("bluuuf");
            Console.WriteLine("\nPolimorfismo en acción");
            Vehiculo miVehiculo = miCoche;
            miVehiculo.Conducir();
            miVehiculo = miAvion;
            miVehiculo.Conducir();
        }
    }
    
   
}
