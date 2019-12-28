using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico1
{
    class Avion: Vehiculo
    {
        public void Aterrizar()
        {

            Console.WriteLine("Estoy aterrizando");
        }
        public void Despegar()
        {

            Console.WriteLine("Estoy despegando");
        }

        public override void Conducir()
        {
            // base.Conducir();
            Console.WriteLine("Surcando los cielos del globo");
        }
    }
}
