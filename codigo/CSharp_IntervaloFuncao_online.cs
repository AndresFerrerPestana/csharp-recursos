using System;

class Program
{
    static void Main()
    {
        Console.Write("Número de 1 a 10: ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Introduza um inteiro.");
        }
        else if (EstaNoIntervalo(numero, 1, 10))
        {
            Console.WriteLine("Valor aceite.");
        }
        else
        {
            Console.WriteLine("Valor fora do intervalo.");
        }
    }

    static bool EstaNoIntervalo(int valor, int minimo, int maximo)
    {
        return valor >= minimo && valor <= maximo;
    }
}
