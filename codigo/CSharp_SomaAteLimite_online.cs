using System;

class Program
{
    static void Main()
    {
        int limite = LerInteiroNoIntervalo("Limite [1, 100]: ", 1, 100);
        int soma = SomarAte(limite);
        Console.WriteLine($"Soma: {soma}");
    }

    static int LerInteiroNoIntervalo(string mensagem,
        int minimo, int maximo)
    {
        int numero;
        bool valido;
        do
        {
            Console.Write(mensagem);
            // Validar a conversão antes de aceitar o valor.
            valido = int.TryParse(Console.ReadLine(), out numero)
                && numero >= minimo && numero <= maximo;
            if (!valido)
            {
                Console.WriteLine(
                    $"Introduza um inteiro entre {minimo} e {maximo}.");
            }
        } while (!valido);
        return numero; // Só devolve um valor aceite.
    }

    static int SomarAte(int limite)
    {
        int soma = 0; // Um novo acumulador em cada chamada.
        for (int numero = 1; numero <= limite; numero++)
        {
            soma += numero;
        }
        return soma;
    }
}
