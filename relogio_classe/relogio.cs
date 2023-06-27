/* using System;

namespace relogio
{
    public class Relogio
    {
        private int hora;
        private int minuto;
        private int segundo;
        private int dia;
        private int mes;

        public int Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public int Minuto
        {
            get { return minuto; }
            set { minuto = value; }
        }

        public int Segundo
        {
            get { return segundo; }
            set { segundo = value; }
        }

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public Relogio()
        {
            Reiniciar();
        }

        public void AjustarHora(int novaHora, int novoMinuto, int novoSegundo)
        {
            Hora = novaHora;
            Minuto = novoMinuto;
            Segundo = novoSegundo;
        }

        public void AjustarData(int novoDia, int novoMes)
        {
            Dia = novoDia;
            Mes = novoMes;
        }

        public void Reiniciar()
        {
            Hora = 0;
            Minuto = 0;
            Segundo = 0;
            Dia = 1;
            Mes = 1;
        }

        public void PassarTempo(int horas, int minutos, int segundos)
        {
            Segundo += segundos;
            Minuto += minutos;
            Hora += horas;

            if (Segundo >= 60)
            {
                Segundo -= 60;
                Minuto++;
            }

            if (Minuto >= 60)
            {
                Minuto -= 60;
                Hora++;
            }

            if (Hora >= 24)
            {
                Hora -= 24;
                Dia++;
            }

            int diasNoMes = DiasNoMes(Mes);
            if (Dia > diasNoMes)
            {
                Dia = 1;
                Mes++;

                if (Mes > 12)
                {
                    Mes = 1;
                }
            }
        }

        private int DiasNoMes(int mes)//só pode ser utilizada por métodos de dentro da classe
        {
            if (mes == 2)
            {
                bool eAnoBissexto = (mes % 4 == 0 && mes % 100 != 0) || (mes % 400 == 0);
                return eAnoBissexto ? 29 : 28;
            }

            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                return 30;
            }

            return 31;
        }

        public void ExibirDataHora()
        {
            Console.WriteLine($"{Dia:D2}/{Mes:D2}/{DateTime.Now.Year:D4} {Hora:D2}:{Minuto:D2}:{Segundo:D2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Relogio relogio = new Relogio();
            relogio.ExibirDataHora();  // Saída: 01/01/2000 00:00:00

            relogio.AjustarData(31, 12);
            relogio.AjustarHora(23, 59, 59);
            relogio.ExibirDataHora();  // Saída: 31/12/2000 23:59:
        }
    }
}
*/