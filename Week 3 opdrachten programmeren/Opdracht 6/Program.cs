using System;

namespace Opdracht_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your score: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("You got an A!");
                Console.WriteLine("You passed");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("You got an B!");
                Console.WriteLine("You passed");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("You got an C!");
                Console.WriteLine("You passed");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("You got an D!");
                Console.WriteLine("You failed!");
            }
            else
            {
                Console.WriteLine("You got an F!");
                Console.WriteLine("You failed!");
            }
            Console.ReadKey();
        }
    }
}
