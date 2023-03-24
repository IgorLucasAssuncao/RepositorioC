/*
using System;
namespace Name
{
class Primeira{
public static void Main(string[] args){
    /*
    
    int x=0; 
    Console.WriteLine("insira um numero!");
    x= int.Parse(Console.ReadLine());
    
    if(x<3){
        Console.WriteLine("Seu número é menor que 3");
    }else if(x>25){
        Console.WriteLine("Seu número é maior que 25");
    }else
        Console.WriteLine(" Seu número está entre 3 e 25");
    
*//*
// 2) Faça um programa que leia 2 números e imprima o quadrado do menor número e a raiz quadrada do maior número.

    double x=0,y=0;

    
    Console.WriteLine(@"insira dois números");
    
    x = double.Parse(Console.ReadLine());
    y = double.Parse(Console.ReadLine());
    
    if(x<y){
        x= Math.Pow(x, 2);
        y = Math.Sqrt(y);
        Console.WriteLine("Resultado do quadrado do menor número:"+ x);
        Console.WriteLine("Resultado da raiz do maior número:"+ y);
        
    }else{
         y=Math.Pow(y, 2);
        x=Math.Sqrt(x);
         Console.WriteLine("Resultado do quadrado do menor número:"+ y);
        Console.WriteLine("Resultado da raiz do maior número:"+ x);
    }
*//*
   // 3) Faça um programa para ler um número e imprimir uma mensagem dizendo se o mesmo é par
   //e positivo ao mesmo tempo. (Para verificar se é par, use o operador % - módulo).

    int x=0;
    while(true){
    Console.WriteLine(@"insira um número.");
    x = int.Parse(Console.ReadLine());
    if(x%2==0){
        Console.WriteLine("É par");
    }else{
          Console.WriteLine("É ímpar");
    }
*//*
  /// 4) Elabore um programa que indique se um número digitado está compreendido entre 20 e 90, ou não.


    int x=0;
    while(true){
    Console.WriteLine(@"insira um número.");
    x = int.Parse(Console.ReadLine());
    if(x>20 && x<90){
        Console.WriteLine("Esta compreendido");
    }else{
          Console.WriteLine("Não esta compreendido");
    }
*//*
  /// 5) Faça um programa para imprimir a raiz quadrada de um número (lido do teclado) caso ele seja positivo e o quadrado do número, caso ele seja negativo.



    double x;
    while(true){
    Console.WriteLine(@"insira um número.");
    x = double.Parse(Console.ReadLine());
    if(x>0){
        x=Math.Sqrt(x);
         Console.WriteLine($"Raiz: "+x.ToString("N3"));
        
    }else{
        x=Math.Pow(x,2);
          Console.WriteLine($"potencia: "+x);
          
    }
*//*
 //6) Um comerciante comprou um produto e quer vendê-lo com um lucro de 45% se o valor da compra for menor que R$20,00; caso contrário, o lucro será de 30%. Leia do teclado o valor do produto, calcule o valor da venda e imprima-o.



    double x, y;
    while(true){
    Console.WriteLine(@"insira um número.");
    x = double.Parse(Console.ReadLine());
    y = x;
    if(x<20.00){
   x=((x*45)/100);
        Console.WriteLine($"Preço final: "+(x+y));
    }else{
         x= ((x*30)/100);
          Console.WriteLine($"Preço final: "+(x+y));
          
    }
*//*
  //7) Em um posto de gasolina existe uma promoção de acordo com a quantidade de litros de
//combustível que um cliente coloca. Os prêmios são: o Menos que 10 litros: Ganha um chaveiro o Igual ou superior a 10 litros: Ganha uma ducha Faça um programa que leia o número de litros colocados em um automóvel e imprima uma
//mensagem dizendo qual o prêmio ganho.




    double x;
    while(true){
    Console.WriteLine(@"Quantos litros de combustível voce colocou?");
    x = double.Parse(Console.ReadLine());
    if(x<10.0){

        Console.WriteLine("Ganhou um chaveiro");
    }else if(x>=10.0){
         Console.WriteLine("Ganhou uma ducha");
    }



}
}
}
*/