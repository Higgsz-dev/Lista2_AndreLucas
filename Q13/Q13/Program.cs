using System;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Digite seu peso em quilos: ");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Peso convertido para gramas: "+peso*1000);

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            };
        }
    }
}
