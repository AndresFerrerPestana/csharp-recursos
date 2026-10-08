using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Preço unitário: ");
bool precoValido = decimal.TryParse(Console.ReadLine(), out decimal preco);

Console.Write("Quantidade: ");
bool quantidadeValida = int.TryParse(Console.ReadLine(), out int quantidade);

if (!precoValido || !quantidadeValida || preco <= 0 || quantidade <= 0)
{
    Console.WriteLine("Dados inválidos.");
}
else
{
    decimal subtotal = preco * quantidade;
    decimal desconto = 0m;

    if (subtotal >= 100m)
    {
        desconto = subtotal * 0.10m;
    }

    decimal total = subtotal - desconto;

    Console.WriteLine($"Subtotal: {subtotal:F2} €");
    Console.WriteLine($"Desconto: {desconto:F2} €");
    Console.WriteLine($"Total: {total:F2} €");
}