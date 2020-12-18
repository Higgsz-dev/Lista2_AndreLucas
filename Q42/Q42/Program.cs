using System;

namespace Q42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O comando de entrada é o Console.Readline. Mas apenas para strings, para os demias tipo de dado se coloca o tipo");
            Console.WriteLine("e depois .Parse e dentro dos parenteses o comando readline");
            Console.WriteLine("Exemplo: int.Parse(Console.Readline()); ");
            Console.WriteLine("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("O comando de sáida é o Console.Write(Para escrever na mesma linha) e Console.WriteLine (para a linha debaixo)");
            Console.WriteLine("Esse foi o npumero digitado: "+num);
        }
    }
}
