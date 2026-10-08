Console.Write("Primeiro número: ");
bool primeiroValido = int.TryParse(Console.ReadLine(), out int primeiro);

Console.Write("Segundo número: ");
bool segundoValido = int.TryParse(Console.ReadLine(), out int segundo);

if (!primeiroValido || !segundoValido)
{
    Console.WriteLine("Valor inválido.");
}
else if (primeiro > segundo)
{
    Console.WriteLine($"O maior valor é {primeiro}.");
}
else if (segundo > primeiro)
{
    Console.WriteLine($"O maior valor é {segundo}.");
}
else
{
    Console.WriteLine("Os dois valores são iguais.");
}