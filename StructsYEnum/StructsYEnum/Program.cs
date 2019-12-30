using System;

namespace StructsYEnum
{

    class Program
    {
        static void Main(string[] args)
        {
            Empleado Antonio = new Empleado(Bonus.bueno, 2000);
            Console.WriteLine("El salario del empleado es de: "+Antonio.getSalario());
           


        }
    }

    internal class Empleado
    {
        private Bonus bonusEmpleado;
        private double salario;

        public Empleado(Bonus bonusEmpleado, double salario)
        {
            this.bonusEmpleado = bonusEmpleado;
            this.salario = salario;
        }
        public double getSalario() => salario + (double)bonusEmpleado;
    }

    enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 }

}
