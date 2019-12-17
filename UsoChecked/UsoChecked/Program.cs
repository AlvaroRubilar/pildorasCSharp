using System;

namespace UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int numero = int.MaxValue;
            int resultado = checked(numero + 20);
            
            Console.WriteLine(resultado);
            
        }
    }
}
