using System;

namespace Q19
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite um numero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite um numero: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Digite um numero: ");
                int num3 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                   
                }

                Console.WriteLine(num1);

                if (num2 > num3)
                {
                    int temp = num2;
                    num2 = num3;
                    num3 = temp;
                }
                Console.WriteLine(num2);
                Console.WriteLine(num3);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
