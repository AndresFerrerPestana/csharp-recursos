using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduza um inteiro entre 1 e 100: ");

        if (int.TryParse(Console.ReadLine(), out int n)
            && n >= 1 && n <= 100)
        {
            int soma = 0;

            for (int numero = 1; numero <= n; numero++)
            {
                soma += numero;
            }

            Console.WriteLine($"Soma: {soma}");
        }
        else
        {
            Console.WriteLine("Valor invalido.");
        }
    }
}