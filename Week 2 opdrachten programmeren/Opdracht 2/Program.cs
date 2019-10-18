using System;

namespace Opdracht_2
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

            double gemmideld = ((double)getal1 + getal2 + getal3) / 3 ;

            Console.WriteLine("gemmidelde: {0:0.00}", gemmideld);
            Console.ReadKey();

        }
    }
}
