using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico1
{
    class Vehiculo
    {
      

        

        public void ArrancaMotor(String sonidoAlArrancar)
        {

            Console.WriteLine($"Arranca el motor: {sonidoAlArrancar}");
        }
        public void PararMotor(String sonidoAlParar)
        {

            Console.WriteLine($"Parando el motor {sonidoAlParar}");
        }

        public virtual void Conducir()
        {

            Console.WriteLine("Estoy conduciendo un vehículo");
        }
    }
}
