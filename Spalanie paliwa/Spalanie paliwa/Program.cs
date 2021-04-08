using System;

namespace Spalanie_paliwa
{
    class Paliwo
    {
        private double dystans;
        private double spalanie;
        private double cenaPaliwa;

        public Paliwo(double d, double s, double cP)
        {
            dystans = d;
            spalanie = s;
            cenaPaliwa = cP;

        }
        public void Koszt()
        {
            double koszt;
            koszt = (dystans * spalanie) / cenaPaliwa;
            Console.WriteLine("Koszt paliwa to: {0} ", Math.Round(koszt,2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj przejechany dystans: ");
            double dystans = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj spalanie pojazdu (w L/100km): ");
            double spalanie = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj cenę paliwa: ");
            double cenaPaliwa = double.Parse(Console.ReadLine());
            Paliwo paliwo1 = new Paliwo(dystans, spalanie, cenaPaliwa);
            paliwo1.Koszt();
            Console.ReadKey();
        }
    }
}
