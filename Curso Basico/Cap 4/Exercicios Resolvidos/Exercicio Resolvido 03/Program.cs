using System;

/*
Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o
menor dentre os três números lidos. Em caso de empate, mostrar apenas uma vez.
*/

namespace Exercicio_Resolvido_03 {
    class Program {
        static void Main(string[] args) {

            int a, b, c, menor;

            string[] valor = Console.ReadLine().Split(' ');
            a = int.Parse(valor[0]);
            b = int.Parse(valor[1]);
            c = int.Parse(valor[2]);

            if (a < b && a < c) {
                menor = a;
            } 
            else if (b < c) {
                menor = b;
            } 
            else {
                menor = c;
            }
            Console.WriteLine("MENOR = " + menor);
        }
    }
}
