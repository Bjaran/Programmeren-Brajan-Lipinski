using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef aantal seconden: ");
            string invoer = Console.ReadLine();
            int seconden = int.Parse(invoer);

            int uren = seconden / 3600;
            int urenOver = uren * 3600 ;
            int secondenOver = seconden - urenOver;
            int minuten = secondenOver / 60;
            int minutenOver = minuten * 60;
            int secondenResterend = secondenOver - minutenOver;

            Console.WriteLine("{0:00}:{1:00}:{2:00}",uren,minuten,secondenResterend);
            Console.ReadKey();

        }
    }
}
