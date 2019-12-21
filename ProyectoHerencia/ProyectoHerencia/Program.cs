using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo();
            Humano Alvaro = new Humano();
            Gorila Copito = new Gorila();
            Copito.trepar();
        }
    }

    class Mamiferos
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");

        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si misma");
        }
    }
    class Caballo : Mamiferos
    {
    public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
    class Humano : Mamiferos
    {
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
