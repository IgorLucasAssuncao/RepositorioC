/*/*
using System;

namespace Lista10
{

    class Lista10
    {
        /*
                public static double coseno(double X)
                {
                    int sinal = -1;

                    double Y = 1;
                    for (int i = 0, expoente = 2; i < 25; i++, expoente += 2)
                    {
                        Y += sinal * (Math.Pow(X, expoente) / fatorial(expoente));
                        sinal = sinal * (-1);

                    }

                    return Y;
                }


                public static int fatorial(int fatorial)
                {
                    int fat = 1;
                    for (int i = 1; i <= fatorial; i++)
                    {
                        fat *= i;
                    }
                    return fat;
                }


                public static void Main()
                {
                    double CosenoX = 0, recebeX = 0;
                    Console.WriteLine("Insira o X para calcular o Coseno: ");
                    CosenoX = Double.Parse(Console.ReadLine() ?? "0");

                    recebeX = coseno(CosenoX);
                    Console.WriteLine($"O coseno é: {recebeX}");
        */
        //2) Escreva um algoritmo que receba um número inteiro positivo N e apresente um quadro de números como o
        //quadro abaixo. Este é o caso de N = 5. Use um método para gerar e mostrar o quadro abaixo.
        //1 2 3 4 5
        //2 3 4 5 6
        //3 4 5 6 7
        //4 5 6 7 8
        //5 6 7 8 9
        /*
                public static void quadro(int N, int tamanho)
                {
                    int[,] quadro = new int[tamanho, tamanho];
                    int limite = N;
                    int somador = 1;
                    for (int l = 0; l < quadro.GetLength(0); l++)
                    {
                        for (int c = quadro.GetLength(1) - 1; c >= 0; c--)
                        {
                            quadro[l, c] = limite;
                            limite--;
                        }
                        limite = N + somador;
                        somador++;
                    }
                    for (int l = 0; l < quadro.GetLength(0); l++)
                    {
                        for (int c = 0; c < quadro.GetLength(1); c++)
                        {
                            Console.Write($"{quadro[l, c]} ");
                        }
                        Console.WriteLine();
                    }

                }


                public static void Main()
                {
                    int X = 0;
                    int tamanho = 0;
                    Console.WriteLine("Insira um número: ");
                    X = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Insira o tamanho da matriz: ");
                    tamanho = int.Parse(Console.ReadLine() ?? "0");
                    quadro(X, tamanho);

        */
        //3) Crie um método que receba como parâmetro um valor inteiro e positivo N e retorne o valor de S, obtido pelo seguinte
        //cálculo:
        //S = 1 + 1/2 + 1/4 + 1/8 ... + 1/2N
        /*
                public static void calculo(int limite)
                {
                    double S = 0;
                    for (int i = 0; i <= limite; i++)
                    {
                        S += 1 / Math.Pow(2, i);
                    }
                    Console.WriteLine($"O valor de S é: {S}");
                }

                public static void Main()
                {
                    int limite = 0;
                    Console.WriteLine("Insira o limite: ");
                    limite = int.Parse(Console.ReadLine() ?? "0");

                    calculo(limite);]
                    */

        // 4) Um número primo é aquele que é divisível apenas por ele mesmo e por 1. Faça um método que receba como entrada um
        // inteiro qualquer e imprima uma mensagem informando se o número é primo ou não.
        /*
        public static void Primo(int numero)
        {

            int contador = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
            {
                Console.WriteLine("É primo");
            }
            else
            {
                Console.WriteLine("Nao e primo");
            }

        }
        public static void Main()
        {
            int numero = 0;
            Console.WriteLine("Insira um número: ");
            numero = int.Parse(Console.ReadLine() ?? "0");
            Primo(numero);
            
        //   5) Faça um método que receba um número inteiro N como parâmetro e retorne o número de divisores de N. No
        //método main implemente a leitura de uma sequência de números, terminada pelo flag zero, e calcule o número de
        //divisores de cada um deles, usando o método desenvolvido anteriormente.
        public static int divisores(int numero)
        {
            int numero_divisores = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    numero_divisores++;
                }
            }
            return numero_divisores;
        }
        public static void Main()
        {

            int numero = 1, numero_divisores = 0;
            while (numero != 0)
            {
                Console.WriteLine("Insira um número: ");
                numero = int.Parse(Console.ReadLine() ?? "0");
                numero_divisores = divisores(numero);
                Console.WriteLine($"O número de divisores de {numero} é: {numero_divisores}");
            }

        }
    }
}

/*/