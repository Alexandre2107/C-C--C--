using System;
using System.Globalization;

    namespace Primeiro {
        class Program {
            static void Main(string[] args) {
                CultureInfo CI = CultureInfo.InvariantCulture;
                double base, altura, area, perimetro, diagonal;
                
                Console.write ("Base do retangulo: ");
                base = double.Parse(Console.ReadLine(), CI);

                Console.write ("Altura do retangulo: ");
                altura = double.Parse(Console.ReadLine(), CI);

                area = base * altura;
                perimetro = (2* base) + (area * 2);
                diagonal = (Math.Sqrt(Math.Pow (largura, 2.0) + Math.Pow(area, 2.0)));

                Console.WriteLine("AREA = " + area.ToString("F4", CI));
                Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
                Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));
            }

        }
    }


 


