using System.Globalization;

namespace Aula60Teste {
    internal class ContaBank {
        //Atributos
        private string _nome;
        public int Num_conta {  get; private set; }  
        public double Saldo { get; private set; }
        private double _taxa = 5.00;

        //Construtor total
        public ContaBank(int num, string nome, double saldo) {
            Num_conta = num;
            Nome = nome;
            Saldo = saldo;
        }

        //properties
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }


        //Métodos
        public void Saque(double valor) {
            Saldo = Saldo - valor - _taxa;
        }

        public void Deposito(double valor) {
            Saldo = Saldo + valor;
        }

        public override string ToString() {
            return "Conta "
                + Num_conta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
