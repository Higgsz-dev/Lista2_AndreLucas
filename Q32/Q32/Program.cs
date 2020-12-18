using System;

namespace Q32
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i = 1; i < 1000; i++)
                {
                    double calc = i%5;
                    if(calc == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
