/*using System;
namespace Lista14_2
{
    public class Lista14_2
    {
        public static void Main(string[] args)
        {
            //2. Faça um método que preencha 2 matrizes, A 4 x 6 e B 4 x 6. Faça uma função para cada uma das situações
            //a seguir, que recebe duas matrizes preenchidas, calcula e retorna as matrizes indicadas: a) uma matriz S
            //que seja a soma de A e B. b) uma matriz D que seja a diferença de A e B. (A - B). Faça um programa que
            //faça as devidas declarações e acione os módulos para exemplificar o seu uso. Escreva as matrizes
            //resultantes do acionamento de cada uma das funções.

            int[,] matA = new int[4, 6];
            int[,] matB = new int[4, 6];
            PreencheMatriz(matA);
            PreencheMatriz(matB);
            int[,] matSoma = SomaMatriz(matA, matB);
            int[,] matSubtração = SubtraeMatriz(matA, matB);
            bool i = true;
            while (i)
            {
                Console.WriteLine("A");
                for (int x = 0; x < matA.GetLength(0); x++)
                {
                    for (int y = 0; y < matA.GetLength(1); y++)
                    {
                        Console.Write(matA[x, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("B");
                for (int x = 0; x < matB.GetLength(0); x++)
                {
                    for (int y = 0; y < matB.GetLength(1); y++)
                    {
                        Console.Write(matB[x, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Soma");
                for (int x = 0; x < matSoma.GetLength(0); x++)
                {
                    for (int y = 0; y < matSoma.GetLength(1); y++)
                    {
                        Console.Write(matSoma[x, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Subtração");
                for (int x = 0; x < matSubtração.GetLength(0); x++)
                {
                    for (int y = 0; y < matSubtração.GetLength(1); y++)
                    {
                        Console.Write(matSubtração[x, y] + " ");
                    }
                    Console.WriteLine();
                }

                i = false;
            }

        }
        public static void PreencheMatriz(int[,] mat)
        {
            Random rd = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)
            {//Linhas da matriz
                for (int j = 0; j < mat.GetLength(1); j++)
                {//Colunas da Matriz
                    mat[i, j] = rd.Next(0, 11);
                }
            }
        }
        public static int[,] SomaMatriz(int[,] matA, int[,] matB)
        {
            int[,] matSoma = new int[4, 6];
            for (int i = 0; i < matA.GetLength(0); i++)
            {//Linhas da matriz
                for (int j = 0; j < matA.GetLength(1); j++)
                {//Colunas da Matriz
                    matSoma[i, j] = matA[i, j] + matB[i, j];
                }
            }
            return matSoma;
        }

        public static int[,] SubtraeMatriz(int[,] matA, int[,] matB)
        {
            int[,] matSubtrae = new int[4, 6];
            for (int i = 0; i < matA.GetLength(0); i++)
            {//Linhas da matriz
                for (int j = 0; j < matA.GetLength(1); j++)
                {//Colunas da Matriz
                    matSubtrae[i, j] = matA[i, j] - matB[i, j];
                }
            }
            return matSubtrae;
        }

    }
}
*/