using System;

/*
Fazer um programa pra ler um valor inteiro de 1 a 7 representando um dia da semana 
(sendo 1=domingo, 2=segunda, 3=terça, 4=quarta, 5=quinta, 6=sexta, 7=sabado). 
Escrever na tela o dia da semana correspondente, conforme exemplos.
*/

namespace Exercicio_Resolvido_05 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x) {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sábado";
                    break;
                default:
                    dia = "Valor inválido";
                    break;
            }

            Console.WriteLine("Dia da semana: " + dia);
        }
    }
}
