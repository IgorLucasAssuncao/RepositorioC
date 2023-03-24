
using System;


namespace my_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           int num1=0, num2=0, num3=0, aux=0;


            Console.WriteLine("Insira 3 números diferentes:");
            num1= int.Parse(Console.ReadLine()??"0");
             num2= int.Parse(Console.ReadLine()??"0");
              num3= int.Parse(Console.ReadLine()??"0");
              //Meu desejo é que o num1 assuma o menor valor possível
              //Dessa forma essas duas condições me garantem que o num1 terá o menor valor possível dos 3 números
             
              if(num1>num3){
                aux=num3; //salvo na variável auxiliar o valor do num3
                num3=num1; // faço a troca de valor entre num3 e num1
                num1=aux; // agora num1 terá o antigo valor de num3(consequentemente menor que ele)
              }
                else if(num1>num2){
                  aux=num2;//salvo na variável auxiliar o valor do num2
                  num2=num1;// faço a troca de valor entre num2 e num1
                  num1=aux; // agora num1 terá o antigo valor de num2(consequentemente menor que ele), e menor que num2 tbm
                }
                    else if(num2>num3){// agora é só garantir que o num3será o maior número
                    aux=num3;
                    num3=num2;
                    num2=aux;
                    }
                    Console.WriteLine("Os números ordenados em ordem decrescente: "+ num3 +" "+num2+" "+num1);
                */

            /*
            float soma=0, nums=0;



       Console.WriteLine("Faça a entrada com 10 números:");
      for(int i=0; i<10; i++){

      nums= float.Parse(Console.ReadLine());
      soma += nums;


      }


      Console.WriteLine("O resultado da soma dos 10 números é: "+ soma);



*/
            /*
              //3. Escreva um programa para ler a idade de 40 pessoas, exibir a idade da pessoa mais nova, calcular a idade média e calcular a porcentagem de pessoas com idade entre 24 e 30 anos.




                    int idades=0, soma=0, idade_nova=1000000, porcent_per=0;





                       Console.WriteLine("Faça a entrada com a idade de 40 pessoas:");
                      for(int i=0; i<40; i++){

                      idades= int.Parse(Console.ReadLine()??"0");
                      if(idade_nova>idades){
                        idade_nova=idades;
                      }
                      soma += idades;




                      if(idades>24 && idades<30)
                      porcent_per++;
                      }




                      Console.WriteLine("A pessoa mais nova tem a seguinte idade: "+ idade_nova);
                      Console.WriteLine("A idade média dessas pessoas é:  "+ (soma/40));
                      Console.WriteLine("A porcentagem de pessoas com idade entre 24 e 30 anos é: "+ ((porcent_per*100)/40) +"%");
            */
            /*
            //4. Deseja-se fazer uma pesquisa a respeito do consumo mensal de energia elétrica em uma determinada cidade. Para isso, são fornecidos os seguintes dados por consumidor:
//• preço do kWh;
//• quantidade de kWh consumidos durante o mês;
//O número de consumidores que participarão da pesquisa é igual a 80. Faça um programa que leia os dados descritos
//acima, calcule e imprima:
//a) para cada consumidor, o total a pagar,
//b) o maior consumo verificado,
//c) o menor consumo verificado,
//d) a média geral de consumo.


    float preco=0, KWHmes=0, soma=0, maior_consumo=0, menor_consumo=0;


    for(int i=0; i<80; i++){
        Console.WriteLine("Insira o preço do Kwh e o quanto você consumiu esse mês:");
        preco= float.Parse(Console.ReadLine()??"0");
        KWHmes= float.Parse(Console.ReadLine()??"0");
        soma+=KWHmes;
        if(i==1){
            menor_consumo= KWHmes;
        }
        if(maior_consumo<KWHmes){
            maior_consumo=KWHmes;
        }
        if(menor_consumo>KWHmes){
            menor_consumo=KWHmes;
        }
        Console.WriteLine(@"Seu total a pagar: "+(preco*KWHmes));
    }
         Console.WriteLine("Menor consumo: "+(menor_consumo));
         Console.WriteLine("Maior consumo: "+(maior_consumo));
          Console.WriteLine("Média de preços: "+(soma/80));
               


*/
            /* 
            //5. Desenvolver um programa que efetue a soma de todos os números ímpares que são múltiplos de três e que se encontram no conjunto dos números de 500 até 2100.


            int i=500, soma=0;
            for(;i<2100;i++){
                if(i%2==1){
                    if(i%3==0){
                        soma+=i;
                    }

                }
            }
              Console.WriteLine(""+soma);

            */
            /*
            //6. Escrever um programa que leia 60 números e conte quantos deles estão nos seguintes intervalos: [0-25], [26-50], [51-75] e [76-100].




            float numeros;
            int cont=0;
            Console.WriteLine("Insira 80 números:");


            for(int i=0;i<80;i++){
            numeros= int.Parse(Console.ReadLine()??"0");
            if((numeros>0 && numeros<25) || (numeros>26 && numeros<50) || ( numeros>51 && numeros<75) || ( numeros>76 && numeros<100)){
                cont++;
            }


            }
            Console.WriteLine("Quantidade de números entre os citados: "+ cont);

            */
            /* 
            float soma=0F;
            float nums=1f;


            for(int i=1;i<=10;i++, nums++){
            soma+=(nums/(nums*nums));


            }
            Console.WriteLine("Resultado: "+soma.ToString("N3"));
            */
            /* 


                            //8. A secretaria de saúde de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre a idade e a
            //quantidade de filhos de cada habitante. A secretaria deseja saber:
            //a) média da idade da população;
            //b) média do número de filhos;
            //c) maior idade;
            //d) percentual de pessoas acima de 60 anos.
            //O final da leitura de dados se dará com a entrada de uma idade negativa.


                    int idade=0, soma_idade=0, quant_filhos=0, soma_filhos=0, cont_filhos=0, cont_idade=0, maior_idade=0, percent_idade=0;
                    do{
                        Console.WriteLine("Insira uma idade, se a idade for menor do que 0 o programa finalizará: ");


                        idade= int.Parse(Console.ReadLine()??"0");
                        if(idade>0){
                        soma_idade+=idade;
                        cont_idade++;
                        if(cont_idade==1){
                            maior_idade=idade;
                        }
                        if(maior_idade<idade){
                            maior_idade=idade;
                        }
                        if(idade>60){
                            percent_idade++;
                        }

                        Console.WriteLine("Insira quantos filhos a pessoa tem: ");
                        quant_filhos= int.Parse(Console.ReadLine()??"0");
                        soma_filhos+=quant_filhos;
                        cont_filhos++;
            }


                    } while(idade>0);
                    Console.WriteLine("Essa é a média de idade: "+ (soma_idade/cont_idade));
                    Console.WriteLine("Média do número de filhos: "+ (soma_filhos/cont_idade));
                    Console.WriteLine("Essa é a maior idade: "+ maior_idade);
                    Console.WriteLine("Essa é a média de pessoas com idade acima de 60 anos: "+ (percent_idade*100)/cont_idade);    

            */
/*
            //9. Faça um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O programa será encerrado quando as duas coordenadas digitadas forem 0 (nesta situação, sair sem escrever mensagem alguma).
            //Para os dados de entrada abaixo deve ser gerada a seguinte saída:
            //2 2: primeiro quadrante
            //3 -2: quarto quadrante
            //4 7: primeiro quadrante
            //-8 -1: terceiro quadrante
            //-7 1: segundo quadrante

            int x = 0, y = 0;
            do
            {
                Console.WriteLine("Escreva as cordenadas de X e Y");
                x = int.Parse(Console.ReadLine() ?? "0");
                y = int.Parse(Console.ReadLine() ?? "0");
                if (x == 2 && y == 2)
                {
                    Console.WriteLine("primeiro quadrante");
                }
                else if (x == 3 && y == -2)
                {
                    Console.WriteLine("quarto quadrante");
                }
                else if (x == 4 && y == 7)
                {
                    Console.WriteLine("primeiro quadrante");
                }
                else if (x == -8 && y == -1)
                {
                    Console.WriteLine("terceiro quadrante");
                }
                else if (x == -7 && y == 1)
                {
                    Console.WriteLine("segundo quadrante");
                }
                else
                {
                    Console.WriteLine("Entrada sem resposta válida");
                }


            } while (x != 0 && y != 0);
*/
        }
    }
}




