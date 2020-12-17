using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o valor do produto: ");
                double valorProduto = double.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de parcelas: ");
                int parcelas = int.Parse(Console.ReadLine());

                double valorParcela = valorProduto / parcelas;

                Console.WriteLine("O valor de cada parcela será de: "+valorParcela+" R$");

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
