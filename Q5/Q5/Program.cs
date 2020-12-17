using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";
            double contVenda = 0;
            double acrescimos = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o valor so seu salário base: ");
                double salarioBase = double.Parse(Console.ReadLine());

                Console.Write("Quantos carros o funcionário vendeu: ");
                int numCarros = int.Parse(Console.ReadLine());

                Console.Write("Digite o percentual que ele recebe sobre o valor da venda: ");
                int percentVenda = int.Parse(Console.ReadLine());

                for (int i = 0; i < numCarros; i++)
                {
                    Console.Write("Digite o valor do carro vendido: ");
                    double valorVenda = double.Parse(Console.ReadLine());

                    acrescimos = valorVenda / 100 * percentVenda;
                    contVenda = contVenda + acrescimos;
                }

                double salarioFinal = salarioBase + acrescimos;

                Console.WriteLine("O salário deste mês é de: "+salarioFinal+" R$");

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
