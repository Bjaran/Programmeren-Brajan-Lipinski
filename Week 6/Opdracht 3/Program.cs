using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaar = 0;
            do
            {
                Console.Write("Voer in een jaar:");
                jaar = int.Parse(Console.ReadLine());
                bool schrikkeljaar = IsSchrikkelJaar(jaar);
                if(schrikkeljaar)
                    Console.WriteLine("Dit jaar is een schrikkeljaar");
                else
                    Console.WriteLine("Dit jaar is geen schrikkeljaar");
            } while (jaar != 0);
            Console.ReadKey();
        }
        static bool IsSchrikkelJaar(int jaar)
        {
            bool schrikkeljaar = true;
            if (jaar % 400 == 0 || jaar % 4 == 0 && jaar % 100 != 0)
                schrikkeljaar = true;
            else
                schrikkeljaar = false;
                return schrikkeljaar;
        }

    }
}
