using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo miBabieca = new Caballo("Babieca");
            Humano miAlvaro = new Humano("Alvaro");
            Gorila miCopito = new Gorila("Copito");
            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = miBabieca;
            almacenAnimales[1] = miAlvaro;
            almacenAnimales[2] = miCopito;
            almacenAnimales[1].getNombre();





            //Copito.trepar();
            //Alvaro.getNombre();
            //Babieca.getNombre();
            //Copito.getNombre();
        }
    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");

        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si misma");
        }
        public void getNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es: {nombreSerVivo}");
        }
        public String nombreSerVivo;
    }
    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
