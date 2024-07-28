namespace Geral {
    internal class Cadastro {

        // atributos
        public string _nome { get; private set; }
        public string Sobrenome;


        //Auto - Properties

        // Constructor

        // Properties costumer
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        //Métodos
        public static void Triple(ref int x) {
            x = x * 3;
        }
    }
}
