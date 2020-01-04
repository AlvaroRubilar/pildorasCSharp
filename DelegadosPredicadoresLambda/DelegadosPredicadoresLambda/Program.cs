using System;
using System.Collections.Generic;

namespace DelegadosPredicadosLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personas> gente = new List<Personas>();

            Personas P1 = new Personas();
            P1.Nombre = "Antonio";
            P1.Edad = 40;

            Personas P2 = new Personas();
            P2.Nombre = "María";
            P2.Edad = 28;
            ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;
            Console.WriteLine(comparaEdad(P1.Nombre,P2.Nombre));
            



        }
        public delegate bool ComparaPersonas(string n1, string n2);
        
        
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
    
}
