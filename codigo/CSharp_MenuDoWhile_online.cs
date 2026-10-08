using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("1 - Mostrar mensagem");
            Console.WriteLine("0 - Terminar");
            Console.Write("Opcao: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1;
            }

            if (opcao == 1)
            {
                Console.WriteLine("Bem-vindo ao menu!");
            }
            else if (opcao != 0)
            {
                Console.WriteLine("Opcao invalida.");
            }

        } while (opcao != 0);

        Console.WriteLine("Programa terminado.");
    }
}