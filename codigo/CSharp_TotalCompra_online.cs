using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        decimal precoUnitario = 18.50m;
        int quantidade = 3;

        decimal subtotal = precoUnitario * quantidade;
        decimal iva = subtotal * 0.23m;
        decimal total = subtotal + iva;

        Console.WriteLine($"Subtotal: {subtotal:F2} €");
        Console.WriteLine($"IVA: {iva:F2} €");
        Console.WriteLine($"Total: {total:F2} €");
    }
}