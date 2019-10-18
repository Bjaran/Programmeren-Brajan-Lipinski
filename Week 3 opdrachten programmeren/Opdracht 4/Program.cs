using System;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef getal 1: ");
            int getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef getal 2: ");
            int getal2 = int.Parse(Console.ReadLine());
            Console.Write("Geef getal 3: ");
            int getal3 = int.Parse(Console.ReadLine());
            if (getal1 > getal2 && getal1 > getal3)
            {
                Console.WriteLine("getal 1 is de grootste getal");
            }
                else if (getal2 > getal1 && getal2 > getal3)
            {
                Console.WriteLine("getal 2 is de grootste getal");
            }
                 else if (getal3 > getal1 && getal3 > getal2)
            {
                Console.WriteLine("getal 3 is de grootste getal");
            }
             if (getal1 < getal2 && getal1 < getal3)
            {
                Console.WriteLine("getal 1 is de kleinste getal");
            }
                else if (getal2 < getal1 && getal2 < getal3)
            {
                Console.WriteLine("getal 2 is de kleinste getal");
            }
                 else if (getal3 < getal1 && getal3 < getal2)
            {
                Console.WriteLine("getal 3 is de kleinste getal");
            }
            int som = getal1 + getal2 + getal3;
            int product = getal1 * getal2 * getal3;
            double gemiddelde = ((double)getal1 + getal2 + getal3) / 3;
            Console.WriteLine("Som is: " + som );
            Console.WriteLine("Product is: " + product);
            Console.WriteLine("Gemmidelde is: " + gemiddelde.ToString(".00"));
            Console.ReadKey();
        
        }
    }
}
