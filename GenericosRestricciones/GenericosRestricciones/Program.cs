using System;

namespace GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            almacenEmpleados<Estudiante> empleados = new almacenEmpleados<Estudiante>(3);
            empleados.agregar(new Estudiante(4500));
            empleados.agregar(new Estudiante(1500));
            empleados.agregar(new Estudiante(3500));
        }
    }
    class almacenEmpleados <T> where T : IParaEmpleados
    {
       
        public almacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }
        public void agregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }
        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }
        private int i = 0;
        private T[] datosEmpleado;

    }
    class Estudiante
    {
        public Estudiante(double edad)
        {
            this.edad = edad;

        }
        public double getEdad() => edad;
        private double edad;
    }
    class Director:IParaEmpleados
    {
        private double salario;

        

        public Director(double salario)
        {
            
            this.salario = salario;
        }
        public double  getSalario()
        {
            return salario;
        }
    }
    class Secretaria : IParaEmpleados
    {

        private double salario;



        public Secretaria(double salario)
        {

            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }

    class Electricista : IParaEmpleados
    {
        private double salario;



        public Electricista(double salario)
        {

            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }

    interface IParaEmpleados
    {
        double getSalario();
    }
}
