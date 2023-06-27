/*using System;

namespace Lista11
{
    class lista11
    {
        public static int LerOpcaoJogador()
        {
            int opcao = 0;
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            opcao = int.Parse(Console.ReadLine() ?? "0");

            return opcao;

        }
        public static int LerOpcaoComputador()
        {
            Random rd = new Random();
            int opcao = rd.Next(1, 4);

            return opcao;
        }

        public static void VerificaVencedor(int opcaoJogador, int opcaoComputador)
        {
            if (opcaoJogador == opcaoComputador)
            {
                Console.WriteLine("Empate");
            }
            else if (opcaoJogador == 1 && opcaoComputador == 2)
            {
                Console.WriteLine("Computador venceu");
            }
            else if (opcaoJogador == 1 && opcaoComputador == 3)
            {
                Console.WriteLine("Jogador venceu");
            }
            else if (opcaoJogador == 2 && opcaoComputador == 1)
            {
                Console.WriteLine("Jogador venceu");
            }
            else if (opcaoJogador == 2 && opcaoComputador == 3)
            {
                Console.WriteLine("Computador venceu");
            }
            else if (opcaoJogador == 3 && opcaoComputador == 1)
            {
                Console.WriteLine("Computador venceu");
            }
            else if (opcaoJogador == 3 && opcaoComputador == 2)
            {
                Console.WriteLine("Jogador venceu");
            }
        }
        public static void Main()
        {
            VerificaVencedor(LerOpcaoComputador(), LerOpcaoJogador());

        }

    }
}
*/