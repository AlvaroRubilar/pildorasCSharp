using System;

namespace EjemplosPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo;// creación de objeto de tipo circulo. Variable/objeto de tipo círculo
            
            miCirculo = new Circulo(); // Iniciación de variable/objeto de tipo Circulo. Instanciar una clase
                                       // Instanciación. Ejemplarización. Creación de ejemplar de la clase

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculoArea(9));
            

        }

        class Circulo 
        {
            double pi = 3.1416;  // proiedad de la clase Circulo. Campo de clase.
            public double calculoArea(int radio) //métdo de clase, ¿Qué pueden hacer los objeto de este tipo
            {
                return pi * radio * radio;

            }

            
        }
    }
}
