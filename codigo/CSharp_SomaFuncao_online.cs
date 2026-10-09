using System;

class Program
{
    static void Main()
    {
        int total = Somar(7, 5);
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Outra soma: {Somar(-3, 3)}");
    }

    static int Somar(int primeiro, int segundo)
    {
        return primeiro + segundo;
    }
}
