using System;

class Program
{
    static void Main()
    {
        Console.Write("Inteiro entre -100 e 100: ");
        if (!int.TryParse(Console.ReadLine(), out int numero)
            || numero < -100 || numero > 100)
        {
            Console.WriteLine("Introduza um inteiro entre -100 e 100.");
        }
        else
        {
            int resultado = Quadrado(numero);
            Console.WriteLine($"Quadrado: {resultado}");
        }
    }

    static int Quadrado(int numero)
    {
        return numero * numero;
    }
}
