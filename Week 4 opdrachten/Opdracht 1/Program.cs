using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int getalOpsomming = 0;
            int tel =  0;
            do
            {
                Console.Write("Voer een getal in:");
                getal = int.Parse(Console.ReadLine());
                if (getal > 0)
                {
                    getalOpsomming += getal;
                    tel++;
                }

            } while (getal != 0);
            double gemiddelde = (double)getalOpsomming / tel;
            Console.WriteLine("Het gemiddelde v/d positieve getallen is: {0}",gemiddelde.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
