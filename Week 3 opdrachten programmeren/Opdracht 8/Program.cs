using System;

namespace Opdracht_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of workhours: ");
            int workHours = int.Parse(Console.ReadLine());
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Number of malfunctions: ");
            int malfunctions = int.Parse(Console.ReadLine());

            if (workHours > 10000 || age > 7 || malfunctions > 25)
            {
                Console.WriteLine("The machine must be serviced");
            }
            else
            {
                Console.WriteLine("The machine doesn't have to be serviced");
            }
            Console.ReadKey();  
        }
    }
}
