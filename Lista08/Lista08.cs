using System;

namespace lista08
{
    class lista08
    {
        public static void Main(string[] args)
        {
            /*
            //Declare uma matriz 5 x 5. Preencha com 1 a diagonal principal e com 0 os demais elementos. Escreva
            //ao final a matriz obtida
            int[,] mat=new int[5,5];
            Random rd=new Random();

            for(int i=0; i< mat.GetLength(0); i++){
                for(int x=0; x<mat.GetLength(1); x++){
                    if(i==x){
                        mat[i,x]=1;
                    }else{
                        mat[i,x]=0;
                    }
                }
            }

            for(int i=0; i< mat.GetLength(0); i++){
                for(int x=0; x<mat.GetLength(1); x++){
                    Console.Write($"{mat[i,x]} ");
                }
                Console.WriteLine();
            }

            *//*
            //Faça um programa que preenche uma matriz 4 x 4 com o produto do valor da linha e da coluna de
            //cada elemento. Em seguida, imprima na tela a matriz.

            int[,] mat=new int[4,4];

            for(int i=0; i< mat.GetLength(0); i++){
                for(int x=0; x<mat.GetLength(1); x++){
                    mat[i,x]=(i+1)*(1+x);
                }
            }
            for(int i=0; i< mat.GetLength(0); i++){
                for(int x=0; x<mat.GetLength(1); x++){
                    Console.Write($"{mat[i,x]} ");
                }
                Console.WriteLine();
            }
            *//*
            //3) Leia uma matriz 4 x 4, imprima a matriz e retorne a localização (linha e a coluna) do maior valor.
            int maior=int.MinValue;
            int[,] mat=new int[4,4];
            int linha=0, coluna=0;
            for(int i=0; i< mat.GetLength(0); i++){
                for(int x=0; x<mat.GetLength(1); x++){
                    Console.WriteLine("Digite um número");
                    mat[i,x]= int.Parse(Console.ReadLine()??"0");
                    if(mat[i,x]>maior){
                        maior=mat[i,x];
                        linha=i;
                        coluna=x;
                    }
                }
            }
            for(int i=0; i< mat.GetLength(0); i++){
                for(int x=0; x<mat.GetLength(1); x++){
                    Console.Write($"{mat[i,x]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Maior valor: {maior} na linha {linha} e coluna {coluna}");
            *//*
            //4) Leia uma matriz 5 x 5. Leia tambem um valor X. O programa deverá fazer uma busca desse valor na
            //matriz e, ao final, escrever a localização (linha e coluna) ou uma mensagem de “não encontrado”.
            int[,] mat = new int[5, 5];
            int valor = 0;
            bool encontrado = false;
            int linha = 0, coluna = 0;
            Random rd = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)// Adiciona valor
            {
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    mat[i, x] = rd.Next(0, 10);
                }
            }
            for (int i = 0; i < mat.GetLength(0); i++)//Printa valor
            {
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                   Console.Write(" "+mat[i,x]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Digite um valor");// Valor de X
            valor = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < mat.GetLength(0); i++)// Procura por X
            {
    
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    if (mat[i, x] == valor)
                    {
                        encontrado = true;
                        linha = i;
                        coluna = x;
                    }
                }
            }
             if (encontrado)
                    {
                        Console.WriteLine($"Linha {linha} e coluna {coluna}");
                    }
                    else
                    {
                        Console.WriteLine("Ainda não encontrado");
                    }
*//*
//5) Gerar e imprimir uma matriz de tamanho 10 x 10, onde seus elementos são da forma:
int[,] mat= new int[10,10];
int potencial=0;

for(int i=0; i< mat.GetLength(0); i++){
    for(int x=0; x<mat.GetLength(1); x++){
  if(i<x){
mat[i,x]=2*i+7*x-2;
  }else if(i>x){
potencial= Convert.ToInt32(Math.Pow(i,3));
mat[i,x]=(3*potencial)-(5*(x*x)+1);
  }else if(i==x){
mat[i,x]=3*(i*i)-1;
  }
    }
}
for (int i = 0; i < mat.GetLength(0); i++)//Printa valor
            {
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                   Console.Write(" "+mat[i,x]);
                }
                Console.WriteLine();
            }
*//*
//6) Gere matriz 4 x 4 com valores no intervalo [1, 20]. Escreva um programa que transforme a matriz
//gerada numa matriz triangular inferior, ou seja, atribuindo zero a todos os elementos acima da
//diagonal principal. Imprima a matriz original e a matriz transformada.
int[,] mat= new int[4,4];
Random rd=new Random();
 for (int i = 0; i < mat.GetLength(0); i++)// Adiciona valor
            {
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    mat[i, x] = rd.Next(1, 20);
                }
            }

 for (int i = 0; i < mat.GetLength(0); i++)// Adiciona valor
            {
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    if(i==x){
                        for(int c=x+1; c<mat.GetLength(1); c++){
                            mat[i,c]=0;
                        }
                    }
                }
            }
            for (int i = 0; i < mat.GetLength(0); i++)// Adiciona valor
            {
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    Console.Write(" "+mat[i,x]);
                }
                Console.WriteLine();
            }
*/

            //7) Faça programa que leia uma matriz 3 x 6 com valores reais.
            //(a) Imprima a soma de todos os elementos das colunas ímpares.
            //(b) Imprima a média aritmética dos elementos da segunda e quarta colunas.
            //(c) Substitua os valores da sexta coluna pela soma dos valores das colunas 1 e 2.
            //(d) Imprima a matriz modificada.

            int[,] mat = new int[3, 6];
            Random rd = new Random();
            int soma_coluna_impar = 0, media = 0, soma_coluna_1_2 = 0, cont = 0, qual_coluna_impar = 0;

            for (int i = 0; i < mat.GetLength(0); i++)// Adiciona valor
            {
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    mat[i, x] = rd.Next(0, 11);
                }
            }
            for (int i = 0; i < mat.GetLength(0); i++)// printa matriz
            {
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    Console.Write(" " + mat[i, x]);
                }
                Console.WriteLine();
            }

            for (int x = 0; x < mat.GetLength(1); x++)//soma colunas impares
            {
                if (x % 2 == 1)
                {
                    qual_coluna_impar = x;
                    for (int c = 0; c < mat.GetLength(0); c++)
                    {
                        soma_coluna_impar += mat[c, x];
                    }
                    Console.WriteLine($"Coluna {qual_coluna_impar} soma {soma_coluna_impar}");
                }
                soma_coluna_impar = 0;
            }



            //calcula média aritmetica da segunda coluna e da quarta coluna
            for (int x = 0; x < mat.GetLength(1); x++)
            {
                if (x == 1 || x == 3)
                {
                    for (int c = 0; c < mat.GetLength(0); c++)
                    {
                        media += mat[c, x];
                        cont++;
                    }
                }

            }
            Console.WriteLine($"Média aritmetica da segunda e quarta coluna {media / cont}");

            for (int i = 0; i < mat.GetLength(0); i++)
            {//soma_coluna_1_2 para a coluna 6
                soma_coluna_1_2 = 0;
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    if (x == 1)
                    {
                        soma_coluna_1_2 += mat[i, x];
                    }
                    else if (x == 2)
                    {
                        soma_coluna_1_2 += mat[i, x];
                    }
                    else if (x == 5)
                    {
                        mat[i, x] = soma_coluna_1_2;
                    }
                }
            }
            for (int i = 0; i < mat.GetLength(0); i++)
            {//soma_coluna_1_2 para a coluna 6
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    Console.Write(" " + mat[i, x]);
                }
                Console.WriteLine();
            }

        }
    }
}




