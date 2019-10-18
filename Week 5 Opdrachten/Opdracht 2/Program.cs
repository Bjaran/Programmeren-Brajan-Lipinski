using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Random rnd = new Random();
            int[] nummers = new int[20];
            for (i = 0; i < 20; i++)
            {
                nummers[i] = rnd.Next(0, 150);
            }
            i = 0;
            foreach (int nummer in nummers)
            {
                Console.WriteLine("Element: {0} is {1} ", i, nummer);
                i++;
            }
            int min = 150;
            int aantal = 0;
            foreach (int nummer in nummers)
            {
                if (nummer <= min)
                {
                    min = nummer;
                    aantal++;
                }

            }
            Console.WriteLine("Het kleinste getal is: {0} en komt {1} keer voor",min,aantal);
            Console.ReadKey();
        }
    }
}
