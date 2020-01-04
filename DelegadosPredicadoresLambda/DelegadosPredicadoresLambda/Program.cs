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

            Predicate<Personas> elPredicado = new Predicate<Personas>(ExistenMayoresDeEdad);

            bool existe = gente.Exists(elPredicado);
            Console.WriteLine(existe ? "Hay Personas mayores de edad":"No hay nadie mayor de edad") ;


        }
        static bool ExistenMayoresDeEdad(Personas persona) => persona.Edad>=18 ? true : false;
        
        
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
    
}
