/*
namespace ExerciciosStructs
{
    class MainClass
    {
        struct Carro
        {
            private string marca;
            private int ano;
            private float distancia;
            private float consumo;

            public void Preenche()
            {
                Console.WriteLine("entre marca, ano, distância e consumo");
                marca = Console.ReadLine();
                ano = int.Parse(Console.ReadLine());
                distancia = float.Parse(Console.ReadLine());
                consumo = float.Parse(Console.ReadLine());
            }
[]
            public float Calcula()
            {
                return (distancia / consumo);
            }
        }

        public static void Main(string[] args)
        {
            Carro veiculo = new Carro();
            veiculo.Preenche();
            Console.WriteLine("Km por litro: " + veiculo.Calcula());
        }
    }
}
*/