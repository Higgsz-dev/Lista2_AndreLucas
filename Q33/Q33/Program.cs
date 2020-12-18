using System;

namespace Q33
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            int contProva = 0;
            double contNota = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Digite a nota da prova: ");
                    double nota = double.Parse(Console.ReadLine());

                    contNota = contNota + nota;
                    contProva = contProva + 1;
                }

                Console.WriteLine("A média das 4 prova é: "+contNota/contProva+" pontos");

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }


            
        }
    }
}
