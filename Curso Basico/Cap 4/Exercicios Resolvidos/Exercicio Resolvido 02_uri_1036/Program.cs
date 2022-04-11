using System;
using System.Globalization;

/*
Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

Formula: delta = (Math.Pow(b,2)) - (4 * a * c)
         x1 = (-b + Math.Sqrt(delta)) / (2 * a)
         x2 = (-b + Math.Sqrt(delta)) / (2 * a)
         
Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.
*/

namespace Exercicio_Resolvido_02_uri_1036 {
    class Program {
        static void Main(string[] args) {

            double A, B, C;

            string[] valor = Console.ReadLine().Split(' ');
            A = double.Parse(valor[0], CultureInfo.InvariantCulture);
            B = double.Parse(valor[1], CultureInfo.InvariantCulture);
            C = double.Parse(valor[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(B, 2.0) - (4 * A * C);

            if (delta < 0 || A == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                double r1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double r2 = (-B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}