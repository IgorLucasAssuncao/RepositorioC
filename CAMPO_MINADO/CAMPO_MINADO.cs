/*
using System;


namespace Campo
{
    class Program
    {


        /*
        Objetivo do programa:
        Criar um campo minado usando a linguagem C#.O jogo deve mostrar um tabuleiro com vários quadrados vazios,
        no qual em alguns deles há bombas escondidas.O jogador deve selecionar uma linha e coluna, revelando um
        valor que mostra a quantidade de bombas próximas ao local selecionado.O programa deve permitir que o
        jogador insira o local que deseja que seja revelado, verificando a quantidade de bombas adjacentes ao
        local escolhido e verficar se ele perdeu ou ganhou o jogo.
       

 
        Integrantes:
        Érick Fernando dos Santos Vieira;
        Igor Lucas Assunção Ribas;
        Gustavo Aguiar Nogueira Almeida;
        Miguel Sanches Braga Inácio.
       
        Data de escrita: 12/06/2023
        Última atualização: 20/06/2023
        
        static void Main(string[] args)
        {
            //lê as informacoes da linha,coluna e bomba que estao no arquivo
            string arquivo = "C:/Users/igorl/OneDrive/Documentos/GitHub/RepositorioC/CAMPO_MINADO/teste.txt";//endereço do arquivo


            int linhasMatriz, colunasMatriz, bombas;


            StreamReader lerArquivo = new StreamReader(arquivo);
            string[] valores = new string[3];


            string linha;
            int contadorLinha = 0;


            while ((linha = lerArquivo.ReadLine()) != null && contadorLinha < 3)//lê o texto do arquivo que nao for null e conta quantas linnhas o arquivo tem
            {
                // Encontra o índice do sinal de igual
                int indiceIgual = linha.IndexOf("=");
                // Lê ate o fim da linha e pega o penultimo alor dela
                if (indiceIgual != -1 && indiceIgual < linha.Length - 1)
                {
                    string valor = linha.Substring(indiceIgual + 1);
                    valores[contadorLinha] = valor;


                    contadorLinha++;
                }
            }



            // Exibe os valores salvos no array valores
            linhasMatriz = int.Parse(valores[0]);
            colunasMatriz = int.Parse(valores[1]);
            bombas = int.Parse(valores[2]);




            lerArquivo.Close();
            int[,] mat = new int[linhasMatriz, colunasMatriz];
            bool[,] matrevelada = new bool[mat.GetLength(0), mat.GetLength(1)];
            Random rd = new Random();
            bool jogoAcabou = false;

            if (bombas <= 0)
            {
                Console.WriteLine("Não há bombas no campo");
                jogoAcabou = true;
            }
            if (bombas >= mat.GetLength(0) * mat.GetLength(1))
            {
                Console.WriteLine("O número de bombas é maior ou igual ao número de células");
                jogoAcabou = true;
            }


            // Coloca as bombas em posições aleatórias
            for (int i = 0; i < bombas; i++)
            {
                int lin, col;
                do
                {
                    lin = rd.Next(0, mat.GetLength(0));
                    col = rd.Next(0, mat.GetLength(1));
                } while (mat[lin, col] == 1);

                mat[lin, col] = 1;



            }



            //Começo do JOGO
            while (!jogoAcabou)
            {
                Console.Clear();
                // Imprime o campo atual
                PrintCampo(mat, matrevelada);
                bool AcimaArrayMatriz; //Variável para impedir que o usuário digite valores acima do array da matriz
                int linhaJogada, colunaJogada;


                //Impedir que o usuário digite a linha e coluna com valores inválidos
                do
                {
                    AcimaArrayMatriz = false;
                    // Solicita as coordenadas do jogador
                    Console.Write("Digite a linha: ");
                    linhaJogada = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Digite a coluna: ");
                    colunaJogada = int.Parse(Console.ReadLine()) - 1;


                    if (linhaJogada < 0 || linhaJogada >= mat.GetLength(0) || colunaJogada < 0 || colunaJogada >= mat.GetLength(1))
                    {
                        AcimaArrayMatriz = true;
                    }
                } while (AcimaArrayMatriz);


                // Atualiza o valor da matriz
                int v = BombasAdjacentes(mat, linhaJogada, colunaJogada, matrevelada);


                // Atualiza a matriz revelada
                matrevelada[linhaJogada, colunaJogada] = true;


                // Verifica se o jogador encontrou uma bomba
                if (mat[linhaJogada, colunaJogada] == 1)
                {
                    Console.WriteLine("Você abriu uma célula com uma bomba! Fim de jogo!");
                    jogoAcabou = true;


                }


                // Verifica se todas as células sem bombas foram reveladas
                bool todasReveladas = true;


                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        if (mat[i, j] != 1 && !matrevelada[i, j])
                        {
                            todasReveladas = false;
                        }
                    }
                }
                //O jogo só termina depois que todas as linhas e colunas são reveladas
                if (todasReveladas)
                {
                    Console.WriteLine("Parabéns! Você venceu o jogo! ");
                    jogoAcabou = true;
                }


            }
        }


        //Verifica as bombas próximas a linha e coluna selecionada e conta quantas bombas tem
        static int BombasAdjacentes(int[,] mat, int lin, int col, bool[,] matrevelada)
        {
            int nbombas = 0;


            if (mat[lin, col] != 1)
            {
                //verifica se o indice está fora dos limites da matriz
                for (int i = lin - 1; i <= lin + 1; i++)
                {
                    if (i < 0 || i >= mat.GetLength(0))//se o i acessar alguma posição fora da matriz, ele pula para a próxima iteração
                    {
                        continue;
                    }
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (j < 0 || j >= mat.GetLength(1))//se o i acessar alguma posição fora da matriz, ele pula para a próxima iteração
                        {
                            continue;
                        }
                        nbombas += mat[i, j];


                        //Mostra todas as linhas e colunas que o nº bombas é 0
                        if (nbombas == 0)
                        {
                            if (!matrevelada[i, j])
                            {
                                matrevelada[i, j] = true;
                            }
                        }

                    }
                }
            }

            return nbombas;
        }


        // Imprime a Matriz e a quantidade de bombas adjacentes
        static void PrintCampo(int[,] mat, bool[,] matRevelada)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {//Linhas da matriz
                for (int j = 0; j < mat.GetLength(1); j++)
                {//Colunas da Matriz

                    if (matRevelada[i, j])//Se a matriz for revelada:
                    {
                        if (mat[i, j] == 1)//verifica se existe bomba na linha e coluna, se existir, insere o símbolo *, mas somente se a matriz estiver revelada 
                                           //para revelar a matriz como um todo adicionar "matrevelada[lin, col] = true;" abaixo da linha 85
                        {
                            Console.Write(" * |");
                        }
                        else
                        {
                            int nbombas = BombasAdjacentes(mat, i, j, matRevelada);
                            if (nbombas == 0)
                            {
                                Console.Write(" . |");
                            }
                            else
                            {
                                Console.Write(" " + nbombas + " |");
                            }




                        }
                    }
                    else
                    {
                        Console.Write(" X |");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
*/