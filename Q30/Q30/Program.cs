using System;

namespace Q30
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";
            int idade = 1;

            int contIdades = 0;
            int contTotal = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                while(idade > 0)
                {
                    Console.WriteLine("Digite a sua idade: ");
                    idade = int.Parse(Console.ReadLine());

                    contTotal = contTotal + 1;
                    contIdades = contIdades + 1;
                }

                Console.WriteLine("A média das idades digitadas é: "+contIdades/contTotal);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
