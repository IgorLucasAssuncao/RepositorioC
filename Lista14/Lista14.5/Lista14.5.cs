using System;

namespace Lista14_5
{
    public class Lista14_5
    {
        public static void Main(String[] args)
        {
            Voo[] voos = new Voo[10];
            Data[] datas = new Data[10];
            int cadeira = 0;
            Voo VooClone;
            for (int i = 0; i < 10; i++)
            {
                datas[i] = new Data(1, 1, 2000);
                voos[i] = new Voo(datas[i], i);
            }
            while (true)
            {
                Console.WriteLine("Digite o numero do voo: (de 0 a 9)");
                int numeroVoo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero da cadeira: ");
                cadeira = int.Parse(Console.ReadLine());


                for (int i = 0; i < 10; i++)
                {
                    if (voos[i].GetVoo == numeroVoo)
                    {
                        voos[i].OcuparCadeira(cadeira);
                    }
                }
            }
        }
    }


}

