using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal 1-4: ");
            int getal = int.Parse(Console.ReadLine());
            
            switch (getal)
            {
                case 1:
                    Console.WriteLine("spades");
                    break;
                case 2:
                    Console.WriteLine("diamonds");
                    break;
                case 3:
                    Console.WriteLine("hearts");
                    break;
                case 4:
                    Console.WriteLine("clubs");
                    break;
                default:
                    Console.WriteLine("Invalid number !");
                    break;
            }
            Console.ReadKey();
        }
    }
}
