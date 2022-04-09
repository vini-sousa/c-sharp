using System;
using System.Globalization; // Usado pra ignorar região no compilador

namespace curso {
    class Program {
        static void Main(string[] args) {
            
            // Converte inteiro para string
            int n1 = int.Parse(Console.ReadLine());
            // Converte string para char
            char x = char.Parse(Console.ReadLine());
            // CultureInfo.InvariantCulture é usado para ignorar . ou , na digitação
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(x);
            // F2 para limitar a duas casas decimais e o restante para ignorar . e , na impressão
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write(nome);
            Console.Write(" " + sexo);
            Console.Write(" " + idade);
            Console.WriteLine(" " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
