namespace Aula45Ex03 {
    internal class Aluno {

        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double Notas() {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() {
            if (Notas() > +60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotaRestante() {
            if (Aprovado()) {
                return 0.0;
            }
            else {
                return 60 - Notas();
            }
        }
    }
}
