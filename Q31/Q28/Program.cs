using System;

namespace Q28
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            int contTotal = 0;
            int contM = 0;
            int contH = 0;

            int idadeTotal = 0;
            int idadeM = 0;
            int idadeH = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write("Digite a sua idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    contTotal = contTotal + 1;
                    idadeTotal = idadeTotal + 1;

                    Console.Write("Digite M para Mulher e H para Homem: ");
                    string sexo = Console.ReadLine();

                    if (sexo == "M")
                    {
                        contM = contM + 1;
                        idadeM = idadeM + 1;
                    }else
                    {
                        contH = contH + 1;
                        idadeH = idadeH + 1;
                    }

                }

                Console.WriteLine("idade média do grupo: "+idadeTotal/contTotal);
                Console.WriteLine("Idade média dos Homens: "+idadeH/contH);
                Console.WriteLine("Idade média das mulheres: "+idadeM/contM);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
