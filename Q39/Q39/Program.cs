using System;

namespace Q39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uam estrutura condicional, serve para determinar se aquele aquele dado atende as necesidades.");
            Console.WriteLine("Muito usada para validação em logins");
            Console.WriteLine("Neste caso para acessar o sistema, você tem q degitar email A e senha 123");

            Console.Write("Digite o email: ");
            string email = Console.ReadLine();
            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            if(email == "A" && senha == 123)
            {
                Console.WriteLine("Bem vindo ao sistema");
            }
            else
            {
                Console.WriteLine("Senha ou email incorretos");
            }
        }
    }
}
