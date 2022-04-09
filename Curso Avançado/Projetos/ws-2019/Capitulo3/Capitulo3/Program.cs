using System;

namespace Capitulo3 {
    class Program {
        static void Main(string[] args) {

            bool completo = false; // Para valores verdade ou não
            char genero = 'F'; // Para um unico caracter - Aspas simples 'texto'
            char letra = '\u0041'; // Mostrar caracter usando codigo unicode
            string nome = "Vinicius Oliveira"; // Para mais de um caracter - Aspas duplas "texto exemplo"
            object obj1 = "Mikaelly Juca"; // Object pode ser usado para "qualquer coisa"
            object obj2 = 6.2f;

            byte n1 = 126; // Número de 0 a 255
            int n2 = 1000; // Número de -2147483648 a 2147483647
            int n3 = 2147483647;
            long n4 = 2147483648L; // Numero de -9223372036854775808 a 9223372036854775808
            float n5 = 4.5f; // Número do tipo float (precisa um f no final caso declarar o numero com "."
            double n6 = 9.5; // Número do tipo double

            int x1 = int.MinValue;
            int x2 = int.MaxValue;
            float x3 = float.MinValue;
            float x4 = float.MaxValue;
            double x5 = double.MinValue;
            double x6 = double.MaxValue;
            decimal x7 = decimal.MinValue;
            decimal x8 = decimal.MaxValue;
            sbyte x9 = sbyte.MinValue;
            sbyte x10 = sbyte.MaxValue;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            Console.WriteLine($"Valor minimo INT: {x1}"); // Usando '$' no começo e colocando a variavel entre {}, consegue deixar texto e após mostrar
            Console.WriteLine($"Valor máximo INT: {x2}");
            Console.WriteLine($"Valor minimo FLOAT: {x3}");
            Console.WriteLine($"Valor máximo FLOAT: {x4}");
            Console.WriteLine($"Valor minimo DOUBLE: {x5}");
            Console.WriteLine($"Valor máximo DOUBLE: {x6}");
            Console.WriteLine($"Valor minimo DECIMAL: {x7}");
            Console.WriteLine($"Valor máximo DECIMAL: {x8}");
            Console.WriteLine($"Valor minimo SBYTE: {x9}");
            Console.WriteLine($"Valor máximo SBYTE: {x10}");
        }
    }
}
