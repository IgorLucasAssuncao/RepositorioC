using System;

namespace Lista14_5
{
    public class Voo
    {
        private bool[] lugares;
        private int numeroVoo;
        private Data data;

        public Voo(Data data, int numeroVoo)
        {
            this.data = data;
            this.numeroVoo = numeroVoo;
            this.lugares = new bool[100];

            for (int i = 0; i < 100; i++)
            {
                this.lugares[i] = false;
            }
        }
        public int GetVoo
        {
            get { return numeroVoo; }
        }

        public Data GetData
        {
            get { return data; }
            set { data = value; }
        }
        public bool[] Lugares
        {
            get { return lugares; }
        }

        public int ObterProximoLivre(int cadeira)
        {
            int proximaCadeira = 0;
            for (int i = cadeira; i < 100; i++)
            {
                if (Lugares[i] == false)
                {
                    proximaCadeira = i;
                    break;
                }
            }
            return proximaCadeira;
        }
        public bool IsOcupada(int cadeira)
        {
            if (Lugares[cadeira])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OcuparCadeira(int cadeira)
        {
            int opcao = 0;
            if (IsOcupada(cadeira))
            {
                Console.WriteLine("Cadeira ocupada!!!!!!!!!!!!!!!!!");
                Console.WriteLine("As seguintes não estão ocupadas:");
                ObterVagasDisponiveis();
                while (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("Deseja ocupar alguma delas?");
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("2 - Não");
                    opcao = int.Parse(Console.ReadLine());
                }
                if (opcao == 1)
                {
                    Console.WriteLine("Qual cadeira deseja ocupar?");
                    cadeira = int.Parse(Console.ReadLine());
                    if (lugares[cadeira] == false)
                    {
                        Lugares[cadeira] = true;
                    }
                    else
                    {
                        Console.WriteLine("Você sabe ler?");
                    }
                }
                else
                {
                    Console.WriteLine("Vamos te colocar na próxima cadeira disponível");
                    int cadeiraLivre = ObterProximoLivre(cadeira);
                    OcuparCadeira(cadeiraLivre);
                }

            }
            else
            {
                Lugares[cadeira] = true;
                Console.WriteLine("Cadeira ocupada com sucesso");
            }

        }
        public void ObterVagasDisponiveis()
        {
            for (int i = 0; i < 100; i++)
            {
                if (Lugares[i] == false)
                {
                    Console.Write($" " + i);
                    if (i % 10 == 0)
                        Console.WriteLine(" ");
                }
            }
            Console.WriteLine(" ");
        }

        public Voo Clone()
        {
            Voo voo = new Voo(GetData, GetVoo);
            voo.GetData = GetData;
            return voo;
        }

    }
}