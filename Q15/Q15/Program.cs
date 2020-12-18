using System;

namespace Q15
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";
            double contNota = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Digite a "+i+" nota: ");
                    double nota = double.Parse(Console.ReadLine());

                    contNota = contNota + nota;
                }

                if (contNota >= 7)
                {
                    Console.WriteLine("Aprovado");
                }else if (contNota = 5.1 || contNota <= 6.9)
                {
                    Console.WriteLine("Recuperação");
                }else if (contNota < 5)
                {
                    Console.WriteLine("Reprovado");
                }

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
