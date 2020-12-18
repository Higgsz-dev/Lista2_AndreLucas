using System;

namespace Q26
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            int contV = 0;
            int contP = 0;
            double contValor = 0;

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i =0; i < 15; i++)
                {
                    Console.Write("Digite o valor da compra: ");
                    double valorCompra = double.Parse(Console.ReadLine());
                    contValor = contValor + valorCompra;

                    Console.Write("Digite V para compras a vista e P para parceladas: ");
                    string pgto = Console.ReadLine();

                    if (pgto == "V")
                    {
                        contV = contV + 1;
                    }
                    else
                    {
                        contP = contP + 1;
                    }

                }

                Console.WriteLine("Quantidade de compras a vista: "+contV);
                Console.WriteLine("Quantidade de compras parceladas: "+contP);
                Console.WriteLine("Valor total das compras efetuadas: "+contValor);


                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
