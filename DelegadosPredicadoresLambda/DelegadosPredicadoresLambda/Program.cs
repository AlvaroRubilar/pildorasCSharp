using System;

namespace DelegadosPredicadosLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //creción del objeto delegado apuntando a MensajeBienvenida
            ObjDelegado ElDelegado = new ObjDelegado(MensajeBienvenida.SaludoBienvenida);
            ElDelegado("Hola acabo de llegar");
            ElDelegado = new ObjDelegado(MensajeDespedida.SaludoDespedida);
            ElDelegado("Bueno ya me voy");
        }
        // Definición del objeto delegado
        delegate void ObjDelegado(string msj);
    }
    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine($"Mensaje de Bienvenida: {msj}");
        }
    }
    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine($"Mensaje de Despedida: {msj}");
        }
    }
}
