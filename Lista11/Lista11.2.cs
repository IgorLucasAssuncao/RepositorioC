

using System;
namespace Lista11
{
    class lista11_2
    {
        //Questão 2. Faça um programa que leia dois vetores de inteiros de tamanho 10 representando o número de
        //matrícula de alunos matriculados em Algoritmos e Técnicas de Programação e Cálculo I. Em seguida, o programa
        //deverá imprimir o número de matrícula dos alunos que estão matriculados simultaneamente nestas duas
        //disciplinas (ou seja, calcular a interseção dos dois vetores). Se não existirem alunos matriculados simultaneamente
        //nas duas disciplinas informar com uma mensagem na tela. A leitura dos valores dos vetores deve ser feita
        //através de um método. A interseção também deverá ser feita através de um método que irá receber os
        //vetores das matrículas das duas disciplinas, já preenchidos.
        //2
        public static int[] ATP()
        {
            int[] ATP = new int[10];
            Console.WriteLine("Digite o número de matrícula dos alunos de Algoritmos e Técnicas de Programação");
            for (int i = 0; i < ATP.Length; i++)
            {
                Console.WriteLine("Digite um número");
                ATP[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            return ATP;
        }
        public static int[] Calc()
        {
            int[] Calc = new int[10];
            Console.WriteLine("Digite o número de matrícula dos alunos de Cálculo I");
            for (int i = 0; i < Calc.Length; i++)
            {
                Console.WriteLine("Digite um número");
                Calc[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            return Calc;
        }
        public static void Intersecao(int[] ATP, int[] Calc)
        {

            int[] vetATP = ATP;
            int[] vetCalc = Calc;





        }
        public static void Main(string[] args)
        {
            Intersecao(ATP(), Calc());
        }
    }

}

