using System;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 1;
            int nieuwGetal = 0;
            int oudGetal = 0;
            for (int i = 1; i<=20; i++)
            {
                Console.Write(getal + " ");
                nieuwGetal = oudGetal + getal;
                oudGetal = getal;
                getal = nieuwGetal;
            }
            Console.ReadKey();
        }
    }
}
