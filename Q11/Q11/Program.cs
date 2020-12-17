using System;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o peso do prato montado pelo cliente: ");
                double pesoPrato = double.Parse(Console.ReadLine());

                Console.WriteLine("Preço a pagar: "+pesoPrato*12+" R$");

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
