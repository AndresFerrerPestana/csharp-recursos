Console.WriteLine("1 - Consultar saldo");
Console.WriteLine("2 - Consultar movimentos");
Console.Write("Opcao: ");

if (int.TryParse(Console.ReadLine(), out int opcao))
{
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Saldo: 100 euros");
            break;

        case 2:
            Console.WriteLine("Sem movimentos registados.");
            break;

        default:
            Console.WriteLine("Opcao inexistente.");
            break;
    }
}
else
{
    Console.WriteLine("Introduza um numero inteiro.");
}