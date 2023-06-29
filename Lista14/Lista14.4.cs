/*
using System;

namespace Lista14_4
{
    class Lista14_4
    {
        public static void Main(String[] args)
        {

            //4. Faça um método que preencha 2 vetores X e Y com 10 elementos cada um (ocupando as posições de 0 a
            //9 em cada vetor). Faça um outro método que receba dois vetores preenchidos e gere um novo vetor com
            //os elementos desses 2 vetores intercalados de tal forma que nas posições ímpares do novo vetor estejam
            //os elementos do primeiro vetor e nas posições pares os elementos do segundo vetor recebido por
            //parâmetro. Faça um método que receba e exiba o conteúdo de um vetor. Faça um programa que faça as
            //Devidas declarações e acione os métodos para exemplificar o seu uso.

            int[] vetorX = new int[10];
            int[] vetorY = new int[10];
            int[] somaVet;
            PreencheVetor(vetorX);
            PreencheVetor(vetorY);
            somaVet = SomaVetor(vetorX, vetorY);
            exibeVet(vetorX);
            exibeVet(vetorY);
            exibeVet(somaVet);


        }
        public static void PreencheVetor(int[] vet)
        {
            Random rd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rd.Next(0, 11);
            }
        }
        public static int[] SomaVetor(int[] vetX, int[] vetY)
        {
            int[] somaVet = new int[vetX.Length + vetY.Length];
            for (int i = 0, vet1 = 0, vet2 = 0; i < somaVet.Length; i++)
            {
                if (i % 2 == 1)
                {
                    somaVet[i] = vetX[vet1];
                    vet1++;
                }
                else
                {
                    somaVet[i] = vetY[vet2];
                    vet2++;
                }

            }

            return somaVet;
        }
        public static void exibeVet(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/