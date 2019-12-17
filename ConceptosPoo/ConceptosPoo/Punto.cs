using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosPoo
{
    class Punto
    {
        public Punto(int x, int y)
        {
            Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
        }
        public Punto()
        {
            Console.WriteLine("este es el constructor por defecto");
        }
    }
}
