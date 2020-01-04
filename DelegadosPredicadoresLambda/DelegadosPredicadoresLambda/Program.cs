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

            Personas P3 = new Personas();
            P3.Nombre = "Ana";
            P3.Edad = 37;

            gente.AddRange(new Personas[] { P1, P2, P3 });

            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteAlvaro);

            bool existe = gente.Exists(elPredicado);
            Console.WriteLine(existe ? "Hay Personas con el nombre Alvaro":"No hay nadie llamado Alvaro") ;


        }
        static bool ExisteAlvaro(Personas persona) => persona.Nombre == "Alvaro" ? true : false;
        
        
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
    
}
