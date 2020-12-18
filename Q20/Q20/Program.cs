using System;

namespace Q20
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            while (opcao == "sim" || opcao == "Sim" || opcao == "SIM")
            {
                Console.Write("Qual a carga horaria de aula dadas: ");
                double cargaHoraria = double.Parse(Console.ReadLine());

                Console.Write("Qual o nível do professor: ");
                int nivelProf = int.Parse(Console.ReadLine());

                if (nivelProf == 1)
                {
                    Console.WriteLine("Salário deste professor: "+ cargaHoraria * 12+" R$");
                }

                if (nivelProf == 2)
                {
                    Console.WriteLine("Salário deste professor: " + cargaHoraria * 17 + " R$");
                }

                if (nivelProf == 3)
                {
                    Console.WriteLine("Salário deste professor: " + cargaHoraria * 25 + " R$");
                }
                Console.Write("Fazer um novo calculo: ");
                opcao = Console.ReadLine();
            }
        }
    }
}
