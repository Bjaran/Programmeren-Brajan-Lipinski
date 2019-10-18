using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een richtgetal: ");
            int richtgetal = int.Parse(Console.ReadLine());
            int tel = 0;
            Console.Write("Geef een nummer: ");
            int nummer = int.Parse(Console.ReadLine());
            while (nummer != 0)
            {
                if (nummer == richtgetal)
                {
                    tel++;
                }
                Console.Write("Geef een nummer: ");
                nummer = int.Parse(Console.ReadLine());
            }
            Console.Write("Het aantal getallen gelijk aan de richtgetal: {0}",tel);
            Console.ReadKey();
        }
    }
}
