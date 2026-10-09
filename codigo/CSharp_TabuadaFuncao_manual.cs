Console.Write("Inteiro entre 1 e 10: ");
if (!int.TryParse(Console.ReadLine(), out int numero)
    || numero < 1 || numero > 10)
{
    Console.WriteLine("Introduza um inteiro entre 1 e 10.");
}
else
{
    MostrarTabuada(numero);
}

static void MostrarTabuada(int numero)
{
    for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
    {
        Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
    }
}
