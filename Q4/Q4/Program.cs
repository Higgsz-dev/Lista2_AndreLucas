using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o preço de um carro novo: ");
                double precoCarro = double.Parse(Console.ReadLine());

                double custoFabrica = (precoCarro / 100 * 73) - precoCarro;

                Console.WriteLine("O preço do carro ao consumidor final é de: "+custoFabrica+" R$");

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
