using System;
using System.Globalization;

namespace Funcoes_Matematicas {
    class Program {
        static void Main(string[] args) {

            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            // Math.Sqrt é usado para calcular a raiz quadrada
            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);

            Console.WriteLine("A raiz quadrada de " + x + " = " + A);
            Console.WriteLine("A raiz quadrada de " + y + " = " + B);
            Console.WriteLine("A raiz quadrada de 25 = " + A);

            // Math.Pow é usado para elevar o número
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);

            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            // Math.Abs é usado para calcular o valor absoluto (o número sem sinal)
            A = Math.Abs(y);
            B = Math.Abs(z);

            Console.WriteLine("O valor absoluto de " + y + " = " + A);
            Console.WriteLine("O valor absoluto de " + z + " = " + B);

            Console.ReadLine();

            /* Expressão usada pra calcular DELTA
            delta = Math.Pow(b, 2.0) - 4 * a * c;
            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); */
        }
    }
}
