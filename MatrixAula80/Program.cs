using System;

namespace MatrixAula80 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            // declarar uma matriz quadrada, conhecida "de ordem n", sendo n = linhas e colunas.
            int[,] mat = new int[n, n];

            //inserir valores na matriz.
            for (int i = 0; i < n; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            //mostrar valores da diagonal.
            Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(mat[i, i] + " ");
            }
            Console.WriteLine();

            // para contar quantos números negativos possui a matriz.
            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}