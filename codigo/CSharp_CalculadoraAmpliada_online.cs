using System;

class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            MostrarMenu();
            opcao = LerInteiroNoIntervalo("Opção: ", 0, 3);
            if (opcao != 0)
            {
                int primeiro = LerInteiroNoIntervalo(
                    "Primeiro número [-100, 100]: ", -100, 100);
                int segundo = LerInteiroNoIntervalo(
                    "Segundo número [-100, 100]: ", -100, 100);
                switch (opcao)
                {
                    case 1:
                        int soma = Somar(primeiro, segundo);
                        Console.WriteLine($"Soma: {soma}");
                        break;
                    case 2:
                        int maior = Maior(primeiro, segundo);
                        Console.WriteLine($"Maior: {maior}");
                        break;
                    case 3:
                        int diferenca = Subtrair(primeiro, segundo);
                        Console.WriteLine($"Diferença: {diferenca}");
                        break;
                }
            }
        } while (opcao != 0);
        Console.WriteLine("Programa terminado.");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Maior de dois valores");
        Console.WriteLine("3 - Diferença");
        Console.WriteLine("0 - Terminar");
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

    static int Somar(int primeiro, int segundo)
    {
        return primeiro + segundo;
    }

    static int Maior(int primeiro, int segundo)
    {
        if (primeiro >= segundo)
        {
            return primeiro;
        }
        return segundo;
    }

    static int Subtrair(int primeiro, int segundo)
    {
        return primeiro - segundo;
    }
}
