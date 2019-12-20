using System;

namespace UsoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //array implícito
            var datos = new[] { "Alvaro", "Rubilar", "Chile" };//deben ser del mismo tipo
            var valores = new[] { 15, 28, 35, 75.5, 30.3 };//se convierte en double
            //array de objetos
            Empleados Ana = new Empleados("Ana", 27);
            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = Ana;
            //array de tipos de o clases anónimas
            var personas = new[]
            {
                new {Nombre= "Juan", Edad=19 },
                new {Nombre= "María", Edad= 49},
                new {Nombre= "Diana", Edad= 35}
            };

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }
           
        }
    }
    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            
        }
        String nombre;
        int edad;
    }
}
