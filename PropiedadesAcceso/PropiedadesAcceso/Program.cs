using System;

namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Alvaro = new Empleado("Álvaro");

        }
    }

    class Empleado
    {


        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }
        public void setSalario(double salario)
        {

            if (salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo. Se asignará 0 como salario");
                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }
        public double getSalario()
        {

            return salario;
        }
        private string nombre;
        private double salario;


    }
}
