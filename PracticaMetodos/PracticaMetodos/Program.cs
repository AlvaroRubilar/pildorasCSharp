using System;
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
            Console.WriteLine(divideNumeros(18, 7)); 
        }
        static double divideNumeros(double num1, int num2) => num1 / num2;
        
    }
}
