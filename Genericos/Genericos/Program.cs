using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjeros<Empleado> archivos = new AlmacenObjeros<Empleado>(4);
          
           
            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));
            archivos.agregar(new Empleado(4500));
            Empleado salarioEmpleado = archivos.getElemento(2);
            Console.WriteLine(salarioEmpleado.getSalario());

        }
    }

    class AlmacenObjeros <T>
    {
        public AlmacenObjeros(int z)
        {
            datosElemento = new T[z];
        }
        public void agregar(T  obj)
        {

            datosElemento[i] =  obj;
            i++;
        }
        public T getElemento(int i)
        {
            return datosElemento[i];
        }

        private T[] datosElemento;

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
