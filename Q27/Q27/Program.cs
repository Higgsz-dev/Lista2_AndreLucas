using System;

namespace Q27
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";
            int acima90 = 0;
            int contPessoas = 0;
            int contIdades = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for(int i = 0; i < 2; i++)
                {
                    Console.Write("Digite a sua idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    contIdades = contIdades + idade;
                    contPessoas = contPessoas + 1;

                    Console.Write("Qual o seu peso: ");
                    double peso = double.Parse(Console.ReadLine());

                    if (peso > 90)
                    {
                        acima90 = acima90 + 1;
                    }
                }

                Console.WriteLine("Quantidade de pessoas acima de 90 quilos: "+acima90);
                Console.WriteLine("Média de idades: "+contIdades/contPessoas);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
