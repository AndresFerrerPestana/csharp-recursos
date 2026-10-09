Console.Write("Inteiro entre -100 e 100: ");
if (!int.TryParse(Console.ReadLine(), out int numero)
    || numero < -100 || numero > 100)
{
    Console.WriteLine("Introduza um inteiro entre -100 e 100.");
}
else if (EhPar(numero))
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Ímpar");
}

static bool EhPar(int numero)
{
    return numero % 2 == 0;
}
