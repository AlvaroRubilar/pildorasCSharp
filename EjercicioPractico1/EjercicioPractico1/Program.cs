using System;

namespace EjercicioPractico1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Vehiculo
    {

        private String marca,modelo;

        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public void arrancarMotor()
        {

            Console.WriteLine("El vehiculo ha arrancado su motor");
        }
        public void pararMotor()
        {

            Console.WriteLine("El vehiculo ha detenido su motor");
        }

        public virtual void Conducir()
        {

            Console.WriteLine("Estoy conduciendo un vehículo");
        }

    }
    class Avion:Vehiculo
    {
        public Avion(String marca, String modelo):base(marca,modelo)
        {

        }
        public override void Conducir()
        {

            Console.WriteLine("Estoy conduciendo un avión");
        }
    }
    class Coche : Vehiculo
    {
        public Coche(String marca, String modelo) : base(marca, modelo)
        {

        }
        public override void Conducir()
        {

            Console.WriteLine("Estoy conduciendo un coche");
        }
    }
}
