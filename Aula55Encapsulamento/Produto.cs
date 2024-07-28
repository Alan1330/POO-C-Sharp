using System.Globalization;

namespace Aula55Encapsulamento {
    class Produto {

        //Atributos
        private string _nome; // não foi aplicado auto-properties devido lógica mais elaborada na properties manual.

        // private double _preco;
        // private int _quantidade;


        // auto Propriedade = Properties

        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // Construtor
        public Produto() {
        }

        public Produto(string nome, double preco) {
            _nome = nome;
            Preco = preco;
            Quantidade = 0; // ou não escrever pode ser útil.
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Properties

        /*Criação de Propriedades*/
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        /*public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }
        
        //Métodos GET e SET
         * 
         * 
        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public double GetQuantidade() {
            return _quantidade;
        }

        */
        
        //Métodos

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
