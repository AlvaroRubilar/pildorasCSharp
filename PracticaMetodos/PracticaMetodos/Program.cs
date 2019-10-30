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
            Console.WriteLine(Suma(7,5.3));
        }

        private static double Suma(int v1, double v2)
        {
            return Suma2(v1, v2);
        }

        private static double Suma2(int v1, double v2)
        {
            return v1 + v2;
        }
    }
}
