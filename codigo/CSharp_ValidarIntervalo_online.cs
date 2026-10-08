using System;

class Program
{
    static void Main()
    {
        int numero;
        bool valido;

        do
        {
            Console.Write("Introduza um inteiro entre 1 e 10: ");

            valido = int.TryParse(Console.ReadLine(), out numero)
                     && numero >= 1 && numero <= 10;

            if (!valido)
            {
                Console.WriteLine("Valor invalido. Tente novamente.");
            }

        } while (!valido);

        Console.WriteLine($"Valor aceite: {numero}");
    }
}