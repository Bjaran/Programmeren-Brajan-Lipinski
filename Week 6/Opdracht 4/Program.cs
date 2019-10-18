using System;
using System.Linq;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een string: ");
            string invoer = Console.ReadLine();
            OnderzoekTekst(invoer, out int telPunten, out int telCommas, out int telSemicolon);
            Console.WriteLine($"Er zijn {telPunten} punten, {telCommas} Comma's en {telSemicolon} Puntkomma's");
            Console.ReadKey();
        }
        static void OnderzoekTekst(string invoer, out int telPunten, out int telCommas, out int telSemicolon)
        {
            telPunten = invoer.Count(c => c == '.');
            telCommas = invoer.Count(c => c == ',');
            telSemicolon = invoer.Count(c => c == ';');
        }
    }
}
