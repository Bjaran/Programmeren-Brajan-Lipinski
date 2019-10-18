using System;

namespace Opdracht_7
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Height(in cm): ");
         int height = int.Parse(Console.ReadLine());
         Console.Write("Weight(in kg): ");
         int weight = int.Parse(Console.ReadLine());
         Console.Write("Sex (M/W): ");
         string sex  = Console.ReadLine();
         string male = "M";
         double bmi = ((double)weight / ((height / 100) ^ 2));
            if (string.Equals(sex, male))
            {
                double normalWeightManMin = (20 * ((height / 100) ^ 2));
                double normalWeightManMax = (25 * ((height / 100) ^ 2));
                Console.WriteLine("Healthy BMI is between 20 and 25");
                Console.WriteLine("This is your BMI: {0}", bmi.ToString("0.00"));
                Console.WriteLine("Your weight should be in between {0} and {1}", normalWeightManMin, normalWeightManMax);
            }
            else
            {
                double normalWeightWomanMin = (19 * ((height / 100) ^ 2));
                double normalWeightWomanMax = (24 * ((height / 100) ^ 2));
                Console.WriteLine("Healthy BMI is between 19 and 24");
                Console.WriteLine("This is your BMI: {0}", bmi.ToString("0.00"));
                Console.WriteLine("Your weight should be in between {0} and {1}", normalWeightWomanMin, normalWeightWomanMax);
            }
            Console.ReadKey();
        }
    }
}
