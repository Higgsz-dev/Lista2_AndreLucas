using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o valor aplicado na poupança: ");
                double valorIncial = double.Parse(Console.ReadLine());

                double valorFinal = (valorIncial / 100 * 2) + valorIncial;

                Console.WriteLine("O valor no final é de: "+valorFinal+" R$");

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
