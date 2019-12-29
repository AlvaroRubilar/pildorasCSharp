using System;

namespace StructsYEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 250);
            Console.WriteLine(empleado1);
        }
    }

    internal class Empleado
    {
        private int salarioBase;
        private int comision;

        public Empleado(int salarioBase, int comision)
        {
            this.SalarioBase = salarioBase;
            this.Comision = comision;
        }

        public int SalarioBase { get => salarioBase; set => salarioBase = value; }
        public int Comision { get => comision; set => comision = value; }
        public override string ToString() =>
            string.Format( "Salario y comisión del empleado ({0},{1})", salarioBase, comision);
    }
}
