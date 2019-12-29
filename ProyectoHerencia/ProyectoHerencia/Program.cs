﻿using System;

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

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Ballena miWally = new Ballena("Wally");
            ISaltoConPatas ImiBabieca = miBabieca;
            Console.WriteLine("Patas utilizadas en el salto de Babieca " + ImiBabieca.numeroPatas());



            //Copito.trepar();
            //Alvaro.getNombre();
            //Babieca.getNombre();
            //Copito.getNombre();
        }
    }
    interface IMamiferosTerrestres
    {
        int numeroPatas();

    }
    interface IAnimalesDeportes
    {
        String tipoDeporte();
        Boolean esOlimpico();

    }
    interface ISaltoConPatas
    {
        int numeroPatas();
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
        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
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
    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }
        public void nadar()
        {
            Console.WriteLine("soy capaz de nadar");
        }
    }
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }


        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public bool esOlimpico()
        {
            return false;
        }

        public string tipoDeporte()
        {
            return "Hípica";
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }
        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }
    }
    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }

        public int numeroPatas()
        {
            return 2;
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
