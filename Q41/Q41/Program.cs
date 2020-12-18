using System;

namespace Q41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes são parecidas com funções, que por sua vez nos economizam tempo. Mas dentro das classes");
            Console.WriteLine("temos os objetos, que carregam varias e paremetros");
            Console.WriteLine("exemplo de uma classe para exibir numeros: ");

            Somar s = new Somar();

            Console.Write("Digite um número: ");
            s.Num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um número: ");
            s.Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(s);
        }
    }
}
