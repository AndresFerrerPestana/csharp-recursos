using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduza um inteiro entre 0 e 20: ");

        if (int.TryParse(Console.ReadLine(), out int numero)
            && numero >= 0 && numero <= 20)
        {
            for (int contador = numero; contador >= 0; contador--)
            {
                Console.WriteLine(contador);
            }

            Console.WriteLine("Contagem terminada.");
        }
        else
        {
            Console.WriteLine("Valor invalido.");
        }
    }
}