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

            

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);
            //foreach (int numero in numerosPares) Console.WriteLine(numero);
            numerosPares.ForEach(numero => Console.WriteLine(numero));


        }
        
        
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
    
}
