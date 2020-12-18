using System;

namespace Q16
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite a sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                if(idade < 18)
                {
                    Console.WriteLine("Menor de idade");
                }if (idade >= 18 && idade <= 49)
                {
                    Console.WriteLine("Maior de idade");
                } if (idade >= 50)
                {
                    Console.WriteLine("Idoso");
                }

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
