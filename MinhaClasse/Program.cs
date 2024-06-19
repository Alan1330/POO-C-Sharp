using System;
using System.Globalization;

namespace MinhaClasse {
    internal class Program {
        static void Main(string[] args) {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
        }
    }
}
