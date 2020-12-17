using System;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o primeiro numero: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o primeiro numero: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("O valor da divisão do priemiro pelo segundo é de: "+num1/num2);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
