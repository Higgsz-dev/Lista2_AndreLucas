using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite quantos anos você tem: ");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine(nome + " você já viveu " + idade * 365);
                Console.WriteLine("");

                Console.Write("Realizar outro calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
