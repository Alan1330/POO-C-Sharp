// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Specialized;

namespace MatrizAula81Teste {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o tamanho da Matriz: ");
            string[] m = Console.ReadLine().Split(' ');
            int l = int.Parse(m[0]);
            int c = int.Parse(m[1]);

            int[,] mat = new int[l, c];

            //inserir valores
            for (int i = 0; i < l; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            /* mostrar os valores da matriz.
            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            } */


            Console.WriteLine();
            Console.Write("Mostre os valores possíveis ao redor de: ");
            int x = int.Parse(Console.ReadLine());
            int count = 0;


            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    if (x == mat[i, j]) {
                        count++;
                        Console.WriteLine();
                        Console.WriteLine("#" + (i + 1) + " Position: " + "[" + i + ", " + j + "]");

                        if (j - 1 >= 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (j + 1 < c) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i - 1 >= 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (i + 1 < l) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }

                    }
                }
            }
            Console.WriteLine("Total encontrados: " + count);
        }
    }
}