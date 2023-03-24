/*
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
  //  1. Escreva um programa onde serão fornecidos como entrada de dados dois valores inteiros,
   //  calcule e imprima a soma, o produto, a diferença, o quociente destes números.


   int a, b;
   Console.WriteLine(@"Escolha dois números:");
   a = int.Parse(Console.ReadLine());
   b = int.Parse(Console.ReadLine());
    Console.WriteLine(@"Soma: "+ (a+b));
     Console.WriteLine(@"produto: "+ (a*b));
      Console.WriteLine(@"subtração: "+(a-b));
       Console.WriteLine(@"quociente: "+(a/b));




}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
  //  2. Escreva um programa que leia uma temperatura em graus Farenheit e a imprima em graus Centígrados.
  //A conversão de graus Farenheit para Centígrados é obtida por C=(5/9)(F-32).


   double F, C=0, g=1.8;
   Console.WriteLine(@"Insira a temperatura em Farenheit:");
   F= float.Parse(Console.ReadLine());
   C=((F-32)*g);
    Console.WriteLine(@"Graus centígrados: "+ C.ToString("N1"));




}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
  //  3. Escreva um programa que pergunte os seguintes dados referentes ao pneu de um
//automóvel: P = pressão V = volume T = temperatura e calcule a massa de
// ar desse pneu segundo a fórmula (M = massa de ar):
//PV = 0.37M(T+460)


   double P, V, T, M;
   //Multiplicação P*V
   double multi;
   //Soma T+460
   double soma;
   Console.WriteLine(@"Insira a pressão, volume e temperatura:(respectivamente)");
   P= float.Parse(Console.ReadLine());
     V= float.Parse(Console.ReadLine());
       T= float.Parse(Console.ReadLine());
  multi=P*V;
  soma= T + 460;
  M= ((multi/soma)/0.37);




    Console.WriteLine(@"Massa de ar: "+ M.ToString("N1"));




}
}
}


using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
  //  4. Escreva um programa que pergunte qual o tempo transcorrido em um cronômetro em
//horas, minutos e segundos e transforme (e mostre) todo este tempo em segundos.






   int hr, min, seg;   Console.WriteLine(@"Insira as horas, minutos e segundos presentes no cronômetro:(respectivamente)");
   hr= int.Parse(Console.ReadLine());
     min= int.Parse(Console.ReadLine());
       seg= int.Parse(Console.ReadLine());
  seg=seg+(min*60)+(hr*3600);




    Console.WriteLine(@"segundos totais: "+ seg);




}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
  //5. Criar um algoritmo que obtenha 4 números reais e exiba a sua média ponderada,
  //sabendo- se que os pesos são 2, 1, 3 e 4, nesta ordem.






   float[] numeros= new float[4];
   double média;
   
 Console.WriteLine("Insira 4 números, executaremos uma média ponderada, os números selecionados terão peso 2, 1, 3, 4, respectivamente.");
   for(int i=0;i<4;i++){
   numeros[i]= float.Parse(Console.ReadLine());
   }


média =((numeros[0]*2)+numeros[1]+(numeros[2]*3)+(numeros[3]*4))/10;
Console.WriteLine("A média poderada é: "+média.ToString("N1"));
}
}
}


using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
 //6. Para vários tributos a base de cálculo é o salário mínimo. Fazer um algoritmo que leia o o
//valor do salário de uma pessoa. Calcular e exibir quantos salários mínimos essa pessoa
//ganha. Considere que o valor do salário mínimo é: R$1.212,00.


 float salário_min=1212.00F, sala, quant_sala;
   
 Console.WriteLine("Insira quanto você ganha:");
   
   sala= float.Parse(Console.ReadLine());
   quant_sala=sala/salário_min;


Console.WriteLine("você ganha "+quant_sala.ToString("N1")+" salários mínimos.");
}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
 //7. Todo restaurante cobra 10% sobre o valor do consumo do cliente para o garçom, embora
//por lei não possa obrigar o cliente a pagar. Fazer um algoritmo que leia o valor gasto com
//as despesas realizadas em um restaurante e imprima o valor da gorjeta e o valor total a
//ser pago (despesa mais gorjeta).




 float conta, gorjeta;
   
 Console.WriteLine("Quanto foi gasto nesse restaurante?(despesas, somente alimentação)");
   
   conta= float.Parse(Console.ReadLine());
   gorjeta= (conta*10)/100;




Console.WriteLine(@"valor gorjeta: "+ gorjeta.ToString("N1"));
Console.WriteLine("Valor total da conta: "+ (gorjeta+conta).ToString("N1"));
}
}
}


using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
 //8. Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os cavalos comprados para um haras.


 int CAVALO;
 Console.WriteLine("Qual a quantidade total de CAVALOS presente no haras?");
   
   CAVALO= int.Parse(Console.ReadLine());
 
Console.WriteLine("Numero total de ferraduras: "+ (CAVALO*4));
}
}
}



*/