using System;
using System.Globalization; // Ignorar região do compilador

namespace exercicio {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite seu nome completo");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimo = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write(ultimo);
            Console.Write(" " + idade);
            Console.WriteLine(" " + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
