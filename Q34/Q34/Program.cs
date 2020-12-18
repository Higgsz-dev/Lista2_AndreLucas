using System;

namespace Q34
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";
            double saldo = 300;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o valor que deseja sacar");
                double saque = double.Parse(Console.ReadLine());

                double result = saldo - saque;

                Console.WriteLine("Saldo da conta: "+result);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
