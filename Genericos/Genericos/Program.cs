using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjeros archivos = new AlmacenObjeros(4);
            archivos.agregar("Alvaro");
            archivos.agregar("Elena");
            archivos.agregar("Antonio");
            archivos.agregar("Sandra");
            String nombrePersona = (String)archivos.getElemento(2);
            Console.WriteLine(nombrePersona);
        }
    }

    class AlmacenObjeros
    {
        public AlmacenObjeros(int z)
        {
            datosElemento = new Object[z];
        }
        public void agregar(Object obj)
        {

            datosElemento[i] = obj;
            i++;
        }
        public Object getElemento(int i)
        {
            return datosElemento[i];
        }
        private Object[] datosElemento;
        private int i = 0;
    }
}
