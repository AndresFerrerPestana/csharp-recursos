Console.Write("Primeiro valor: ");
bool v1Valido = double.TryParse(Console.ReadLine(), out double valor1);

Console.Write("Segundo valor: ");
bool v2Valido = double.TryParse(Console.ReadLine(), out double valor2);

Console.Write("Terceiro valor: ");
bool v3Valido = double.TryParse(Console.ReadLine(), out double valor3);

if (!v1Valido || !v2Valido || !v3Valido)
{
    Console.WriteLine("Valor inválido.");
}
else
{
    double media = (valor1 + valor2 + valor3) / 3;

    Console.WriteLine($"Média: {media:F2}");

    if (media >= 18)
        Console.WriteLine("Muito bom");
    else if (media >= 14)
        Console.WriteLine("Bom");
    else if (media >= 10)
        Console.WriteLine("Suficiente");
    else
        Console.WriteLine("Insuficiente");
}