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
            Punto otroPunto = new Punto();
            Console.WriteLine($"La distancia entre los dos puntos es de {distancia}");
            Console.WriteLine($"Número de objetos creados: {Punto.ContadorDeObjetos()}");
        }
    }

    
}
