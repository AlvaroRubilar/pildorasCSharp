using System;

namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Alvaro = new Empleado("Álvaro");
            Alvaro.SALARIO = 750;
            Console.WriteLine("El salario del empleado es: " + Alvaro.SALARIO);


        }
    }

    class Empleado
    {


        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }
        //public void setSalario(double salario)
        //{

        //    if (salario < 0)
        //    {
        //        Console.WriteLine("El salario no puede ser negativo. Se asignará 0 como salario");
        //        this.salario = 0;
        //    }
        //    else
        //    {
        //        this.salario = salario;
        //    }
        //}
        //public double getSalario()
        //{

        //    return salario;
        //}
        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;


        }
        //creación de propiedad
        //public double SALARIO
        //{
        //    get
        //    {
        //        return this.salario;
        //    }
        //    set
        //    {
        //        this.salario = evaluaSalario(value);
        //    }
        //}
        private string nombre;
        private double salario;

        public double SALARIO { get => this.salario; set => this.salario = evaluaSalario(value); }
    }
}
