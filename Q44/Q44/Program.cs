using System;

namespace Q44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para compara strings usamos ==");
            Console.WriteLine("Digite um nome: ");
            string nome1 = Console.ReadLine();

            Console.WriteLine("Digite um nome: ");
            string nome2 = Console.ReadLine();


            if (nome1 == nome2)
            {
                Console.WriteLine("Os nomes são iguais");
            }
            else
            {
                Console.WriteLine("Os nome são diferentes");
            }
        }
    }
}
