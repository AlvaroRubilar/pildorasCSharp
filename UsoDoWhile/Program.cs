using System;

namespace UsoDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);

            int intentos = 0;
            int adivina;
            do
            {
                intentos++;
                Console.WriteLine("Ingresa un número:");
                try{

                    adivina = int.Parse(Console.ReadLine());
                }
                catch(FormatException ex){

                    System.Console.WriteLine("No has introducido un número valido, se toma como número intoducido el cero");
                    adivina=0;
                }

                Console.WriteLine(adivina < numeroAleatorio ? "Más alto" :
                    (adivina > numeroAleatorio ? "Más bajo" : $"Has acertado en {intentos} intentos"));
                
            }while (adivina != numeroAleatorio);
        }
    }
}
