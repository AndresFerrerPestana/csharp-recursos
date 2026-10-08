using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Valor da encomenda: ");

if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor >= 0)
{
    decimal portes;

    if (valor >= 50m)
        portes = 0m;
    else
        portes = 4.90m;

    decimal total = valor + portes;

    Console.WriteLine($"Encomenda: {valor:F2} €");
    Console.WriteLine($"Portes: {portes:F2} €");
    Console.WriteLine($"Total: {total:F2} €");
}
else
{
    Console.WriteLine("Valor inválido.");
}