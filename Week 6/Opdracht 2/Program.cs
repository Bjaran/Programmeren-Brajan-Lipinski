using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 0;
            do
            {
                Console.Write("Geef een getal (0 is stop): ");
                getal = int.Parse(Console.ReadLine());
                bool isPriem = IsPriemGetal(getal);
                if (isPriem)
                    Console.WriteLine("Het getal is een Priemgetal");
                else
                    Console.WriteLine("Het getal is geen Priemgetal");
            } while (getal != 0);
            Console.WriteLine("Einde");
            Console.ReadKey();
        }
        static bool IsPriemGetal(int getal)
        {
            bool isPriem = true;
            int i = 2;
            while ((i < getal) && isPriem)
            {
                if ((getal % i) == 0)
                    isPriem = false;
                else 
                    i = i + 1;
            }
            return isPriem;
        }
    }
}
