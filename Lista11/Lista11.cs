
using System;
namespace Lista11
{
    class Lista10
    {
        //Questão 1. Intercalação é o processo utilizado para construir uma tabela ordenada, de tamanho m + n, a partir de
        //duas tabelas já ordenadas de tamanhos m e n. Por exemplo, a partir das tabelas A e B construímos a tabela C:
        //Faça um programa que:
        //a) leia NA, número de elementos do conjunto A (NA < 100);
        //b) leia, em seguida, os elementos do conjunto A;
        //c) leia, logo após o valor de NB, número de elementos do conjunto B (NB < 100);
        //d) crie e imprima um conjunto C, ordenado, de tamanho NA + NB, a partir dos conjuntos originais A e B.
        //Observações:
        //1. Considerar os elementos de A e B como inteiros.
        //2. Os elementos de A e B já são lidos ordenados.
        //3. A leitura dos valores dos vetores A e B deve ser feita através de um método. A intercalação também deverá
        //ser feita através de um método que irá receber os vetores A e B já preenchidos.

        public static int[] VetorA()
        {
            int tamanho = 0;
            Console.WriteLine("Digite o tamanho do vetor A");
            tamanho = int.Parse(Console.ReadLine() ?? "0");
            int[] vetorA = new int[tamanho];
            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine("Digite um número");
                vetorA[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            return vetorA;
        }

        public static int[] VetorB()
        {
            int tamanho = 0;
            Console.WriteLine("Digite o tamanho do vetor B");
            tamanho = int.Parse(Console.ReadLine() ?? "0");
            int[] vetorB = new int[tamanho];
            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine("Digite um número");
                vetorB[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            return vetorB;

        }
        public static void intercala(int[] A, int[] B)
        {
            int[] vetA = A;
            int[] vetB = B;
            int[] vetC = new int[vetA.Length + vetB.Length];
            for (int i = 0; i < vetA.Length; i++)
            {
                vetC[i] = vetA[i];

            }
            for (int i = vetA.Length, x = 0; i < (vetB.Length + vetA.Length); i++, x++)
            {
                vetC[i] = vetB[x];
            }


            for (int i = 0; i < vetC.Length; i++)
            {
                Console.WriteLine(@" " + vetC[i]);
            }

        }
        public static void Main()
        {
            intercala(VetorA(), VetorB());

        }
    }
}