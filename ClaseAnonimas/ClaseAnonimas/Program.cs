using System;


namespace ClaseAnonimas
{
    class Program
    {
        static void Main(string[] args)
        {
            var miVariable = new { Nombre = "Álvaro", Edad = 19 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

            var miOtravariable = new { Nombre = "Ana", Edad = 25 };

            miVariable = miOtravariable;


        }
    }
}
