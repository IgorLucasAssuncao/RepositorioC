/*
using System;
namespace Conta_poupanca
{
    public class ContaDePoupanca
    {
        private static double taxaDeJurosAnual;
        private double saldoPoupanca;

        public ContaDePoupanca(double saldoInicial)
        {
            saldoPoupanca = saldoInicial;
        }

        public void CalcularJuroMensal()
        {
            double juroMensal = (saldoPoupanca * taxaDeJurosAnual) / 12;
            saldoPoupanca += juroMensal;
        }

        public static void AlterarTaxaDeJuros(double novaTaxa)
        {
            taxaDeJurosAnual = novaTaxa;
        }

        public double GetSaldoPoupanca()
        {
            return saldoPoupanca;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContaDePoupanca.AlterarTaxaDeJuros(0.04);

            ContaDePoupanca poupador1 = new ContaDePoupanca(2000.0);
            ContaDePoupanca poupador2 = new ContaDePoupanca(3000.0);

            poupador1.CalcularJuroMensal();
            poupador2.CalcularJuroMensal();

            Console.WriteLine("Saldo do poupador 1 após um mês: " + poupador1.GetSaldoPoupanca().ToString("C"));
            Console.WriteLine("Saldo do poupador 2 após um mês: " + poupador2.GetSaldoPoupanca().ToString("C"));

            ContaDePoupanca.AlterarTaxaDeJuros(0.05);

            poupador1.CalcularJuroMensal();
            poupador2.CalcularJuroMensal();

            Console.WriteLine("Saldo do poupador 1 após dois meses: " + poupador1.GetSaldoPoupanca().ToString("C"));
            Console.WriteLine("Saldo do poupador 2 após dois meses: " + poupador2.GetSaldoPoupanca().ToString("C"));
        }
    }
}
*/