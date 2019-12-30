using System;
using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();
            miArchivo.mensaje();
        }
    }
    class ManejoArchivos
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;
        public ManejoArchivos()
        {
            archivo = new StreamReader(@"C:\Users\mars_\OneDrive\Documents\Prueba.txt");
            while ((linea=archivo.ReadLine())!=null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
        public void mensaje()
        {
            Console.WriteLine("hay {0} lineas",contador);
            
        }
        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
