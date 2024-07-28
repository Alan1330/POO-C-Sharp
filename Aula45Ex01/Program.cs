using System;
using System.Globalization;

namespace Aula45Ex01 {
    internal class Program {
        static void Main(string[] args) {

            Retangulo a = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            a.Altura = double.Parse(Console.ReadLine());
            a.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("ÁREA = " + a.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + a.Perimetro().ToString("F2", CultureInfo.InvariantCulture)); ;
            Console.WriteLine("DIAGONAL = " + a.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}