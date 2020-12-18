using System;

namespace Q17
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

                Console.Write("M para Masculino e F feminino: ");
                string sexo = Console.ReadLine();

                if (sexo == "M")
                {
                    Console.WriteLine(nome);
                    Console.WriteLine("É Homem");
                }
                else
                {
                    Console.WriteLine(nome);
                    Console.WriteLine("É Mulher");
                }

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
