using System;

namespace ConceptosPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            RealizarTarea();
        }
        static void RealizarTarea()
        {
            Punto origen = new Punto(1,2);
            Punto destino = new Punto(6, 14);
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los dos puntos es de {distancia}");
        }
    }

    
}
