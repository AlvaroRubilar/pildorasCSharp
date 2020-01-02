using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjeros<DateTime> archivos = new AlmacenObjeros<DateTime>(4);
          
           
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            DateTime fecha = archivos.getElemento(2);
            Console.WriteLine(fecha);

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
