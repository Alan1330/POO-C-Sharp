using System;
using System.Globalization;

namespace Aula70VetoresPT2 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Produto[] vector = new Produto[n];

            for (int i = 0; i < n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vector[i] = new Produto { Name = nome, Price = preco };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++) {
                soma += vector[i].Price;// soma = soma + os valores de atributo Price.
            }

            double avg = soma / n;
            Console.WriteLine("AVERAGE PRICE " + avg.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}