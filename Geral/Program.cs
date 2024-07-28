using Geral;
using System;

namespace geral {
    internal class Program {
        static void Main(string[] args) {

            /*Cadastro aluno = new Cadastro();

            aluno.Sobrenome = "Silva";
            Console.WriteLine(aluno.Sobrenome);

            Console.WriteLine(aluno.Nome = "A");
            Console.WriteLine();
            Console.Write("alterado nome de " + aluno.Nome + " para ");
            
            aluno.Nome = "florentina de Jesus";
            Console.WriteLine(aluno.Nome);
          
            double? x = null;

            Console.WriteLine(x.GetValueOrDefault());// pega&mostre o valor de X,caso seja NULL mostre valor padrão ,ex: double é zero !!
            Console.WriteLine(x.HasValue); // verifica se tem ou não valor. e sua saída é TRUE ou seja sim! tem valor ou False nao tem valor.
                                           // definido ou o valor padrão de acordo com tipo.
                                           //Console.WriteLine(x.Value); // mostrar o valor caso seja diferente de null ou fazer if else como tratamento.


            if (x.HasValue) { Console.WriteLine(x.Value); }
            else { Console.WriteLine("X is null"); }

            int somatorio = Calculator.Some(2, 3, 4);
             

            int a = 10;
            int triplo;
            Calculator.Triple(a, out triplo);
            Console.WriteLine(a);

            int valor = 10;

            Object obj = valor;

            int referencia = (int) obj;
         

            // cria um vetor e inicializa com valores
            string[] nomes = new string[] { "Alan", "Tayna", "Taylan" };

            //forma 1 de mostrar os valores
            for(int i = 0; i < nomes.Length; i++) {
                Console.WriteLine(nomes[i]);
            }

            //forma 2 de mostrar os valores mais legivel.
            Console.WriteLine("__________");

            foreach (string obj in nomes) {
                Console.WriteLine(obj);
            }
                */

            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alan");
            lista.Add("Tayna");
            lista.Add("Bob");
            lista.Add("Ana");

            foreach(string obj in lista){
                Console.WriteLine(obj);
            }


            List<string> lista2 = lista.FindAll(x => x.Length == 5);

            foreach(string obj in lista2){
                Console.WriteLine(obj);
            }
        }
    }
}
