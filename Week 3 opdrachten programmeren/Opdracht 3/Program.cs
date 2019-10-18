using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef getal 1:");
            int getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef getal 2:");
            int getal2 = int.Parse(Console.ReadLine());
            Console.Write("Geef getal 3:");
            int getal3 = int.Parse(Console.ReadLine());

            if (getal1 > getal3 && getal2 > getal3)
            {
                Console.WriteLine("Getal 3 is het kleinste getal");
            }
            else
            {
                Console.WriteLine("Getal 3 is niet het kleinste getal");
            }
            Console.ReadKey();
        }
    }
}
