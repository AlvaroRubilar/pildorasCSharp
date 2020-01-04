using System;

namespace DelegadosPredicadosLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //creción del objeto delegado apuntando a MensajeBienvenida
            ObjDelegado ElDelegado = new ObjDelegado(MensajeBienvenida.SaludoBienvenida);
            ElDelegado();
        }
        // Definición del objeto delegado
        delegate void ObjDelegado();
    }
    class MensajeBienvenida
    {
        public static void SaludoBienvenida()
        {
            Console.WriteLine("Hola acabo de llegar.¿Qué tal?");
        }
    }
    class MensajeDespedida
    {
        public static void SaludoDespedida()
        {
            Console.WriteLine("Bueno ya me marcho. Hasta luego");
        }
    }
}
