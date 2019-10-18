using System;

namespace Opdracht_1
{
    class Program
    {
        const double btw = 0.21;
        static void Main(string[] args)
        {
            Console.Write("Geef prijs:");
            float prijs = float.Parse(Console.ReadLine());
            double prijsBtw = BerekenBtw(prijs);
            double totaalPrijs = prijsBtw + prijs;
            Console.WriteLine("prijs: {0} btw: {1} totaal: {2} ", prijs, prijsBtw.ToString("0.00"), totaalPrijs.ToString("0.00"));
            Console.ReadKey();
        }
        static float BerekenBtw(float prijs)
        {
            double prijsBtw = prijs * btw;

            return (float)prijsBtw;
        }
    }
}
