/*
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){


Console.Write("Insira um Raio!");
Console.WriteLine(@"");
float raio;Double Perimetro;
            raio = float.Parse(Console.ReadLine());
            Perimetro = (2*3.14)*raio;


            Console.WriteLine(@"Esse é o perimetro "+ Perimetro);


}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){


Console.Write("Insira a nota de 4 alunos");
Console.WriteLine(@"");


float[] alunos= new float[4];
float nota=0;


for (int x=0;x<alunos.Length;x++){


 alunos[x]= float.Parse(Console.ReadLine());
 nota = nota+alunos[x];
}
            Console.WriteLine(@"Esse é a soma das notas: "+ nota,@"Essa é a média"+ (nota/4));
             Console.WriteLine(@"Essa é a média aritmética: " +(nota/4));


}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
   
int[] idade= new int[3];
int dias_totais=0;






Console.WriteLine(@"insira quantos anos você tem:");
 idade[0]= int.Parse(Console.ReadLine());
Console.WriteLine(@"insira quantos meses se passaram desde seu último aniversário:");
 idade[1]= int.Parse(Console.ReadLine());
Console.WriteLine(@"insira quantos dias se passaram desde o ínicio do mês:");
 idade[2]= int.Parse(Console.ReadLine());


            dias_totais=(idade[0]*365)+(idade[1]*30)+(idade[2]);


    Console.WriteLine($"Você está vivo tem "+ dias_totais +" dias");


}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
    //d = 1/2 g t ²
    float d= 0.0F;
    float g= 9.86F;
    float t= 0.0F;
    Console.Write("O objeto demorou quanto tempo para cair?");
    t= float.Parse(Console.ReadLine());
    //double a1 = Math.Pow(2, 5);//32
    d=0.5F*g*(t*t);
    Console.WriteLine("Deslocamento: " + d +" metros");


}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
    //5. Suponha que você foi ao supermercado e comprou: N latas de chocolate em pó a um custo unitário Q, L
//litros de leite a um custo unitário P e B quilos de banana a um custo unitário T. Faça um programa que
//escreva: o nome do produto, total gasto com cada produto e total gasto no mercado.
int x=0;
int quantidade=0;
float Q=5.0F, P=4.5F, T=12.0F, preco_total=0.0F;
while(x!=4){
    Console.WriteLine(@"1)Preço da lata de chocolate: " +Q);
    Console.WriteLine(@"2)Preço do litro de leite: " +P);
    Console.WriteLine(@"3)Preço do quilo da banana:  " +T);
    Console.WriteLine(@"4)Sair  ");
    Console.WriteLine(@"digite o número correspondente do qual deseja comprar(1,2 ou 3).");
    x= int.Parse(Console.ReadLine());


switch(x){
    case 1:
    Console.WriteLine("quantos unidade deseja comprar?");
    quantidade=int.Parse(Console.ReadLine());
    preco_total=preco_total+(quantidade*Q);


    break;
    case 2:
    Console.WriteLine("quantos litros deseja comprar?");
    quantidade=int.Parse(Console.ReadLine());
    preco_total=preco_total+(quantidade*P);


    break;
    case 3:
    Console.WriteLine("quantos quilos deseja comprar?");
    quantidade=int.Parse(Console.ReadLine());
    preco_total=preco_total+(quantidade*T);


    break;
default:
break;
}
}
Console.WriteLine("Preço total: "+ preco_total + "R$");
}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
   //6. Faça um programa que leia o número total de prestações de um consórcio, o total de prestações pagas e
   //o valor atual da prestação. O programa deve calcular e mostrar o saldo devedor atual.
   int total_de_prestacoes=0, prestacoes_a_pagar=0, aux=0;
   float valor_das_prestações=0;
   Console.WriteLine(@"Bem vindo ao software de cálculo de financiamento online!"+$"Nos informe: O número");
   Console.WriteLine(@"total de parcelas, quantas prestações já foram pagas e o valor total das prestações, respectivamente.");
    total_de_prestacoes= int.Parse(Console.ReadLine());
    aux=int.Parse(Console.ReadLine());
    prestacoes_a_pagar= total_de_prestacoes - aux;
    valor_das_prestações=float.Parse(Console.ReadLine());
    Console.WriteLine("O saldo devedor atual é:" + (valor_das_prestações*prestacoes_a_pagar));




}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
   //7. Escreva um programa que leia as medidas dos lados de um retângulo, calcule e imprima
   // a medida do seu perímetro, da diagonal e da área do retângulo.
    Double Diagonal = 0.0F;
    float Base, Altura, perímetro, area;
    Console.WriteLine("Digite a base e a altura do retângulo(respectivamente):");
    Base=float.Parse(Console.ReadLine());
    Altura=float.Parse(Console.ReadLine());
   Diagonal= Math.Sqrt(((Base*Base)+(Altura*Altura)));
   perímetro= ((Base+Base)+(Altura+Altura));
    area=Base*Altura;
    Console.WriteLine(@"Diagonal: "+ Diagonal.ToString("N3"));
    Console.WriteLine("Perímetro: "+ perímetro);
    Console.WriteLine("Área: "+ area);








}
}
}
using System;
namespace Name
{
   


class Primeira{
public static void Main(string[] args){
   //8. O governo acaba de liberar US$ 10.000.000,00 dólares para construção de casas populares, a qual contratou
   // a Construtora Solidez Engenharia S.A. Cada casa custa o equivalente a 150 salários mínimos. Faça um algoritmo
    //que leia o valor do salário mínimo (você deve digitar um valor. Pode ser fictício) e calcule a quantidade
    //de casas possíveis de se construir com a verba americana. Considere a cotação do
   // dólar como US$ 1,00 = R$5,15
double dinheiro = 10000000.00D;
double real= dinheiro*5.15;
float salario_min;
double custo_casa;
double número_casas;


Console.WriteLine(@"Dê o valor do salário mínimo: ");
salario_min= float.Parse(Console.ReadLine());
custo_casa=salario_min*150;
número_casas= real/custo_casa;


Console.WriteLine("O total de casa que podem ser construídas é: "+número_casas.ToString("N1"));


}
}
}



*/