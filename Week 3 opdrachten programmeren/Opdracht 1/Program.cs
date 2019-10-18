using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef getal 1:");
            int getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef getal 2:");
            int getal2 = int.Parse(Console.ReadLine());
            if (getal1 < getal2)
            {
                Console.WriteLine("grootste waarde is: " + getal2);
                Console.WriteLine("kleinste waarde is: " + getal1);
            }
            else
            {
                Console.WriteLine("grootste waarde is: " + getal1);
                Console.WriteLine("kleinste waarde is: " + getal2);
            }
            Console.ReadKey();

        }
    }
}
