using System;
using System.Globalization;

namespace Exemplo02 {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdcionarProdutos(int quantidade) {
            Quantidade += quantidade; //Quantidade + quantidade
        }

        public void RemoverProdutos(int quantidade) {

            while (Quantidade < quantidade) {
                Console.WriteLine("ATENÇÃO : Pode remover no máximo: " + Quantidade);
                Console.Write("Digite o número de produtos a ser removidos do estoque: ");
                quantidade = int.Parse(Console.ReadLine());
            }
            Quantidade -= quantidade; //Quantidade - quantidade

        }

        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidade(s), Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
