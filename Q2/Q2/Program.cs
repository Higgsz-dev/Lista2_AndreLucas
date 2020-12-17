using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite o número total de eleitores do municipio: ");
                int totalEleitores = int.Parse(Console.ReadLine());

                Console.Write("Digite o total de votos brancos: ");
                int brancos = int.Parse(Console.ReadLine());

                Console.Write("Digite o total de votos nulos: ");
                int nulos = int.Parse(Console.ReadLine());

                Console.Write("Digite o total de votos válidos: ");
                int validos = int.Parse(Console.ReadLine());

                double totalBrancos = totalEleitores / 100 * brancos;
                Console.WriteLine("O percentual de votos em brancos: "+totalBrancos+" %");

                double totalNulos = totalEleitores / 100 * nulos;
                Console.WriteLine("O percentual de votos em nulos: " + totalNulos + " %");

                double totalValidos = totalEleitores / 100 * validos;
                Console.WriteLine("O percentual de votos em brancos: " + totalValidos + " %");

                Console.Write("Deseja realizar outro calculos: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
