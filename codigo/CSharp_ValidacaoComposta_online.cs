using System;

class Program
{
    static void Main()
    {
        Console.Write("Idade: ");

        if (!int.TryParse(Console.ReadLine(), out int idade))
        {
            Console.WriteLine("Idade inválida.");
        }
        else
        {
            Console.Write("Existe autorização? (S/N): ");
            string resposta = (Console.ReadLine() ?? "").Trim();

            bool autorizacao = resposta == "S" || resposta == "s";

            if (idade >= 18 && autorizacao)
            {
                Console.WriteLine("Acesso permitido.");
            }
            else
            {
                Console.WriteLine("Acesso não permitido.");
            }
        }
    }
}