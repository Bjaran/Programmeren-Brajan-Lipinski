using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef getal 1: ");
            int getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef getal 2: ");
            int getal2 = int.Parse(Console.ReadLine());
            if (getal1 % getal2 == 0 )
                Console.WriteLine("Getal 1 is een veelvoud van Getal 2");
            else if (getal2 % getal1 == 0)
                Console.WriteLine("Getal 2 is een veelvoud van Getal 1");
            else
                Console.WriteLine("Getallen zijn geen veelvouden");
            Console.ReadKey();

        }
    }
}
