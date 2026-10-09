int numero = 10;
MostrarIncremento(numero);
Console.WriteLine($"No programa: {numero}");

static void MostrarIncremento(int valor)
{
    valor++;
    Console.WriteLine($"Na função: {valor}");
}
