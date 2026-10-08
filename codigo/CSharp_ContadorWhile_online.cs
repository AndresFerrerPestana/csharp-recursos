using System;

class Program
{
    static void Main()
    {
        Console.Write("Limite de 1 a 10: ");

        if (int.TryParse(Console.ReadLine(), out int limite)
            && limite >= 1 && limite <= 10)
        {
            int contador = 1;

            while (contador <= limite)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }
        else
        {
            Console.WriteLine("Introduza um inteiro de 1 a 10.");
        }
    }
}