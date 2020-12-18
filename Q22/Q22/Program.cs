using System;

namespace Q22
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine("5 X "+i+" = "+5*i);
                }

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
