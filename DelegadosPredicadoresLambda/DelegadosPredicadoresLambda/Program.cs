using System;
using System.Collections.Generic;

namespace DelegadosPredicadosLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personas> gente = new List<Personas>();

            //Personas P1 = new Personas();
            //P1.Nombre = "Antonio";
            //P1.Edad = 40;

            //Personas P2 = new Personas();
            //P2.Nombre = "María";
            //P2.Edad = 28;

            //Uso del delgado
            OperacionesMatematicas operacion = new OperacionesMatematicas(Suma);
            Console.WriteLine(operacion(4,7));
           


        }
        public delegate int OperacionesMatematicas(int numero1, int numero2);
        //public static int Cuadrado(int num)
        //{
        //    return num * num;
        //}
        public static int Suma(int num1, int num2) => num1 + num2;
        
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
    
}
