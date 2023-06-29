/* using System;
namespace lista14_3
{
    class lista14_3
    {
        public static void Main(string[] args)
        {
            //3. Escreva um método que preencha uma matriz M(10,10) e a escreva. Faça outros métodos que recebam a
            //matriz preenchida, realiza as trocas indicadas a seguir (um método para cada uma delas) e exiba a matriz
            //resultante da troca:
            //a) a linha 2 com a linha 8
            //b) a coluna 4 com a coluna 9
            //c) a diagonal principal com a diagonal secundária
            //d) a linha 5 com a coluna 9. Faça um programa que faça as devidas declarações e acione os métodos
            //para exemplificar o seu uso.
            int[,] mat = new int[10, 10];
            PreencheMatriz(mat);
            int soma2_8 = 0, soma4_9 = 0, somaDPeDS = 0, soma5_9 = 0;
            soma2_8 = soma2e8(mat);
            soma4_9 = soma4e9(mat);
            somaDPeDS = diagonais(mat);
            soma5_9 = soma5e9(mat);
            Console.WriteLine($"Soma da linha 2 e 8: {soma2_8}");
            Console.WriteLine($"Soma da coluna 4 e 9: {soma4_9}");
            Console.WriteLine($"Soma da diagonal principal e secundária: {somaDPeDS}");
            Console.WriteLine($"Soma da linha 5 e coluna 9: {soma5_9}");

        }
        public static void PreencheMatriz(int[,] mat)
        {
            Random rd = new Random();
            for (int x = 0; x < mat.GetLength(0); x++)
            {
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    mat[x, y] = rd.Next(0, 10);
                }
            }
            //imprimir matriz na tela
            for (int x = 0; x < mat.GetLength(0); x++)
            {
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    Console.Write(mat[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int soma2e8(int[,] mat)
        {
            int soma2_8 = 0;
            for (int x = 0; x < mat.GetLength(0); x++)
            {
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    if (x == 2)
                    {
                        soma2_8 += mat[x, y];
                    }
                    if (x == 8)
                    {
                        soma2_8 += mat[x, y];
                    }
                }
            }
            return soma2_8;
        }
        public static int soma4e9(int[,] mat)
        {
            int soma4_9 = 0;
            for (int x = 0; x < mat.GetLength(0); x++)
            {
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    if (y == 4)
                    {
                        soma4_9 += mat[x, y];
                    }
                    if (y == 9)
                    {
                        soma4_9 += mat[x, y];
                    }
                }
            }
            return soma4_9;
        }
        public static int soma5e9(int[,] mat)
        {
            int soma5_9 = 0;
            for (int x = 0; x < mat.GetLength(0); x++)
            {
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    if (x == 5)
                    {
                        soma5_9 += mat[x, y];
                    }
                    if (y == 9)
                    {
                        soma5_9 += mat[x, y];
                    }
                }
            }
            return soma5_9;
        }
        public static int diagonais(int[,] mat)
        {
            int somaDPeDS = 0;
            for (int x = 0; x < mat.GetLength(0); x++)
            {
                somaDPeDS += mat[x, x];
            }
            for (int x = 0; x < mat.GetLength(0); x++)
            {
                somaDPeDS += mat[x, mat.GetLength(0) - 1 - x];
            }
            return somaDPeDS;
        }

    }

}
*/
