/*using System;

namespace Lista09
{
    class Lista09
    {
        public static void Main()
        {
            /*
                string palavra="";
                   bool palindromo=false;
                   Console.WriteLine("Esvreva uma palavra: ");
                   palavra=Console.ReadLine();
                   for(int i=palavra.Length-1, x=0; i>=0;i--,x++){
                      if(palavra[x]==palavra[i]){
                          palindromo=true;
                      }
                      else{
                      palindromo=false;
                      }
                      }
                     if(palindromo){
                         Console.WriteLine("Palindromo");
                     }
                     else{
                           Console.WriteLine("Não Palindromo");
                     }
            */
            /*
              string string1, string2, string3="", aux;
                        Console.WriteLine("Insira duas Palavras: ");
                        string1=Console.ReadLine()??"0";
                        string2=Console.ReadLine()??"0";


                        if(string1.Length<string2.Length){
                            aux=string1;
                            string1=string2;
                            string2=aux;
                        }




                        for(int i=0;i<string1.Length;i++){
                            if (i<string2.Length){
                            string3+=(string1[i].ToString()+string2[i].ToString());
                            }else{
                                string3 += string1[i];
                            }
                        }


                        Console.WriteLine("String: "+ string3.ToString());
            */
            //3) Elabore um programa que leia uma frase (string) e crie dois vetores: um para vogais e outro para consoantes. Transfira
            //para o vetor vogal todas as vogais da frase lida e para o vetor consoante todas as consoantes da frase lida. Mostre os
            //dois vetores gerados.
            /*
                        string string1 = "", string2 = "", string3 = "";
                        Console.WriteLine("Insira uma frase: ");
                        string1 = Console.ReadLine() ?? "0";

                        for (int i = 0; i < string1.Length; i++)
                        {


                            if (string1[i] == 'a' || string1[i] == 'e' || string1[i] == 'i' || string1[i] == 'o' || string1[i] == 'u')
                            {
                                string2 += string1[i];
                            }
                            else
                            {
                                string3 += string1[i];
                            }
                        }
                        Console.WriteLine("Vogais: " + string2);
                        Console.WriteLine("Consoantes: " + string3);
                        */
            //4) Strings que gaguejam: Crie um programa que, dada uma string, duplique cada caractere da mesma.
            //Exemplo:
            //String de entrada: casa
            //String de saída: ccaassaa
            /*
                    string normal = "", gaguejada = "";
                    Console.WriteLine("Insira uma frase: ");
                    normal = Console.ReadLine() ?? "0";
                    for (int i = 0; i < normal.Length; i++)
                    {
                        gaguejada += normal[i].ToString() + normal[i].ToString();

                    }
                    Console.WriteLine($"String normal: {normal}");
                    Console.WriteLine($"String gaguejada: {gaguejada}");
                    */
            //     5) Faça um programa de “criptografia” (codificação de dados visando a privacidade de acesso as informações), onde
            //dada uma string este programa codifique os dados através de um processo de substituição de letras. Você pode definir
            //o seu próprio método de criptografia, desde que depois seja possível reverter este processo, ou seja, um código
            //criptografado deve poder ser convertido novamente ao valor inicial.
            //Exemplo:
            //>> Criptografador – Codifica uma String <<
            //Entre com o texto (string) a ser criptografado: LinguagemC
            //Texto criptografado: MjohvbhfnD (alterou cada caractere em 1 posição no alfabeto
            /*
                        string normal = "", criptografada = "", descriptografada = "";
                        Console.WriteLine("Insira um texto: ");
                        normal = Console.ReadLine() ?? "0";

                        for (int i = 0; i < normal.Length; i++)
                        {
                            byte bytenormal = Convert.ToByte(normal[i]);
                            byte modificado = (byte)(bytenormal ^ 1);
                            char bytemodificado = Convert.ToChar(modificado);
                            criptografada += bytemodificado.ToString();
                        }
                        Console.WriteLine("String normal: " + normal);
                        Console.WriteLine($"String criptografada: {criptografada}");

                        for (int i = 0; i < criptografada.Length; i++)
                        {
                            byte byterefaz = Convert.ToByte(criptografada[i]);
                            byte modificadoRefaz = (byte)(byterefaz ^ 1);
                            char bytemodificado = Convert.ToChar(modificadoRefaz);
                            descriptografada += bytemodificado.ToString();
                        }
                        Console.WriteLine($"String descriptograda: {descriptografada}");
            */
            //6) Implemente um programa que leia um nome completo e apresente apenas o último nome e o primeiro nome na
            //seguinte forma:
            //Último, Primeiro
            //Exemplo:
            //Entrada: Rafael Paes Oliveira
            //Saída: Oliveira, Rafae

            // Separador 
            /*
                        string Nome = "", PrimeiroUltimoNome = "";

                        Console.WriteLine("Insira um nome completo: ");
                        Nome = Console.ReadLine() ?? "0";
                        string[] NomeSeparado = Nome.Split(' ');
                        PrimeiroUltimoNome = NomeSeparado[NomeSeparado.Length - 1] + ", " + NomeSeparado[0];
                        Console.WriteLine($"Nome: {Nome}");
                        Console.WriteLine($"Nome separado: {PrimeiroUltimoNome}");
            */
            //7) Crie um programa que mostre todos os caracteres de uma string que são repetidos. Se a string não tiver caracteres
            //repetidos, mostre uma mensagem na tela.
            /*
            string string1 = "";
            Boolean repetido = false;
            Console.WriteLine("Insira uma frase: ");
            string1 = Console.ReadLine() ?? "0";
            for (int i = 0; i < string1.Length; i++)
            {
                for (int x = i + 1; x < string1.Length; x++)
                {
                    if (string1[i] == string1[x])
                    {
                        Console.WriteLine($"Caracter repetido: {string1[i]}");
                        repetido = true;
                    }

                }


            }
            if (repetido)
            {
                Console.WriteLine("há caracteres repetidos");
            }
            else
            {
                Console.WriteLine("Não há caracteres repetidos");
            }
        }
    }
}

*/
