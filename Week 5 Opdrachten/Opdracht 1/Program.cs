using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int som = 0;
            Random rnd = new Random();
            int[] nummers = new int[20] ;
            for (i = 0; i < 20; i++)
            {
                nummers[i] = rnd.Next(0,200);
            }
            i = 0;
            foreach (int nummer in nummers)
            {
                Console.WriteLine("Element: {0} is {1} ",i,nummer);
                i++;
                som += nummer;
            }
            double gemiddelde = (double)som / nummers.Length;
            Console.WriteLine("Het gemiddelde is: " + gemiddelde.ToString("0.00"));
            foreach (int nummer in nummers)
            {
                double verschil = nummer - gemiddelde;
                Console.WriteLine("Het verschil met het gemiddelde is: " + Math.Abs(verschil));
            }
            Console.ReadKey();
        }
    }
}
