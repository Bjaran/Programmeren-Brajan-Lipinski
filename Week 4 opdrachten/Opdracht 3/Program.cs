using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummer;
            int iteratie = 1;
            int getallenVijf = 0;
            do
            {
                Console.Write("Geef een nummer: ");
                nummer = int.Parse(Console.ReadLine());
                if (iteratie % 5 == 0)
                {
                    getallenVijf += nummer;
                }
                iteratie++;
            } while (nummer != 0);
            Console.Write("De som van het 5 - de, 10 - de, 15 - de... getal is: {0}",getallenVijf);
            Console.ReadKey();
        }
    }
}
