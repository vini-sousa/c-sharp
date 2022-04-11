using System;
using System.Globalization;

/*
Fazer um programa para ler as medidas da base e altura de um retângulo.
Em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo,
com quatro casas decimais, conforme exemplo.
*/

namespace exercicio {
    class Program {
        static void Main(string[] args) {
            
            double valorBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorAltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = valorBase * valorAltura;
            double perimetro = (2 * valorBase) + (2 * valorAltura);
            double diagonal = Math.Sqrt((Math.Pow(valorBase, 2)) + Math.Pow(valorAltura, 2));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}