 using System;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o preço do litro da gasolina: ");
                double precoGasolina = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor que você deseja abastecer: ");
                double valorColocado = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade de litros abastecido: "+valorColocado/precoGasolina);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
