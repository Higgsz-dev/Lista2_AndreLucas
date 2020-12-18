using System;

namespace Q25
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";
            int ate15 = 0;
            int de16a30 = 0;
            int de31a45 = 0;
            int de46a60 = 0;
            int acima61 = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Digite a sua idade: ");
                    int idade = int.Parse(Console.ReadLine());

                    if (idade <= 15)
                    {
                        ate15 = +1;
                    }
                    if (idade >= 16 && idade <=30)
                    {
                        de16a30 = +1;
                    }
                    if (idade >= 31 && idade <= 45)
                    {
                        de31a45 = +1;
                    }
                    if (idade >= 46 && idade <= 60)
                    {
                        de46a60 = +1;
                    }
                    if (idade >= 61)
                    {
                        acima61 = +1;
                    }
                }

                Console.WriteLine("Pesosa com até 15 anos: " + ate15);
                Console.WriteLine("Pessoas entre 16 e 30 anos: "+de16a30);
                Console.WriteLine("Pessoas entre 31 e 45 anos: "+de31a45);
                Console.WriteLine("Pessoas entre 45 e 60 anos: "+de46a60);
                Console.WriteLine("Pessoas acima de 60 anos: "+acima61);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
