﻿using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' '); // Separa palavras em uma mesma linha. Detecta o espaço entre elas e armazena em vetores para dividir cada uma em variaveis.
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.Write(a);
            Console.Write(" " + b);
            Console.WriteLine(" " +c);
        }
    }
}