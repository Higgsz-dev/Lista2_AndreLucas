using System;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite um número: ");
                double num = double.Parse(Console.ReadLine());                

                if (num >= 100 && num <= 200)
                {
                    Console.WriteLine("O número está entre 100 e 200");
                }else
                {
                    Console.WriteLine("O número não está entre 100 e 200");
                }


                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
