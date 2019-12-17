using System;

namespace EjemplosPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.cambiaValorEuro(2);
            
            Console.WriteLine(obj.convierte(50));
            
            

        }

        class Circulo 
        {
            private const double pi = 3.1416;  // proiedad de la clase Circulo. Campo de clase.
            public double CalculoArea(int radio) //métdo de clase, ¿Qué pueden hacer los objeto de este tipo
            {
                return pi * radio * radio;

            }

            
        }
        class ConversorEuroDolar
        {
            private  double euro = 1.253;
            public double convierte(double cantidad)
            {
                return cantidad * euro;
            }
            public void cambiaValorEuro(double nuevoValor)
            {
                euro = (nuevoValor<0)? 1.253:nuevoValor;
            }
        }
    }
}
