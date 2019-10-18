using System;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[20];
            int getal = 0;
            int i = 0;
            int tel = 0;
            do
            {
                Console.Write("Geef een getal <0-stoppen> : ");
                getal = int.Parse(Console.ReadLine());
                getallen[i] = getal;
                i++;
            }
            while (getal != 0);
            tel = 0;
            Console.Write("Geef de zoekwaarde : ");
            int zoekwaarde = int.Parse(Console.ReadLine());
            foreach (int zoekgetal in getallen)
            {
             if (zoekwaarde == zoekgetal)
                {
                    tel++;
                }

            }
            Console.WriteLine($"De zoekwaarde is: {zoekwaarde}");
            Console.WriteLine($"De zoekwaarde komt {tel} keer voor");
            Console.ReadKey();
        }
    }
}
