using System;

namespace Lista10
{

    class Lista10
    {

        public static double coseno(double X)
        {
            int sinal = -1;

            double Y = 1;
            for (int i = 0, expoente = 2; i < 25; i++, expoente += 2)
            {
                Y += sinal * (Math.Pow(X, expoente) / fatorial(expoente));
                sinal = sinal * (-1);

            }

            return Y;
        }


        public static int fatorial(int fatorial)
        {
            int fat = 1;
            for (int i = 1; i <= fatorial; i++)
            {
                fat *= i;
            }
            return fat;
        }


        public static void Main()
        {
            double CosenoX = 0, recebeX = 0;
            Console.WriteLine("Insira o X para calcular o Coseno: ");
            CosenoX = Double.Parse(Console.ReadLine() ?? "0");

            recebeX = coseno(CosenoX);
            Console.WriteLine($"O coseno é: {recebeX}");

        }
    }
}