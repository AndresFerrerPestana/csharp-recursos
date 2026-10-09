MostrarDobro(4);
MostrarDobro(0);
int valor = -3;
MostrarDobro(valor);

static void MostrarDobro(int numero)
{
    int dobro = numero * 2;
    Console.WriteLine($"Dobro de {numero}: {dobro}");
}
