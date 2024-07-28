using System;
using System.Globalization;

namespace Aula45Ex02 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario agente = new Funcionario();

            Console.Write("Nome: ");
            agente.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            agente.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            agente.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + agente);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            agente.AumentarSalario(valor);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + agente);

        }
    }
}