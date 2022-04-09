using System;
using System.Globalization;

namespace ConsoleApplication2 {
    class Program {
        static void Main(string[] args) {

            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!"); // Escreve um texto
            Console.WriteLine("Bom dia!"); // Escreve um texto com quebra de linho no final
            Console.WriteLine("Até mais.");
        
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); // Limita o número com 2 casas decimais
            Console.WriteLine(x.ToString("F4")); // Limita o número com 4 casas decimais
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // Usa "ponto" invés de "vírgula" nos decimais

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
        
            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
        
            Console.ReadLine();
        }
    }
}
