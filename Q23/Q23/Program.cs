using System;

namespace Q23
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";


            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                for (int i = 0; i < 17; i++)
                {
                    Console.Write("Digite o seu nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite o valor das comprar feitas no ano passado: ");
                    double valorCompras = double.Parse(Console.ReadLine());

                    if (valorCompras < 1000)
                    {
                        Console.WriteLine(nome+" você tem um bônus de 10% em nossa loja");
                    }else
                    {
                        Console.WriteLine(nome+" você tem um saldo de 15% em nossa loja");
                    }
                }

                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
