using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Aula60Teste {
    internal class Program {
        static void Main(string[] args) {
            
            double dep = 0.0;

            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");


            string nome = Console.ReadLine();
            Console.Write("Entre o valor de deposito inicial: ");

            Console.Write("Hávera depósito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's') {
                Console.Write("Entre o valor depósito inicial: ");
                dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else { dep = 0.0; }

            ContaBank funcionario = new ContaBank(num, nome, dep);
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(funcionario);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            funcionario.Deposito(dep);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(funcionario);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.Saque(dep);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(funcionario);

            

            
        }
    }
}