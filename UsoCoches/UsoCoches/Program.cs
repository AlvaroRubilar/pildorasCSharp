using System;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();// crear objeto/instancia de tipo Coche.
            // dar un estado inicial a nuestro coche
            Coche coche2 = new Coche();
            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());
            Coche coche3 = new Coche(4500.25, 1.20035);
            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());
        }
    }
    class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }
        public String getInfoCoche()
        {
            return "Información del coche:\n"+"Ruedas:\t"+ruedas+"\nLargo:\t"+largo+" cm\nAncho:\t"+ancho+" m";
        }
        public void setExtras(bool paramClimatizador, String paramTapiceria)
        {

            climatizador = paramClimatizador;
            tapiceria = paramTapiceria;
        }
        public String getExtras()
        {
            return "Extras del coche:\n" + "Tapicería:\t" + tapiceria + "\nClimatizador:\t" + climatizador;
        }
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }   
}
