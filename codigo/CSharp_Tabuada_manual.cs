Console.Write("Escolha uma tabuada entre 1 e 10: ");

if (int.TryParse(Console.ReadLine(), out int numero)
    && numero >= 1 && numero <= 10)
{
    for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
    {
        int resultado = numero * multiplicador;
        Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
    }
}
else
{
    Console.WriteLine("Valor invalido.");
}