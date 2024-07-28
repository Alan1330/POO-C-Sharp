using System;
using System.Globalization;

namespace Aula48Estaticos01 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do Dólar? ");
            double cota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vaiPagar = ConversorDeMoeda.RealParaDolla(cota, compra);
            Console.WriteLine("Valor a ser pago em Reais = " + vaiPagar.ToString("F2", CultureInfo.InvariantCulture ));
        }
    }
}