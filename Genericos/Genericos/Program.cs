using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjeros archivos = new AlmacenObjeros(4);
            //archivos.agregar("Alvaro");
            //archivos.agregar("Elena");
            //archivos.agregar("Antonio");
            //archivos.agregar("Sandra");
           
            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));
            archivos.agregar(new Empleado(4500));
            Empleado salarioEmpleado = (Empleado)archivos.getElemento(2);
            Console.WriteLine(salarioEmpleado.getSalario());

        }
    }

    class AlmacenObjeros
    {
        public AlmacenObjeros(int z)
        {
            datosElemento = new Object[z];
        }
        public void agregar(Object obj)
        {

            datosElemento[i] = obj;
            i++;
        }
        public Object getElemento(int i)
        {
            return datosElemento[i];
        }

        private Object[] datosElemento;

        private int i = 0;
    }
    class Empleado
    {
        

        public Empleado(double salario)
        {
            this.salario = salario;
        }
        public double getSalario() => salario;

        private double salario;
    }
}
