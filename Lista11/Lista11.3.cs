/*

using System;



namespace Lista11
{
    class lista11_3
    {

        public static int[] inicializa_mega_sena()
        {
            int[] mega_sena = new int[6];
            Random rd = new Random();
            for (int i = 0; i < mega_sena.Length; i++)
            {
                mega_sena[i] = rd.Next(1, 61);
            }
            return mega_sena;
        }

        public static void aposta(int[] mega_sena)
        {
            int[] aposta = new int[6];
            int cont = 0;
            for (int i = 0; i < aposta.Length; i++)
            {
                Console.WriteLine("Digite um número");
                aposta[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            for (int i = 0; i < aposta.Length; i++)
            {
                for (int x = 0; x < aposta.Length; x++)
                {
                    if (aposta[i] == mega_sena[x])
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine($"Você acertou {cont} números");
        }



        public static void Main()
        {
            aposta(inicializa_mega_sena());
        }
    }
}
*/