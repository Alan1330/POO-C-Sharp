using System;

namespace Aula71Quartos {
    internal class Program {
        static void Main(string[] args) {

            Quartos[] hotel = new Quartos[10];// classe customizada em vetor, declarada e instaciada com quantidade fixa para o vetor.

            Console.Write("Quantos quartos será alugado? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine();
                
                Console.WriteLine($"Aluguel #{i}:");  // Console.WriteLine($"Aluguel #{i}:"); 
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int num = int.Parse(Console.ReadLine());
                hotel[num] = new Quartos(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (hotel[i] != null) {
                    Console.WriteLine(i + ": " + hotel[i]);
                }
            }

        }
    }
}