using System;
using System.Globalization;

namespace Exercicios_Resolvidos {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Digite a largura do terreno:");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a comprimento do terreno:");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o preço do metro quadrado do terreno:");
            double precoMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine("Largura do terreno" + " = " + largura.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Comprimento do terreno" + " = " + comprimento.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço do metro quadrado" + " = " + precoMetro.ToString("F2", CultureInfo.InvariantCulture));

            double valorArea = largura * comprimento;

            Console.WriteLine("Valor da área do terreno" + " = " + valorArea.ToString("F2", CultureInfo.InvariantCulture));

            double valorTerreno = valorArea * precoMetro;

            Console.WriteLine("Preço do terreno" + " = " + valorTerreno.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
