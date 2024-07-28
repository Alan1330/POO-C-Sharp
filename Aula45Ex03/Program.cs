using System;
using System.Globalization;

namespace Aula45Ex03 {
    internal class Program {
        static void Main(string[] args) {

            Aluno estudante = new Aluno();
            Console.Write("Nome do Aluno: ");
            estudante.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            estudante.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            estudante.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            estudante.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + estudante.Notas().ToString("F2", CultureInfo.InvariantCulture));
            if (estudante.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + estudante.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
}