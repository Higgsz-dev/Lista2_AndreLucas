using System;

namespace Q37
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.WriteLine("Repete enquanto atender a condição determinada pelo desenvolvedor: ");
                Console.WriteLine("Neste caso irá repetir enquanto a resposta for sim");
                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }

            Console.WriteLine("Irá repetir de acordo com a quantidade de vezes determinaeda pelo usuário");
            Console.WriteLine("Deseja repetir quantas vezes: ");
            int opcao2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < opcao2; i++)
            {
                Console.WriteLine("Repetindo");
            }
        }
    }
}
