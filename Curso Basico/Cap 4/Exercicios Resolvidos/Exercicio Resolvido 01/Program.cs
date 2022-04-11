using System;
using System.Globalization;

namespace Exercicio_Resolvido_01 {
    class Program {
        static void Main(string[] args) {

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = a + b;

            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

            if (notaFinal < 60.00) {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
