﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            mesajeEnPantalla();
            Console.WriteLine("Mensaje desde el Main");
        }
        static void mesajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el método mensajeEnPantalla");

        }
    }
}
