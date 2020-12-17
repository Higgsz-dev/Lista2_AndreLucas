using System;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o valor de custo do produto: ");
                double precoCusto = double.Parse(Console.ReadLine());

                Console.Write("Digite o percentual acrescido para criar o preço de venda: ");
                double percent = double.Parse(Console.ReadLine());

                double precoVenda = precoCusto / 100 * percent + precoCusto;

                Console.WriteLine("O preço de venda do produto é de: "+precoVenda+" R$");

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
