using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een vaknaam: ");
            string vak = Console.ReadLine();
            Console.Write("Geef het aantal studenten: ");
            int studenten = int.Parse(Console.ReadLine());
            string[] studentenNamen = new string[studenten];
            double[] cijfers = new double[studenten];
            double som = 0;
            double hoogsteCijfer = 0;
            int i = 0;
            for ( i = 0; i < studentenNamen.Length; i++)
            {
                Console.WriteLine($"Geef de naam van de {i + 1}de student: ");
                studentenNamen[i] = Console.ReadLine();
            }
            for ( i = 0; i < studentenNamen.Length; i++)
            {
                Console.WriteLine($"Geef de cijfer van de {i + 1}de student: ");
                cijfers[i] = double.Parse(Console.ReadLine());
            }
            foreach (double cijfer in cijfers)
            {
                som += cijfer;
                if (cijfer>hoogsteCijfer)
                {
                    hoogsteCijfer = cijfer;
                }
            }
            som = som / studenten;
            Console.WriteLine($"Het gemiddelde cijfer is: {som.ToString("0.00")}");
            Console.WriteLine($"Het hoogste cijfer is: {hoogsteCijfer}");
            i = 0;
            foreach (string student in studentenNamen)
            {
                Console.WriteLine($"Student {studentenNamen[i]} heeft voor {vak} het cijfer {cijfers[i]}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
