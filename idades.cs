using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome1, nome2;
            int idade1, idade2;
            double media;

            Console.Write("Dados da primeira pessoa: ");
            nome1 = Console.ReadLine();
            idade1 = int.Parse(Console.ReadLine());

            Console.Write("Dados da segunda pessoa: ");
            nome2 = Console.ReadLine();
            idade2 = int.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " eh de" + media.ToString("F1", CI) + " anos.");
        }
    }
}
