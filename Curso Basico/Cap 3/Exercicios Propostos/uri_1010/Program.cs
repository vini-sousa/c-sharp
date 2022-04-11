using System;
using System.Globalization;

/*
Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
Entrada

O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.
Saída

A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
*/

namespace uri_1010 {
    class Program {
        static void Main(string[] args) {

            double valor;

            string[] vet1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet1[0]);
            int numero1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int numero2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valor = (numero1 * valor1) + (numero2 * valor2);

            Console.WriteLine("VALOR A PAGAR: " + "R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}