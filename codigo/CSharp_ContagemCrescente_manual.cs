Console.Write("Introduza um inteiro entre 1 e 20: ");

if (int.TryParse(Console.ReadLine(), out int limite)
    && limite >= 1 && limite <= 20)
{
    int contador = 1;

    while (contador <= limite)
    {
        Console.WriteLine(contador);
        contador++;
    }
}
else
{
    Console.WriteLine("Valor invalido.");
}