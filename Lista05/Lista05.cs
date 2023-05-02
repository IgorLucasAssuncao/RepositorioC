/*using System;


namespace my_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              //   1. Faça um programa para mostrar na tela todas as tabuadas de multiplicar de 1 até 10.
         int x=1, i=1;
         for(;i<=10;i++){


            for(;x<=10;x++){
                    Console.WriteLine("Resultado "+ i + " vezes "+ x + ": "+(i*x));
           
            }
            x=1;
         }
*/
            /*
            //   2. Faça um programa que leia números do teclado, calcule e mostre o quadrado de cada número até entrar um número múltiplo de 6 que deverá ter seu quadrado também impresso.



                     double num=0, potencia;


                     do{
                        Console.WriteLine("Digite um numero");
                        num = double.Parse(Console.ReadLine()??"0");
            potencia= Math.Pow(num, 2);
              Console.WriteLine("Quadrado do número: "+ potencia);


                     }while(num % 6 != 0);
            */
            /*  //   3. Faça um programa que receba a quantidade de pessoas que assistiram a uma partida de futebol e mostre as
            //mensagens de acordo com a tabela:
            //menos que 1.000 – “público baixo”
            //entre 1.001 e 10.000 – “público médio”
            //acima de 10.000 – “público bom”




                    int numero_pessoas=0;


            while(true){
                    Console.WriteLine("Digite o número de pessoas");
                    numero_pessoas=int.Parse(Console.ReadLine()??"0");


                    if(numero_pessoas < 1000){
                         Console.WriteLine("público baixo");
                    }else if(numero_pessoas>1001 && numero_pessoas<10000){
                        Console.WriteLine("público médio");
                    }else if( numero_pessoas>10000){
                        Console.WriteLine("público bom");
                    }


            }
            */
            /*
                   //   4. Faça um programa que leia dois valores, um representando o saldo de uma pessoa e o outro representando o valor que será depositado ou retirado da conta de acordo com a seguinte regra: se o valor do saldo for maior que o segundo
                        //valor digitado, seu programa faz a retirada do menor valor do saldo. Caso contrário, seu programa irá depositar este valor na conta, aumentando-o ao saldo. Mostre o saldo final.







                        double saldo=0, conta;


                        Console.WriteLine(" Digite seu saldo");
                        saldo = double.Parse(Console.ReadLine()??"0");


                        Console.WriteLine("Insira o valor que deseja depositar: ");
                        conta = double.Parse(Console.ReadLine()??"0");
                        if( saldo>conta){
                            saldo-=conta;
                        }else{
                            saldo+=conta;
                        }
                    Console.WriteLine("seu saldo: "+ saldo);




            */
            /*
            //  5. Escreva um programa que leia o peso de um indivíduo. Considere que serão lidos os pesos de 30 pessoas. Calcule e
                        //*mostre:
                        //- A média aritmética dos pesos das pessoas que possuem mais de 60 Kg
                        //- O valor do peso da pessoa mais pesada


                    double peso_pessoas=0,soma_peso=0, pessoa_pesada=double.MinValue;
                    for(int i=0; i<5;i++){
                        Console.WriteLine("Insira o peso da pessoa");
                        peso_pessoas=double.Parse(Console.ReadLine()??"0");
                        if(peso_pessoas>60){
                        soma_peso += peso_pessoas;
                        }
                        if(pessoa_pesada<peso_pessoas){
                            pessoa_pesada=peso_pessoas;
                        }


                    }
                     Console.WriteLine("Média aritmética: "+ (soma_peso/5));
                     Console.WriteLine("Pessoa mais pesada: "+ (pessoa_pesada));
            */
            /*
                  //  6. Criar um programa para identificar o valor a ser pago por um plano de saúde dada a idade do conveniado
            //considerando que todos pagam R$ 100 mais um adicional conforme a seguinte tabela:
            //crianças com menos de 10 anos pagam R$180
            //conveniados com idade entre 10 e 30 anos pagam R$150
            //conveniados com idade entre 40 e 60 anos pagam R$195
            //conveniados com mais de 60 anos pagam R$230


                  int idade=0, valor=100;






                  Console.WriteLine("Insira a idade:");
                  idade=int.Parse(Console.ReadLine()??"0");


                if(idade<10){
            valor+=180;
                }else if(idade>10 && idade<30){
            valor+=150;
                }else if(idade>40 && idade<60){
            valor+=195;
                }else{
            valor+=230;
                }
                Console.WriteLine("Valor: "+valor);


            */
            /*
            //  7. Escrever um programa que leia um número n que indica quantos valores devem ser lidos a seguir. Para cada número lido, mostre uma tabela contendo o valor lido e o fatorial deste valor.


            int cont_numeros = 0,fatorial,num;

            Console.WriteLine("Quantos numeros devo ler?");

            cont_numeros = int.Parse(Console.ReadLine() ?? "0");
            for (int i = 0; i < cont_numeros; i++)
            {
                Console.WriteLine("Insira um numero:");
                num = int.Parse(Console.ReadLine()?? "0");
                fatorial = num;

                for (int x = num - 1; x > 1; x--)
                {
                    fatorial = fatorial * x;
                   



                }

                 Console.WriteLine($"{num}! = {fatorial}");




            }
            *//*
            //8. Faça um programa que realize e mostre o produto entre 2 números inteiros A e B, através de somas sucessivas. Os
//números deverão ser lidos do teclado
    
                int a=0,b=0,resultado=0;
    
                Console.WriteLine("Insira o primeiro numero");
                a=int.Parse(Console.ReadLine()?? "0");
                Console.WriteLine("Insira o segundo numero");
                b=int.Parse(Console.ReadLine()?? "0");
    
                for(int i=0; i<b;i++){
                    resultado+=a;
                }
                Console.WriteLine("Resultado: "+resultado);

*//*
            //9. Faça um programa que calcule e mostre o resultado para o seguinte somatório:
            double denominador = 15, numerador = 0, resultado = 0;
            for (int i = 1; i <= 16384; i *= 2, denominador--)
            {
                numerador = i;
                resultado += numerador / Math.Pow(denominador,2);
            }
            Console.WriteLine("Resultado: " + resultado);
*//*
//10. Escreva um programa que calcule e mostre o valor da série:
double denominador=1, numerador=4,resultado=0;
int num=0;
Console.WriteLine("Quantas vezes devo calcular?");
num = int.Parse(Console.ReadLine() ?? "0");

        for(int i=1; i<=num; i++, denominador+=2){

            if(i%2==0){
                resultado -= (numerador / denominador); 
            }else{
            resultado += (numerador / denominador);
            }


        }
        Console.WriteLine("Resultado: "+resultado.ToString("N3"));
        *//*
  //  12. Crie um programa que leia uma sequência de números terminada por 0(zero) e imprima o número que for múltiplo
//de sua posição na sequência.
//Exemplo:
//valores lidos: 3 7 8 16 0
//posição: 1 2 3 4
//impressão que deve ser apresentada: 3 16
//Interpretação do exemplo:
//3 é múltiplo de 1,
//7 não é múltiplo de 2 (Logo não será impresso)
//8 não é múltiplo de 3 (Logo não será impresso)
//16 é múltiplo 4

int num=1;
List<int> lista = new List<int>();

// adicionar elementos à lista
Console.WriteLine("Insira os números");

for (; num !=0;) {
    num = int.Parse(Console.ReadLine() ?? "0");
    if(num != 0){
    lista.Add(num);
    }
}
int[] valor = lista.ToArray();

for (int i = 1, x=0; x <valor.Length; i++, x++){
    if(valor[x] % i == 0){
        Console.WriteLine(valor[x]);
    }
}
*///14. Repare a seguinte característica do número 3025: 30 + 25 = 55 e 552 = 3025
//Crie um programa que possa ler vários números (um de cada vez) inteiros de 4 algarismos, e diga se o número
//apresenta a mesma característica (repare que 3025/100 = 30 com resto 25). O algoritmo termina quando for lido um
//valor menor que 1000 ou maior que 9999. Utilize apenas operações aritméticas básicas na solução desta questão.
/*
int num=1001, num1, num2, num3, num4;

for (; num >= 1000 && num <= 9999;){
    Console.WriteLine("Insira um numero de 4 algarismos");
    num = int.Parse(Console.ReadLine() ?? "0");
    if(num >= 1000 && num <= 9999){
         num1 = num / 100;
         num2 = num % 100;
         num3 = num1 + num2;
         num4 = num3 * num3;
        if(num4 == num){
            Console.WriteLine("O numero apresenta a mesma caracteristica");
        }else{
            Console.WriteLine("O numero não apresenta a mesma caracteristica");
        }
    }
}
        }
    }
}



        
*/
