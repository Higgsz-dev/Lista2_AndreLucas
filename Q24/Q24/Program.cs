using System;

namespace Q24
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";
            int menor18 = 0;
            int mais18 = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("Digite a sua idade: ");
                    int idade = int.Parse(Console.ReadLine());

                    if (idade <= 18)
                    {
                        menor18 =+ 1;
                    }else
                    {
                        mais18 = +1;
                    }
                }

                Console.WriteLine("Pesosa com menos de 18: " + menor18);
                Console.WriteLine("Pessoa com mais de 18: " + mais18);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
