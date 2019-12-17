using System;

namespace LanzamientoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce número de mes");
            int numeroMes = int.Parse(Console.ReadLine());
            Console.WriteLine(NombreDelMes(numeroMes));
            Console.WriteLine("Aquí continuaría la ejecución del resto del programa");
        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    return "Mes erroneo";
            }
        }
    }
}
