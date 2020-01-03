using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();
            edades.Add("Alvaro", 40);
            edades.Add("Diandra", 32);
            edades["María"] = 25;
            edades["Antonio"] = 29;

            //recorrer diccionario

            foreach (KeyValuePair<string,int> persona in edades)
            {
                Console.WriteLine($"Nombre: {persona.Key}\nEdad: {persona.Value}");
            }
        }
    }
}
