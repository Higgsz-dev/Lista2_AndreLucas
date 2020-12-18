using System;

namespace Q38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uma função é uma sequencia de comandos, basta cria-la uma e isso vai te poupar de reescrever determinado processo");
            Console.WriteLine("várias vezes no programa. Este exemplo é um função para somar dois numeros");
            int AddNumbers(int num1, int num2)
            {
                int result = num1 + num2;
                return result;
            }
            Console.WriteLine("Número 1: 10");
            Console.WriteLine("Número 2: 5");
            int result = AddNumbers(10, 5);
            Console.WriteLine(result);
        }
    }
}
