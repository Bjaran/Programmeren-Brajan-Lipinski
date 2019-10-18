using System;

namespace Opdracht_1
{
    class Program
    {
        const double btw = 0.21;
        static void Main(string[] args)
        {
            Console.Write("Geef prijs:");
            string invoer = Console.ReadLine();
            double prijs = double.Parse(invoer);
            double prijsBtw = prijs * btw;
            double totaalPrijs = prijsBtw + prijs;
            Console.WriteLine("prijs: {0} btw: {1} totaal: {2} ", prijs, prijsBtw, totaalPrijs );
            Console.ReadKey();
        }
    }
}
