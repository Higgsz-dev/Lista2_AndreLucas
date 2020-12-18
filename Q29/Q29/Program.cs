using System;

namespace Q29
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            int contTotal = 0;
            int contIdade = 0;
            int contPesq = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Digite a sua idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    contTotal = contTotal + 1;
                    contIdade = contIdade + 1;

                    Console.WriteLine("Digite a sua altura (em cm): ");
                    int altura = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o seu peso: ");
                    double peso = double.Parse(Console.ReadLine());

                    if(altura < 150 && peso > 90)
                    {
                        contPesq = contPesq + 1;
                    }
                }

                Console.WriteLine("Média de idades: "+contIdade/contTotal);
                Console.WriteLine("Quantidade de pessoa com peso superior a 90Kg e altura inferior a 1.50cm: "+contPesq);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
