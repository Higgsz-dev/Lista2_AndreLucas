using System;

namespace Q18
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o valor do veiculo: ");
                double valorVeiculo = double.Parse(Console.ReadLine());

                if (valorVeiculo == 0)
                {
                    Console.WriteLine("Programa encerrado");
                }

                Console.WriteLine("Digite o combustivel que esse veiculo usa: ");
                string combustivel = Console.ReadLine();

                if(combustivel == "alcool" || combustivel == "Alcool")
                {
                    Console.WriteLine("Valor do desconto: "+valorVeiculo/100*25);

                    double valorAtual = valorVeiculo / 100 * 25 - valorVeiculo;
                    Console.WriteLine("Valor do veiculos (Com descontro): "+valorAtual);
                }
                if (combustivel == "gasolina" || combustivel == "Gasolina")
                {
                    Console.WriteLine("Valor do desconto: " + valorVeiculo / 100 * 21);

                    double valorAtual = valorVeiculo / 100 * 21 - valorVeiculo;
                    Console.WriteLine("Valor do veiculos (Com descontro): " + valorAtual);
                }
                if (combustivel == "diesel" || combustivel == "Diesel")
                {
                    Console.WriteLine("Valor do desconto: " + valorVeiculo / 100 * 14);

                    double valorAtual = valorVeiculo / 100 * 14 - valorVeiculo;
                    Console.WriteLine("Valor do veiculos (Com descontro): " + valorAtual);
                }

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
