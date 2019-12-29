using System;

namespace StructsYEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 250);
            empleado1.cambiaSalario(empleado1,100);
            Console.WriteLine(empleado1);
        }
    }

     public  struct Empleado
    {
        private double salarioBase;
        private double comision;

        public Empleado(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
           this.comision = comision;
        }

       
        public override string ToString() =>
            string.Format( "Salario y comisión del empleado ({0},{1})", salarioBase, comision);
        public void cambiaSalario (Empleado emp,double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }
    }
}
