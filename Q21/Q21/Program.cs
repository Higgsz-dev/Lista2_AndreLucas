using System;

namespace Q21
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.WriteLine("Digite a sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Infantil A");
                }

                if (idade >= 8 && idade <= 10)
                {
                    Console.WriteLine("Infantil B");
                }

                if (idade >= 11 && idade <= 13)
                {
                    Console.WriteLine("Juvenil A");
                }

                if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Juvenil B");
                }

                if (idade >= 18 && idade <= 25)
                {
                    Console.WriteLine("Sênior");
                }

                if (idade < 5 && idade > 25)
                {
                    Console.WriteLine("idade fora da faixa etária");
                }

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
