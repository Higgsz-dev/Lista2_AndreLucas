using System;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digita a quantidad de pães vendidos no dia: ");
                int qtdPao = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de broas vendidas no dia: ");
                int qtdBroas = int.Parse(Console.ReadLine());

                double totalVendas = (qtdPao * 0.12) + (qtdBroas * 1.5);
                double valorPoupança = totalVendas / 100 * 10;

                Console.WriteLine("O valor da venda de pães e broas no dia foi de: "+totalVendas+" R$");
                Console.WriteLine("O valor a ser aplicado na poupança será de: "+valorPoupança+" R$");

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
