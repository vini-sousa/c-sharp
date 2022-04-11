using System;
using System.Globalization;

/*
Leia um valor de ponto flutuante com duas casas decimais. 
Este valor representa um valor monetário. A seguir, calcule 
o menor número de notas e moedas possíveis no qual o valor 
pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. 
As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. 
A seguir mostre a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.
*/

namespace uri_1021_cedulas_moedas {
    class Program {
        static void Main(string[] args) {

            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int cem = (int) N / 100;
            double resto = N % 100;

            int cinquenta = (int) (resto / 50);
            resto = resto % 50;

            int vinte = (int) (resto / 20);
            resto = resto % 20;

            int dez = (int) (resto) / 10;
            resto = resto % 10;

            int cinco = (int) (resto / 5);
            resto = resto % 5;

            int dois = (int) (resto / 2);
            resto = resto % 2;

            int umReal = (int) (resto / 1);
            resto = resto % 1;

            int cinquentaCentavos = (int) (resto / 0.50);
            resto = resto % 0.50;

            int vinte_cincoCentavos = (int) (resto / 0.25);
            resto = resto % 0.25;

            int dezCentavos = (int) (resto / 0.10);
            resto = resto % 0.10;

            int cincoCentavos = (int) (resto / 0.05);
            resto = resto % 0.05;

            int umCentavo = (int) (resto / 0.01);

            Console.WriteLine("NOTAS:");
            Console.WriteLine(cem + " nota(s) de R$ 100.00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50.00");
            Console.WriteLine(vinte + " nota(s) de R$ 20.00");
            Console.WriteLine(dez + " nota(s) de R$ 10.00");
            Console.WriteLine(cinco + " nota(s) de R$ 5.00");
            Console.WriteLine(dois + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(umReal + " moeda(s) de R$ 1.00");
            Console.WriteLine(cinquentaCentavos + " moeda(s) de R$ 0.50");
            Console.WriteLine(vinte_cincoCentavos + " moeda(s) de R$ 0.25");
            Console.WriteLine(dezCentavos + " moeda(s) de R$ 0.10");
            Console.WriteLine(cincoCentavos + " moeda(s) de R$ 0.05");
            Console.WriteLine(umCentavo + " moeda(s) de R$ 0.01");
        }
    }
}