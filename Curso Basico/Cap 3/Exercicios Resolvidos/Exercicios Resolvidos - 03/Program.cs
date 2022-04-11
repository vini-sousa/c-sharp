using System;
using System.Globalization;

/*
Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas.
Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas,
com uma casa decimal, conforme exemplo.
*/

namespace Exercicios_Resolvidos_03 {
    class Program {
        static void Main(string[] args) {

            string[] vet1 = Console.ReadLine().Split(' ');
            string nome1 = vet1[0];
            int idade1 = int.Parse(vet1[1]);

            string[] vet2 = Console.ReadLine().Split(' ');
            string nome2 = vet2[0];
            int idade2 = int.Parse(vet2[1]);

            double idadeMedia = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + idadeMedia.ToString("F1", CultureInfo.InvariantCulture) + " anos");
        }
    }
}