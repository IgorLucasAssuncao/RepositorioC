/*using System;

namespace lista07
{
class lista07
{
    public static void Main(string[] args)
    {
    /*
            //. Faça um programa que leia os elementos de uma matriz 3 x 5 com números inteiros (isto é, 3 linhas e 5 colunas),
            //calcule e imprima a quantidade de elementos maiores que 40.
            int[,] mat=new int[3,5];
            int quantidade_maior_40=0;

            for(int i=0; i< mat.GetLength(0); i++){
                for(int x=0; x<mat.GetLength(1); x++){
                    Console.WriteLine("Digite um número");
                    mat[i,x]=int.Parse(Console.ReadLine()??"0");
                    if(mat[i,x]>40){
                        quantidade_maior_40++;
                    }
                }
            }
        Console.WriteLine($"Quantidade de números maiores que 40: {quantidade_maior_40}");
        */
        /*
        //2. Faça um programa que:
//a) leia uma matriz quadrada de 10 x 10 elementos inteiros
//b) imprima essa matriz
//c) calcule e imprima a soma dos elementos situados na diagonal secundária e abaixo dela.

int[,] mat=new int[3,3];
int soma=0;
int inicio=0;

for(int i=0; i< mat.GetLength(0); i++){
    for(int x=0; x<mat.GetLength(1); x++){
        Console.WriteLine("Digite um número");
        mat[i,x]=int.Parse(Console.ReadLine()??"0");
    }
}

for(int i=0; i< mat.GetLength(0); i++){
    
    for(int x=0; x<mat.GetLength(1); x++){
        Console.Write($"{mat[i,x]} ");
    }
    Console.WriteLine();
    }

    for(int i=mat.GetLength(0)-1; i>=0; i--){
        for(int j=inicio; j<mat.GetLength(1); j++){
            soma+=mat[i,j];
        }
        inicio ++;

   }
    Console.WriteLine($"Soma dos elementos abaixo da diagonal secundária: {soma}");
    




*/
//3. Faça um programa que:
//a) leia uma matriz quadrada de 20 x 20 elementos reais
//b) divida cada elemento de uma linha da matriz pelo elemento da diagonal principal desta linha
//c) imprima a matriz assim modificada
//Obs:
/*
int[,] matriz=new int[3,3];
Random rd= new Random();
int valor_vetor=0;
for(int x=0; x<matriz.GetLength(0); x++){
    for(int y=0; y<matriz.GetLength(1); y++){
        matriz[x,y]=rd.Next(1,10);
        Console.Write($"{matriz[x,y]} ");
    }
    Console.WriteLine();
   }
    
for(int x=0; x<matriz.GetLength(0); x++){
    for(int y=0; y<matriz.GetLength(1); y++){

        if(x==y){
        valor_vetor=matriz[x,y];
        for(int j=0; j<matriz.GetLength(1); j++){
            if(j!=y){
            matriz[x,j]=matriz[x,j]/valor_vetor;
            }

              }

        }
    }

   }
for(int x=0; x<matriz.GetLength(0); x++){
    for(int y=0; y<matriz.GetLength(1); y++){
        Console.Write($"{matriz[x,y]} ");

    }
    Console.WriteLine();
    }
    */
    
  //  Elabore um programa que leia uma matriz 4 x 4 e indique se é uma matriz triangular superior. Matriz triangular
//superior é uma matriz quadrada onde todos os elementos abaixo da diagonal principal são nulos (valor zero). Veja
//exemplo abaixo:
/*
    int[,] mat=new int[10,10];
    Random rd= new Random();
    bool triangular_superior=true;

for(int i=0; i< mat.GetLength(0); i++){//ADICIONA VALORES A MATRIZ
    for(int x=0; x<mat.GetLength(1); x++){
        mat[i,x]=rd.Next(0, 10);
    }
}
for(int x=0; x<mat.GetLength(0); x++){//PRINTA MATRIZ
    for(int y=0; y<mat.GetLength(1); y++){
        Console.Write($"{mat[x,y]} ");
    }
    Console.WriteLine();
}



for(int x=0; x<mat.GetLength(0); x++){//FAZ A CONTA
    for(int y=0; y<mat.GetLength(1); y++){
        if(x==y){
    for(int i=0; i<y;i++){
        if(mat[x,i]!=0){
            triangular_superior=false;
        }
    }
        
    }
}

}
if(triangular_superior){
    Console.WriteLine("É triangular superior");
}else{
    Console.WriteLine("Não é triangular superior");
}
*//*
//Faça um programa que leia os elementos de uma matriz 5 x 5 e crie dois vetores de cinco posições cada um, que
//contenham, respectivamente, as somas das linhas e as somas das colunas da matriz. Escreva a matriz e os vetores
//criados.
int[,] mat=new int[5,5];
int[] vetor_linha=new int[mat.GetLength(0)];
int[] vetor_coluna=new int[mat.GetLength(1)];
Random rd= new Random();
int soma=0;
for(int i=0; i< mat.GetLength(0); i++){//ADICIONA VALORES A MATRIZ
    for(int x=0; x<mat.GetLength(1); x++){
        mat[i,x]=rd.Next(0, 10);
    }
}
for(int x=0; x<mat.GetLength(0); x++){//PRINTA MATRIZ
    for(int y=0; y<mat.GetLength(1); y++){
        Console.Write($"{mat[x,y]} ");
    }
    Console.WriteLine();
}
for(int x=0; x<mat.GetLength(0); x++){//FAZ A CONTA-
soma=0;
    for(int y=0; y<mat.GetLength(1); y++){
        soma+=mat[x,y];
    }
    vetor_linha[x]=soma;
}
for(int x=0; x<mat.GetLength(0); x++){//FAZ A CONTA-
soma=0;
    for(int y=0; y<mat.GetLength(1); y++){
        soma+=mat[y,x];
    }
    vetor_coluna[x]=soma;
}
for(int x=0; x<vetor_linha.Length; x++){
    Console.WriteLine(vetor_linha[x]);
}
for(int x=0; x<vetor_coluna.Length; x++){
    Console.WriteLine(vetor_coluna[x]);
}
*//*
//Escreva um programa que preencha uma matriz 5 x 5 com números aleatórios de 1 a 50. Depois mostre a matriz
//gerada, encontre e mostre todos os números primos e a posição onde cada um deles se encontra no formato:
//O número X é primo e se encontra no índice: [linha – coluna].
//Obs: Um número primo é aquele que é divisível apenas por um e por ele mesmo

int[,] mat=new int[5,5];
Random rd= new Random();

for(int i=0; i< mat.GetLength(0); i++){//ADICIONA VALORES A MATRIZ
    for(int x=0; x<mat.GetLength(1); x++){
        mat[i,x]=rd.Next(1, 50);
    }
}
for(int x=0; x<mat.GetLength(0); x++){//PRINTA MATRIZ
    for(int y=0; y<mat.GetLength(1); y++){
        Console.Write($"{mat[x,y]} ");
    }
    Console.WriteLine();
    }


for(int x=0; x<mat.GetLength(0); x++){//PRINTA MATRIZ
    for(int y=0; y<mat.GetLength(1); y++){

        if(mat[x,y]==2){
            Console.WriteLine($"O número {mat[x,y]} é primo e se encontra no índice: [{x} - {y}]");
        }else{
        if(mat[x,y]%2!=0){
            bool primo=true;
            for(int i=3; i<mat[x,y]; i++){
                if(mat[x,y]%i==0){
                    primo=false;
             
                }
            }
            if(primo){
                Console.WriteLine($"O número {mat[x,y]} é primo e se encontra no índice: [{x} - {y}]");
    }
    }
    }}}

//Escrever um programa que determine se uma matriz quadrada de n > 0 linhas e colunas é uma matriz de
//permutação. Uma matriz quadrada é chamada de matriz de permutação se seus elementos são apenas 0’s e 1’s e
//se em cada linha e coluna da matriz existe apenas um único valor 1. Para testar o exercício, considere a matriz
//4x4 do exemplo.
//Exemplo:

int[,] mat=new int[4,4];
Random rd= new Random();
bool permutacao=true;
int validacao=0;

for(int i=0; i< mat.GetLength(0); i++){//ADICIONA VALORES A MATRIZ
    for(int x=0; x<mat.GetLength(1); x++){
        mat[i,x]=rd.Next(0,2);
    }
}
for(int x=0; x<mat.GetLength(0); x++){//PRINTA MATRIZ
    for(int y=0; y<mat.GetLength(1); y++){
        Console.Write($"{mat[x,y]} ");
    }
    Console.WriteLine();
    }
for(int x=0; x<mat.GetLength(0); x++){//PRINTA MATRIZ
    validacao=0;
    for(int y=0; y<mat.GetLength(1); y++){
    if(mat[x,y]>=1){
        validacao++;
    }
    }
    if(validacao>1){
        permutacao=false;
    }
    }
    for(int x=0; x<mat.GetLength(0); x++){//PRINTA MATRIZ
    validacao=0;
    for(int y=0; y<mat.GetLength(1); y++){
    if(mat[y,x]>=1){
        validacao++;
    }
    }
    if(validacao>1){
        permutacao=false;
    }
    }

    if(permutacao){
        Console.WriteLine("É permutação");
    }else{
        Console.WriteLine("Não é permutação");
    }


    }
}
}

*/